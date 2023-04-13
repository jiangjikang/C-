//namespace day28;
//class Program
//{
//    static void Main(string[] args)
//    {

//    }
//}


//abstract class Student
//{
//    abstract public void Study();
//}









//------------------------------------------------------------------------------------------------------








//违反了设计原则：不能 copy paste。
//class Car
//{
//    public void Run()
//    {
//        Console.WriteLine("Car is running...");
//    }

//    public void Stop()
//    {
//        Console.WriteLine("Stopped");
//    }
//}


//class Truck
//{
//    public void Run()
//    {
//        Console.WriteLine("Car is running...");
//    }

//    public void Stop()
//    {
//        Console.WriteLine("Stopped");
//    }
//}









//------------------------------------------------------------------------------------------------------









//class Vehicle
//{
//    public void Stop()
//    {
//        Console.WriteLine("Stopped");
//    }

//    //违反了开闭原则，既没有修 bug 又没有添新功能就多了个 Run 方法
//    public void Run(string type)
//    {
//        if (type == "car")
//        {
//            Console.WriteLine("Car is running...");
//        }
//        else if (type == "truck")
//        {
//            Console.WriteLine("Truck is running...");
//        }
//    }
//}


//class Car : Vehicle
//{
//    public void Run()
//    {
//        Console.WriteLine("Car is running...");
//    }
//}


//class Truck : Vehicle
//{
//    public void Run()
//    {
//        Console.WriteLine("Car is running...");
//    }
//}








//------------------------------------------------------------------------------------------------------









//class Program
//{
//    static void Main(string[] args)
//    {
//        Vehicle v = new Car();
//        v.Run();
//    }
//}


//class Vehicle
//{
//    public void Stop()
//    {
//        Console.WriteLine("Stopped!");
//    }

//    public virtual void Run()
//    {
//        //这将是一段不会执行的代码！
//        Console.WriteLine("Vehicle is running...");
//    }
//}


//class Car : Vehicle
//{
//    public override void Run()
//    {
//        Console.WriteLine("Car is running...");

//    }
//}


//class Truck : Vehicle
//{
//    public override void Run()
//    {
//        Console.WriteLine("Truck is running...");
//    }
//}










//------------------------------------------------------------------------------------------------------










//class Program
//{
//    static void Main(string[] args)
//    {
//        Vehicle v = new Car();
//        v.Run();
//    }
//}



////抽象类
//abstract class Vehicle
//{
//    public void Stop()
//    {
//        Console.WriteLine("Stopped!");
//    }

//    //抽象方法
//    public abstract void Run();
//}


//class Car : Vehicle
//{
//    //实现抽象方法
//    public override void Run()
//    {
//        Console.WriteLine("Car is running...");
//    }
//}


//class Truck : Vehicle
//{
//    public override void Run()
//    {
//        Console.WriteLine("Truck is running...");
//    }
//}











//------------------------------------------------------------------------------------------------------












//纯虚类
//interface IVehicle
//{
//    void Stop();
//    void Fill();
//    void Run();
//}


//abstract class Vehicle : IVehicle
//{
//    public void Stop()
//    {
//        Console.WriteLine("Stopped!");
//    }

//    public void Fill()
//    {
//        Console.WriteLine("Pay and fill...");
//    }

//    public abstract void Run();
//}


//class Car : Vehicle
//{
//    public override void Run()
//    {
//        Console.WriteLine("Run is running...");
//    }
//}
