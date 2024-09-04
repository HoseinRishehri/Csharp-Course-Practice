using System;

namespace Music_Theory_Project
{
    class Program
    {
        static void Main(string[] args)
        {
             string userAnswer = null;


            while (userAnswer != "bb")
            {
                Console.Clear();
                Console.WriteLine($"Hi, this is Music Theory Practice Project!");
                Console.WriteLine($"1. Give you random notes and you should write it on sheet");
                Console.WriteLine($"");
                Console.WriteLine($"Wite 'bb' to quiet the project");
                Console.WriteLine($"");
                Console.Write("--->   ");
                userAnswer = Console.ReadLine();


                switch (userAnswer)
                {
                    // practice number one, random note!
                    case "1":
                        Console.Clear();
                        string practiceOneUserAnswer = null;

                        Console.WriteLine($"Here's the Tutorial:");
                        Console.WriteLine($"I write a note with 1.Name 2.Octave 3.Rhtyem every time you press the Enter!");
                        Console.WriteLine($"For example:  5B w means B note on third line with whole-note rythem.");
                        Console.WriteLine($"Press enter to start or press any other key for exit.");
                        Console.WriteLine($"");
                        Console.Write($"--->  ");
                        practiceOneUserAnswer = Console.ReadLine();

                        while (practiceOneUserAnswer == "")
                        {

                            Console.Clear();
                            string name = null;
                            int octave;
                            string rythem = null;
                            Random random = new Random();

                            var randomNumber1 = random.Next(1, 8);
                            var randomNumber2 = random.Next(1, 3);
                            var randomNumber3 = random.Next(1, 7);

                            switch (randomNumber1)
                            {
                                case 1:
                                    name = "C";
                                    break;
                                case 2:
                                    name = "D";
                                    break;
                                case 3:
                                    name = "E";
                                    break;
                                case 4:
                                    name = "F";
                                    break;
                                case 5:
                                    name = "G";
                                    break;
                                case 6:
                                    name = "A";
                                    break;
                                case 7:
                                    name = "B";
                                    break;
                                default:
                                    name = "wtf!";
                                    break;
                            }

                            switch (randomNumber2)
                            {
                                case 1:
                                    octave = 4;
                                    break;
                                case 2:
                                    octave = 5;
                                    break;
                                default:
                                    octave = 99999;
                                    break;
                            }

                            switch (randomNumber3)
                            {
                                case 1:
                                    rythem = "1";
                                    break;
                                case 2:
                                    rythem = "1/2";
                                    break;
                                case 3:
                                    rythem = "1/4";
                                    break;
                                case 4:
                                    rythem = "1/8";
                                    break;
                                case 5:
                                    rythem = "1/16";
                                    break;
                                case 6:
                                    rythem = "1/32";
                                    break;
                                default:
                                    rythem = "wtf!";
                                    break;
                            }

                            Console.WriteLine($"1/1 = whole-note & 1/2 = half-note & 1/4 = quarter-note & 1/8 = eight-note & 1/16 = sixtheentnote & 1/32 = thirtytwonote");
                            Console.WriteLine($"");
                            Console.WriteLine($"");
                            Console.WriteLine($"Your random note is:  {name + octave} {rythem}");
                            practiceOneUserAnswer = Console.ReadLine();
                        }
                        break;
                    default:
                        break;
                }

            }

            Console.Clear();
            Console.WriteLine($"Made by H.g");

        }
    }
}
