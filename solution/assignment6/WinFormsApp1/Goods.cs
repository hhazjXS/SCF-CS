using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Goods
    {
        public string Goods_Name { get; set; }
        public int Goods_Amount { get; set; }

        public double Goods_Price { get; set; }
        public Goods(string name, int amount, double price)
        {
            Goods_Name = name;
            Goods_Amount = amount;
            Goods_Price = price;
        }
        public override string ToString()
        {
            return "货物名称：" + Goods_Name + " 货物数量：" + Goods_Amount + " 货物单价：" + Goods_Price + "元";
        }
        public override bool Equals(object obj)
        {
            Goods g = obj as Goods;
            return g.Goods_Name == Goods_Name && g.Goods_Amount == Goods_Amount && g.Goods_Price == Goods_Price;
        }
    }
}
