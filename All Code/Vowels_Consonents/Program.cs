//using Microsoft.VisualBasic;

string name = "Nikhil";

//int vow = 0,con = 0;

//foreach (char ch in name.ToLower())
//{
//    if(!char.IsLetter(ch))
//        continue;

//    switch (ch)
//    {
//        case 'a':
//        case 'e':
//        case 'i':
//        case 'o':
//        case 'u':
//            vow++;
//            break;
//        default:
//            con++;
//            break;
//    }
//}
//Console.WriteLine("vowels are "+vow+ "And conso are "+con);

int vowels = name.Count(c => "aeiouAEIOU".Contains(c));
int consonants = name.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c));

Console.WriteLine(vowels);
Console.WriteLine(consonants);