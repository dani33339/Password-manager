using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordmamanger
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gosafe_btn_Click(object sender, EventArgs e)
        {
            // Run rootkitremover in order to detect keylogger or viruses
            /*McAfee is a well-known name in the industry, while Rootkit Remover is a free program,
             * it is highly effective. It effectively scans the system and removes all rootkit malware detected,
             * including keyloggers. 
             * You don’t have to install McAfee Rootkit Remover.
             */
            System.Diagnostics.Process.Start(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "rootkitremover.exe"));
            Gonext();
        }

        private void Gonext()
        {
            System.Threading.Thread.Sleep(4000);
            Login newForm = new Login();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void Gosupersafe_btn_Click(object sender, EventArgs e)
        {
            //get parent process id
            var CurrentProcessId = Process.GetCurrentProcess().Id;
            var query = string.Format("SELECT ParentProcessId FROM Win32_Process WHERE ProcessId = {0}", CurrentProcessId);
            var search = new ManagementObjectSearcher("root\\CIMV2", query);
            var results = search.Get().GetEnumerator();
            results.MoveNext();
            var queryObj = results.Current;
            var parentId = (uint)queryObj["ParentProcessId"];
            var parent = Process.GetProcessById((int)parentId);

            //kill all the process that you can
            Process[] process = Process.GetProcesses();
            foreach (Process p in process)
            {
                if (p.Id != CurrentProcessId && p.Id != parent.Id)
                {
                    try
                    {
                        p.Kill();
                    }
                    //if dosn't have accses to kill this Process
                    catch
                    { }
                }
            }

            // Run rootkitremover in order to detect keylogger or viruses
            /*McAfee is a well-known name in the industry, while Rootkit Remover is a free program,
             * it is highly effective. It effectively scans the system and removes all rootkit malware detected,
             * including keyloggers. 
             * You don’t have to install McAfee Rootkit Remover.
             */
            System.Diagnostics.Process.Start(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "rootkitremover.exe"));
            Gonext();
        }
    }
}
