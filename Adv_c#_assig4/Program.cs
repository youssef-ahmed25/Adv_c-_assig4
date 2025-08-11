using System.Collections;
using System.Collections.Generic;

namespace Adv_c__assig4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int[] arr = { 1, 2, 2, 3, 1, 4, 2 };
            //Hashtable frq = new Hashtable();

            //foreach (int num in arr)
            //{
            //    if (frq[num] != null)
            //    {
            //        frq[num] = (int)frq[num] + 1;
            //    }
            //    else
            //    {
            //        frq[num] = 1;
            //    }
            //}

            //foreach (DictionaryEntry entry in frq)
            //{
            //    Console.WriteLine($"num:{entry.Key},frq:{entry.Value}");
            //}
            #endregion
            #region Q2
            //Hashtable hash = new Hashtable
            //{
            //    ["youssef"] = 10,
            //    ["ahmed"] = 30,
            //    ["ali"] = 20,
            //    ["mohamed"] = 50
            //};
            //int max = 0;
            //string maxKey = string.Empty;
            //foreach (DictionaryEntry entry in hash)
            //{
            //    if ((int)entry.Value > max)
            //    {
            //        max = (int)entry.Value;
            //        maxKey = (string)entry.Key;
            //    }
            //}

            //Console.WriteLine($"max key is: {maxKey},{max}");
            #endregion
            #region Q3
            //Hashtable hash = new Hashtable
            //{
            //    ["youssef"] = 10,
            //    ["ahmed"] = 30,
            //    ["ali"] = 20,
            //    ["mohamed"] = 10
            //};

            //Console.Write("Enter value: ");
            //int.TryParse(Console.ReadLine(), out int x);
            //foreach (DictionaryEntry entry in hash)
            //{
            //    if ((int)entry.Value == x)
            //    {
            //    Console.WriteLine($"{entry.Key},{entry.Value}");
            //    }
            //}
            #endregion
            #region Q4
            //مش عارف اعملها 
            #endregion
            #region Q5
            //int[] nums = { 1, 2, 3, 4, 5, 5, 6, 6, 1, 1, 2 };
            ////int[] nums = { 1, 2, 3, 4, 5, 6 };
            //HashSet<int> table = new HashSet<int>();

            //bool dup = false;
            //foreach (int num in nums)
            //{
            //    if (table.Contains(num))
            //    {
            //        dup = true;
            //        break;
            //    }
            //    table.Add(num);
            //}

            //Console.WriteLine(dup ? "duplecate found" : "No duplecate");
            #endregion
            #region Q6
            //SortedDictionary<int, string> student = new SortedDictionary<int, string>
            //{
            //    [10] = "youssef",
            //    [20] = "ali",
            //    [40] = "ahmed",
            //    [50] = "omer"
            //};
            //student.Remove(50);
            //foreach (var stu in student)
            //{
            //    Console.WriteLine($"id: {stu.Key}, name:{stu.Value}");
            //}

            //Console.WriteLine("Student id 20: " + student[20]);
            //student.Add(60, "Ali");
            //foreach (var stu in student)
            //{
            //    Console.WriteLine($"id: {stu.Key}, name:{stu.Value}");
            //}
            #endregion
            #region Q7
            //SortedList<int, string> emp = new()
            //{
            //    [40] = "youssef",
            //    [10] = "Mona",
            //    [20] = "Ahmed",
            //    [50] = "Hossam",
            //    [30] = "Sara"

            //};
            //foreach (var e in emp)
            //{
            //    Console.WriteLine($"id:{e.Key},name:{e.Value}");
            //}
            #endregion
            #region Q8
            //int N = 10;
            //HashSet<int> chek = new HashSet<int>() { 1, 5, 3, 7, 4, 8 };
            //for (int i = 1; i <= N; i++)
            //{
            //    if (!chek.Contains(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Q9
            //List<int> list = new List<int> { 1, 1, 2, 2, 3, 4, 5, 6, 6 };

            //HashSet<int> uniqe = new HashSet<int>(list);
            //foreach (int i in uniqe)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q10
            //Hashtable first = new Hashtable()
            //{
            //    ["youssef"] = 10,
            //    ["ahmed"] = 30,
            //    ["ali"] = 20,
            //    ["mohamed"] = 50
            //};

            //Hashtable second = new Hashtable();

            //foreach (DictionaryEntry item in first)
            //{
            //    second[item.Value] = item.Key;
            //}

            //foreach (DictionaryEntry item in second)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //}
            #endregion
            #region Q11
            //HashSet<int> n1 = new HashSet<int> 
            //{1,2,3,4,5};
            //HashSet<int> n2 = new HashSet<int> 
            //{3,4,5,6,7,8};

            //n1.UnionWith(n2);
            //foreach (int num in n1)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
            #region Q12
            //outputحولت بس كان بطلع معايا غلط فى 
            #endregion
            #region Q13
            //SortedSet<int> numbers = new SortedSet<int> { 1, 3, 4, 6, 8, 9, 15, 20 };

            //Console.Write("enter number: ");
            //int x = int.Parse(Console.ReadLine());

            //List<int> check = new List<int>();

            //foreach (int i in numbers)
            //{
            //    if (i > x)
            //    {
            //        check.Add(i);
            //    }
            //}
            //foreach (int num in check)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
            #region Q14
            SortedList<string, int> emp = new()
            {
                ["youssef"] = 2,
                ["Mona"] = 1,
                ["Ahmed"] = 3,
                ["Hossam"] = 5,
                ["Sara"] = 4,
                ["Ali"] = 6

            };
            List<string> check = new List<string>();
            foreach (var entry in emp)
            {
                int x = (int)entry.Value;
                if (x % 2 == 0)
                {
                    check.Add(entry.Key);

                }
            }
            foreach (string name in check)
            {
                Console.WriteLine(name);
            }
            #endregion
        }
    }
}
