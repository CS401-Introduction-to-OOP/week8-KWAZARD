namespace Week8;

public class Parcel : DeliveryItem
{
    public string Dimension { get; set; }
    public Parcel(string trackingNumber, double weight, string dimension) : base(trackingNumber, weight)
    {
        Dimension = dimension;
    }

    public override double CalculateCost()
    {
        return 50 + Weight * 25;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimension: {Dimension}");
    }
}