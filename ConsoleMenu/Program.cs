using System;

namespace ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string name = "";
            string password = "12345";
            bool isAuthorized = false;
            Console.WriteLine("Введите команду (Help - список команд):");

            while (userInput != "Esc")
            {
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "Help":
                        Console.WriteLine("Доступные команды:\nSetName\nChangeConsoleColor\nSetPassword\nWriteName\nEnterPassword\nEsc  ");
                        break;
                    case "SetName":
                        Console.Write("Введите имя :");
                        name = Console.ReadLine();
                        break;
                    case "ChangeConsoleColor":
                        Console.Write("Введите цвет консоли (доступные цевета синий, красный, зеленый):");
                        userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "синий":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case "красный":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case "зеленый":
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            default:
                                Console.Write("Не верный цвет");
                                break;
                        }

                        break;
                    case "SetPassword":                        

                        if (isAuthorized)
                        {
                            Console.Write("Введите новый пароль :");
                            password = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Данная команда доступна только после авторизации, введите команду EnterPassword");
                        }

                        break;
                    case "WriteName":

                        if (isAuthorized)
                        {
                            if (name == string.Empty)
                            {
                                Console.WriteLine("Имя не установлено");
                            } 
                            else
                            {
                                Console.WriteLine(name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Данная команда доступна только после авторизации, введите команду EnterPassword");
                        }

                        break;
                    case "EnterPassword":
                        Console.Write("Введите пароль :");
                        userInput = Console.ReadLine();

                        if (userInput == password)
                        {
                            Console.WriteLine("Вы вошли в систему");
                            isAuthorized = true;
                        }
                        else
                        {
                            Console.WriteLine("Не верный пароль!");

                            if (isAuthorized)
                            {
                                isAuthorized = false;
                            }
                        }

                        break;
                    case "Esc":
                        continue;
                    default:
                        Console.WriteLine("Не известная команда (help - список команд)!");
                        break;
                }
                Console.Write("Введите команду :");
            }
        }
    }
}
