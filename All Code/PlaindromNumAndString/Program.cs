
//int num = 1213;
//int rev = 0;
//int temp = num;

//while(num > 0)
//{
//    int rem = num % 10;
//    rev = rev * 10 + rem;
//    num =  num / 10;
    
//}
//temp = rev;
//if(rev == num)
//    Console.WriteLine("given no is palindrome");
//else
//    Console.WriteLine("given no is not palindrome");


string name = "madam";
string rev = string.Empty;

string temp = name;

for (int i = name.Length - 1; i >= 0 ; i--)
{
    rev = rev + name[i];
}

temp = rev;
if (rev == name)
    Console.WriteLine("given string is palindrome");
else
    Console.WriteLine("given string is not palindrome");




