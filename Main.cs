using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Employee Records with Objects");

    Employee unknown = new Employee();
    unknown.Intro();

    Employee john = new Employee("john", "smith", 1234, 45, "active");
    john.Intro();  
  }
}