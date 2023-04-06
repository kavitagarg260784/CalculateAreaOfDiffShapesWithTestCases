namespace Utility
{
    public class AreaCalculation
    {
        public double area = 0;
        public virtual double  Area(double radius)
        {
            return area;
        }
        public virtual double Area(double length, double width)
        {
            return area;
        }


    }
   public class Rectangle : AreaCalculation
    {
        public override double Area(double length, double width) // overriding the method of area calculation
        {
            area = length * width;
            return area;
        }

    }
   public class Triangle : AreaCalculation
    {
        public override double Area(double height, double baseLength)  // overriding the method of area calculation
        {
            area = 0.5 * baseLength * height;
            return area;
        }
    }
   public class Circle : AreaCalculation
    {
        public override double Area(double radius)  // overriding the method of area calculation
        {
            double PI = 3.14159;
            area = PI * radius * radius;
            area = Math.Round(area);
            return area;
        }
    }

}