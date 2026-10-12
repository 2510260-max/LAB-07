using System;
class Program
{
    static void Main(string[] args)
    {
        Microwave myMicrowave = new Microwave();
        myMicrowave.PowerOn();

        Console.ReadLine();
    }
}
public class Device
{
    public virtual void PowerOn()
    {
        Console.WriteLine("Device is powering on...");
    }
}
public class KitchenAppliance : Device
{
    public override void PowerOn()
    {
        base.PowerOn();
        Console.WriteLine("Kitchen Appliance: Safety checks completed.");
    }
}
public class Microwave : KitchenAppliance
{
    public override void PowerOn()
    {
        base.PowerOn();
        Console.WriteLine("Microwave: Heating elements initialized.");
    }
}