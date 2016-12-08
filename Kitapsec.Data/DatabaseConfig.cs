using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapsec.Data
{
    public class DatabaseConfig
    {
        private static string connectionString;
        public static string ConnectionString {
            get
            {
                if (String.IsNullOrEmpty(connectionString))
                {
                    connectionString = @"Data Source=.\sqlexpress;Initial Catalog=kitapsec;Integrated Security=True";
                }

                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }
    }
}
