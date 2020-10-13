using System;

namespace IF_Sætninger
{
    class Program
    {
        static void Main(string[] args)
        {
            //If sætninger kan bruges til at lave betingelser for udførsel af kode.

            //TODO Opgave 1: gør således at følgende if sætning faktisk kører og der bliver skrevet "opgave 1" i konsollen.
            if (false)
            {
                Console.WriteLine("opgave 1");
            }


            //If sætninger skal have en boolean værdi imellem paranteserne. Hvis denne boolean værdi er true, så kører koden inden imellem curly-brackets

            //TODO Opgave 2: Følgende if sætning bruger en boolean variabel til at afgøre om den skal køre eller ej. Gør således at denne kode kører, og "opgave 2" bliver skrevet i konsollen.
            //NOTE der er to veje til at løse denne opgave
            bool opg2ShouldRun = false;
            if (opg2ShouldRun)
            {
                Console.WriteLine("opgave 2");
            }


            //Fordi if sætninger tager imod en boolean værdi kan vi bruge vores viden om operatorer fra sidste kapitel til at gøre dem smarte.
            //TODO Opgave 3,4 og 5: Ændre på værdierne for a, b og c således at der ikke bliver printet "Error" nogen steder, og at der bliver printet hhv. opgave 3, opgave 4 og opgave 5.
            const int a = 1;
            const int b = 1;
            const int c = 1;

            if (a > c)
            {
                Console.WriteLine("Error");
            }

            if (a < c)
            {
                Console.WriteLine("opgave 3");
            }

            if (a == b && a < c)
            {
                Console.WriteLine("error");
            }

            if (c < b)
            {
                Console.WriteLine("opgave 4");
            }

            if (a != a)
            {
                Console.WriteLine("error");
            }

            if (a < b || a == c)
            {
                Console.WriteLine("opgave 5");
            }


            //Man kan udvide sin if sætning med en "else sætning", for at beskrive hvad der skal ske hvis if sætningen får en false boolean værdi.
            //TODO Opgave 6: Ændre på d således at "opgave 6" bliver printet i konsollen.
            const int d = 3;
            if (d < 5)
            {
                Console.WriteLine("Error");
            } else
            {
                Console.WriteLine("opgave 6");
            }


            //Og man kan også udvide med en if-else sætning
            //TODO Opgave 7: Ændre på e således at "opgave 7" bliver printet i konsollen.
            const int e = 0;
            if (e < 10)
            {
                Console.WriteLine("Error");
            } else if (e > 0)
            {
                Console.WriteLine("opgave 7");
            }

            /* Hvis du har lavet opgaverne rigtigt indtil videre, så burde der nu stå
             * opgave 1
             * opgave 2
             * opgave 3
             * opgave 4
             * opgave 5
             * opgave 6
             * opgave 7
             */



            /* TODO Opgave 8: Du skal nu lave en if struktur. Den skal have afhænge af ovenstående to variabler, foo og bar
             * Hvis foo er mindre end 15 skal du tjekke om bar er større end foo. Hvis den er skriver du Works. Ellers skriver du Error.
             * Ellers skal du tjekke om bar er mindre end 15, og skrive error i konsollen hvis den er. Ellers skriver du Works.
             * Hvis foo er større eller ligmed 15 
             * Test gerne med forskellige værdier af foo og bar
             */


        }
    }
}
