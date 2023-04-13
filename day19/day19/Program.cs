namespace day19;

//Action 和 Func委托
//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculator calculator = new Calculator();
//        Action action = new Action(calculator.Report);
//        action();
//        Func<int, int, int> func1 = new Func<int, int, int>(calculator.Add);
//        Func<int, int, int> func2 = new Func<int, int, int>(calculator.Sub);

//        int y1 = func1(100, 200);

//        int y2 = func2(500, 200);
//        Console.WriteLine(y1);
//        Console.WriteLine(y2);


//    }
//}

//class Calculator
//{
//    public void Report()
//    {
//        Console.WriteLine("I have three Methods");
//    }

//    public int Add(int a, int b)
//    {
//        return a + b;
//    }

//    public int Sub(int a, int b)
//    {
//        return a - b;
//    }
//}







//------------------------------------------------------------------------------------------------------




//自定义委托（delegate）
//•委托是一种类（class），类是数据类型所以委托也是一种数据类型
//•它的声名方式与一般的类不同，主要是为了照顾可读性和C/C++传统
//•注意声明委托的位置
//•避免写错地方结果声明成嵌套类型
//•委托与所封装的方法必需“类型兼容〞
//public delegate double Calc(double x, double y);
//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculator calculator = new Calculator();
//        Calc calc1 = new Calc(calculator.Add);
//        Calc calc2 = new Calc(calculator.Sub);
//        Calc calc3 = new Calc(calculator.Mul);
//        Calc calc4 = new Calc(calculator.Div);

//        Console.WriteLine(calc1(1000, 100));
//        Console.WriteLine(calc2(1000, 100));
//        Console.WriteLine(calc3(1000, 100));
//        Console.WriteLine(calc4(1000, 100));
//    }
//}


//class Calculator
//{
//    public double Add(double a, double b)
//    {
//        return a + b;
//    }

//    public double Sub(double a, double b)
//    {
//        return a - b;
//    }

//    public double Mul(double x, double y)
//    {
//        return x * y;
//    }

//    public double Div(double x, double y)
//    {
//        return x / y;
//    }
//}








//------------------------------------------------------------------------------------------------------








//模版方法
//class Program
//{
//    static void Main(string[] args)
//    {
//        ProductFactory productFactory = new ProductFactory();
//        WrapFactory wrapFactory = new WrapFactory();

//        Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
//        Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

//        Box box1 = wrapFactory.Wraproduct(func1);
//        Box box2 = wrapFactory.Wraproduct(func2);

//        Console.WriteLine(box1.Product.Name);
//        Console.WriteLine(box2.Product.Name);
//    }
//}


//class Product
//{
//    public string Name { get; set; }
//}


//class Box
//{
//    public Product Product { get; set; }
//}


//class WrapFactory
//{
//    public Box Wraproduct(Func<Product> getProduct)
//    {
//        Box box = new Box();
//        Product product = getProduct.Invoke();
//        box.Product = product;
//        return box;
//    }
//}


//class ProductFactory
//{
//    public Product MakePizza()
//    {
//        Product product = new Product();
//        product.Name = "Pizza";
//        return product;
//    }

//    public Product MakeToyCar()
//    {
//        Product product = new Product();
//        product.Name = "ToyCar";
//        return product;
//    }
//}








//------------------------------------------------------------------------------------------------------






//回调方法
//class Program
//{
//    static void Main(string[] args)
//    {
//        ProductFactory productFactory = new ProductFactory();
//        WrapFactory wrapFactory = new WrapFactory();

//        Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
//        Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

//        Logger logger = new Logger();
//        Action<Product> log = new Action<Product>(logger.Log);

//        Box box1 = wrapFactory.Wraproduct(func1, log);
//        Box box2 = wrapFactory.Wraproduct(func2, log);

//        Console.WriteLine(box1.Product.Name);
//        Console.WriteLine(box2.Product.Name);
//    }
//}


//class Logger
//{
//    public void Log(Product product)
//    {
//        Console.WriteLine("Product {0} created at {1}. Price is {2}.", product.Name, DateTime.UtcNow, product.Price);
//    }
//}


//class Product
//{
//    public string Name { get; set; }
//    public double Price { get; set; }
//}


//class Box
//{
//    public Product Product { get; set; }
//}


//class WrapFactory
//{
//    public Box Wraproduct(Func<Product> getProduct, Action<Product> logCallback)
//    {
//        Box box = new Box();
//        Product product = getProduct.Invoke();
//        if (product.Price >= 50)
//        {
//            logCallback(product);
//        }
//        box.Product = product;
//        return box;
//    }
//}


//class ProductFactory
//{
//    public Product MakePizza()
//    {
//        Product product = new Product();
//        product.Name = "Pizza";
//        product.Price = 12;
//        return product;
//    }

//    public Product MakeToyCar()
//    {
//        Product product = new Product();
//        product.Name = "ToyCar";
//        product.Price = 100;
//        return product;
//    }
//}









//------------------------------------------------------------------------------------------------------












