using System;

namespace Number_to_Alphabet_and_Number_to_Days_of_the_week
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string userAnswer = null;
            
            while (userAnswer != "3")
            {

                userAnswer = null;
                Console.Clear();
                Console.WriteLine("Welcome");
                Console.WriteLine("Enter a number to execute :");
                Console.WriteLine("1) Convert number to alphabet");
                Console.WriteLine("2) Convert number to day of wekk");
                Console.WriteLine("3) Exit");
                Console.Write("--> ");
                userAnswer = Console.ReadLine();


                switch (userAnswer)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter a number between 1 - 10 :");
                        var answer1 = Console.ReadLine();

                        switch (answer1)
                        {
                            case "1":
                                Console.WriteLine("--> Result: One");

                                break;

                            case "2":
                                Console.WriteLine("--> Result: Two");
                                break;

                            case "3":
                                Console.WriteLine("--> Result: Three");
                                break;

                            case "4":
                                Console.WriteLine("--> Result: Four");
                                break;

                            case "5":
                                Console.WriteLine("--> Result: Five");
                                break;

                            case "6":
                                Console.WriteLine("--> Result: Six");
                                break;

                            case "7":
                                Console.WriteLine("--> Result: Seven");
                                break;

                            case "8":
                                Console.WriteLine("--> Result: Eight");
                                break;

                            case "9":
                                Console.WriteLine("--> Result: Nine");
                                break;

                            case "10":
                                Console.WriteLine("--> Result: Ten");
                                break;

                            default:
                                Console.WriteLine("You entered out of range!");
                                break;
                        }

                        Console.ReadLine();
                        break;


                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter a number between 1 - 7 for days of the week");
                        string number2 = Console.ReadLine();

                        switch (number2)
                        {
                            case "1":
                                Console.WriteLine("--> Today is Saturday");
                                break;

                            case "2":
                                Console.WriteLine("--> Today is Sunday");
                                break;

                            case "3":
                                Console.WriteLine("--> Today is Monday");
                                break;

                            case "4":
                                Console.WriteLine("--> Today is Tuesday");
                                break;

                            case "5":
                                Console.WriteLine("--> Today is Wednesday");
                                break;

                            case "6":
                                Console.WriteLine("--> Today is Thursday");
                                break;

                            case "7":
                                Console.WriteLine("--> Today is Friday");
                                break;

                            default:
                                Console.WriteLine("You entered out of range!");
                                break;

                        }
                        Console.ReadLine();

                        break;



                    case "3":
                        userAnswer = "3";
                        break;


                    default:
                        Console.Clear();
                        Console.WriteLine("You enter wrong item");
                        Console.WriteLine("Try Again.");
                        Console.ReadLine();
                        break;
                }

                Console.Clear();
                Console.WriteLine("Bb");
            }

        }
    }
}
