using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Order
    {
        public string Order_Id { get; set; }
        public string Order_Name { get; set; }

        public OrderDetails orderdetails;
        public Order(string id, string name, OrderDetails orderdetails)
        {
            Order_Id = id;
            Order_Name = name;
            this.orderdetails = orderdetails;
        }
        public override string ToString()
        {
            return "订单号：" + Order_Id + " 订单名：" + Order_Name + "\n" + orderdetails + "\n";
        }
        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return o.Order_Name == Order_Name && o.Order_Id == Order_Id && o.orderdetails.Equals(orderdetails);
        }
    }
}
