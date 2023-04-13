namespace day26;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Type t = typeof(Car);
//        Type tb = t.BaseType;
//        Console.WriteLine(tb.FullName);


//        Car car = new Car();
//        Vehicle vehicle1 = new Vehicle();

//        Console.WriteLine(vehicle1 is Car);
//        Console.WriteLine(car is Vehicle);


//        Vehicle vehicle2 = new Car();
//        Object o1 = new Vehicle();
//        Object o2 = new Car();
//    }
//}
////继承的本质是派生类在基类已有成员的基础之上对基类进行的横向或纵向的扩展
////sealed: 加在class前，此类就不能作为基类(不能被其他类继承)
//class Vehicle
//{

//}


////只能有一个基类
////子类的访问级别不能超过父类
//class Car : Vehicle
//{

//}








//------------------------------------------------------------------------------------------------------







//class Program
//{
//    static void Main(string[] args)
//    {
//        Car car = new Car("car");

//        Console.WriteLine(car.Owner);

//    }
//}


//class Vehicle
//{
//    public Vehicle(string owner)
//    {
//        this.Owner = owner;
//    }

//    public string Owner { get; set; }
//}


//class Car : Vehicle
//{
//    public Car(string owner) : base(owner)
//    {

//    }

//    public void ShowOwner()
//    {
//        //base:基类对象(只能向上访问一层)
//        Console.WriteLine(base.Owner);
//        //this:当前对象
//        Console.WriteLine(this.Owner);
//    }
//}








//------------------------------------------------------------------------------------------------------







//using MyLib;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Vehicle vehicle = new Vehicle();
//        Car car = new Car("Tim");
//        car.ShowOwner();
//    }  
//}












