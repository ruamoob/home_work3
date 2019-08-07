using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paranoik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя задачи:");
            String userInput = Console.ReadLine();
            String name_task = parseNameTask(userInput);

            Console.WriteLine("Введите оценку в часах:");
            userInput = Console.ReadLine();
            short hour = parseHourTask(userInput);

            Console.WriteLine("Введите дату начала:");
            userInput = Console.ReadLine();
            DateTime begin_task = parseBeginTask(userInput);

            Console.WriteLine("Введите дату окончания:");
            userInput = Console.ReadLine();
            DateTime end_task = parseEndTask(userInput);

            Console.WriteLine("Введите комментарий к задаче:");
            userInput = Console.ReadLine();
            String comment = parseCommentTask(userInput);

            Console.WriteLine("\n Вы ввели данные: \n Задача: " + name_task +
             "\n Дата начала: " + begin_task +
             "\n Дата окончания: " + end_task +
             "\n Кол-во часов: " + hour +
             "\n Комментарий: " + comment);
            Console.ReadKey();
        }

        private static short parseHourTask(string userInput)
        {
            short parseHourTaskLocal;
            try
            {
                parseHourTaskLocal = Int16.Parse(userInput);
            }
            catch (ArgumentNullException Ex)
            {
                Console.WriteLine(Ex.Message);
                userInput = Console.ReadLine();
                return parseHourTask(userInput);
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine(formatEx.Message);
                userInput = Console.ReadLine();
                return parseHourTask(userInput);
            }
            return parseHourTaskLocal;
        }

        private static string parseNameTask(string userInput)
        {
            String NameTaskLocal;
            NameTaskLocal = userInput;//При вводе пустой строки ругается                       
            if (NameTaskLocal == "")
            {
                Console.WriteLine("Вы не ввели имя задачи! Введите значение");
                userInput = Console.ReadLine();
                return parseNameTask(userInput);
            }
            return NameTaskLocal;
        }

        private static string parseCommentTask(string userInput)
        {
            String NameCommentLocal = userInput;
            if (NameCommentLocal == "")
            {
                Console.WriteLine("Вы не ввели комментарий к задаче! Введите значение");
                userInput = Console.ReadLine();
                return parseCommentTask(userInput);
            }
            return NameCommentLocal;
        }

        private static DateTime parseBeginTask(string userInput)
        {
            DateTime parseBeginTaskLocal;
            try
            {
                parseBeginTaskLocal = Convert.ToDateTime(userInput);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Дата начала не введена");
                userInput = Console.ReadLine();
                return parseBeginTask(userInput);
            }
            catch (FormatException formatEx)
            {
                //Console.WriteLine(formatEx.Message);
                Console.WriteLine("Дата начала введена не по формату dd/mm/yyyy");
                userInput = Console.ReadLine();
                return parseBeginTask(userInput);
            }
            return parseBeginTaskLocal;
        }
        private static DateTime parseEndTask(string userInput)
        {
            DateTime parseEndTaskLocal;
            try
            {
                parseEndTaskLocal = Convert.ToDateTime(userInput);
            }
            catch (ArgumentNullException Ex)
            {
                //Console.WriteLine(Ex.Message);
                Console.WriteLine("Дата окончания не введена");
                userInput = Console.ReadLine();
                return parseEndTask(userInput);
            }
            catch (FormatException formatEx)
            {
                //Console.WriteLine(formatEx.Message);
                Console.WriteLine("Дата окончания введена не по формату dd/mm/yyyy");
                userInput = Console.ReadLine();
                return parseEndTask(userInput);
            }
            return parseEndTaskLocal;
        }

    }








    //do
    //{
    //    Console.WriteLine("Введите имя задачи:");
    //    name_task = Console.ReadLine();
    //    if (name_task == "") Console.WriteLine("Вы не ввели имя задачи!");
    //}
    //while (name_task == "");

    //do
    //{
    //    Console.WriteLine("Введите дату начала:");
    //    try
    //    {
    //        begin_task = Convert.ToDateTime(Console.ReadLine());
    //        //  if (Convert.ToString(begin_task)=="")  Console.WriteLine("Вы не ввели дату начала!");
    //        if (begin_task == null) Console.WriteLine("Вы не ввели дату начала!");
    //    }
    //    catch (FormatException)
    //    {
    //        Console.WriteLine("Дата начала введена не по формату dd/mm/yyyy");
    //    }
    //}
    //while (begin_task == null);

    //do
    //{
    //    Console.WriteLine("Введите дату окончания:");
    //    try
    //    {
    //        end_task = Convert.ToDateTime(Console.ReadLine());
    //        if (end_task == null) Console.WriteLine("Вы не ввели дату окончания!");
    //    }
    //    catch (FormatException)
    //    {
    //        Console.WriteLine("Дата окончания введена не по формату dd/mm/yyyy");
    //    }
    //}
    //while (end_task == null);

    //do
    //{
    //    Console.WriteLine("Введите оценку в часах:");
    //    try
    //    {
    //        hour = Convert.ToInt16(Console.ReadLine());
    //        if (hour == null) Console.WriteLine("Вы не указали оценку в часах!");
    //        if (hour < 0) Console.WriteLine("Введено отрицательное число!");
    //    }
    //    catch (FormatException)
    //    {
    //        Console.WriteLine("Введено не число!");
    //    }
    //} while (hour == null || hour < 0);


    //do
    //{
    //    Console.WriteLine("Введите комментарий:");
    //    comment = Console.ReadLine();
    //    if (comment == "") Console.WriteLine("Комментарий не введен!");
    //}
    //while (comment == "");

    //Console.WriteLine("\n Вы ввели данные: \n Задача: " + name_task +
    //     "\n Дата начала: " + begin_task +
    //     "\n Дата окончания: " + end_task +
    //     "\n Кол-во часов: " + hour +
    //     "\n Комментарий: " + comment);
    //Console.ReadKey();


}


