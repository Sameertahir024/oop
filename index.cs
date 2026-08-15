public class Car
{
    public string Model { get; set; }

    public Car(string model)
    {
        Model = model;
    }

    public void Tell()
    {
        Console.WriteLine($"{Model} has started.");
    }
}

Car myCar = new Car("Red");
myCar.Tell();
