using System;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lektion 1 - Variabler

            //bool (Boolean) kan indeholde true og false
            bool isHappy = true;
            bool isTired = false;

            //int (Integer) kan indeholde hele tal, både positive og negative
            int alder = 30;
            int penge = -3000; // :(

            //double (Double Floating-Point Number) kan indeholde kommatal, både positive og negative
            double temperatur = 14.3; //Læg mærke til at man bruger . og ikke , til kommatal. Det er fordi C# er baseret på det engelske nummersystem.

            //string kan indeholde et stykke tekst
            string name = "Mads";
            string hilsen = "Mit navn er Mads";

            //TODO Opgave1: Ændre værdierne i de ovenstående variabler således at de passer med dig, i stedet for med mig.


            //Vi kan bruge Console.Write og Console.WriteLine til at skrive variabler ud i konsollen 
            Console.Write(hilsen);
            Console.Write(". ");
            Console.Write("Jeg er " + alder); //Læg mærke til at man kan plusse ting sammen for at lave en længere sammensat string.
            Console.Write("år gammel.");
            Console.WriteLine();

            //TODO Opgave2: Skriv de 5 ovenstående linjer om, således at man kun bruger Console.Write funktionen EN gang.

            //TODO Opgave3: Ærklær en variabel herunder som kan indeholde antallet af elever i en klasse. Giv den et passende navn.

            //TODO Opgave4: Ærklær en variabel herunder som kan indeholde navnet på en skole. Giv den et passende navn.

            //TODO Opgave5: Ærklær en variabel herunder som kan indeholde vægten på en vare. Giv den et passende navn.

            //TODO Opgave6: Ærklær en variabel herunder som kan holde styr på om du har spist idag eller ej. Giv den et passende navn.

            //TODO Opgave7: Ærklær en variabel herunder som kan indeholde mængden af havregryn i en pose. Giv den et passende navn


            //Når en variabel er oprettet kan man ændre den ved at skrive variablens navn, et ligmed tegn og en værdi.
            penge = 1500; //Læg mærke til at vi ikke skriver 'int' inden.


            //Man kan godt oprette en variabel, uden at give den en værdi.
            int numberOfEmployees;
            string address;
            bool isHungry;

            //Hvis man prøver at bruge unassigned variabler får man fejl. Det kan du prøve ved at fjerne kommenteringen på linjen herunder.
            //Console.WriteLine(numberOfEmployees);

            //TODO Opgave 8: Fix det således at den ovenstående linje virker. Enten ved at ændre på ærklæringen af variablen, eller ved at ændre værdien efter ærklæringen.

        }
    }
}
