using System;

//C#里面的属性和方法都是Pascal原则，即首字母都大写
//变量才使用camel原则，即首字母小写，其它首字母大写
namespace Shapes
{

    /*
     *方法一：直接使用抽象类实现
     */

    // 定义一个抽象类，表示基础形状，包含计算面积的方法
    /*public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract bool IsValid(); // 子类实现
    }*/


    /*
     *方法二：利用接口再通过抽象类重写实现
     */

    // 定义一个接口，表示可计算面积的形状
    //接口的名字前最好加一个大写的I
    public interface IShape
    {
        double Area { get; } // 只读面积
        bool IsValid(); // 判断形状是否合法
    }

    // 定义一个抽象类，表示基础形状，包含计算面积的方法
    public abstract class Shape : IShape
    {
        public abstract double Area { get; }
        public abstract bool IsValid(); // 子类实现
    }

    // 长方形类
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area
        {
            get { return length * width; }
        }

        public override bool IsValid()
        {
            return length > 0 && width > 0;
        }
    }

    // 正方形类
    public class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double Area
        {
            get { return side * side; }
        }

        public override bool IsValid()
        {
            return side > 0;
        }
    }

    // 三角形类
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area
        {
            get
            {
                // 使用海伦公式计算三角形面积
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public override bool IsValid()
        {
            // 判断是否满足三角形的边长条件
            return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double length = 0, width = 0;
            double side = 0;
            double a = 0, b = 0, c = 0;

            //异常值处理
            try
            {
                Console.Write("请分别输入长方形的长和宽：");
                length = Convert.ToDouble(Console.ReadLine());
                width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入正方形的边长：");
                side = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请分别输入三角形的三条边长：");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"错误：{e.Message}");
            }
            Rectangle rect = new Rectangle(length, width);
            Square square = new Square(side);
            Triangle triangle = new Triangle(a, b, c);

            //计算面积
            if (rect.IsValid())
            {
                Console.WriteLine("长方形的面积为：" + rect.Area);
            }
            if (square.IsValid())
            {
                Console.WriteLine("正方形的面积为：" + square.Area);
            }
            if (triangle.IsValid())
            {
                Console.WriteLine("三角形的面积为：" + triangle.Area);
            }
        }
    }
}
