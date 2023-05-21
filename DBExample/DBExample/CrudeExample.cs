using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DBExample
{
    class CrudeExample
    {
        public void setConnection()
        {
            string cs = "Data Source=NCCS-155\\SQLEXPRESS; Initial Catalog=db_csita; Integrated Security=true";
            try
            {
                //Connecting with database
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                //checking Connection
                if(conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connected");
                }
                //Inserting data into table
                string inQuery = "insert into tbl_emp values('1','ram','male','IT','manager','50000')";
                SqlCommand sc = new SqlCommand(inQuery, conn);
                int res = sc.ExecuteNonQuery();
                if(res >= 1)
                {
                    Console.WriteLine("Data Inserted");
                }
            }catch(SqlException s)
            {
                Console.WriteLine(s);
            }
        }
    }
}
