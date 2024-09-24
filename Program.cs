//Q1.

//using System;

//public class BankAccount
//{
//    private double balance;

//    public double Balance
//    {
//        get { return balance; }
//        set
//        {
//            if (value < 0)
//            {
//                throw new ArgumentException("Balance cannot be negative");
//            }
//            balance = value;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount();

//        try
//        {
//            account.Balance =-500; 
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }

//        Console.WriteLine("Account balance: " + account.Balance);
//    }
//}

//Q2.  


//public class Car
//{
//    public string Make { get; set; }
//    public string Model { get; set; }
//    public int Year { get; set; }

//    public string FullCarName
//    {
//        get { return Make + " " + Model + " " + Year; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Car myCar = new Car();
//        myCar.Make = "Toyota";
//        myCar.Model = "Camry";
//        myCar.Year = 2022;

//        Console.WriteLine("My car: " + myCar.FullCarName);
//    }



//Q3. 


//public class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }

//    public string FullNameInUpperCase
//    {
//        get { return (FirstName + " " + LastName).ToUpper(); }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person person = new Person();
//        person.FirstName = "John";
//        person.LastName = "Doe";

//        Console.WriteLine("Full Name in Uppercase: " + person.FullNameInUpperCase);
//    }
//}


//Q4.

//public class Temperature
//{
//    private double celsius;

//    public double Celsius
//    {
//        get { return celsius; }
//        set { celsius = value; }
//    }

//    public double Fahrenheit
//    {
//        get { return celsius * 9 / 5 + 32; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Temperature temp = new Temperature();
//        temp.Celsius = 20;

//        Console.WriteLine("Temperature in Celsius: " + temp.Celsius);
//        Console.WriteLine("Temperature in Fahrenheit: " + temp.Fahrenheit);
//    }
//}