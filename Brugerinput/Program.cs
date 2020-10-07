using System;
using System.Reflection.PortableExecutable;

namespace Brugerinput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Man kan få brugerens input ved at bruge funktionen Console.Readline()

            string input = Console.ReadLine();

            //Som du kan se, så får vi brugerens input i en streng.

            //TODO Opgave 1: Print brugerinputtet ud i konsollen. Kør så programmet og test at det du skriver i konsollen bliver skrevet tilbage.
            //Den type program du lige har lavet kaldes også for et "echo" program


            //Man kan kalde Console.ReadLine() flere gange. Hver gang "pauser" programmet indtil at brugeren har trykket enter.

            //TODO Opgave 2: Lav to string variabler og fyld dem med hver deres brugerinput. Derefter printer du begge input ud på én linje.

            //TODO Opgave 3: Lav opgave 2 igen herunder, men denne gang må du kun bruge én string variabel til begge inputs.


            //Nogen gange kan det være upraktisk at få strings ud. Hvis man for eksempel gerne vil have inputtet som en int
            //Til dette kan vi bruge int.Parse.

            //TODO Opgave 4: Udkommenter de 2 nedenstående linjer. Prøv så at printe integeren "n" ud i konsollen. Hvad sker der hvis du ikke skriver et tal?

            //input = Console.ReadLine();
            //int n = int.Parse(input);

            //Når man skal konvertere strings om til int kan programmet crashe hvis man skriver noget andet end et tal. Det kan man løse, men det kommer vi tilbage til i et senere kapitel.


            //Det er en god ide at skrive noget tekst ind imellem brugerinput for at fortælle brugeren hvad han skal skrive.
            
            //Console.WriteLine("Skriv dit navn.");
            //string name = Console.ReadLine();
            
            //TODO Opgave 5: Udkommenter de to ovenstående linjer og stil derefter brugeren yderligere spørgsmål til deres addresse og alder etc., og gem dem i forskellige passende variabler.

            
            //TODO Opgave 6: Lav et lille program som kan bede brugeren skrive to tal, og derefter fortælle ham hvad summen af de to tal er.

            //TODO Opgave 7: Lav et lille program hvor brugeren skal gætte et tal imellem 1 og 10. Giv brugeren 3 gæt til at gætte rigtigt.
            //NOTE: Nogen af jer kunne måske finde på at bruge loops til ovenstående opgave. Indtil videre, så hold jer til at lave opgaven uden.
        }
    }
}
