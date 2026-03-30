using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_pattern
{
    public class EmailNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Email send");
        }
    }

    public class SmsNotification : INotification
    {
        public void Send() => Console.WriteLine("SMS send");
    }
}
