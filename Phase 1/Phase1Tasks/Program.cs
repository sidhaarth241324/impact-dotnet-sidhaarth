
#define TRIAL_VERSION
using Application;
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
        //Task 1.15
        CheckValue(42);
        CheckValue("Hello");    
        CheckValue(null);
        CheckValue(25.5);
        CheckValue(true);
        Console.WriteLine(CalculateGrade(95));
        Console.WriteLine(CalculateGrade(80));
        Console.WriteLine(CalculateGrade(65));
        Console.WriteLine(CalculateGrade(40));
        Console.WriteLine(CalculateGrade(25));
        Console.WriteLine(CalculateGrade(110));

        //1.15
        Order order1 = new Order("Completed", 1200);
        CalculateDiscount(order1);
        Order order2 = new Order("Completed", 600);
        CalculateDiscount(order2);
        Order order3 = new Order("Pending", 800);
        CalculateDiscount(order3);

        //Task 1.16
        Student stud1 = new Student("Sid", 22, 1001);
        Console.WriteLine("Student1");
        Console.WriteLine($"Name: {stud1.Name}, Age: {stud1.Age}, StudentId: {stud1.StudentId}");

        //chained constructor
        Student stud2 = new Student("Ravi", 25);
        Console.WriteLine("Student2");
        Console.WriteLine($"Name: {stud2.Name}, Age: {stud2.Age}, StudentId: {stud2.StudentId}");

//Test overload methods
        Console.WriteLine($"Grade for score 85 (int): {stud1.CalculateGrade(85)}");
        Console.WriteLine($"Grade for score 72.5(double): {stud1.CalculateGrade(72.5)}");

        //Age validation
        try
        {
            stud1.Age = 3;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Demonstrate readonly
        // student1.StudentId = 500; // Uncomment to see the compiler error.

        // Demonstrate const
        // Student.MinimumAge = 10; // Uncomment to see the compiler error.

        //Task 1.17  Partial class Employee across two files with a partial method; an access-modifier matrix class; Address(Street, City, Pincode) record compared with == and copied with with; a Playlist indexer with bounds checking + a string indexer.
        //Employee
        Employee employee = new Employee
        {
            EmployeeId = 101,
            Name = "Sid",
            Department = "IT"
        };
        employee.DisplayDetails();

        employee.Name = "Sidhaarth"; // This will trigger the OnNameChanged partial method

        //Access Modifiers

        AccessModifierMatrix access = new AccessModifierMatrix();

        access.DisplayFields();

        Console.WriteLine();
        DerivedClass derived = new DerivedClass();
        derived.DisplayDerivedFields();


        //Address record equality
        Address address1 = new Address("School Street","Karaikal","609609");

        Address address2 = new Address("School Street", "Karaikal", "609609");

        Console.WriteLine($"Address1 == Address2: {address1 == address2}"); // True

        Address address3 = address1 with { city = "Pondicherry" }; // Copy with modification

        Console.WriteLine($"Address3: {address3.street}, {address3.city}, {address3.pincode}"); // School Street, Pondicherry, 609609

        //Playlist indexer
        Playlist playlist = new Playlist(
            "Karuppane",
            "Thalapathy Kacheri",
            "Vidamuyarchi"
            );
        // Integer indexer
        Console.WriteLine($"First song: {playlist[0]}");

        //update song
        playlist[1] = "The One";
        Console.WriteLine($"Updated song: {playlist[1]}");

        //string indexer
        Console.WriteLine($"Next song { playlist["Vidamuyarchi"]}");

        try
        {
            Console.WriteLine(playlist[1]);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex);
        }

        //Task Mini Q1  Product Catalog: Product { Name, Price, Category(enum) }, 5 objects printed grouped by category.  ✓ Done when: output is grouped correctly by category. 
        List<ProductCatalogue> products = new List<ProductCatalogue>
        {
            new ProductCatalogue("Laptop",52000, Category.Electronics),
            new ProductCatalogue("T-Shirt", 799, Category.Clothing),
            new ProductCatalogue("Rice", 120, Category.Food),
            new ProductCatalogue("Headphones", 1500, Category.Electronics),
            new ProductCatalogue("Jeans", 1299, Category.Clothing)
        };

        foreach (Category category in Enum.GetValues(typeof(Category)))
        {
            Console.WriteLine($"\nCategory: {category}");
            // Check every product
            foreach (ProductCatalogue Product in products)
            {
                if (Product.Category == category)
                {
                    Console.WriteLine($"Name: {Product.Name}, Price: ₹{Product.Price:F2}"); //F2 --fixed point numeric stanfing
                }
            }
        }

        //Task Mini Q2 Temperature Converter: value + unit → the other two units, using method overloading
        TemperatureConverter converter = new TemperatureConverter();
        Console.WriteLine("From Celsius:");
        converter.Convert(25.0, "C");

        Console.WriteLine("\nFrom Fahrenheit:");
        converter.Convert("F", 77.0);

        Console.WriteLine("\nFrom Kelvin:");
        converter.Convert(300.0, 1);

        //Task Mini Q3  Contact Card: ContactCard struct array of 5; case-insensitive search by name.
        ContactCard[] contacts = new ContactCard[5];
        contacts[0] = new ContactCard(
    "Sidhaarth", "9876543210", "sid@example.com");

        contacts[1] = new ContactCard(
            "Ravi", "9876543211", "ravi@example.com");

        contacts[2] = new ContactCard(
            "Priya", "9876543212", "priya@example.com");

        contacts[3] = new ContactCard(
            "Arun", "9876543213", "arun@example.com");

        contacts[4] = new ContactCard(
            "Nivashini", "9876543214", "niva@example.com");

        // Get the name to search for
        Console.Write("Enter a name to search: ");
        string searchName = Console.ReadLine() ?? "";

        bool found = false;

        // Search through the contact array
        foreach (ContactCard contact in contacts)
        {
            if (string.Equals(
                contact.Name,
                searchName,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nContact found!");
                Console.WriteLine($"Name: {contact.Name}");
                Console.WriteLine($"Phone: {contact.PhoneNumber}");
                Console.WriteLine($"Email: {contact.Email}");

                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Contact not found.");
        }

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
    //Task.1.15
    static void CheckValue(object? value)
    {
        switch (value)
        {
            case int intValue:
                Console.WriteLine("Integer value: " + intValue);
                break;
            case string strValue:
                Console.WriteLine("String value: " + strValue);
                break;
            case null:
                Console.WriteLine("Value is null.");
                break;
            default:
                Console.WriteLine("Unknown type.");
                break;
        }
    }
    //  Grade Calculator Using Relational Patterns
    static string CalculateGrade(int score)
    {
        return score switch
        {
            < 0 or > 100 => "Invalid mark",
            >= 90 => "A",
            >= 75 => "B",
            >= 60 => "C",
            >= 35 => "D",
            _ => "F"    // _ is the discard pattern. Here, it handles any valid mark below 35.
        };
    }
    static void CalculateDiscount(Order order)
    {
        switch (order)
        {
            case { Status: "Completed", Amount: >= 1000 }:
                Console.WriteLine("Apply 10% discount.");
                break;
            case { Status: "Completed", Amount: >= 500 }:
                Console.WriteLine("Apply 5% discount.");
                break;
            case { Status: "Pending" }:
                Console.WriteLine("No discount for pending orders.");
                break;
            default:
                Console.WriteLine("No discount applicable.");
                break;
        }
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

//Property Patterns Using an Order Class

class Order
{
    public string Status { get; set; }
    public double Amount { get; set; }

    public Order(string status, double amount)
    {
        Status = status;
        Amount = amount;
    }
}

//Task 1.16:
class Student
{
    // const,readonly fields Student class: validated properties (age 5–100), parameterized + chained constructor (: this(...)), overloaded CalculateGrade(). Add const vs readonly fields and show which can't change where. 
    public const int MinimumAge = 5; // Constant field, cannot be changed after compilation
    public const int MaximumAge = 100;
    
    public readonly int StudentId; // Readonly field, can only be assigned in constructor

    private int age;

    public string Name { get; set; }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < MinimumAge || value > MaximumAge)
            {
                throw new ArgumentOutOfRangeException($"Age must be between {MinimumAge} and {MaximumAge}.");
            }
            age = value;
        }
    }

    //Parameterized constructor:
    public Student(string name, int age, int studentId)
    {
        Name = name;
        Age = age;
        StudentId = studentId;
    }

    //Constructor chaining:
    public Student(string name, int age) 
        : this(name, age, 1001)
    {
    }

    //Overloaded CalculateGrade methods
    public string CalculateGrade(int score)
    {
        if (score >= 90) return "A";
        if (score >= 75) return "B";
        if (score >= 60) return "C";
        if (score >= 35) return "D";
        return "F";
    }

    public string CalculateGrade(double score)
    {
        return CalculateGrade((int)score); // Call the int version
    }
}
