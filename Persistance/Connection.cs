using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public Connection()
        {
            ConnectionString = "Server=LAPTOP-SP2T588K\\SQLEXPRESS;Database=TweetUserDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True";
        }
    }
}