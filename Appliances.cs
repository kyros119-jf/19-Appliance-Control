public abstract class Appliance
{
    public abstract void TurnOn();
    public abstract void TurnOff();
}


public class WashingMachine : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Washing machine is now ON.");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Washing machine is now OFF.");
    }
}

public class Refrigerator : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Refrigerator is now ON.");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Refrigerator is now OFF.");
    }
}