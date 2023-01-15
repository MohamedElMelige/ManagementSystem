using System;

namespace EmployeesManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] menu = new string[] { "Add New Employee", "Display Employees", "Sort Employees", "Exit" };
            int highlighted = 0;
            bool flag = true;

            do
            {
                Console.ResetColor();
                Console.Clear();

                Console.WriteLine("Employees Management System\n");
                Console.WriteLine("Please Select The Choice You Want");

                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == highlighted)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.SetCursorPosition(50, 5 * (i + 1));
                    Console.WriteLine(menu[i]);
                }
                Console.ResetColor();

                ConsoleKeyInfo k = Console.ReadKey();

                switch (k.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            highlighted--;
                            if (highlighted < 0)
                            {
                                highlighted = menu.Length - 1;
                            }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            highlighted++;
                            if (highlighted > menu.Length - 1)
                            {
                                highlighted = 0;
                            }
                            break;
                        }
                    case ConsoleKey.Home:
                        {
                            highlighted = 0;
                            break;
                        }
                    case ConsoleKey.End:
                        {
                            highlighted = menu.Length - 1;
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            switch (highlighted)
                            {
                                case 0:
                                    {
                                        Console.Clear();
                                        Employees.New();
                                        Console.ReadKey();
                                        break;
                                    }
                                case 1:
                                    {
                                        Console.Clear();
                                        Employees.Display();
                                        Console.ReadKey();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Clear();
                                        Employees.Sort();
                                        Console.ReadKey();
                                        break;
                                    }
                                case 3:
                                    {
                                        char respons;
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Are You Sure You Want Exit The Menu ? (Y or N)");

                                            if (char.TryParse(Console.ReadLine(), out respons))
                                            {
                                                respons = char.ToUpper(respons);

                                                if (respons != 'Y' && respons != 'N')
                                                {
                                                    Console.WriteLine("You Must Enter Y or N");
                                                    Console.ReadKey();
                                                }
                                                else if (respons == 'Y')
                                                {
                                                    flag = false;
                                                    Console.WriteLine("Exiting The Menu . . . ");
                                                    Console.ReadKey();
                                                }
                                                else if (respons == 'N')
                                                {
                                                    flag = true;
                                                    Console.WriteLine("Press Enter To Return Home Page . . . ");
                                                    Console.ReadKey();
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("please Enter Valid Answer . . . ");
                                                Console.ReadKey();
                                            }
                                        } while (respons != 'Y' && respons != 'N');
                                        break;
                                    }
                            }
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            char respons;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Are You Sure You Want Exit The Menu ? (Y or N)");

                                if (char.TryParse(Console.ReadLine(), out respons))
                                {
                                    respons = char.ToUpper(respons);

                                    if (respons != 'Y' && respons != 'N')
                                    {
                                        Console.WriteLine("You Must Enter Y or N");
                                        Console.ReadKey();
                                    }
                                    else if (respons == 'Y')
                                    {
                                        flag = false;
                                        Console.WriteLine("Exiting The Menu . . . ");
                                        Console.ReadKey();
                                    }
                                    else if (respons == 'N')
                                    {
                                        flag = true;
                                        Console.WriteLine("Press Enter To Return Home Page . . . ");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("please Enter Valid Answer . . . ");
                                    Console.ReadKey();
                                }
                            } while (respons != 'Y' && respons != 'N');
                            break;
                        }
                }
            } while (flag);
        }
    }
}
