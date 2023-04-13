namespace day18;

//引用参数 -> 值类型
//class Program
//{
//    
//    static void Main(string[] args)
//    {
//        int y = 1;
//        IWantSideEffect(ref y);
//        Console.WriteLine(y);
//    }

//    static void IWantSideEffect(ref int x)
//    {
//        x += 100;
//    }
//}





//------------------------------------------------------------------------------------------------------


//引用参数 -> 引用类型
//class Program
//{
//    static void Main(string[] args)
//    {
//        var outterStu = new Student() { Name = "Tim" };
//        Console.WriteLine("HashCode={0}, Name={1}", outterStu.GetHashCode(), outterStu.Name);
//        Console.WriteLine("-----------------");
//        IWantSideEffect(ref outterStu);
//        Console.WriteLine("HashCode={0}, Name={1}", outterStu.GetHashCode(), outterStu.Name);
//    }

//    static void IWantSideEffect(ref Student stu)
//    {
//        stu = new Student() { Name = "Tom" };
//        Console.WriteLine("HashCode={0}, Name={1}", stu.GetHashCode(), stu.Name);
//    }
//}

//class Student
//{
//    public string Name { get; set; }
//}







//------------------------------------------------------------------------------------------------------







//输出参数 -> 值类型
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Please input first number:");
//        var arg1 = Console.ReadLine();
//        double x = 0;
//        if (double.TryParse(arg1, out x) == false)
//        {
//            Console.WriteLine("Input error!");
//            return;
//        }

//        Console.WriteLine("Please input second number:");
//        var arg2 = Console.ReadLine();
//        double y = 0;
//        if (double.TryParse(arg2, out y) == false)
//        {
//            Console.WriteLine("Input error!");
//            return;
//        }

//        double z = x + y;
//        Console.WriteLine(z);
//    }
//}







//------------------------------------------------------------------------------------------------------







//自己实现了带有输出参数的 TryParse
//class Program
//{
//    static void Main(string[] args)
//    {
//        double x = 0;
//        if (DoubleParser.TryParse("aa", out x))
//        {
//            Console.WriteLine(x);
//        }
//    }
//}

//class DoubleParser
//{
//    public static bool TryParse(string input, out double result)
//    {
//        try
//        {
//            result = double.Parse(input);
//            return true;
//        }
//        catch
//        {
//            result = 0;
//            return false;
//        }
//    }
//}








//------------------------------------------------------------------------------------------------------







//输出参数 -> 引用类型
//class Program
//{
//    static void Main(string[] args)
//    {
//        Student stu = null;
//        if (StudentFactory.Create("Tim", 34, out stu))
//        {
//            Console.WriteLine("Student {0}, age is {1}", stu.Name, stu.Age);
//        }
//    }
//}

//class Student
//{
//    public int Age { get; set; }
//    public string Name { get; set; }
//}

//class StudentFactory
//{
//    public static bool Create(string stuName, int stuAge, out Student result)
//    {
//        result = null;
//        if (string.IsNullOrEmpty(stuName))
//        {
//            return false;
//        }

//        if (stuAge < 20 || stuAge > 80)
//        {
//            return false;
//        }

//        result = new Student() { Name = stuName, Age = stuAge };
//        return true;
//    }
//}





//------------------------------------------------------------------------------------------------------




//数组参数 params
//class Program
//{
//    static void Main(string[] args)
//    {
//        int result = CalculateSum(1,2,3);
//        Console.WriteLine(result);


//        string str = "jiang;ji.kang";
//        string[] strArray = str.Split(';','.');
//        foreach (var item in strArray)
//        {
//            Console.WriteLine(item);
//        }
//    }

//    static int CalculateSum(params int[] intArray)
//    {
//        int sum = 0;
//        foreach (var item in intArray)
//        {
//            sum += item;
//        }
//        return sum;
//    }
//}





//------------------------------------------------------------------------------------------------------




//具名参数: 提高代码的可读性、不受参数列表顺序的约束
//class Program
//{
//    static void Main(string[] args)
//    {
//        PrintInfo(name:"jiang", age:23);
//    }

//    static void PrintInfo(string name, int age)
//    {
//        Console.WriteLine("Hello {0} you are {1}", name, age);
//    }
//}





//------------------------------------------------------------------------------------------------------





//可选参数: 有默认值
//class Program
//{
//    static void Main(string[] args)
//    {
//        PrintInfo();
//    }

//    static void PrintInfo(string name = "Tim", int age = 34)
//    {
//        Console.WriteLine("Hello {0} you are {1}", name, age);
//    }
//}






//------------------------------------------------------------------------------------------------------





//扩展方法:
//方法必需是公有、静态的，即被public static所修饰
//必需是形参列表中的第一个，由this修饰
//必需由一个静态类（一般类名为SomeTypeExtension）来统一收纳对SomeType类型的扩展方法
//class Program
//{
//    static void Main(string[] args)
//    {
//        double x = 3.1415926;
//        double y = x.Round(4);
//        Console.WriteLine(y);
//    }
//}


//static class DoubleExtension
//{
//    public static double Round(this double input, int digits)
//    {
//        double result = Math.Round(input, digits);
//        return result;
//    }
//}