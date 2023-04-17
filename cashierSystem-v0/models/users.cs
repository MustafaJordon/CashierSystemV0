using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Configuration.ConfigurationManager;

namespace cashierSystem_v0.models
{
    internal class usersStore
    {
        public void insert(string pUsername, string pPasswordDigest, string pRole, int pIsActive)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            try
            {
                //
                string query = "INSERT INTO users(username,passwordDigest,role,isActive) VALUES(N'" + pUsername + "','" + pPasswordDigest + "',N'" + pRole + "'," + pIsActive + ")";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.Message, "message");
            }
            finally { 
                con.Close();
            }
        }
    }
}
