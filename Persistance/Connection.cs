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
            ConnectionString = "Server=192.168.2.5,1433;database=TweetUserStore;UID=sa;PWD=Jyoti@1234;MultipleActiveResultSets=True;TrustServerCertificate=True";
        }
    }
}