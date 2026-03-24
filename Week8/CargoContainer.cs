namespace Week8;

public class CargoContainer<T> where T: DeliveryItem
{
    private List<T> saveObject = new List<T>();

    public void AddItem(T value)
    {
        saveObject.Add(value);
    }

    public double GetTotalCost()
    {
        double sum = 0;
        foreach (var saveObj in saveObject)
        {
            sum += saveObj.CalculateCost();
        }

        return sum;
    }
    
}