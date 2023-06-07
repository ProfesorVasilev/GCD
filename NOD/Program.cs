using System.Linq.Expressions;
using System.Security.AccessControl;

namespace NOD
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //gcd - greatest common divisor (nai-golqm obsht delitel)

            int temporaryA = 0; int temporaryB = 0; // izpolzvat se za izchisleniqta 
            int a; int b;
            bool gcdIsFound = false;
            bool parsedA; bool parsedB;
            int originalA; int originalB;

            do
            {
                Console.WriteLine("Input a and b:");
                Console.Write("a = ");
                string stringA = Console.ReadLine();
                parsedA = int.TryParse(stringA, out a); // proverqva dali "a" e int
                Console.Write("b = ");
                string stringB = Console.ReadLine();
                parsedB = int.TryParse(stringB, out b); // proverqva dali "b" e int

                if (parsedA == false || parsedB == false) // a ili b ne e int
                { 
                    Console.WriteLine("Please enter valid numbers!"); 
                }
            }
            while (!parsedA || !parsedB); // do-while loopa izpulnqva koda vinagi izpulnqva koda edin put i posle ako uslovieto v while() e vqrno

            originalA = a; 
            originalB = b;

            while (!gcdIsFound)
            {
                if (a == 0)
                {
                    Console.WriteLine($"GCD({originalA},{originalB}) = {b}."); // printirame NOD 
                    gcdIsFound = true; // spirame cikula
                }
                else if (b == 0)
                {
                    Console.WriteLine($"GCD({originalA},{originalB}) = {a}."); // printirame NOD 
                    gcdIsFound = true; // spirame cikula
                }
                else if (a > b)
                {
                    temporaryA = b; // po-golqmoto chislo (a) vzima stoinostta na po-malkoto (b)
                    temporaryB = a % b; // izchislqvame kolko trqbva da e stoinostta na po-malkoto chislo (b)

                    a = temporaryA; // promenqme stoinostite na promenlivite koito polzvame, sled kato sme izchislili kolko trqbva da sa te
                    b = temporaryB; // ^ 
                }
                else if (b > a) 
                {
                    temporaryB = a; // po-golqmoto chislo (b) vzima stoinostta na po-malkoto (a)
                    temporaryA = b % a; // izchislqvame kolko trqbva da e stoinostta na po-malkoto chislo (a)

                    b = temporaryB; // promenqme stoinostite na promenlivite koito polzvame, sled kato sme izchislili kolko trqbva da sa te
                    a = temporaryA; // ^ 
                }
                else if (a == b)
                {
                    Console.WriteLine($"GCD({originalA},{originalB}) = {a}."); // printirame NOD 
                    gcdIsFound = true; // spirame cikula
                }
            }
        }
    }
}