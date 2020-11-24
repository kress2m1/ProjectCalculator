using System;
using System.Collections.Generic;
using System.Text;

namespace ResharpANew
{
    public class UserLogin
    {
        private const int PasswordOne = 145236;
        private const int PasswordTwo = 748596;
        private const int PasswordThree = 456321;
        private const int PasswordFour = 741258;
        private const int PasswordFive = 963258;

        public static void Validation()
        {
            //Ask for the username
            Console.WriteLine("Please enter your username");
            var username = Console.ReadLine();

            switch (username)
            {
                case "Juliana":
                    Console.WriteLine($"Welcome {username}. Please enter your password");
                    var password1 = Convert.ToInt32(Console.ReadLine());
                    if (password1 != PasswordOne)
                    {
                        Console.WriteLine("You are now logged in");
                    }
                    else
                    {
                        Console.WriteLine($"Either your username or password was incorrect\n" +
                                          $"Please try again");
                    }
                    break;
                case "Toyin":
                    Console.WriteLine($"Welcome {username}. Please enter your password");
                    var password2 = Convert.ToInt32(Console.ReadLine());
                    if (password2 == PasswordTwo)
                    {
                        Console.WriteLine("You are now logged in");
                    }
                    else
                    {
                        Console.WriteLine($"Either your username or password was incorrect\n" +
                                          $"Please try again");
                        
                    }
                    break;
                case "Bissy":
                    Console.WriteLine($"Welcome {username}. Please enter your password");
                    var password3 = Convert.ToInt32(Console.ReadLine());
                    if (password3 == PasswordThree)
                    {
                        Console.WriteLine("You are now logged in");
                    }
                    else
                    {
                        Console.WriteLine($"Either your username or password was incorrect\n" +
                                          $"Please try again");
                    }
                    break;
                case "Made":
                    Console.WriteLine($"Welcome {username}. Please enter your password");
                    var password4 = Convert.ToInt32(Console.ReadLine());
                    if (password4 == PasswordFour)
                    {
                        Console.WriteLine("You are now logged in");
                    }
                    else
                    {
                        Console.WriteLine($"Either your username or password was incorrect\n" +
                                          $"Please try again");
                    }
                    break;
                case "Nike":
                    Console.WriteLine($"Welcome {username}. Please enter your password");
                    var password5 = Convert.ToInt32(Console.ReadLine());
                    if (password5 == PasswordOne)
                    {
                        Console.WriteLine("You are now logged in");
                    }
                    else
                    {
                        Console.WriteLine($"Either your username or password was incorrect\n" +
                                          $"Please try again");
                    }
                    break;
                    default:
                    Console.WriteLine($"The username {username} is not recognised");
                    break;
            }
        }
    }
}
