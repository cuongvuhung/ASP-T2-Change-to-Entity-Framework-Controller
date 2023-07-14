using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.Arm;
using Microsoft.VisualBasic.FileIO;
namespace ASPT1.Models
{
    internal class DALtest
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        // Excute SQLExecute

        public int SQLExecute(string str)
        {
            DBConnect dbconnect = new();
            SqlCommand cmd = dbconnect.Cnn.CreateCommand();
            cmd.CommandText = str;                
            int result = cmd.ExecuteNonQuery();
            return result;          

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        // Excute SQLQuery
        public List<string> SQLQuery(string str)
        {
            List<string> result = new List<string>();
            DBConnect dbconnect = new();
            SqlCommand cmd = new(str, dbconnect.Cnn);            
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string line = "";
                for (int j = 0; j < rdr.FieldCount; j++)
                {
                    line += rdr[j].ToString().Trim() + ",";
                }
                result.Add(line);
            }
            rdr.Close();
            return result;
            ///////////////////////////////////////////////////////////////////////////////////////////////////
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
