using System.Collections;

namespace day29;


//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
//        ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };

//        Console.WriteLine(Sum(nums2));
//        Console.WriteLine(Avg(nums2));
//    }

//    //没有引入接口会使代码非常的冗余
//    static int Sum(int[] nums)
//    {
//        int sum = 0;
//        foreach (var item in nums)
//        {
//            sum += item;
//        }
//        return sum;
//    }

//    static double Avg(int[] nums)
//    {
//        int sum = 0;
//        double count = 0;
//        foreach (var item in nums)
//        {
//            sum += item;
//            count++;
//        }
//        return sum / count;
//    }

//    static int Sum(ArrayList nums)
//    {
//        int sum = 0;
//        foreach (var item in nums)
//        {
//            sum += (int)item;
//        }
//        return sum;
//    }

//    static double Avg(ArrayList nums)
//    {
//        int sum = 0;
//        double count = 0;
//        foreach (var item in nums)
//        {
//            sum += (int)item;
//            count++;
//        }
//        return sum / count;
//    }
//}













//------------------------------------------------------------------------------------------------------











class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
        ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };

        Console.WriteLine(Sum(nums2));
        Console.WriteLine(Avg(nums2));
    }


    //引入接口
    static int Sum(IEnumerable nums)
    {
        int sum = 0;
        foreach (var item in nums)
        {
            sum += (int)item;
        }
        return sum;
    }

    static double Avg(IEnumerable nums)
    {
        int sum = 0;
        double count = 0;
        foreach (var item in nums)
        {
            sum += (int)item;
            count++;
        }
        return sum / count;
    }
}












//------------------------------------------------------------------------------------------------------













//class Program
//{
//    static void Main(string[] args)
//    {
//        var engine = new Engine();
//        var car = new Car(engine);

//        car.Run(3);
//        Console.WriteLine(car.Speed);
//    }
//}


//class Engine
//{
//    public int RPM { get; private set; }
//    public void Work(int gas)
//    {
//        this.RPM = 1000 * gas;
//    }
//}


//class Car
//{
//    private Engine _engine;

//    public int Speed { get; private set; }

//    public Car(Engine engine)
//    {
//        _engine = engine;
//    }

//    public void Run(int gas)
//    {
//        _engine.Work(gas);
//        this.Speed = _engine.RPM / 100;
//    }
//}














//------------------------------------------------------------------------------------------------------













//class Program
//{
//    static void Main(string[] args)
//    {
//        var phoneUser = new PhoneUser(new NokiaPhone());
//        phoneUser.UserPhone();
//    }
//}


//class PhoneUser
//{
//    private IPhone _phone;
//    public PhoneUser(IPhone phone)
//    {
//        this._phone = phone;
//    }

//    public void UserPhone()
//    {
//        _phone.Dail();
//        _phone.PickUp();
//        _phone.Send();
//        _phone.Receive();
//    }
//}


//interface IPhone
//{
//    void Dail();
//    void PickUp();
//    void Send();
//    void Receive();
//}


//class NokiaPhone : IPhone
//{
//    public void Dail()
//    {
//        Console.WriteLine("Nokia calling ...");
//    }

//    public void PickUp()
//    {
//        Console.WriteLine("Hello! This is Tim!");
//    }

//    public void Send()
//    {
//        Console.WriteLine("Nokia message ring ...");
//    }

//    public void Receive()
//    {
//        Console.WriteLine("Hello!");
//    }
//}


//class EricssonPhone : IPhone
//{
//    public void Dail()
//    {
//        Console.WriteLine("Ericsson calling ...");
//    }

//    public void PickUp()
//    {
//        Console.WriteLine("Hello! This is Tim!");
//    }

//    public void Send()
//    {
//        Console.WriteLine("Ericsson ring ...");
//    }

//    public void Receive()
//    {
//        Console.WriteLine("Good evening!");
//    }
//}















//------------------------------------------------------------------------------------------------------














//class Program
//{
//    static void Main(string[] args)
//    {
//        DeskFan deskFan = new DeskFan(new PowerSupply());
//        Console.WriteLine(deskFan.Work());
//    }
//}


//public interface IPowerSupply
//{
//    int GetPower();
//}


//class PowerSupply : IPowerSupply
//{
//    public int GetPower()
//    {
//        return 100;
//    }
//}


//public class DeskFan
//{
//    private IPowerSupply _powerSupply;
//    public DeskFan(IPowerSupply powerSupply)
//    {
//        _powerSupply = powerSupply;
//    }

//    public string Work()
//    {
//        int power = _powerSupply.GetPower();
//        if (power <= 0)
//        {
//            return "Won't work.";
//        }
//        else if (power < 100)
//        {
//            return "Slow";
//        }
//        else if (power < 200)
//        {
//            return "Work fine";
//        }
//        else
//        {
//            return "Warning";
//        }
//    }
//}