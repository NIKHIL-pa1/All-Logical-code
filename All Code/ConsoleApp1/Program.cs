public class TestExtentionMethod
{
    static void Main(string[] args)
    {

        //Duplicate();
        //RemDupliWithString();
        //FindOccurence();
        //SortArray();
        //FindOccurenceWithoutInbuild();
        //FirstNonRepeChar();
        //Palindrome();
        //RemoveDuplicateChar();
        //AnagramString();
        ///StringComparisons();
        //FindLongestSubstring();
        //DuplicateCount();
        //findPairOutput();
        //FindMaxConce();(
        FindDuplicates();


    }
    static void Duplicate()
    {
        int[] Arr = { 12, 34, 45, 56, 12, 45 };

        HashSet<int> set = new HashSet<int>();
        HashSet<int> set1 = new HashSet<int>();

        for (int i = 0; i < Arr.Length; i++)
        {
            if (!set.Contains(Arr[i]))
            {
                set.Add(Arr[i]);
            }
        }

        Console.WriteLine(string.Join(",", set));
        Console.WriteLine("----------");

        for (int i = 0; i < Arr.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < i; j++)
            {
                if (Arr[i] == Arr[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                set1.Add(Arr[i]);
            }

        }
        Console.WriteLine(string.Join(",", set1));
    }

    static void RemDupliWithString()
    {
        char[] Arr = { 'N', 'I', 'k', 'H', 'i', 'L' };

        string convert = new string(Arr).ToLower();

        char[] arr2 = convert.ToCharArray();
        List<char> set = new List<char>();

        //Console.WriteLine(string.Join(",",arr2));

        for (int i = 0; i < arr2.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < i; j++)
            {
                if (arr2[i] == arr2[j])
                {
                    isDuplicate = true;
                    break;
                }

            }
            if (!isDuplicate)
            {
                set.Add(arr2[i]);
            }
        }
        Console.WriteLine(string.Join(",", set));
    }

    static void FindOccurence()
    {
        Console.WriteLine("Enter name");
        string name = Console.ReadLine();

        Dictionary<char, int> dict = new Dictionary<char, int>();


        foreach (var item in name)
        {
            if (dict.ContainsKey(item))
                dict[item]++;
            else
                dict[item] = 1;
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key}" + "-->" + $"{item.Value}");
        }
    }

    static void SortArray()
    {
        int[] Arr = { 12, 34, 45, 56, 12, 45 };
        // List<int> list = new List<int>();
        for (int i = 0; i < Arr.Length; i++)
        {
            for (int j = i + 1; j < Arr.Length; j++)
            {
                if (Arr[i] > Arr[j])
                {
                    int tem = Arr[i];
                    Arr[i] = Arr[j];
                    Arr[j] = tem;
                }
            }
        }
        Console.WriteLine(string.Join(",", Arr));
    }

    static void FindOccurenceWithoutInbuild()
    {
        string name = "Nikhil";

        for (int i = 0; i < name.Length; i++)
        {
            int count = 1;
            bool isExist = false;

            for (int j = 0; j < i; j++)
            {
                if (name[i] == name[j])
                {
                    isExist = true;
                    break;
                }
            }

            if (isExist)
                continue;

            for (int k = i + 1; k < name.Length; k++)
            {
                if (name[i] == name[k])
                    count++;
            }
            Console.WriteLine(name[i] + " is " + count);

            //string name = "Nikhil";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    int count = 1;
            //    bool isCountexist = false;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (name[i] == name[j])
            //        {
            //            isCountexist = true;
            //            break;
            //        }
            //    }


            //    if (isCountexist)
            //        continue;

            //    for (int k = i + 1; k < name.Length; k++)
            //    {
            //        if (name[i] == name[k])
            //            count++;
            //    }
            //    Console.WriteLine(name[i] + "-" + count);
            //}
            //string name = "Programming";

            //for(int i = 0; i < name.Length; i++)
            //{
            //    int count = 1;
            //    bool alreadyCount = false;

            //  check if already counted
            //    for(int j = 0; j < i; j++)
            //    {
            //        if (name[i] == name[j])
            //        {
            //            alreadyCount = true;
            //            break;
            //        }
            //    }
            //    if (alreadyCount)
            //        continue;

            //    count occurrences
            //    for(int k = i+1; k<name.Length;k++)
            //    {
            //        if (name[i] == name[k])
            //            count++;
            //    }

            //    Console.WriteLine(name[i]+"-"+count);
            //}
        }

        static void FirstNonRepeChar()
        {
            string name = "racecar";

            for (int i = 0; i < name.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[i] == name[j] && i != j)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    Console.WriteLine("first non repe char is " + name[i]);
                return;
            }
        }
    }

    static void Palindrome()
    {
        string name = "Madam";
        string convert = name.ToLower();

        string empty = "";
        for (int i = convert.Length - 1; i >= 0; i--)
        {
            empty += convert[i];
        }

        if (convert == empty)
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }

    static void RemoveDuplicateChar()
    {
        //string name = "banana";
        //List<char> list = new List<char>();
        //for (int i = 0; i < name.Length; i++)
        //{
        //    bool found = false;
        //    for (int j = 0; j < name.Length; j++)
        //    {
        //        if (!list.Contains(name[i]))
        //            list.Add(name[i]);
        //    }
        //}
        //Console.WriteLine(string.Join(",",list));

        string name = "banana";

        char[] ch = { 'b', 'A', 'n', 'a', 'n', 'a' };

        string convert = new string(ch).ToLower();
        // list
        List<char> list = convert.ToList();
        for (int i = 0; i < name.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < i; j++)
            {
                if (name[i] == name[j])
                {
                    found = true;
                    break;
                }

            }
            if (!found)
                list.Add(name[i]);
        }
        Console.WriteLine(string.Join(",", list));

        HashSet<char> set = new HashSet<char>();
        foreach (var item in name)
        {
            if (!set.Contains(item))
            {
                set.Add(item);
            }
        }

        Console.WriteLine(string.Join(",", set));
    }

    static void AnagramString()
    {

        string name1 = "Liste";
        string name2 = "silent";

        #region code with string and char array
        //string convertname1 = new string(name1).ToLower();
        //char[] ch = convertname1.ToCharArray();

        //string convertname2 = new string(name2).ToLower();
        //char[] ch2 = convertname2.ToCharArray();

        //for (int i = 0; i < ch.Length; i++)
        //{
        //    for (int j = i + 1; j < ch.Length; j++)
        //    {
        //        if (ch[i] > ch[j])
        //        {
        //            var temp = ch[i];
        //            ch[i] = ch[j];
        //            ch[j] = temp;
        //        }
        //    }
        //    Console.WriteLine(string.Join(",", ch[i]));

        //}
        //Console.WriteLine("--------------");

        //for (int i = 0; i < ch2.Length; i++)
        //{
        //    for (int j = i + 1; j < ch2.Length; j++)
        //    {
        //        if (ch2[i] > ch2[j])
        //        {
        //            var temp = ch2[i];
        //            ch2[i] = ch2[j];
        //            ch2[j] = temp;
        //        }
        //    }
        //    Console.WriteLine(string.Join(",", ch[i]));

        //}

        //string n1 = new string(ch);
        //string n2 = new string(ch2);

        //Console.WriteLine("--------------------");

        //if (n1 == n2)
        //    Console.WriteLine("Anagram string");
        //else
        //    Console.WriteLine("not anagram string");
        #endregion

        #region code with list collection

        List<char> ch1 = name1.ToLower().ToList();
        List<char> ch2 = name2.ToLower().ToList();

        for (int i = 0; i < ch1.Count; i++)
        {
            for (int j = i + 1; j < ch1.Count; j++)
            {
                if (ch1[i] > ch1[j])
                {
                    var temp = ch1[i];
                    ch1[i] = ch1[j];
                    ch1[j] = temp;
                }
            }
        }
        // Console.WriteLine(string.Join(",",ch1));

        for (int i = 0; i < ch2.Count; i++)
        {
            for (int j = i + 1; j < ch2.Count; j++)
            {
                if (ch2[i] > ch2[j])
                {
                    var temp = ch2[i];
                    ch2[i] = ch2[j];
                    ch2[j] = temp;
                }
            }
        }

        if (new string(ch1.ToArray()) == new string(ch2.ToArray()))
            Console.WriteLine("anagram string");
        else
            Console.WriteLine("not anagram");
        #endregion

    }

    static void StringComparisons()
    {
        string name = "Nikhil";
        List<char> list = new List<char>();
        for (int i = 0; i < name.Length; i++)
        {
            int count = 0;
            bool found = false;
            for (int j = 0; j < i; j++)
            {
                if (name[i] == name[j])
                {
                    found = true;
                    break;
                }
            }

            if (found)
                continue;

            for (int k = 0; k < name.Length; k++)
            {
                if (name[i] == name[k])
                {
                    //Console.Write(name[i]);
                    count++;

                }
            }
            Console.Write(name[i] + "" + count);

        }

    }

    static void FindLongestSubstring()
    {
        string s = "abcabcbbdef";
        //int maxLength = 0;
        int maxLen = 0;
        string longeststr = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            string currentStr = string.Empty;
            for (int j = i; j < s.Length; j++)
            {
                bool found = false;
                for (int k = i; k < j; k++)
                {
                    if (s[k] == s[j])
                    {
                        found = true;
                        break;
                    }    
                }

                if (found)
                    break;

                currentStr += s[j];

                //maxLen = currentStr.Length;

                if(currentStr.Length > maxLen)
                {
                    maxLen = currentStr.Length;
                    
                    longeststr = currentStr;
                }

            }
        }

        Console.WriteLine("Longest substring is "+longeststr + " and Longest Length: " + maxLen);


        //for (int i = 0; i < s.Length; i++)
        //{
        //    string current = "";

        //    for (int j = i; j < s.Length; j++)
        //    {
        //        bool isDuplicate = false;

        //        // check duplicate manually
        //        for (int k = 0; k < current.Length; k++)
        //        {
        //            if (current[k] == s[j])
        //            {
        //                isDuplicate = true;
        //                break;
        //            }
        //        }

        //        if (isDuplicate)
        //            break;

        //        current += s[j];

        //        if (current.Length > maxLength)
        //        {
        //            maxLength = current.Length;
        //        }
        //    }
        //}

        // Console.WriteLine("Longest Length: " + maxLength);
    }

    static void DuplicateCount()
    {
        int[] arr = { 10, 20, 30, 10, 20, 30, 30, 40 };

        for (int i = 0; i < arr.Length; i++)
        {
            int count = 1;
            bool isExist = false;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] == arr[j] && i != j)
                {
                    isExist = true;
                    break;
                }
            }

            if (isExist)
                continue;


            for (int k = i + 1; k < arr.Length; k++)
            {
                if (arr[k] == arr[i])
                {
                    count++;
                }
            }

            Console.WriteLine(string.Join(",", arr[i] +" is "+ count));
        }



    }

    static void findPairOutput()
    {
        int[] arr= { 1, 2, 3, 4, 5, 6 };

        int n = 3;

        //int[] NewArr = new int[arr.Length];
        int[] ans = new int[arr.Length];
       // int k = 0;

        //int position = 0;

        int pos = 0;
        for (int i = 0; i < n; i++)
        {
            ans[pos] = arr[i];
            ans[pos + 1] = arr[n + i];
            pos = pos + 2;
        }

        //for (int i = 0; i < arr.Length; i = i+ 2)
        //{
        //    NewArr[i] = arr[k++];

        //}

        //for (int i = 1; i < arr.Length; i += 2)
        //{
        //    NewArr[i] = arr[k++];
        //}

        Console.WriteLine(string.Join(",", ans));
    }

    static void FindMaxConce()
    {
        int[] arr = { 1, 1, 0, 1, 1, 1 };

        int maxCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int count = 0;
            for (int j = i; j < arr.Length; j++)
            {
                bool found = false;
                for (int k = i; k < j; k++)
                {
                    if (arr[j] == arr[k])
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                    break;

                count += arr[j];

                if (count > maxCount)
                    maxCount = count;


            }
        }

        Console.WriteLine("max Count is " + maxCount);
    }

    static void FindDuplicates()
    {
        string name = "Programam";
        //optimize solution
        HashSet<char> seen = new HashSet<char>();
        HashSet<char> duplicate = new HashSet<char>();

        foreach (var item in name)
        {
            if (!seen.Add(item))
                duplicate.Add(item);
        }

        foreach (var item in duplicate)
        {
            Console.WriteLine(item);
        }

        //for (int i = 0; i < name.Length; i++)
        //{
        //    int count = 1;
        //    bool isExist = false;
        //    for (int k = 0; k < i; k++)
        //    {
        //        if (name[i] == name[k])
        //        {
        //            isExist = true;
        //            break;
                    
        //        }
        //    }

        //    if (isExist)
        //        continue;

        //    for (int j = i + 1; j < name.Length; j++)
        //    {
        //        if (name[j] == name[i])
        //        {
        //            count++; 
        //        }
        //    }

        //    if(count > 1)
        //        Console.WriteLine(name[i]);

        //}
    }
}