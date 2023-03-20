using System;

class Clock
{
    private int TicksPerSecond; // 每秒嘀嗒数
    private int SecondsUntilAlarm; // 距离响铃的秒数

    //委托类型，定义事件处理函数的格式
    public delegate void TickEventHandler(object sender, TickEventArg arg);

    // 嘀嗒事件
    public event TickEventHandler Tick;

    // 响铃事件
    public event EventHandler Alarm;

    public Clock(int TicksPerSecond)
    {
        this.TicksPerSecond = TicksPerSecond;
        this.SecondsUntilAlarm = 0;
    }

    //嘀嗒事件参数
    public class TickEventArg
    {
        public int X { get; set; }
    }

    // 启动闹钟
    public void Start()
    {
        while (true)
        {

            TickEventArg arg = new TickEventArg() { X = SecondsUntilAlarm };

            // 触发嘀嗒事件
            Tick?.Invoke(this, arg);
            // 每秒钟减少一秒距离响铃的时间
            if (SecondsUntilAlarm > 0)
            {
                SecondsUntilAlarm--;
                if (SecondsUntilAlarm == 0)
                {
                    // 触发响铃事件
                    Alarm?.Invoke(this, EventArgs.Empty);
                    //一次响铃完就结束程序
                    break;
                }
            }
            // 计算嘀嗒间隔时间
            int interval = 1000 / TicksPerSecond;
            // 暂停一段时间，sleep参数的单位为毫秒
            System.Threading.Thread.Sleep(interval);
        }
    }

    // 设置闹钟响铃时间
    public void SetAlarm(int secondsUntilAlarm)
    {
        this.SecondsUntilAlarm = secondsUntilAlarm;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Clock clock = new Clock(1);

        // 注册嘀嗒事件
        clock.Tick += (sender, arg) =>
        {
            Console.WriteLine($"Tick {arg.X}");
        };

        // 注册响铃事件
        clock.Alarm += (sender, e) =>
        {
            Console.WriteLine("Alarm ringing!");
        };

        // 设置闹钟响铃时间
        clock.SetAlarm(6);

        // 启动闹钟
        clock.Start();
    }
}

