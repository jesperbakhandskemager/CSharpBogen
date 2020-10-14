using System;

namespace IF_Sætninger
{
    class Program
    {
        static void Main(string[] args)
        {
            //If sætninger kan bruges til at lave betingelser for udførsel af kode.
            
            //TODO Opgave 1: gør således at følgende if sætning faktisk kører og der bliver skrevet "opgave 1" i konsollen.
            if(false)
            {
                Console.WriteLine("opgave 1");
            }


            //If sætninger skal have en boolean værdi imellem paranteserne. Hvis denne boolean værdi er true, så kører koden inden imellem curly-brackets

            //TODO Opgave 2: Følgende if sætning bruger en boolean variabel til at afgøre om den skal køre eller ej. Gør således at denne kode kører, og "opgave 2" bliver skrevet i konsollen.
            //NOTE der er to veje til at løse denne opgave
            bool opg2ShouldRun = false;
            if(opg2ShouldRun)
            {
                Console.WriteLine("opgave 2");
            }


            //Fordi if sætninger tager imod en boolean værdi kan vi bruge vores viden om operatorer fra sidste kapitel til at gøre dem smarte.
            const int a = 3;
            const int b = 7;
            const int c = 5;

            if(a > c)
            {
                Console.WriteLine("Error");
            }

            if(a < c)
            {
                Console.WriteLine("opgave 3");
            }

            if(a == b && a < c)
            {
                Console.WriteLine("error");
            }

            if(c < b)
            {
                Console.WriteLine("opgave 4");
            }

            if(a != a)
            {
                Console.WriteLine("error");
            }

            if(a < b || a == c)
            {
                Console.WriteLine("opgave 5");
            }

        }
    }
}
