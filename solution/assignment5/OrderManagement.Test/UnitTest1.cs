using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.Test
{
    [TestClass]
    public class OrderServiceTest
    {
        private OrderService service;

        [TestInitialize]
        public void TestInitialize()
        {
            service = new OrderService();
            service.AddOrder(new Order
            {
                OrderNumber = 1,
                CustomerName = "William",
                Details = new List<OrderDetails>
                {
                    new OrderDetails
                    {
                        ProductName = "A",
                        Price = 100,
                        Quantity = 1
                    },
                    new OrderDetails
                    {
                        ProductName = "B",
                        Price = 50,
                        Quantity = 2
                    }
                }
            });
            service.AddOrder(new Order
            {
                OrderNumber = 2,
                CustomerName = "Mike",
                Details = new List<OrderDetails>
                {
                    new OrderDetails
                    {
                        ProductName = "C",
                        Price = 2000,
                        Quantity = 1
                    },
                    new OrderDetails
                    {
                        ProductName = "D",
                        Price = 75,
                        Quantity = 3
                    }
                }
            });
            service.AddOrder(new Order
            {
                OrderNumber = 3,
                CustomerName = "Kun",
                Details = new List<OrderDetails>
                {
                    new OrderDetails
                    {
                        ProductName = "E",
                        Price = 1500,
                        Quantity = 2
                    },
                    new OrderDetails
                    {
                        ProductName = "F",
                        Price = 30,
                        Quantity = 5
                    }
                }
            });
        }

        [TestMethod]
        public void QueryOrderByNumberTest()
        {
            // 查询已有的订单
            var order = service.QueryOrderByNumber(1);
            Assert.IsNotNull(order);
            Assert.AreEqual(order.OrderNumber, 1);

            // 查询不存在的订单
            var fakeOrder = service.QueryOrderByNumber(10);
            Assert.IsNull(fakeOrder);
        }

        [TestMethod]
        public void RemoveOrderTest()
        {
            // 删除一个已有的订单
            service.RemoveOrder(1);
            Assert.IsNull(service.QueryOrderByNumber(1));

            // 删除一个不存在的订单
            Assert.ThrowsException<ArgumentException>(() => service.RemoveOrder(10));
        }
        [TestMethod]
        public void SortOrdersTest()
        {
            // 默认按订单号排序
            var sortedOrders = service.SortOrders();
            Assert.AreEqual(sortedOrders.First().OrderNumber, 1);

            // 自定义排序：按订单总金额排序
            sortedOrders = service.SortOrders((o1, o2) => o1.TotalAmount.CompareTo(o2.TotalAmount));
            Assert.AreEqual(sortedOrders.First().OrderNumber, 3);
        }
    }
}


