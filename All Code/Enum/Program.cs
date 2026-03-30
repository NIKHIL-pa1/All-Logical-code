enum Order
{
    Pending,
    Proccess,
    Shipped,
    Delivered
}


class RecorStatus
{
    public Order Status { get; set; }
}

class Program
{
    static void Main()
    {
        RecorStatus recStatus = new RecorStatus();
        recStatus.Status = Order.Shipped;

        Console.WriteLine(recStatus.Status);
        Console.WriteLine((int)recStatus.Status);
    }

}