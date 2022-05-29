using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordmamanger
{
    public class UserInfo
    {
        public String Email { get; set; }
        public MongoDB.Bson.ObjectId Id { get; set; }
        public String UserName { get; set; }
        public String FirstName { get; set; }
        public String Password { get; set; }
        public List<MongoDB.Bson.ObjectId> sites { get; set; }
    }
}
