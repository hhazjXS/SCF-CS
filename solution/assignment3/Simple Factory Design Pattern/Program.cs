using System;
using System.Security.Principal;

/**
    *在简单工厂模式中，有三个主要的角色：
    *Product（产品类）：需要被创建的类或对象的父类或接口。这个类或接口定义了对象的基本属性和方法。
    *ConcreteProduct（具体产品类）：实现了Product接口的具体类或对象。它们是工厂方法创建的对象。
    *Factory（工厂类）：创建具体产品类的类。它是实现了创建对象的代码逻辑的地方。
 */

namespace SFDP
{
    //定义一个返回面积的接口
    interface IShape
    {
        double GetArea();
    }
    //下面来定义不同形状类来实现IShape接口

    //长方形
    class Rectangle : IShape
    {
        private double length, width;
        //构造函数
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        //实现接口
        public double GetArea()
        {
            return length * width;
        }
    }

    //正方形
    class Square : IShape
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
        }
        //实现接口
        public double GetArea()
        {
            return side * side;
        }
    }

    //圆形
    class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        //实现接口
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    //三角形
    class Triangle : IShape
    {
        private double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        //判断是否构成三角形
        public bool Judge(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && (a + b) > c && (a + c) > b && (b + c) > a;
        }
        //实现接口
        public double GetArea()
        {
            double tem = (a + b + c) / 2;
            return Math.Sqrt(tem * (tem - a) * (tem - b) * (tem - c));
        }
    }

    //下面定义工厂类(创建具体的类)
    class ShapeFactory
    {
        //创建一个随机数
        private Random rand = new Random();
        public IShape CreateShape()
        {
            switch (rand.Next(4))
            {
                case 0:
                    return new Rectangle(rand.Next(1, 9), rand.Next(1, 9));
                case 1:
                    return new Square(rand.Next(1, 9));
                case 2:
                    return new Circle(rand.Next(1, 9));
                case 3://判断是否构成三角形
                    while (true)
                    {
                        double a = rand.Next(1, 9);
                        double b = rand.Next(1, 9);
                        double c = rand.Next(1, 9);
                        Triangle Tri = new Triangle(a, b, c);
                        if (Tri.Judge(a, b, c))
                        {
                            return Tri;
                        }
                    }
                default:
                    throw new Exception("随机数生成错误，检查随机数的生成！");
            }
        }
    }

    class SumArea
    {
        static void Main(string[] args)
        {
            //实现
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                ShapeFactory factory = new ShapeFactory();
                sum += factory.CreateShape().GetArea();
            }
            Console.WriteLine("The total area: " + sum);
        }
    }
}
