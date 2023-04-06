using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class OrderService
    {
        public List<Order> orders = new List<Order>();
        public OrderService()
        {
        }

        //添加订单功能
        public void AddOrder(Order order)//添加订单
        {
            if (orders.Contains(order))
            {
                ExceptionForm exceptionForm = new ExceptionForm();
                exceptionForm.ShowDialog();
            }
            else
            {
                orders.Add(order);
                ResponseForm responseForm = new ResponseForm();
                responseForm.ShowDialog();
            }
        }

        //删除订单功能
        public void DeleteOrder(string orderId)//根据Id删除订单
        {
            int idx = orders.FindIndex(o => o.Order_Id == orderId);
            if (idx >= 0)
            {
                orders.RemoveAt(idx);
                ResponseForm responseForm = new ResponseForm();
                responseForm.ShowDialog();
            }
            else
            {
                ExceptionForm exceptionForm = new ExceptionForm();
                exceptionForm.ShowDialog();
            }
        }

        //查询订单功能
        public List<Order> SelectAllOrder()//查询所有订单
        {
            return orders;
        }
        public List<Order> SelectByClientName(string client_name)//根据客户名查询订单
        {
            var query = from o in orders
                        where o.orderdetails.client.Client_Name == client_name
                        orderby o.orderdetails.SumPrince
                        select o;
            return query.ToList();
        }
        public List<Order> SelectByGoodsName(string goods_name)//根据货物名查询订单
        {
            var query = from o in orders
                        where o.orderdetails.goods.Goods_Name == goods_name
                        orderby o.orderdetails.SumPrince
                        select o;
            return query.ToList();
        }
        public List<Order> SelectByOrderID(string order_id)//根据订单号查询订单
        {
            var query = from o in orders
                        where o.Order_Id == order_id
                        orderby o.orderdetails.SumPrince
                        select o;
            return query.ToList();
        }
        public List<Order> SelectBySumPrice(double sumprice)//根据总量查询订单
        {
            var query = from o in orders
                        where o.orderdetails.SumPrince == sumprice
                        select o;
            return query.ToList();
        }
        //修改订单功能
        public void Update(Order order,string order_id)
        {
            int idx = orders.FindIndex(o => o.Order_Id == order_id);
            if (idx < 0)
            {
                ExceptionForm exceptionForm = new ExceptionForm();
                exceptionForm.ShowDialog();
            }
            else
            {
                orders.RemoveAt(idx);
                orders.Add(order);
                ResponseForm responseForm = new ResponseForm();
                responseForm.ShowDialog();

            }
        }
    }
}
