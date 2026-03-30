using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

class Customer
{
    public string Name = "Nikhil";
    public string Email = "nikhilpatil6519@gmail.com";
    public DateTime ExpiryDate = new DateTime(2025, 11, 3);
}

class Program
{
    static void Main()
    {
        List<Customer> customers = GetCustomers(); // Load from DB or file

        foreach (var customer in customers)
        {
            int daysLeft = (customer.ExpiryDate - DateTime.Today).Days;

            if (daysLeft == 30 || daysLeft == 15 || daysLeft == 7 || daysLeft == 1)
            {
                SendReminderEmail(customer, daysLeft);
            }
        }
    }

    static void SendReminderEmail(Customer customer, int daysLeft)
    {
        string subject = $"Your license key expires in {daysLeft} day(s)";
        string body = $"Hi {customer.Name},\n\nYour license key will expire in {daysLeft} day(s). Please renew soon.";

        MailMessage mail = new MailMessage("your@email.com", customer.Email, subject, body);
        SmtpClient client = new SmtpClient("smtp.yourserver.com")
        {
            Port = 587, // or 465 for SSL
            EnableSsl = true,
            Credentials = new NetworkCredential("your@email.com", "yourpassword")
        };


        client.Send(mail);
        Console.WriteLine($"Reminder sent to {customer.Email}");
    }

    static List<Customer> GetCustomers()
    {
        // Replace with actual DB/file logic
        return new List<Customer>
        {
            new Customer { Name = "Amit", Email = "amit@example.com", ExpiryDate = DateTime.Today.AddDays(30) },
            new Customer { Name = "Neha", Email = "neha@example.com", ExpiryDate = DateTime.Today.AddDays(15) }
        };
    }
}
