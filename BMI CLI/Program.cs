using System;

namespace BMI_CLI
{
    class Program
    {
         static void Main(string[] args)
        {
            switch (args[0])
            {
                case "bmi" when args[1] == "--weight" && args[3] == "--height":
                    bmiCalculaterWeight(Convert.ToDouble(args[2]), Convert.ToDouble(args[4]));
                    break;
                case "bmi" when args[1] == "--height" && args[3] == "--weight":
                    bmiCalculaterHeight(Convert.ToDouble(args[4]), Convert.ToDouble(args[2]));
                    break;
                case "bmi" when args[1] == "--helps":
                    helpSwitch();
                    break;
                case "bmi" when args[1] == "--version":
                    versionSwitch();
                    break;
                default:
                    invalidCommandSwitch();
                    break;
            }
        }

        static void bmiCalculaterWeight(double weight, double height)
        {
            Console.Clear();
            double bmi = Math.Round((weight / (Math.Pow((height / 100.0), 2))), 1);
            string bmiCategories = "";

            if (bmi < 18.5)
            {
                bmiCategories = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                bmiCategories = "Normal";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                bmiCategories = "Overweight";
            }
            else if (bmi > 30)
            {
                bmiCategories = "Obese";
            }

            Console.WriteLine($"Your BMI is {bmi} and it's {bmiCategories}");
        }
        static void bmiCalculaterHeight(double weight, double height)
        {
            Console.Clear();
            double bmi = Math.Round((weight / (Math.Pow((height / 100.0), 2))), 1);
            string bmiCategories = "";

            if (bmi < 18.5)
            {
                bmiCategories = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                bmiCategories = "Normal";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                bmiCategories = "Overweight";
            }
            else if (bmi > 30)
            {
                bmiCategories = "Obese";
            }
            Console.WriteLine($"Your BMI is {bmi} and it's {bmiCategories}");
        }
        static void helpSwitch()
        {
            Console.Clear();
            Console.WriteLine($"Use these switch to run program:");
            Console.WriteLine($"--height        Your height (centimeters)");
            Console.WriteLine($"--weight        Your weight (kilograms)");
            Console.WriteLine($"--version       Show current version");
            Console.WriteLine($"--helps         Show command list");

        }
        static void invalidCommandSwitch()

        {
            Console.Clear();
            Console.WriteLine("Invalid command :-?");
            Console.WriteLine($"");
            Console.WriteLine("Use --helps switch to show help");
        }
        static void versionSwitch()
        {
            Console.WriteLine($"Current version is 1.0");
        }
    }
}
