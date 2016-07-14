using System;
using DataAccess.DataServices;
using Domain;

namespace ConsoleTest
{
    public class Test<T>
    {
        public T GenericProperty { get; set; }

        public Test(T value)
        {
            GenericProperty = value;
        }
    }

    public class Normal
    {
        public string ToString<T>(T value)
        {
            return value.ToString();
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            //int[] array = new int[3];
            //array[2] = 4;
            //array = new int[5];
            //var normal = new Normal();
            //string a = normal.ToString<int>(5);
            //var test = new Test<int>(2);
            //var test2 = new Test<string>("asd");
            //Func<int, int, int> func = (x, y) => x * y;
            //Action<string> func2 = x => Console.WriteLine(x.ToUpper());
            //Func<int> func3 = () => 5;
            //Console.WriteLine(func(5, 6));
            //func2("asdasd");
            //Console.WriteLine(func3());
            //ListExamples.Run();
            //DictionaryExamples.Run();
            //LinqExamples.Run();
            var studentDataService = new StudentDataService();
            foreach (var student in studentDataService.GetAll())
            {
                Console.WriteLine($"{student.FirstMidName} {student.SecondName} {student.LastName}");
            }
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
