using System;

namespace BMI_challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            // ****** UNDONE *****


            Console.WriteLine("this is bmi calculater\n");
            Console.WriteLine("Enter your weight in kg:");
            var weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height in cm:");
            var height = (Convert.ToDouble(Console.ReadLine()) / 100.0);

            double bmi = Math.Round((weight / (Math.Pow(height, 2))), 1);
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

            Console.WriteLine($"your bmi is {bmi} and your are {bmiCategories} ");



            // Console.Clear();

            // Console.WriteLine("Hello there. \nFor calculating your BMI please enter your weight in Kg");
            // var weight = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Great, Now enter your height in Cm");
            // var height = Convert.ToDouble(Console.ReadLine()) / 100.0;

            // var bmi = Math.Round(weight / (height * height), 1);

            // Console.Write($"Well, Your BMI is {bmi} and ");

            // if (bmi <= 18.4)
            // {
            //     Console.WriteLine(($"it's Underweight"));
            // }

            // else if (bmi <= 24.9)
            // {
            //     Console.WriteLine(($"it's Normal"));
            // }

            // else if (bmi <= 39.9)
            // {
            //     Console.WriteLine(($"it's Overwight"));
            // }
            // else if (bmi >= 40)
            // {
            //     Console.WriteLine(($"it's Obese"));
            // }






        }
    }
}
