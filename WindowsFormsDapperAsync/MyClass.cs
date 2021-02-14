using System;
using System.Data;
using System.Data.SqlClient;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using Dapper.Contrib;
namespace WindowsFormsDapperAsync
{
    class MyClass
    {

        public MyClass()
        {

        }

        async public Task<IEnumerable<dynamic>> LoadAsync()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Library; Integrated Security = SSPI;");

            var res = await sqlConnection.QueryAsync(" WAITFOR DELAY '00:00:03' ;select *from Authors");

            return res;

        }

        public IEnumerable<dynamic> LoadSync()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Library; Integrated Security = SSPI;");
            var res =  sqlConnection.QueryFirstOrDefault("select *from Authors");
            return res;

        }

    }
    
}
