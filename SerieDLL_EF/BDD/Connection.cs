using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.BDD
{
    internal class Connection
    {
        public string DataSource { get; set; }
        public string Catalog { get; set; }

        public Connection(string dataSource, string catalog)
        {
            DataSource = dataSource;
            Catalog = catalog;
        }

        public string GetConnectionString()
        {
            return $"Data Source={DataSource};Initial Catalog={Catalog};Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" ;
        }
    }
}
