using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops kan bruges til at gentage den samme kode mange gange.
            //Et simpelt loop er et while loop. Den kører indtil dens condition er false.

            int i = 10;
            while(i >= 0)
            {
                Console.WriteLine("Dette bliver skrevet 10 gange");
                i -= 1; //NOTE Dette tager i variablen og reducerer den med 1
            }

            //TODO Opgave 1: Kør koden og se det teksten blive skrevet 10 gange. Opdater koden således at det nu bliver skrevet 100 gange.

            //TODO Opgave 2: Prøv at fjerne linjen "i -= 1". Programmet vil nu have problemer med at køre da du har lavet en infinite loop.

            /*TODO Opgave 3: Opdater koden ovenfor så outputtet i stedet bliver:
             * Dette er iteration nummer 0
             * Dette er iteration nummer 1
             * Dette er iteration nummer 2
             * Dette er iteration nummer 3
             * ... osv
             */


            //En løkke kan også bruges sammen med et array, for at gøre noget for hver index i arrayet
            
            string[] texts = new string[0];
            i = 0;
            while (false) //NOTE det er denne linje der skal ændres i opgave 4
            {
                Console.WriteLine(texts[i]);
            }

            //TODO Opgave 4: Ændrer loopets condition ovenfor således at hvert element i arrayet bliver skrevet ud. Fyld arrayet med noget valgfri data.
            //HINT man kan få antallet af elementer i et array ved at skrive <array identifier>.Length. Så med texts arrayet vil det være texts.Length 

            //Hvis du laver opgave 4 rigtigt, vil det være ligemeget hvor mange elementer der er i texts når du kører det, den vil altid vise dem alle.


            //TODO Opgave 5: Skriv din egen loop struktur herunder som tæller fra 0 og op til 1000, men i skridt af 5. Dvs. 
            /* 0
             * 5
             * 10
             * 15
             * 20
             * ...etc
             */

            /*TODO Opgave 6: Lav et lille program som:
             * step 1: Spørger brugeren hvor mange stykker tekst han gerne vil skrive ind.
             * step 2: Opretter et array med så mange pladser
             * step 3: Laver et loop som kører så mange gange
             * step 4: For hver iteration i loopet tager brugerens input og gemmer på en tilsvarende plads i arrayet.
             */


            /*TODO Opgave 7: Lav et loop inden i et loop som kan printe navnet på felterne på et skakbræt. Dvs.
             * a1
             * a2
             * a3
             * a4
             * a5
             * a6
             * a7
             * a8
             * b1
             * b2
             */


        }
    }
}
