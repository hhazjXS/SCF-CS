using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Client
    {
        public string Client_Name { get; set; }
        public string Client_Location { get; set; }
        public string Client_Number { get; set; }
        public Client(string name, string location, string number)
        {
            Client_Name = name;
            Client_Location = location;
            Client_Number = number;
        }
        public override string ToString()
        {
            return "客户姓名：" + Client_Name + " 客户地址：" + Client_Location + " 客户电话：" + Client_Number;
        }
        public override bool Equals(object obj)
        {
            Client c = obj as Client;
            return c.Client_Name == Client_Name && c.Client_Number == Client_Number && c.Client_Location == Client_Location;
        }
    }
}
