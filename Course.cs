using System;
   class Course
{
    protected  void ShowDetails()
    {
        Console.WriteLine("course name:BCA");
        Console.WriteLine("course duration:3 years");
        Console.WriteLine("course fees:Rs. 148000");
    }
}
class Program : Course
{
    static void Main()
    {
        Program p = new Program();
        p.ShowDetails();
        Console.WriteLine("course mode:Online");
    }

}
