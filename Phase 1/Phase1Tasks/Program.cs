
#define TRIAL_VERSION
using SchoolManagementSystem; //Task 1.5
using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        // With using directive
        student student1 = new student();
        student1.Details();

        // Without using directive
        SchoolManagementSystem.student student2 = new SchoolManagementSystem.student();
        student2.Details();

        ModuleA.Helper.Greet(); // Task 1.6
        ModuleB.Helper.Greet();


        string studentName = "Sid"; // Task 1.7
        int AgeOld = 22;
        double StudentHeight = 5.9;
        bool isEnrolled = true;
        char grade = 'A';

        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Age: " + AgeOld);
        Console.WriteLine("Height: " + StudentHeight);
        Console.WriteLine("Enrolled: " + isEnrolled);
        Console.WriteLine("Grade: " + grade);

        int @class = 10;
        Console.WriteLine("Class: " + @class);


#if TRIAL_VERSION //Task 1.8
        Console.WriteLine("Trial version is running.");
#else
        Console.WriteLine("Full version is running.");
#endif

        Product product = new Product("Laptop", 50000);
        product.DisplayDetails();


        // Copy and modify integers --- Copying an integer creates a new copy of the value, so modifying the copy does not affect the original value.
        int a = 10;
        int b = a;

        b = 20;
        Console.WriteLine("a:" + a);
        Console.WriteLine("b:" + b);

        // Copy and modify int[] ---- Cpying an array creates a reference to the original array, so modifying the copy will affect the original array as well.
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;

        arr2[0] = 10;
        Console.WriteLine("arr1[0]:" + arr1[0]);
        Console.WriteLine("arr2[0]:" + arr2[0]);


        // Copy and modify CoordinateClass
        CoordinateClass Coordinate1 = new CoordinateClass(5, 10);
        CoordinateClass Coordinate2 = Coordinate1;

        Coordinate2.X = 20;

        Console.WriteLine("Coordinate1.X: " + Coordinate1.X);
        Console.WriteLine("Coordinate2.X: " + Coordinate2.X);

        // Copy and modify CoordinateStruct
        CoordinateStruct Struct1 = new CoordinateStruct(5, 10);
        CoordinateStruct Struct2 = Struct1;
        Struct2.X = 20;

        Console.WriteLine("Struct1.X: " + Struct1.X);
        Console.WriteLine("Struct2.X: " + Struct2.X);

        Console.Write("Enter num (0-6): ");
        int dayNo = Convert.ToInt32(Console.ReadLine()); // Task 1.10

        if (Enum.IsDefined(typeof(DaysOfWeek), dayNo))
        {
            DaysOfWeek day = (DaysOfWeek)dayNo;
            Console.WriteLine("Day: " + day);
        }
        else
        {
            Console.WriteLine("Invalid day number.");
        }
        //FilePermission flags
        FilePermissions permissions = FilePermissions.Read | FilePermissions.Write;
        Console.WriteLine("Permissions: " + permissions);
        // Check Read permission
        if ((permissions & FilePermissions.Read) == FilePermissions.Read)
        {
            Console.WriteLine("Read permission is granted.");
        }
        else
        {
            Console.WriteLine("Read permission is not granted.");
        }

        //Execute permission check
        if ((permissions & FilePermissions.Execute) == FilePermissions.Execute)
        {
            Console.WriteLine("Execute permission is granted.");
        }
        else
        {
            Console.WriteLine("Execute permission is not granted.");
        }

        int? age = null; // Tak 1.11
        if (age.HasValue)
        {
            Console.WriteLine("Age: " + age.Value);
        }
        else
        {
            Console.WriteLine("Age is not specified.");
        }


        age = 22;
        if (age.HasValue)
        {
            Console.WriteLine("Age: " + age.Value);
        }
        else
        {
            Console.WriteLine("Age is not specified.");
        }

        double ogprice = 50000;
        double pricewithDefault = ApplyDiscount(ogprice, null); // Task 1.11
        Console.WriteLine("Price with default discount: " + pricewithDefault);

        double pricewithCustom = ApplyDiscount(ogprice, 10);
        Console.WriteLine("Price with custom discount: " + pricewithCustom);

        //Task 1.12: Implicit type conversion
        int intValue = 70;
        long longValue = intValue; // Implicit conversion from int to long
        float floatValue = intValue; // Implicit conversion from int to float
        double doubleValue = intValue; // Implicit conversion from int to doubleTask 1.12  Show int→long→float→double (implicit) and double→int (explicit, precision loss). Take a string and use is, as, Convert.ToInt32, int.TryParse, noting when each is right.  ✓ Done when: all four conversion approaches run and the precision-loss case is noted. 
        Console.WriteLine("Integer:" + intValue);
        Console.WriteLine("Long:" + longValue); 
        Console.WriteLine("Float:" + floatValue);
        Console.WriteLine("Double:" + doubleValue);

        // Explicit type conversion
        double decimalValue = 56.47;
        int integerValue = (int)decimalValue;
        Console.WriteLine("Decimal:" + decimalValue);
        Console.WriteLine("Conveted Integer:" + integerValue);

        //is operator
        object objVal = 100;
        if (objVal is int)
        {
            Console.WriteLine("objVal is an integer.");
        }
        else
        {
            Console.WriteLine("objVal is not an integer.");
        }

        //as operator
        object objStr = "Hello";
        string? convertedString = objStr as string;
        Console.WriteLine(convertedString ?? "Conversion failed.");

        //Convert.ToInt32
        string strValue = "324";
        int convertedNumber = Convert.ToInt32(strValue);
        Console.WriteLine("Converted Number: " + convertedNumber);

        //int.TryParse
        Console.Write("Enter an int: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int parsedNumber))
        {
            Console.WriteLine("Parsed Number: " + parsedNumber);
        }
        else
        {
            Console.WriteLine("Invalid input. Could not parse to an integer.");
        }

        var numb = 10; // Task 1.13
        Console.WriteLine(numb);
        //numb = "Hello";

        dynamic value = "Hi";
        Console.WriteLine(value + "-" + value.GetType());

        value = 100;
        Console.WriteLine(value + "-" + value.GetType());

        value = true;
        Console.WriteLine(value + "-" + value.GetType());

        //Dynamic add method
        dynamic result1 = Add(10, 20);
        Console.WriteLine("Result int: " + result1);
        Console.WriteLine("Result type: " + result1.GetType());

        dynamic result2 = Add("Hi rfgit","Sid");
        Console.WriteLine("Result string: " + result2);
        Console.WriteLine("Result type: " + result2.GetType());

        // Task 1.14: GetMinMax and deconstruction
        int[] numbers = { 23, 234, 566, 34, 53, 23, 43 };

        (int minVal, int maxVal) = GetMinMax(numbers);
        Console.WriteLine("Min Value: " + minVal);
        Console.WriteLine("Max Value: " + maxVal);
        //deconstruction
        (string empName, int empAge, string empDept) = GetEmployee();
        Console.WriteLine("Employee Name: " + empName);
        Console.WriteLine("Employee Age: " + empAge);
        Console.WriteLine("Employee Department: " + empDept);

    }

    static double ApplyDiscount(double price, double? discount)
    {
        double actualDiscount = discount ?? 5;
        return price - (price * actualDiscount / 100);
    }
    static dynamic Add(dynamic a, dynamic b)
    {
        return a + b;
    }

    // Task 1.14: Get minimum and maximum values
    static (int Min, int Max) GetMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach(int num in numbers)
        {
            if(num < min)
            {
                min = num;
            }
            if(num > max)
            {
                max = num;
            }
        }
        return (min, max);
    }
    //Employee lookup
    static (string Name, int Age, string Dept)GetEmployee()
    {
        return("Sid", 22, "IT");
    }

}

class Product
{
    #region Fields
    private string name;
    private double price;
    #endregion

    #region Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    #endregion

    #region Constructors
    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }
    #endregion

    #region Methods
    public void DisplayDetails()
    {
        Console.WriteLine("Product: " + Name);
        Console.WriteLine("Price: " + Price);
    }
    #endregion
}

//Copy and modify Coordinate class //Reference type---- Copying a class creates a reference to the original object, so modifying the copy will affect the original object as well.
class CoordinateClass
{
    public int X;
    public int Y;

    public CoordinateClass(int x, int y)
    {
        X = x;
        Y = y;
    }

}

//Copy and modify Coordinate struct //Value type --- Copying a struct does not create a reference to the original struct, but rather creates a new copy of the struct with its own values. Therefore, modifying the copy does not affect the original struct.
struct CoordinateStruct

{
    public int X;
    public int Y;

    public CoordinateStruct(int x, int y)
    {
        X = x;
        Y = y;
    }
}

enum DaysOfWeek // Task 1.10
{
    Sunday = 0,
    Monday = 1,
    Tuesday =2,
    Wednesday=3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6
}

[Flags]
enum FilePermissions // Task 1.10 --- Flag for file permission
{
    Read = 1,
    Write = 2,
    Execute = 4
}

