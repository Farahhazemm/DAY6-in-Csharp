/*
 // 1:


 using System;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point(3, 4);
        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
}

 */
//Question: Why can't a struct inherit from another struct or class in C#?

//Structs in C# are value types and do not support inheritance to maintain simplicity, stack allocation efficiency, and avoid overhead from reference type features like polymorphism. All structs implicitly inherit from System.ValueType.


/*
 
 // 2 :

 public class TypeA
{
    private int F;
    internal int G;
    public int H;
}

class Program
{
    static void Main()
    {
        TypeA obj = new TypeA();
        // obj.F = 5;  // Compilation Error (private)
        obj.G = 10;    // Valid (same assembly)
        obj.H = 15;    // Valid (public)
    }
}

 //Question: How do access modifiers impact the scope and visibility of a class member?

 //Access modifiers (private, internal, public, etc.) restrict member accessibility to specific contexts (e.g., class, assembly, or globally), preventing unintended interactions and enforcing encapsulation.
*/


/*
 
 //3 :

 public struct Employee
{
    private int EmpId;
    private string Name;
    private decimal Salary;

    public string GetName() => Name;
    public void SetName(string name) => Name = name;
    public int EmployeeId { get => EmpId; set => EmpId = value; }
    public decimal SalaryProperty { get => Salary; set => Salary = value; }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.SetName("John Doe");
        emp.EmployeeId = 101;
        emp.SalaryProperty = 50000m;
        Console.WriteLine($"ID: {emp.EmployeeId}, Name: {emp.GetName()}, Salary: {emp.SalaryProperty}");
    }
}

 //Question: Why is encapsulation critical in software design?

 //Encapsulation protects object state by controlling access, ensuring data integrity, reducing bugs, and allowing flexible implementation changes without affecting dependent code.

 */


/*
 
 // 4 : 

 public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x)
    {
        X = x;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(5);
        Point p2 = new Point(3, 7);
        Console.WriteLine($"p1: ({p1.X}, {p1.Y})");
        Console.WriteLine($"p2: ({p2.X}, {p2.Y})");
    }
}

 //Question: What is constructors in structs?

 //Constructors in structs initialize fields. Unlike classes, structs can't have explicit parameterless constructors (prior to C# 10), and all fields must be assigned in parameterized constructors.

*/


/*
 
 // 5 :
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"Point(X: {X}, Y: {Y})";
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point { X = 2, Y = 3 };
        Point p2 = new Point { X = -1, Y = 5 };
        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
}

 //Question: How does overriding ToString() improve readability?

 //It converts an object’s state into a human-readable string, simplifying debugging, logging, and output formatting.

 */


/*
 
 // 6 :

 public struct Point { public int X; public int Y; }
public class Employee { public string Name; }

class Program
{
    static void ModifyPoint(Point p) { p.X = 99; }
    static void ModifyEmployee(Employee e) { e.Name = "Modified"; }

    static void Main()
    {
        Point point = new Point { X = 1, Y = 1 };
        Employee emp = new Employee { Name = "Original" };

        ModifyPoint(point);
        ModifyEmployee(emp);

        Console.WriteLine($"Point: ({point.X}, {point.Y})");
        Console.WriteLine($"Employee: {emp.Name}");
    }
}

 //Question: How does memory allocation differ for structs and classes?

 //Structs are allocated on the stack (or inline in containing types), enabling fast access and deallocation. Classes are heap-allocated, requiring garbage collection and introducing overhead.

 */



