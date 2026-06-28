
class Student1
{
    public string Name;
    public int Age;

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Rectangle
{
    public double Width;
    public double Height;

    public double Area() => Width * Height;
    public double Perimeter() => 2 * (Width + Height);
}

class Book
{
    public string Title;
    public string Author;
    public double Price;

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price:C}");
    }
}

class Employee
{
    public string Name;
    public double Salary;

    public Employee()
    {
        Name = "Unknown";
        Salary = 0;
    }

    public Employee(string name)
    {
        Name = name;
        Salary = 0;
    }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"Employee: {Name}, Salary: {Salary:C}");
    }
}

class Student5
{
    public string Name;
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0 && value <= 120)
                age = value;
            else
                Console.WriteLine("Tuổi không hợp lệ! Phải từ 0 đến 120.");
        }
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Student6
{
    public string Name;
    public static int Count = 0;

    public Student6(string name)
    {
        Name = name;
        Count++;
    }

    public static void ShowCount()
    {
        Console.WriteLine($"Tổng số sinh viên: {Count}");
    }
}

class BankAccount
{
    public string Owner;
    private double balance;

    public BankAccount(string owner, double initialBalance = 0)
    {
        Owner = owner;
        balance = initialBalance >= 0 ? initialBalance : 0;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Nạp {amount:C} thành công.");
        }
        else
            Console.WriteLine("Số tiền nạp phải lớn hơn 0.");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            Console.WriteLine("Số tiền rút phải lớn hơn 0.");
        else if (amount > balance)
            Console.WriteLine("Số dư không đủ! Không cho số dư âm.");
        else
        {
            balance -= amount;
            Console.WriteLine($"Rút {amount:C} thành công.");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Chủ tài khoản: {Owner}, Số dư: {balance:C}");
    }
}

class Car
{
    public string Brand;
    public int Year;

    public Car(string brand, int year)
    {
        this.Brand = brand;
        this.Year = year;
    }

    public void Display()
    {
        Console.WriteLine($"Brand: {this.Brand}, Year: {this.Year}");
    }
}

class Product
{
    public string Name;
    public double Price;
    public int Quantity;

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public double TotalValue() => Price * Quantity;

    public void Display()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price:C}, Qty: {Quantity}, Total: {TotalValue():C}");
    }
}

class Student10
{
    public string Name;
    public double Math;
    public double Physics;
    public double Chemistry;

    public Student10(string name, double math, double physics, double chemistry)
    {
        Name = name;
        Math = math;
        Physics = physics;
        Chemistry = chemistry;
    }

    public double Average() => (Math + Physics + Chemistry) / 3;

    public string Rank()
    {
        double avg = Average();
        if (avg >= 8) return "Giỏi";
        if (avg >= 6.5) return "Khá";
        if (avg >= 5) return "Trung bình";
        return "Yếu";
    }

    public void Display()
    {
        Console.WriteLine($"Tên: {Name}");
        Console.WriteLine($"  Toán: {Math}, Lý: {Physics}, Hóa: {Chemistry}");
        Console.WriteLine($"  Trung bình: {Average():F2} - Xếp loại: {Rank()}");
    }
}

class BankAccountPro
{
    private double balance;

    public double Balance
    {
        get { return balance; }
    }

    public BankAccountPro(double initialBalance = 0)
    {
        balance = initialBalance >= 0 ? initialBalance : 0;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Nạp {amount:C} thành công.");
        }
        else
            Console.WriteLine("Số tiền nạp phải lớn hơn 0.");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            Console.WriteLine("Số tiền rút phải lớn hơn 0.");
        else if (amount > balance)
            Console.WriteLine($"Không đủ số dư! Hiện có: {balance:C}. Không cho rút quá số dư.");
        else
        {
            balance -= amount;
            Console.WriteLine($"Rút {amount:C} thành công.");
        }
    }

    public void Display()
    {
        Console.WriteLine($"Số dư hiện tại: {Balance:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("===== BÀI 1: Student =====");
        Student1 s1 = new Student1 { Name = "An", Age = 20 };
        Student1 s2 = new Student1 { Name = "Bình", Age = 22 };
        s1.Display();
        s2.Display();

        Console.WriteLine("\n===== BÀI 2: Rectangle =====");
        Rectangle rect = new Rectangle { Width = 5, Height = 3 };
        Console.WriteLine($"Diện tích: {rect.Area()}, Chu vi: {rect.Perimeter()}");

        Console.WriteLine("\n===== BÀI 3: Book =====");
        Book book = new Book("Lập trình C#", "Nguyễn Văn A", 120000);
        book.Display();

        Console.WriteLine("\n===== BÀI 4: Employee (Overloading Constructor) =====");
        Employee e1 = new Employee();
        Employee e2 = new Employee("Lan");
        Employee e3 = new Employee("Minh", 15000000);
        e1.Display();
        e2.Display();
        e3.Display();

        Console.WriteLine("\n===== BÀI 5: Property =====");
        Student5 s5 = new Student5 { Name = "Hoa" };
        s5.Age = 19;
        s5.Display();
        s5.Age = 200; 

        Console.WriteLine("\n===== BÀI 6: Static =====");
        Student6 sv1 = new Student6("Nam");
        Student6 sv2 = new Student6("Linh");
        Student6 sv3 = new Student6("Hùng");
        Student6.ShowCount();

        Console.WriteLine("\n===== BÀI 7: Access Modifier =====");
        BankAccount acc = new BankAccount("Trần Văn B", 500000);
        acc.ShowBalance();
        acc.Deposit(200000);
        acc.Withdraw(100000);
        acc.Withdraw(700000); // sẽ bị từ chối
        acc.ShowBalance();

        Console.WriteLine("\n===== BÀI 8: this =====");
        Car car = new Car("Toyota", 2022);
        car.Display();

        Console.WriteLine("\n===== BÀI 9: Product =====");
        Product p = new Product("Laptop", 15000000, 3);
        p.Display();

        Console.WriteLine("\n===== BÀI 10: Tổng hợp Student =====");
        Student10 st1 = new Student10("An", 9, 8.5, 8);
        Student10 st2 = new Student10("Bình", 6, 7, 6.5);
        Student10 st3 = new Student10("Cường", 4, 5, 4.5);
        st1.Display();
        st2.Display();
        st3.Display();

        Console.WriteLine("\n===== BÀI THỬ THÁCH: BankAccount Pro =====");
        BankAccountPro proAcc = new BankAccountPro(1000000);
        proAcc.Display();
        proAcc.Deposit(500000);
        proAcc.Withdraw(200000);
        proAcc.Withdraw(2000000); // vượt số dư
        proAcc.Display();
    }
}
