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

        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<UserInfo> m_CollectionUser;
        IMongoCollection<Sites> m_CollectionSites;
        public Db()
        {
            m_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            m_Database = m_Client.GetDatabase("CyberUser");
            m_CollectionUser = m_Database.GetCollection<UserInfo>("User");
            m_CollectionSites = m_Database.GetCollection<Sites>("Sites");
        }

        public IMongoCollection<UserInfo> getcollectionUser()
        {
            return m_CollectionUser;
        }
        public IMongoCollection<Sites> getcollectionSties()
        {
            return m_CollectionSites;
        }
    }
}
