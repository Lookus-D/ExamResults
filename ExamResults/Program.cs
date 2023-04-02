using System;

namespace ExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your exam results in particular subjects, please:");
            //Wynik z matematyki powyżej 70
            //Wynik z fizyki powyżej 55
            //Wynik z chemii powyżej 45
            //Łączny wynik z 3 przedmiotów powyżej 180
            //albo
            //Wynik z matematyki i jednego przedmiotu powyżej 150
            
            Console.WriteLine("Give me your result in mathematics:");
            string math = Console.ReadLine();
            int chosenMath = 0;
            Int32.TryParse(math, out chosenMath); 

            Console.WriteLine("Give me your result in physics:");
            string phy = Console.ReadLine();
            int chosenPhy = 0;
            Int32.TryParse(phy, out chosenPhy);

            Console.WriteLine("Give me your result in chemistry:");
            string chem = Console.ReadLine();
            int chosenChem = 0;
            Int32.TryParse(chem, out chosenChem);


            if (chosenMath > 70)
            {
                Console.WriteLine($"Congratulation! You passed exam. Your score in mathematics is over expected 70 points [Score:\"{chosenMath}\"]");
            }
            else if (chosenPhy > 55)
            {
                Console.WriteLine($"Congratulation! You passed exam. Your score in physics is over expected 55 points [Score:\"{chosenPhy}\"]");
            }
            else if(chosenChem > 45)
            {
                Console.WriteLine($"Congratulation! You passed exam. Your score in chemistry is over expected 45 points [Score:\"{chosenChem}\".");
            }
            else if (chosenMath + chosenPhy + chosenChem > 180)
            {
                Console.WriteLine($"Congratulation! You passed exam. Your total score is over expected 180 points");
            }
            else if ((chosenMath + chosenPhy > 150) || (chosenMath + chosenChem > 150))
            {
                Console.WriteLine($"Congratulation! You passed exam. Your total score is over expected 150 points");
            }
            else
            {
                Console.WriteLine($"Sorry! You failed exam. Your total score is bellow expectations.");
            }
        }
    }

}
