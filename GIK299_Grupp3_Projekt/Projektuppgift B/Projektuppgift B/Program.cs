using GIK299_Grupp3_Projekt;
using System;
using System.Reflection.Metadata.Ecma335;

namespace GIK299_Grupp3_Projekt
{

    internal class Program
    {
      
        static void Main(string[] args)
        {
            //Skapar en meny åt användaren
            Menu menu = new Menu();
            Console.Clear();
            menu.AddOption("addition, subtraktion, mulitplikation eller division: \n", Option1);
            menu.AddOption("Upphöjda tal\n", Option2);
            menu.AddOption("kvadratroten\n", Option3);
            menu.AddOption("avsluta programmet: \n", Quit);
            menu.Start();
        }
        //                     --------------------------------- OPTION 1 - RÄKNA UT DE OLIKA RÄKNESÄTTEN (+, -, *, /) ------------------------------------
        static void Option1()
        {

            Console.WriteLine("Du har valt alternativ 1");

            while (true)
            {
                double result = 0;
                Console.Clear();
                Console.Write("välj ett nummer: ");
                double num1 = Convert.ToDouble(Console.ReadLine());


                Console.Write("välj ett räknesätt (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("välj ett andra nummer: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                string result1 = "";
                string result2 = "";
               
                // --- Räknar ut utifrån användarens val
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                         result1 = "Resultat: " + result;
                         result2 = $"Resultat: {num1} + {num2} = {result}";
                        break;
                    case "-":
                        result = num1 - num2;
                         result1 = "Resultat: " + result;
                         result2 = $"Resultat: {num1} - {num2} = {result}";
                        break;
                    case "*":
                        result = num1 * num2;
                         result1 = "Resultat: " + result;
                         result2 = $"Resultat: {num1} * {num2} = {result}";
                        break;
                    case "/":
                        result = num1 / num2;
                        int intResult = ((int)num1) / ((int)num2);
                        int intRemainder = ((int)num1) % ((int)num2);
                        result1 = "Resultat: " + result;
                         result2 = $"Resultat: {num1} / {num2} = {result} Men vid heltalsdivision  {intResult}, med rest {intRemainder} ";
                        break;
                    default:
                        Console.WriteLine("inkorrekt svar, försök igen:");
                        break;
                }
                Console.WriteLine(result1);
                Console.WriteLine(result2);
                String[] results = { result1, result2 };
                File.AppendAllLines("C:\\Users\\tyral\\source\\repos\\Projektuppgift B\\Projektuppgift B\\Projekttext.txt", results);

                // ----- Frågar användaren om ett nytt nummer vill läggas till -------
                while (true)
                {
                    Console.WriteLine("vill du lägga in ett till nummer? (j/n) ");
                    string input = Console.ReadLine();
                    if (input == "n")
                    {
                        break;
                    }
                    if (input == "j")
                    {
                        Console.Write("välj ett räknesätt (+, -, *, /): ");
                        string additionalOp = Console.ReadLine();

                        Console.Write("välj ett nummer: ");
                        double num3 = Convert.ToDouble(Console.ReadLine());

                        double result3 =0;
                        string result4 ="";
                        string result5 ="";

                        // --- Räknar ut den nya uträkningen
                        switch (additionalOp)
                        {
                            case "+":
                                result3 = result + num3;
                                result4 = "Resultat: " + result3;
                                result5 = $"Resultat: {result} + {num3} = {result3}";
                                break;
                            case "-":
                                result3 = result - num3;
                                result4 = "Resultat: " + result3;
                                result5 = $"Resultat: {result} - {num3} = {result3}";
                                break;
                            case "*":
                                result3 = result * num3;
                                result4 = "Resultat: " + result3;
                                result5 = $"Resultat: {result} * {num3} = {result3}";
                                break;
                            case "/":
                                result3 = result / num3;
                                result4 = "Resultat: " + result3;
                                result5 = $"Resultat: {result} / {num3} = {result3}";
                                break;
                            default:
                                Console.WriteLine("inkorrekt input, försök igen:");
                                break;
                        }
                         Console.WriteLine(result4);
                         Console.WriteLine(result5);
                         String[] results2 = { result4, result5 };
                         File.AppendAllLines("C:\\Users\\tyral\\source\\repos\\GIK299_Grupp3_Projekt\\GIK299_Grupp3_Projekt\\Projekttext.txt", results2);
                    }
                    else
                    //Felhantering
                    {
                        Console.WriteLine("Du har skrivit något fel, försök igen: ");
                    }
                }
                //  ---- Om användaren vill göra en ny uträkning eller gå tillaka till menyn
                Console.WriteLine("Vill du göra en ny uträkning? (j/n): ");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    Console.Clear();
                    break;
                }
                if (answer == "j")
                {
                    continue;
                }
            }
        }
       
         //                     --------------------------------- OPTION 2 - RÄKNA UT UPPHÖJT ------------------------------------
        static void Option2()
        {
            //Vi lägger in kod till upphöjt
            Console.WriteLine("Du har valt alternativ 2");
            Console.Clear();

            Console.Write("välj ett nummer: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("välj ett till nummer: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(num1, num2);
            Console.WriteLine($"Ditt svar är: {num1} ^ {num2} = {result}");
        }

 //                     --------------------------------- OPTION 3 - RÄKNA UT KVADRATROT ------------------------------------
        static void Option3()
        //Kod för att räkna ut kvadratrot
        {
            Console.WriteLine("Du har valt alternativ 3");
            Console.Write("välj ett nummer: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double result = Math.Sqrt(num1);
            Console.WriteLine($"Ditt svar roten ur {num1} =  {result}");
        }
        
         //                     --------------------------------- OPTION 4 - AVSLUTA PROGRAMMET  ------------------------------------
        static void Quit()
        {
            Console.WriteLine("Välkommen åter!");
            //Någon kod för att avsluta
            Environment.Exit(0);
        }


    }
}