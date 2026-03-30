//using System;
//namespace LogicalProgram
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter the string : ");
//            string message = Console.ReadLine();

//            //Remove the empty spaces from the message
//            message = message.Replace(" ", string.Empty);

//            while (message.Length > 0)
//            {
//                Console.Write(message[0] + " : ");
//                int count = 0;
//                for (int j = 0; j < message.Length; j++)
//                {
//                    if (message[0] == message[j])
//                    {
//                        count++;
//                    }
//                }
//                Console.WriteLine(count);
//                message = message.Replace(message[0].ToString(), string.Empty);
//            }

//            Console.ReadKey();
//        }
//    }
//}


//string input = "nan";

//    int count = 0;
//for (int i = 0; i < input.Length; i++)
//{
//    char current = input[i];

//    // Check if character already printed before
//    bool printedBefore = false;
//    for (int p = 0; p < i; p++)
//    {
//        if (input[p] == input[i])
//        {
//            printedBefore = true;
//            break;
//        }
//    }

//    if (printedBefore)
//        continue;

//    // Count how many times this character appears
//    for (int j = i; j < input.Length; j++)
//    {
//        if (input[j] == input[i])
//            count++;
//    }

//    Console.WriteLine(input[i] + " → " + count);
//}



string name = string.Empty;

Console.WriteLine("Enter a name : " + name);
name = Console.ReadLine();


for (int i = 0; i < name.Length; i++)
{
    int count = 0;
    bool isPrinted = false;
    for (int j = 0; j < i; j++)
    {
        if (name[j] == name[i])
        {
            isPrinted = true;
            break;
        }

    }

    if (isPrinted)
    {
        continue;
    }

    for (int k = i; k < name.Length; k++)
    {
        if (name[k] == name[i])
        {
            count++;
        }
    }
    Console.WriteLine(name[i] + " -> " + count);
    //Console.ReadKey();
}