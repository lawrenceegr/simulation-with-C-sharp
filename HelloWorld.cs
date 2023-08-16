using System;

class HelloCSharp
{
    static double GetRectangleArea(double height, double width)
    {
        double area = height * width;
        return area;
    }
    static void Main()
    {
        System.Console.WriteLine("***THIS PROGRAM WILL HELP IN CALCULATING AREA OF A TRIANGLE***");
        System.Console.Write("Enter the height: ");
        double height = double.Parse(System.Console.ReadLine());
        System.Console.Write("Enter the width: ");
        double width = double.Parse(System.Console.ReadLine());
        // double Area = GetRectangleArea(height, width);

        System.Console.WriteLine("Area = {0}", GetRectangleArea(height, width));
    }
}