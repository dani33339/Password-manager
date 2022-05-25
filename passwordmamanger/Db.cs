using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
namespace passwordmamanger
{
    class Db
    {

        MongoClient m_ClientUser;
        IMongoDatabase m_DatabaseUser;
        IMongoCollection<UserInfo> m_CollectionUser;

        public Db()
        {
            m_ClientUser = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            m_DatabaseUser = m_ClientUser.GetDatabase("CyberUser");
            m_CollectionUser = m_DatabaseUser.GetCollection<UserInfo>("User");
        }

        public IMongoCollection<UserInfo> getcollection()
        {
            return m_CollectionUser;
        }
    }
}
