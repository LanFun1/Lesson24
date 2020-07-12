using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson24
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " ";
            string pass = " ";
            string codeWord = " ";
            Console.WriteLine("Добро пожаловать! У вас есть 6 команд:exit- выйти\nSetName - установить имя\nSetPass - установить пароль\nChangeConsoleColor - изменить цвет консоли\nWriteName - вывести имя\nChangePass - изменить имя");
            while (codeWord != "exit")
            {
                Console.WriteLine("Введите команду.");
                codeWord = Console.ReadLine();
                switch (codeWord)
                {
                    case "SetName":
                        Console.WriteLine("Введите имя");
                        name = Console.ReadLine();
                        while(name.Length <4)
                        {
                            Console.WriteLine("Имя должно содержать больше 4 символов. Введите его заново");
                            name = Console.ReadLine();
                        }
                        break;
                    case "SetPass":
                        if (pass == " ")
                        {
                            Console.WriteLine("Введите пароль.");
                            pass = Console.ReadLine();
                            while (pass.Length < 8)
                            {
                                Console.WriteLine("Пароль слишком короткий. В пароле должно быть больше 8 символов. Введите пароль заново.");
                                pass = Console.ReadLine();
                            }
                        }
                        break;
                    case "ChangePass":
                        if (pass != " ")
                        {
                            Console.WriteLine("Введите старый пароль.");
                            string lastPass = Console.ReadLine();
                            if (lastPass == pass)
                            {
                                Console.WriteLine("Введите новый пароль.");
                                pass = Console.ReadLine();
                                while (pass.Length < 8)
                                {
                                    Console.WriteLine("Пароль слишком короткий. В пароле должно быть больше 8 символов. Введите пароль заново.");
                                    pass = Console.ReadLine();
                                    if(pass == lastPass)
                                    {
                                        Console.WriteLine("Новый пароль не может совпадать со старым");
                                        pass = " ";
                                    }
                                }
                            }
                            else
                            {
                                while(pass != lastPass)
                                {
                                    Console.WriteLine("Старый пароль введён неверно, попробуйте снова.");
                                    lastPass = Console.ReadLine();
                                }
                                if (lastPass == pass)
                                {
                                    Console.WriteLine("Введите новый пароль.");
                                    pass = Console.ReadLine();
                                    while (pass.Length < 8)
                                    {
                                        Console.WriteLine("Пароль слишком короткий. В пароле должно быть больше 8 символов. Введите пароль заново.");
                                        pass = Console.ReadLine();
                                        while (pass == lastPass)
                                        {
                                            Console.WriteLine("Новый пароль не может совпадать со старым");
                                            pass = Console.ReadLine();
                                        }
                                    }
                                }
                            }
                                
                        }
                        else
                        {
                            Console.WriteLine("Вы ещё не установили пароль, поэтому функция смены пароля недоступна!");
                        }
                        break;
                    case "ChangeConsoleColor":
                        Console.WriteLine("Введите номер желаемого цвета.(от 0 до 16)");
                        string wordsColor = Console.ReadLine();
                        switch(wordsColor)
                        {
                            case "0":
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                            case "1":
                                Console.ForegroundColor = ConsoleColor.DarkBlue; 
                                break;
                            case "2":
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                break;
                            case "3":
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                break;
                            case "4":
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                break;
                            case "5":
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                break;
                            case "6":
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                break;
                            case "7":
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            case "8":
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                            case "9":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case "10":
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case "11":
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                break;
                            case "12":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case "13":
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                break;
                            case "14":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case "15":
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                        break;
                    case "WriteName":
                        if(name != " ")
                        {
                            Console.WriteLine(name);
                        }
                        else
                        {
                            Console.WriteLine("Вы не можете вывести имя, потому что его нету. Введите сначало имя. Для это напишите команду SetName");
                        }
                        break;
                }
            }
        }
    }
}
