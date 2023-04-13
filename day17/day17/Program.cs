namespace day17;

//实例字段与静态字段
//class Program
//{
//    static void Main(string[] args)
//    {
//        var stuList = new List<Student>();
//        for (int i = 0; i < 100; i++)
//        {
//            var stu = new Student() { Age = 23, Score = i };

//            stuList.Add(stu);
//        }

//        int totalAge = 0;
//        int totalScore = 0;

//        foreach (var item in stuList)
//        {
//            totalAge += item.Age;
//            totalScore += item.Score;
//        }

//        Student.AverageAge = totalAge / Student.Amout;
//        Student.AverageScore = totalScore / Student.Amout;

//        Student.ReportAmout();
//        Student.ReportAverageAge();
//        Student.ReportAverageScore();
//    }
//}


//class Student
//{
//    //静态构造器: 数据类型被运行环境加载时，它的静态构造器将会被调用，且只被调用一次。
//    static Student()
//    {
//        Amout = 0;
//    }

//    //对于实例字段，它初始化的时机是在实例创建时
//    public int Age;
//    public int Score;

//    //对于静态字段，它初始化的时机是在运行环境加载该数据类型时
//    public static int AverageAge;
//    public static int AverageScore;
//    public static int Amout;

//    public Student()
//    {
//        Amout++;
//    }

//    public static void ReportAmout()
//    {
//        Console.WriteLine(Amout);
//    }

//    public static void ReportAverageAge()
//    {
//        Console.WriteLine(AverageAge);
//    }

//    public static void ReportAverageScore()
//    {
//        Console.WriteLine(AverageScore);
//    }
//}


//只读字段 readonly: 只读字段为实例或类型保存一旦初始化后就不希望再改变的值。
//可用于修饰属性、字段、结构体成员。













//------------------------------------------------------------------------------------------------------













//属性
//class Program
//{
//    static void Main(string[] args)
//    {
//        Student student = new Student();
//    }
//}


//class Student
//{
//    private int age;

//    //永远使用属性（而不是字段）来暴露数据，即字段永远是 private 或 protected 的。
//    //字段只在类内部使用，类之间交换数据，永远只用属性。
//    public string Name { get; set; }
//    public int Age { get; set; }
//}












//------------------------------------------------------------------------------------------------------














