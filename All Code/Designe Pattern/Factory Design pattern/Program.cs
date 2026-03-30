using Factory_Design_pattern;

class Program
{
    static void Main(string[] args)
    {
        INotification obj = Factory.CreateNotification(("Email").ToLower());

        obj.Send();
    }
}
