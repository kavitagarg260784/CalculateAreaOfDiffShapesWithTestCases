// See https://aka.ms/new-console-template for more information

using Utility;
Console.WriteLine("Hello, World!");


Console.WriteLine("enter the shapde name");// for example circle or rectangle or triangle

double length = 0;
double baseLength = 0;
double radius = 0;
double width = 0;
double height = 0;
double area = 0;
String ShapeName = Console.ReadLine();


if (ShapeName == "circle") // area calculation method for circle
{
    Circle C = new Circle();
    Console.WriteLine("enter radius");

    radius = double.Parse(Console.ReadLine());

    area = C.Area(radius);   // calling overriding method for circle
    Console.WriteLine("area is" + area);
}

else if (ShapeName == "rectangle") // area calculation method for circle
{
    Rectangle R = new Rectangle();

    Console.WriteLine("enter length ");
    length = double.Parse(Console.ReadLine());

    Console.WriteLine("enter width ");
    width = double.Parse(Console.ReadLine());


    area = R.Area(length, width);  // calling overriding method for rectangle
    Console.WriteLine("area is" + area);
}
 else if (ShapeName == "triangle")
{
    Triangle T = new Triangle();
    Console.WriteLine("enter height");

    height = double.Parse(Console.ReadLine());

    Console.WriteLine("base length");
    baseLength = double.Parse(Console.ReadLine());
   area =  T.Area(height, baseLength);    // calling overriding method for triangle
    Console.WriteLine("area is" + area);

}
else
{
    Console.WriteLine("please enter correct shape name");
}