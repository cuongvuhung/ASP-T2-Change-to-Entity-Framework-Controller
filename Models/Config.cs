using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASPT2.Models
{
    public static class Config
    {

        public static string dataSource = "Data Source = 10.36.0.36;";
        public static string catalog = "Initial Catalog = Cuongvh-Achievements;";
        public static string user = "User ID = cuongvt;";
        public static string password = "Password = Abcd@12345;";
        public static string conStr = dataSource + catalog + user + password + "TrustServerCertificate=True;";
        /*public Config()
        {
            

            *//*
            FileStream fileStream = new("config.cfg", FileMode.OpenOrCreate);
            StreamReader streamReader = new(fileStream);
            string dataSource = streamReader.ReadLine() + "";
            string catalog = streamReader.ReadLine() + "";
            string user = streamReader.ReadLine() + "";
            string password = streamReader.ReadLine() + "";
            streamReader.Close();
            *//*
        }*/
    }
}
