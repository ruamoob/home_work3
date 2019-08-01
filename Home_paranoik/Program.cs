using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_paranoik
{
    class Program
    {
        static void Main(string[] args)
        {

            String name_task;
            DateTime? begin_task = null;
            DateTime? end_task = null;
            int? hour = null;
            String comment;
            do
            {
                Console.WriteLine("Введите имя задачи:");
                name_task = Console.ReadLine();
                if (name_task == "") Console.WriteLine("Вы не ввели имя задачи!");
            }
            while (name_task == "");

            do
            {
                Console.WriteLine("Введите дату начала:");
                try
                {
                    begin_task = Convert.ToDateTime(Console.ReadLine());
                    //  if (Convert.ToString(begin_task)=="")  Console.WriteLine("Вы не ввели дату начала!");
                    if (begin_task == null) Console.WriteLine("Вы не ввели дату начала!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Дата начала введена не по формату dd/mm/yyyy");
                }
            }
            while (begin_task == null);

            do
            {
                Console.WriteLine("Введите дату окончания:");
                try
                {
                    end_task = Convert.ToDateTime(Console.ReadLine());
                    if (end_task == null) Console.WriteLine("Вы не ввели дату окончания!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Дата окончания введена не по формату dd/mm/yyyy");
                }
            }
            while (end_task == null);

            do
            {
                Console.WriteLine("Введите оценку в часах:");
                try
                {
                    hour = Convert.ToInt16(Console.ReadLine());
                    if (hour == null) Console.WriteLine("Вы не указали оценку в часах!");
                    if (hour < 0) Console.WriteLine("Введено отрицательное число!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено не число!");
                }
            } while (hour == null || hour < 0);


            do
            {
                Console.WriteLine("Введите комментарий:");
                comment = Console.ReadLine();
                if (comment == "") Console.WriteLine("Комментарий не введен!");
            }
            while (comment == "");

            Console.WriteLine("\n Вы ввели данные: \n Задача: " + name_task +
                 "\n Дата начала: " + begin_task +
                 "\n Дата окончания: " + end_task +
                 "\n Кол-во часов: " + hour +
                 "\n Комментарий: " + comment);
            Console.ReadKey();


        }
    }
}
