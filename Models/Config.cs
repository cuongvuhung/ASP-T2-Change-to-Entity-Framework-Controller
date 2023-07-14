using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASPT1.Models
{
    public class Config
    {
        public string conStr;
        public Config()
        {
            string dataSource = "Data Source = 10.36.0.36;";
            string catalog = "Initial Catalog = Cuongvh-Achievements;";
            string user = "User ID = cuongvt;";
            string password = "Password = Abcd@12345";
            conStr = dataSource + catalog + user + password;

            /*
            FileStream fileStream = new("config.cfg", FileMode.OpenOrCreate);
            StreamReader streamReader = new(fileStream);
            string dataSource = streamReader.ReadLine() + "";
            string catalog = streamReader.ReadLine() + "";
            string user = streamReader.ReadLine() + "";
            string password = streamReader.ReadLine() + "";
            streamReader.Close();
            */
        }
    }
}
