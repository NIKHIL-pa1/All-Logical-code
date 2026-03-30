using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_pattern
{
    public class Factory
    {
        public static INotification CreateNotification(string type)
        {
            if (type == "email")
                return new EmailNotification();
            else if (type == "Sms")
                return new SmsNotification();
            else
                throw new Exception("Invalid type");
        }
    }
}
