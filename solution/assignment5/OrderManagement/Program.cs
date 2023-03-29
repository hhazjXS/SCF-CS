using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace OrderManagement
{
    // 订单明细类
    public class OrderDetails : IEquatable<OrderDetails> //当类需要自定义相等比较逻辑时，可以实现IEquatable接口，并重写Equals方法
    {
        public string ProductName { get; set; } // 商品名称
        public double Price { get; set; } // 商品单价
        public int Quantity { get; set; } // 商品数量

        // 重写Equals方法，确保订单明细不重复
        public bool Equals(OrderDetails other)
        {
            if (other == null)
            {
                return false;
            }
            return this.ProductName == other.ProductName &&
                   this.Price == other.Price &&
                   this.Quantity == other.Quantity;
        }

        //重写ToString方法，定义该类的对象如何被转换为字符串,当一个类的对象需要被表示为字符串时，调用ToString()方法就会返回一个字符串表示该对象的内容。
        public override string ToString()
        {
            return $"Product: {ProductName}, Price: {Price:C}, Quantity: {Quantity}";
        }
    }

    // 订单类
    public class Order : IEquatable<Order>, IComparable<Order> //用于定义对象的比较方法。实现了该接口的类可以通过实现CompareTo方法来定义对象的比较逻辑，以用于排序和查找等操作。
    {
        public DateTime CreateTime { get; }//用于确定订单创建时间
        public int OrderNumber { get; set; } // 订单号
        public string CustomerName { get; set; } // 客户名称
        public List<OrderDetails> Details { get; set; } // 订单明细  (这个其实不是属性，属于字段！！！！！！！）
        public double TotalPrice => Details.Sum(d => d.Price * d.Quantity); // 订单总价

        /*
        public double TotalPrice
        {
            get=>Details.Sum(d=>d.Price * d.Quantity);
        }
        */

        //Order默认构造函数,确定订单创建时间
        public Order()
        {
            CreateTime = DateTime.Now;
        }

        // 重写Equals方法，确保订单不重复
        public bool Equals(Order other)
        {
            if (other == null)
            {
                return false;
            }
            return this.OrderNumber == other.OrderNumber;
        }

        // 实现IComparable<Order>接口，按照订单总金额排序，当调用sort等排序方法时，会调用此方法进行排序
        public int CompareTo(Order other)
        {
            if (other == null)
            {
                return 1;
            }
            return this.TotalPrice.CompareTo(other.TotalPrice);

            //代码简化
            //return (other==null)?1:this.TotalPrice.CompareTo(other.TotalPrice);
        }

        public override string ToString()
        {
            return $"Order Number: {OrderNumber}, Customer: {CustomerName}, Total Price: {TotalPrice:C}";
        }
    }

    // 订单服务类
    public class OrderService
    {
        private List<Order> orders = new List<Order>(); // 订单列表

        // 添加订单
        public void AddOrder(Order order)
        {
            if (orders.Contains(order))//调用Equals遍历List判断是否有相同的订单
            {
                throw new ArgumentException($"Order {order.OrderNumber} already exists.");
            }
            foreach (var detail in order.Details)
            {
                //如果该订单中有重复的产品，抛出一个ArgumentException异常，说明重复的订单号和产品名称。
                if (order.Details.Count(d => d.Equals(detail)) > 1)
                {
                    throw new ArgumentException($"Duplicate detail for product {detail.ProductName} in order {order.OrderNumber}.");
                }
            }
            orders.Add(order);
        }

        // 删除订单
        public void RemoveOrder(int orderNumber)
        {
            //FirstOrDefault是C#中LINQ查询语句中的一个操作符，用于从一个序列中获取第一个满足特定条件的元素，或者在序列中没有符合条件的元素时返回默认值。
            var order = orders.FirstOrDefault(o => o.OrderNumber == orderNumber);
            if (order == null)
            {
                throw new ArgumentException($"Order {orderNumber} does not exist.");
            }
            orders.Remove(order);
        }

        // 修改订单
        public void ModifyOrder(Order order)
        {
            //FindIndex是List<T>类中的一个方法，用于在列表中搜索满足指定条件的元素，并返回该元素在列表中的索引
            var index = orders.FindIndex(o => o.OrderNumber == order.OrderNumber);
            if (index == -1)
            {
                throw new ArgumentException($"Order {order.OrderNumber} does not exist.");
            }
            //修改此索引下的订单
            orders[index] = order;
        }

        // 按照订单号查询订单
        public Order QueryOrderByNumber(int orderNumber)
        {
            var order = orders.FirstOrDefault(o => o.OrderNumber == orderNumber);
            if (order == null)
            {
                throw new ArgumentException($"Order {orderNumber} does not exist.");
            }
            return order;
        }

        // 按照商品名称查询订单，注意可能有多个订单，所以要返回一个list
        public List<Order> QueryOrderByProduct(string productName)
        {
            var result = orders.Where(o => o.Details.Exists(d => d.ProductName == productName))//查询订单是否存在
                               .OrderBy(o => o.TotalPrice)//按照订单总价排序
                               .ToList();//结果转化为列表返回
            if (result.Count == 0)
            {
                throw new ArgumentException($"No order contains product {productName}.");
            }
            return result;
        }

        // 按照客户名称查询订单，一个客户可能有多个订单
        public List<Order> QueryOrderByCustomer(string customerName)
        {
            var result = orders.Where(o => o.CustomerName == customerName)
                               .OrderBy(o => o.TotalPrice)
                               .ToList();
            if (result.Count == 0)
            {
                throw new ArgumentException($"No order belongs to customer {customerName}.");
            }
            return result;
        }

        // 按照订单总金额查询订单，订单总金额可能相同
        public List<Order> QueryOrderByTotalPrice(double minPrice, double maxPrice)
        {
            var result = orders.Where(o => o.TotalPrice >= minPrice && o.TotalPrice <= maxPrice)
                               .OrderBy(o => o.TotalPrice)
                               .ToList();
            if (result.Count == 0)
            {
                throw new ArgumentException($"No order's total price is between {minPrice:C} and {maxPrice:C}.");
            }
            return result;
        }

        // 默认按照订单号排序
        public void SortOrders()
        {
            orders.Sort((o1, o2) => o1.OrderNumber.CompareTo(o2.OrderNumber));
        }

        // 按照Lambda表达式自定义排序,按照订单创建时间排序
        public int comparison(Order o1, Order o2)
        {
            return o1.CreateTime.CompareTo(o2.CreateTime);
        }

        public void SortOrders(Comparison<Order> comparison)
        {
            orders.Sort(comparison);
        }

        public override string ToString()
        {
            return $"Total Orders: {orders.Count}";
        }
    }

    // 控制台程序
    class Program
    {
        static void Main(string[] args)
        {
            var service = new OrderService();

            // 添加测试订单
            var order1 = new Order
            {
                OrderNumber = 1,
                CustomerName = "Alice",
                Details = new List<OrderDetails>
            {
                new OrderDetails { ProductName = "P1", Price = 5.0, Quantity = 2 },
                new OrderDetails { ProductName = "P2", Price = 4.0, Quantity = 3 },
                new OrderDetails { ProductName = "P3", Price = 10.0, Quantity = 1 }
            }
            };
            service.AddOrder(order1);

            var order2 = new Order
            {
                OrderNumber = 2,
                CustomerName = "Bob",
                Details = new List<OrderDetails>
            {
                new OrderDetails { ProductName = "P4", Price = 4.0, Quantity = 2 },
                new OrderDetails { ProductName = "P5", Price = 10.0, Quantity = 2 },
                new OrderDetails { ProductName = "P6", Price = 20.0, Quantity = 1 }
            }
            };
            service.AddOrder(order2);

            var order3 = new Order
            {
                OrderNumber = 3,
                CustomerName = "William",
                Details = new List<OrderDetails>
                {
                    new OrderDetails { ProductName="Alienware",Price=17000.0,Quantity=1},
                    new OrderDetails { ProductName="Mouse",Price=10.0,Quantity=1},
                    new OrderDetails { ProductName="Bag",Price=170.0,Quantity=1}
                }
            };
            service.AddOrder(order3);


            var temp = service.QueryOrderByTotalPrice(double.MinValue, double.MaxValue);
            Console.WriteLine(temp.Count);
            Console.WriteLine(temp.Last().TotalPrice);
            Console.WriteLine(temp.Last().CustomerName);

            Console.WriteLine(order3.Details.First());
        }
    }
}





/*
 *分离各个类，不要写一起
 *定义一个集合最好先初始化
 *字段一般是private，安全问题：private readonly List<OrderDetails>Details=new List<OrderDetails>();
 *readonly 设置成只读属性
 *属性一般是public，供外界调用
 *一般类把构造函数写上
 */