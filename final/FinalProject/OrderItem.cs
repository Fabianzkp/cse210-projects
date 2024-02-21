
// Class representing an item in an order
class OrderItem
{
    public InventoryItem Item { get; set; }
    public int Quantity { get; set; }
    public double Subtotal => Item.Price * Quantity;
}
