using System.Collections.Generic;

namespace day31;



//class Program
//{
//    static void Main(string[] args)
//    {
//        Apple apple = new Apple() { Color = "red" };
//        Box box = new Box() { Cargo = apple };
//        Console.WriteLine(box.Cargo.Color);
//    }
//}


//class Apple
//{
//    public string Color { get; set; }
//}


//class Box
//{
//    public Apple Cargo { get; set; }
//}












//------------------------------------------------------------------------------------------------------











//一：我们专门为 Book 类添加一个 BookBox 类的盒子。
//class Program
//{
//    static void Main(string[] args)
//    {
//        var apple = new Apple() { Color = "red" };
//        var appleBox = new AppleBox() { Cargo = apple };
//        Console.WriteLine(appleBox.Cargo.Color);

//        Book book = new Book() { Name = "new book" };
//        BookBox bookBox = new BookBox() { Cargo = book };
//        Console.WriteLine(bookBox.Cargo.Name);
//    }
//}


//class Apple
//{
//    public string Color { get; set; }
//}


//class Book
//{
//    public string Name { get; set; }
//}


//class AppleBox
//{
//    public Apple Cargo { get; set; }
//}


//class BookBox
//{
//    public Book Cargo { get; set; }
//}












//------------------------------------------------------------------------------------------------------














//二：用同一个 Box 类，每增加一个商品时就给 Box 类添加一个属性。
//class Program
//{
//    static void Main(string[] args)
//    {
//        Apple apple = new Apple() { Color = "red" };
//        Book book = new Book() { Name = "new name" };
//        Box boxApple = new Box() { Apple = apple };
//        Box boxBook = new Box() { Book = book };
//        Console.WriteLine(boxApple.Apple.Color);
//        Console.WriteLine(boxBook.Book.Name);
//    }
//}


//class Apple
//{
//    public string Color { get; set; }
//}


//class Book
//{
//    public string Name { get; set; }
//}


//class Box
//{
//    public Apple Apple { get; set; }
//    public  Book Book { get; set; }
//}












//------------------------------------------------------------------------------------------------------












//三：Box 类里面的 Cargo 改为 Object 类型。
//class Program
//{
//    static void Main(string[] args)
//    {
//        Apple apple = new Apple() { Color = "red" };
//        Book book = new Book() { Name = "new name" };
//        Box appleBox = new Box() { Cargo = apple };
//        Box bookBox = new Box() { Cargo = book };
//        Console.WriteLine((appleBox.Cargo as Apple)?.Color);
//    }
//}


//class Apple
//{
//    public string Color { get; set; }
//}


//class Book
//{
//    public string Name { get; set; }
//}


//class Box
//{
//    public object Cargo { get; set; }
//}











//------------------------------------------------------------------------------------------------------












//四：泛型类
//class Program
//{
//    static void Main(string[] args)
//    {
//        Apple apple = new Apple() { Color = "red" };
//        Book book = new Book() { Name = "new name" };
//        Box<Apple> appleBox = new Box<Apple>() { Cargo = apple };
//        Box<Book> bookBox = new Box<Book>() { Cargo = book };
//    }
//}


//class Apple
//{
//    public string Color { get; set; }
//}


//class Book
//{
//    public string Name { get; set; }
//}


//class Box<TCargo>
//{
//    public TCargo Cargo { get; set; }
//}












//------------------------------------------------------------------------------------------------------













//泛型接口
//class Program
//{
//    static void Main(string[] args)
//    {
//        Student<int, string> student = new Student<int, string>();
//        student.ID = 23;
//        student.Name = "jiang";

//    }
//}


//interface IUnique<T>
//{
//    T ID { get; set; }
//}


//class Student<T,T1> : IUnique<T>
//{
//    public T ID { get; set; }
//    public T1 Name { get; set; }
//}


//class Student : IUnique<ulong>
//{
//    public ulong ID { get; set; }
//    public string Name { get; set; }
//}











//------------------------------------------------------------------------------------------------------












//泛型集合: 这些泛型集合都集中在 System.Collections.Generic 命名空间中。
//class Program
//{
//    static void Main(string[] args)
//    {
//        IList<int> list = new List<int>();
//        for (int i = 0; i < 100; i++)
//        {
//            list.Add(i);
//        }

//        foreach (var item in list)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}










//------------------------------------------------------------------------------------------------------












//泛型方法
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array1 = new int[] { 1, 2, 3, 4, 5 };
//        int[] array2 = new int[] { 1, 2, 3, 4, 5, 6 };
//        var result = Zip(array1, array2);
//        Console.WriteLine(string.Join(",", result));
//    }

//    static T[] Zip<T>(T[] array1, T[]array2)
//    {
//        T[] array3 = new T[array1.Length + array2.Length];
//        int ai = 0, bi = 0, zi = 0;
//        do
//        {
//            if (ai < array1.Length) array3[zi++] = array1[ai++];
//            if (bi < array2.Length) array3[zi++] = array2[bi++];
//        } while (ai < array1.Length || bi < array2.Length);
//        return array3;
//    }
//}



//泛型委托: Action
//class Program
//{
//    static void Main(string[] args)
//    {
//        Action<string> s = Say;
//        s("jiang");

//        Action<int> i = Mul;
//        i(1);
//    }

//    static void Say(string str)
//    {
//        Console.WriteLine($"Hello, {str}!");
//    }

//    static void Mul(int x)
//    {
//        Console.WriteLine(x * 100);
//    }
//}


//泛型委托: Func
//class Program
//{
//    static void Main(string[] args)
//    {
//        Func<int, int, int> add = Add;
//        Console.WriteLine(add(1, 2));

//        Func<double, double, double> funcD = Add;
//        Console.WriteLine(funcD(1, 2));
//    }

//    static int Add(int a, int b)
//    {
//        return a + b;
//    }

//    static double Add(double a ,double b)
//    {
//        return a + b;
//    }
//}












//------------------------------------------------------------------------------------------------------












//枚举
//class Program
//{
//    static void Main(string[] args)
//    {
//        var employee = new Person() { level = Level.Employee};
//        var boss = new Person() { level = Level.Boss };
//        Console.WriteLine(boss.level > employee.level);

//        Console.WriteLine((int)Level.Employee);
//        Console.WriteLine((int)Level.Manager); 
//        Console.WriteLine((int)Level.Boss);    
//        Console.WriteLine((int)Level.BigBoss);
//    }
//}


//enum Level
//{
//    Employee,
//    Manager = 100,
//    Boss = 200,
//    BigBoss,
//}


//class Person
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public Level level { get; set; }
//}













//------------------------------------------------------------------------------------------------------













//结构体
//class Program
//{
//    static void Main(string[] args)
//    {
//        Student student = new Student() { ID = 123, Name = "jiangjikang" };
//        Object o = student;
//        Student stu = (Student)o;
//        stu.ID = 1234;

//        Console.WriteLine($"My name is {stu.Name},ID is {stu.ID}");
//    }
//}


//struct Student
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//}




//结构体实现接口
//class Program
//{
//    static void Main(string[] args)
//    {
//        Student student = new Student() { ID = 123, Name = "jiangjkang" };
//        student.Speak();
//    }
//}


//interface ISpeak
//{
//    void Speak();
//}


//class Student : ISpeak
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public void Speak()
//    {
//        Console.WriteLine($"My name is {Name}, My ID is {ID}");
//    }
//}