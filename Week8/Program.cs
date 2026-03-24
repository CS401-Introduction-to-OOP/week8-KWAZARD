namespace Week8;



public class Program()
{
    static void Main()
    {
        DeliveryItem letter1 = new Letter("1", 1);
        DeliveryItem letter2 = new Letter("2", 1);
        
        DeliveryItem parcel1 = new Parcel("3", 1, "12x30x40");
        DeliveryItem parcel2 = new Parcel("4", 1, "12x30x40");
        
        letter1.PrintInfo();
        Console.WriteLine("================");
        parcel2.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);

        Console.WriteLine($"Total cost: {myCargo.GetTotalCost()}");
        ;
    }
}