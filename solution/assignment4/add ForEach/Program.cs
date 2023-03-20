//链表结点
public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    public Node(T value)
    {
        Value = value;
        Next = null;
    }
}

//泛型链表类
public class GenericList<T>
{
    private Node<T> head;
    private Node<T> tail;

    public GenericList()
    {
        head = tail = null;
    }

    //head属性
    public Node<T> Head
    {
        get => head;
    }

    //add方法
    public void Add(T t)
    {
        Node<T> node = new Node<T>(t);
        if (tail == null)
        {
            head = tail = node;
        }
        tail.Next = node;
        tail = node;
    }

    //ForEach方法
    public void ForEach(Action<T> action)
    {
        Node<T> current = head;

        while (current != null)
        {
            action(current.Value);
            current = current.Next;
        }
    }
}

class Program
{
    private static void Main(string[] args)
    {
        GenericList<int> list = new GenericList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        list.ForEach(x => Console.WriteLine(x));

        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        list.ForEach(x =>
        {
            sum += x;
            max = Math.Max(max, x);
            min = Math.Min(min, x);
        });

        Console.WriteLine("sum= " + sum);
        Console.WriteLine("max= " + max);
        Console.WriteLine("min= " + min);
    }
}