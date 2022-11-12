using System;
using System.Collections;
using System.Collections.Generic;
using Collections_HW.Models;

namespace Collections_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task_1
            List<Author> authors = new List<Author>();

            authors.Add(new Author { Name = "Jalil", Surname = "Mammedguluzadeh", Age = 30 });
            authors.Add(new Author { Name = "Ismail", Surname = "Shikhly", Age = 41 });
            authors.Add(new Author { Name = "Afaq", Surname = "Masud ", Age = 36 });
            authors.Add(new Author { Name = "Chingiz", Surname = "Abdullayev", Age = 67 });
            authors.Add(new Author { Name = "Gurban", Surname = "Said", Age = 50 });

            foreach (var author in authors)
            {
                if(author.Age > 40)
                {
                    Console.WriteLine(author.Name + " " + author.Surname);
                }
            }

            #endregion

            #region Task2_List
            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(23);
            //numbers.Add(190);
            //numbers.Add(60);
            //numbers.Add(120);
            //numbers.Add(90);

            //Console.WriteLine(numbers.Count);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //var res1 = numbers.Find(n => n > 100);
            //Console.WriteLine(res1);

            //var res2 = numbers.FindAll(n => n > 100);
            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //}

            //var res3 = numbers.FindIndex(n => n > 100);
            //Console.WriteLine(res3);

            //var res4 = numbers.FindLastIndex(n => n > 100);
            //Console.WriteLine(res4);

            //numbers.Sort();
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //List<string> names = new List<string>() { "Murad", "Resul", "Anar", "Nicat", "Nicath" };

            //var res5 = names.FindAll(x => x == "Nicat");
            //foreach (var item in res5)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> nums = new List<int>() { 10, 20, 30, 40, 50 };

            //numbers.AddRange(nums);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //var res = Search(names, "Nicat");
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Person> people = new List<Person>();

            //people.Add(new Person { FullName = "Qoshqar Nerimanli", Birthday = DateTime.Now.AddDays(-10), Salary = 1500 });
            //people.Add(new Person { FullName = "Ramil Allahverdiyev", Birthday = DateTime.Now.AddDays(10), Salary = 1700 });
            //people.Add(new Person { FullName = "Nihad Veliyev", Birthday = DateTime.Now.AddDays(12), Salary = 1800 });
            //people.Add(new Person { FullName = "Gultac Ceferova", Birthday = DateTime.Now.AddDays(-10), Salary = 2500 });

            //var result = people.FindAll(s => s.Salary > 1600 && s.FullName.StartsWith("R"));

            //foreach (var person in result)
            //{
            //    Console.WriteLine("FullName : {0}, Birthday : {1}, Salary : {2}", person.FullName, person.Birthday, person.Salary);
            //}

            #endregion

            #region Task2_hashtable
            //Hashtable hashtable = new Hashtable();

            //hashtable.Add(1, "Resul");
            //hashtable.Add(2, "Nicat");
            //hashtable.Add(3, "Vuqar");

            //foreach (var item1 in hashtable.Keys)
            //{
            //    Console.WriteLine(item1);
            //}

            //foreach (var item2 in hashtable.Values)
            //{
            //    Console.WriteLine(item2);
            //}

            //foreach (DictionaryEntry item3 in hashtable)
            //{
            //    Console.WriteLine(item3.Key + " " + item3.Value);
            //}
            #endregion

            #region Task2_SortedList
            //SortedList sortedList = new SortedList();

            //sortedList.Add(1, "Resul");
            //sortedList.Add(2, "Nicat");
            //sortedList.Add(3, "Vuqar");

            //foreach (var item1 in sortedList.Keys)
            //{
            //    Console.WriteLine(item1);
            //}

            //foreach (var item2 in sortedList.Values)
            //{
            //    Console.WriteLine(item2);
            //}

            //foreach (DictionaryEntry item3 in sortedList)
            //{
            //    Console.WriteLine(item3.Key + " " + item3.Value);
            //}



            //SortedList<string, string> list = new SortedList<string, string>();

            //list.Add("Admin", "Qoshqar");
            //list.Add("SuperAdmin", "Nihad");
            //list.Add("Member", "Resul");

            //foreach (KeyValuePair<string, string> item in list)
            //{
            //    if(item.Key == "Admin")
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}
            #endregion

            #region Task2_Arraylist
            //ArrayList arrayList = new ArrayList();

            //arrayList.Add("hello World");
            //arrayList.Add(234);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Task2_Dictionary_Queue_Stack

            //Dictionary<string, string> dictionaryList = new Dictionary<string, string>();
            //dictionaryList.Add("Admin", "Ramil");
            //Console.WriteLine(dictionaryList["Admin"]);

            //Queue<int> ints = new Queue<int>(); //FOF FIRST IN FIRST

            //ints.Enqueue(5);
            //ints.Enqueue(10);
            //ints.Enqueue(3);

            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> ints1 = new Stack<int>(); // LLO LAST IN LAST OUT

            //ints1.Push(11);
            //ints1.Push(22);
            //ints1.Push(3);

            //foreach (var item in ints1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }

        //private static List<string> Search(List<string> datas, string str)
        //{
        //    var result = datas.FindAll(n => n == "Nicat");
        //    return result;
        //}

        //private static List<string> Search(List<string> datas, string str) => datas.FindAll(n => n.ToLower().Contains(str.ToLower()));
    }
}

