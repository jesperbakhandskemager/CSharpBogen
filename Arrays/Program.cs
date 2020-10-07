using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays er en særlig form for datatype som kan indeholde en række af data.
            //Et array indeholder værdier af en bestemt datatype. Man ærklærer eksempelvis et integer array på følgende måde.
            int[] intArray = new int[10];

            //Tallet 10 indikerer at man gerne vil have plads til 10 tal i sit array.
            //Et array har altid en bestemt størrelse.

            //TODO Opgave 1: Ærklær et array med plads til 15 strings herunder.

            //TODO Opgave 2: Ærklær et array med plads til 7 integers herunder.

            //TODO Opgave 3: Ærklær et array med plads til 9 doubles herunder.

            //TODO Opgave 4: Ærklær et array med plads til 25 bools herunder.


            //Når man har oprettet sit array så kan man fylde ting ind i arrayet.
            intArray[0] = 5; //NOTE den første plads i et array har index 0!
            intArray[1] = 7;
            intArray[2] = -15;

            //TODO Opgave 5: Færdiggør arbejdet med at fylde intArray med værdier. Du bestemmer selv hvilke.


            //Derefter vil man kunne læse de forskellige værdier i arrayet, og evt. printe dem ud.
            Console.WriteLine(intArray[8]);


            //En hurtigere måde at ærklære og fylde et array på er således:
            string[] latinWords = {"Vidi", "Vici", "Veni"};

            //TODO Opgave 6: Skriv ordene fra arrayet latinWords ud i følgende rækkefølge "Veni" "Vidi" "Vici"

            //TODO Opgave 7: Lav et array med navnene på dine yndlings spil eller yndlings film. Minimum otte, gerne flere!

            //TODO Opgave 8: Lav herefter et array med de tilsvarende udgivelsesår på dine yndlings spil eller film. De skal passe således at værk og udgivelsesår har samme index.

            //TODO Opgave 9: Skriv herefter værdierne fra de to arrays ud i konsollen. Gerne så det ser lidt ud som dette:
            /*
             * Fight Club - 1999
             * Joker - 2019
             * Inglorious Basterds - 2009
             * ...etc.
             */
        }
    }
}
