using System;

namespace mynamespase
{
    class Program
    {
        static void Main(string[] args)
        {

            int myage = 24;
            int data = 10;
            var arr = new int[] {3, 6, 8};
            Console.WriteLine("Мой возраст: " + myage);

            ChangeAge(ref myage);       //Добавлено служебное слово ref

            Console.WriteLine("Мой измененный возраст: " + myage);

            BigDataOperation(arr, ref data);
            Console.WriteLine(arr[0]);
            Console.WriteLine(data);

        }

        static void ChangeAge(ref int age)      //Добавлено служебное слово ref(можно изменять данные)
        {
            Console.Write("Введите свой возраст: ");

            age = Convert.ToInt32(Console.ReadLine());
        }
        static void BigDataOperation(in int[] arr, ref int data)
        {
            data = 6;
            arr[0] = 5;
        }
    }
}