using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services
{
    public static class ConsoleHelper
    {
        public static int MainMenu()
        {
            int result=10;
            Output("Главное меню");
            Output("1- добавть новый контакт");
            Output("2- удлить контакт");
            Output("3-изменить контакт");
            Output("4-найти контакт");
            Output("5-записать данные в файл");
            Output("6-считать данные из файла");
            Output("7-найти контакт по категории");
            Output("0-выход");

            try
            {
                result = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result= 0;
            }
            return result;
        }
        private static void Output(string message)
        {
            Console.WriteLine(message);
        }

        public static string InputName()
        {
            Output("Введите имя");

            var name=Console.ReadLine();

            return name;
        }
        public static string InputNumber()
        {
            Console.Write("Введите номер- +7 ");

            var number=Console.ReadLine();

            return "+7" +number;
        }
        public static int InputCategory()
        {
            int result = 0;

            Output("Выберите категорию контакта 1-родственники, 2-коллега, 3- друг, 4 - прочее");
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                result= 4;
            }
            if (result>4|| result <= 0)
            {
                Output("ВВведено неккоретное число");
                result = 4;
            }
            return result;

           
        }
        public static int InputSpecies()
        {
            int result = 0;

            Output("Номер 1-мобильный, 2- домашний");
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = 1;
            }
            if (result > 2 || result <= 0)
            {
                Output("ВВведено неккоретное число");
                result = 2;
            }

            return result;
        }
        public static void ForEvent(string massege)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Output(massege);
            Console.ResetColor();
        }
        public static int NumberInputMenu()
        {
            int result=10;
            Output("1 - ввести номер");
            Output("0-выйти");
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = 0;
            }
            if (result > 2 || result < 0)
                result = 0;
            return result;
        }
        public static int ChangeMenu()
        {
            int result=10;
            Output("1- удалить номер");
            Output("2-изменить категорию");
            Output("3-изменить имя");
            Output("4-добавить номер");
            Output("0-выход");
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = 0;
            }
            if (result > 4 || result < 0)
                result = 0;
            return result;

        }

    }
}
