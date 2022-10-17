using Msg = System.Console;

public class Program
{
    public static void Main()
    {
        Circle myCircle = new Circle(); // instantiation
        Msg.WriteLine(myCircle.CalculateArea(6));

        Circle myCircle2 = new Circle(); // instantiation
        Msg.WriteLine(myCircle2.CalculateArea(8));
        Msg.WriteLine(myCircle2.CalculateLongitude(8));
    }
} // end class

public class Circle
{
    private double pi = Math.PI; // property of class circle

    public Double CalculateArea (double radius) // class method or function
    {
        return this.pi * Math.Pow(radius, 2);
    }

    public Double CalculateLongitude(double radius) // class method or function
    {
        return 2 * this.pi * radius;
    }
}