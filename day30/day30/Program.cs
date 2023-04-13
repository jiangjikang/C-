using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace day30;

//接口隔离
//class Program
//{
//    static void Main(string[] args)
//    {
//        var driver = new Driver(new Car());
//        driver.Drive();
//    }
//}


//class Driver
//{
//    private IVehicle _vehicle;
//    public Driver(IVehicle vehicle)
//    {
//        this._vehicle = vehicle;
//    }

//    public void Drive()
//    {
//        _vehicle.Run();
//    }
//}


//interface IVehicle
//{
//    void Run();
//}


//class Car : IVehicle
//{
//    public void Run()
//    {
//        Console.WriteLine("Car is running ...");
//    }
//}


//class Truck : IVehicle
//{
//    public void Run()
//    {
//        Console.WriteLine("Truck is running ...");
//    }
//}


//interface ITank
//{
//    void Fire();
//    void Run();
//}


//class LightTank : ITank
//{
//    public void Fire()
//    {
//        Console.WriteLine("Boom!");
//    }

//    public void Run()
//    {
//        Console.WriteLine("Ka ka ka ...");
//    }
//}


//class MediumTank : ITank
//{
//    public void Fire()
//    {
//        Console.WriteLine("Boom!!");
//    }

//    public void Run()
//    {
//        Console.WriteLine("Ka! ka! ka! ...");
//    }
//}


//class HeavyTank : ITank
//{
//    public void Fire()
//    {
//        Console.WriteLine("Boom!!!");
//    }

//    public void Run()
//    {
//        Console.WriteLine("Ka!! ka!! ka!! ...");
//    }
//}











//------------------------------------------------------------------------------------------------------












//class Program
//{
//    static void Main(string[] args)
//    {
//        var driver = new Driver(new HeavyTank());
//        driver.Drive();
//    }
//}


//class Driver
//{
//    private IVehicle _vehicle;
//    public Driver(IVehicle vehicle)
//    {
//        this._vehicle = vehicle;
//    }

//    public void Drive()
//    {
//        _vehicle.Run();
//    }
//}


//interface IVehicle
//{
//    void Run();
//}


//interface IWeapon
//{
//    void Fire();
//}


//class Car : IVehicle
//{
//    public void Run()
//    {
//        Console.WriteLine("Car is running ...");
//    }
//}


//class Truck : IVehicle
//{
//    public void Run()
//    {
//        Console.WriteLine("Truck is running ...");
//    }
//}


//interface ITank : IVehicle, IWeapon
//{

//}



//class LightTank : ITank
//{
//    public void Fire()
//    {
//        Console.WriteLine("Boom!");
//    }

//    public void Run()
//    {
//        Console.WriteLine("Ka ka ka ...");
//    }
//}


//class MediumTank : ITank
//{
//    public void Fire()
//    {
//        Console.WriteLine("Boom!!");
//    }

//    public void Run()
//    {
//        Console.WriteLine("Ka! ka! ka! ...");
//    }
//}


//class HeavyTank : ITank
//{
//    public void Fire()
//    {
//        Console.WriteLine("Boom!!!");
//    }

//    public void Run()
//    {
//        Console.WriteLine("Ka!! ka!! ka!! ...");
//    }
//}











//------------------------------------------------------------------------------------------------------















//传了个大接口?
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] nums1 = { 1, 2, 3, 4, 5 };
//        ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };

//        Console.WriteLine(Sum(nums1));
//        Console.WriteLine(Sum(nums2));

//        // 可以迭代
//        var num3 = new ReadOnlyConllection(nums1);
//        foreach (var n in num3)
//        {
//            Console.WriteLine(n);
//        }

//        Console.WriteLine(Sum(num3));

//        static int Sum(IEnumerable nums)
//        {
//            int sums = 0;
//            foreach (var item in nums)
//            {
//                sums += (int)item;
//            }
//            return sums;
//        }
//    }
//}


//class ReadOnlyConllection : IEnumerable
//{
//    private int[] _array;

//    public ReadOnlyConllection(int[] array)
//    {
//        this._array = array;
//    }

//    public IEnumerator GetEnumerator()
//    {
//        return new Enumerator(this);
//    }

//    public class Enumerator : IEnumerator
//    {
//        private ReadOnlyConllection _collection;
//        private int _head;

//        public Enumerator(ReadOnlyConllection conllection)
//        {
//            this._collection = conllection;
//        }

//        public object Current
//        {
//            get
//            {
//                object o = _collection._array[_head];
//                return o;
//            }
//        }

//        public bool MoveNext()
//        {
//            return ++_head < _collection._array.Length;
//        }

//        public void Reset()
//        {
//            _head = -1;
//        }
//    }
//}














//------------------------------------------------------------------------------------------------------















//显式接口实现
//class Program
//{
//    static void Main(string[] args)
//    {
//        var warmKiller = new WarmKiller();
//        warmKiller.Love();

//        IKiller killer = new WarmKiller();
//        var wk = (WarmKiller)killer;
//        killer.Kill();

//    }
//}


//interface IGentleman
//{
//    void Love();
//}


//interface IKiller
//{
//    void Kill();
//}


//class WarmKiller : IGentleman, IKiller
//{
//    public void Love()
//    {
//        Console.WriteLine("Let me kill the enemy ...");
//    }
//    void IKiller.Kill()
//    {
//        Console.WriteLine("I will love you forever ...");
//    } 
//}















//------------------------------------------------------------------------------------------------------













//依赖注入
class Program
{
    static void Main(string[] args)
    {
        //ITank tank = new HeavyTank();

        //var t = tank.GetType();
        //object o = Activator.CreateInstance(t);
        //MethodInfo fireMi = t.GetMethod("Fire");
        //MethodInfo runMi = t.GetMethod("Run");

        // ===========分割线===========
        //fireMi.Invoke(o, null);
        //runMi.Invoke(o, null);



        //Servicellection 是容器
        var sc = new ServiceCollection();

        //添加接口 ITank，并设置对应的实现类 HeavyTank
        sc.AddScoped(typeof(ITank), typeof(HeavyTank));
        var sp = sc.BuildServiceProvider();


        // ===========分割线===========
        ITank tank = sp.GetService<ITank>();
        tank.Fire();
        tank.Run();
    }
}


class Driver
{
    private IVehicle _vehicle;
    public Driver(IVehicle vehicle)
    {
        this._vehicle = vehicle;
    }

    public void Drive()
    {
        _vehicle.Run();
    }
}


interface IVehicle
{
    void Run();
}


class Car : IVehicle
{
    public void Run()
    {
        Console.WriteLine("Car is running ...");
    }
}


class Truck : IVehicle
{
    public void Run()
    {
        Console.WriteLine("Truck is running ...");
    }
}


interface ITank
{
    void Fire();
    void Run();
}


class LightTank : ITank
{
    public void Fire()
    {
        Console.WriteLine("Boom!");
    }

    public void Run()
    {
        Console.WriteLine("Ka ka ka ...");
    }
}


class MediumTank : ITank
{
    public void Fire()
    {
        Console.WriteLine("Boom!!");
    }

    public void Run()
    {
        Console.WriteLine("Ka! ka! ka! ...");
    }
}


class HeavyTank : ITank
{
    public void Fire()
    {
        Console.WriteLine("Boom!!!");
    }

    public void Run()
    {
        Console.WriteLine("Ka!! ka!! ka!! ...");
    }
}