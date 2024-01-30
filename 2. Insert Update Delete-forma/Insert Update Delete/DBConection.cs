using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_Update_Delete
{
    internal class DBConection
    {
        public string MyConection()
        {
            string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Proba";
            return con;
        }
    }
}
