using System;

namespace Operatorer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aritmiske Operatorer
            //4 ud af de 5 aritmiske operatorer passer til de fire regnearter

            int sum = 5 + 5;
            int subsubtrahend = 5 - 5;
            int product = 5 * 5;
            double dividend = 5 / 2;

            //TODO Opgave 1: Skriv de fire variabler ovenfor ud i konsollen og verificer at de bliver det som du regner med.

            //TODO Opgave 2: Prøv at ændre dividend variablen til en Integer variabel. Hvad er resultatet nu? Hvorfor?

            //TODO Opgave 3: Lav en variabel der udregner summen af de fire variabler ovenover. Hvad type skal den være? 


            //Der findes også en femte aritmisk operator. Modulo (%), giver den rest der er til overs når man dividere to hel-tal.

            int modulo = 5 % 2;

            //TODO Opgave 4: Udskriv modulo variablen i konsollen.

            //TODO Opgave 5: Prøv at ændre tallet før '%' således at resultatet af regnestykket bliver 0.


            //Sammenlignings Operatorer
            //Disse operatorer har det til fælles at de alle bliver til en boolean værdi

            bool greaterThan = 5 > 3;
            bool greaterThanOrEqual = 2 >= 7.3;
            bool equal = 3.7 == 4.1;
            bool notEqual = 5 != 3;
            bool lessThan = 3 < 4;
            bool lessThanOrEqual = 17 <= 17;

            //TODO Opgave 6: Gæt på hvad de forskellige variabler indeholder og print dem så ud i konsollen. Passede dit gæt?


            //Boolske Operatorer
            //Disse operatorer skal ALTID tage imod boolean værdier, og returnerer en boolean værdi.

            bool and = greaterThan && notEqual;
            bool or = lessThanOrEqual || greaterThanOrEqual;
            bool not = !false;

            //Der er også en sjældent brugt "exclusive OR" operator

            bool xOr = equal ^ lessThan;

            //TODO Opgave 7: Gæt på hvad de forskellige variabler indeholder og print dem ud i konsollen. Passede dit gæt.

            bool mysterious = true && false || !false;

            //TODO Opgave 8: Print den mystiske værdi ud. Hvorfor er det resultatet?

            //TODO Opgave 9: Skriv en variabel herunder som bruger ALLE ovenstående operatorer (+ - * / % > >= == != <= < && || !) og returnerer true;
            //bool result = 
        }
    }
}
