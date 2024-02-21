// DigitalProduct.cs
// Concrete class representing a digital product
class DigitalProduct : InventoryItem
{
    public override double CalculateTotalValue()
    {
        return Price;
    }
}
