using Msg = System.Console;

public class Program
{
    public static void Main()
    {
        Car car1 = new Car();
        Msg.Write(car1.getNumberOfWheels());
        Car car2 = new Car(3,false,"wood");
        Msg.Write(car2.getCarDetails());
    }
} // end class

public class Car
{
    private int numberOfWheels;
    private double length;
    private double width;
    private double height;
    private bool AC;
    private string interior;

    // constructor
    // 1) must be called the same name as the Class
    // 2) doesn't have a return (like void but doesn't have the attribute
    // 3) must be public
    public Car()
    {
        numberOfWheels = 4;
        length = 3.5;
        width = 2.3;
        height = 1.7;
        AC = true;
        interior = "plastic";

    } // end of Car's Constructor

    public Car(int numberOfWheels, bool AC, string interior)
    {
        this.numberOfWheels = numberOfWheels;
        this.AC = AC;
        this.interior = interior;

    } // end of Car's Constructor
    // getter for numberOfWheels
    public int getNumberOfWheels()
    {
        return this.numberOfWheels;
    }
    // pretty description
    public string getCarDetails()
    {
        return $"Car: number of wheels: {this.numberOfWheels}, AC: {this.AC}, Interior: {this.interior}";
    }
    
} // end of Class Car