using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Resturent_App
{
    internal class Functions
    {
        private SqlConnection Con;
        private sqlCommand Cmd;
        private DataTable Dt;
        private sqlDataAdapter Sda;
        private string Constr;


        public Functions()
        {
            Constr = @"";
            Con = new SqlConnection(Constr);
            Cmd = new sqlCommand();
            Cmd.Connection = Con;



        }
        public DataTable GetData (string query)
        {
               Dt = new DataTable();
               Sda = new sqlDataAdapter(query, Constr);
               Sda.Fill(Dt);
               return Dt;
        }

        public int SetData(string query)
        {
           int cnt  = 0;
           if(Con.State == ConnectionState.Closed)
            {
                Con.Open();

                  

            }
           Cmd.Commandtext = query;
            cnt = Cmd.ExecuteNonquery();
            Con.Close();
            return cnt;



        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal object GetData(object query)
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}