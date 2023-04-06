using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class OrderDetails
    {
        public Client client;
        public Goods goods;
        public double SumPrince
        {
            get => goods.Goods_Price * goods.Goods_Amount;
        }
        public OrderDetails(Client client, Goods goods)
        {
            this.client = client;
            this.goods = goods;
        }
        public override string ToString()
        {
            return "订单详情：\n" + "1、订单客户为：\n" + client + "\n2、订单商品为：\n" + goods + "\n3、订单总金额为：" + SumPrince + "元";
        }
        public override bool Equals(object obj)
        {
            OrderDetails od = obj as OrderDetails;
            return od.client.Equals(client) && od.goods.Equals(goods);
        }
    }
}
