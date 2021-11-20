/*1.Напишите набор простейших классов для создания личных исключений, 
 * возникающих при работе с объектом типа Student (Worker, Pencil, Animal, Cat …, см. л.р. №17, №18).
 * 3.Напишите главную программу, демонстрирующую обработку ошибок блоками try-catch. 
 * Объект создайте в свободной памяти. Проверьте выделения памяти новым способом, используя исключение bad_alloc.*/

using System;

namespace lab21
{
    class Program
    {
        static void Main(string[] args) 
        {
            /* Person p1 = new Person();
            p1.Name = "John";
            Person p2 = null;

            Console.WriteLine("p1 = p2: {0}", p1.Equals(p2));*/
            //Personcs person = new Personcs();
            MyClient.Client();
            Console.ReadLine();

        }
    }
}