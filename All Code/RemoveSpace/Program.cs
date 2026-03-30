// See https://aka.ms/new-console-template for more information
//string name  = " Hello, World! ";


//foreach (char item in name)
//{
//    if (item == ' ')
//    {
//        continue;
//    }
//    Console.Write(item);
//}



string input = "Hello World C Sharp";
string result = "";
int index = 0;

foreach (var item in input)
{
	if (item == ' ')
	{
		result += input.Substring(index);
		break;
	}

	result += char.ToUpper(item);
	index++;
}
Console.WriteLine(result);

