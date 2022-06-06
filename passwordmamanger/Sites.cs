using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordmamanger
{
    public class Sites
    {
        public MongoDB.Bson.ObjectId Id { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public String TLD { get; set; }
        public String website { get; set; }
        public MongoDB.Bson.ObjectId User { get; set; }

        public static explicit operator Sites(Task<Sites> v)
        {
            throw new NotImplementedException();
        }
    }
}
