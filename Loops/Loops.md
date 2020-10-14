# Loops

Loops er en nødvnedig del af et hvert programmerings sprog. Der er 3 forskellige former for loops.

Nedenfor kan et eksempel på et for loop ses. I et for loop skal datatypen og variablen oprettes, en betinglse skal laves og en ting der skal gøres efter hver gennemgang.

```csharp=
for (int i = 0; i > 10; i++)
{
Console.WriteLine(i);
}
```
Koden ovenfor ville skrive alle tal fra 1-10.

Et while loop køre mens en given betingelse er opfyldt, og et do while loop er det samme som en while, men køre mindst 1 gang.

Et eksempel på et while loop kan ses nedenfor.

```csharp=
int i = 0;

string[] students = {"Jesper", "Kevin", "Michael", "Josefine", "Signe", "Peter", "Martin", "Gert", "Alfred", "Sigurd", "Tobias", "Mathias" }

// Hvis vi ville skrive alle navnene der er gemt i arraye'et
//  kan vi istedet for at skrive det hele manuelt bruge et loop
//   til at printe dem alle ud

while (i < students.Length)
{
Console.WriteLine(students[i]);
i++;
}
```
Så ovenfor ville loopet køre indtil variablen i var lige så høj som længden på "students" arrayet

Et do while loop kan også bruges i mange tilfælde.

```csharp=
do
            {
                Console.Write("Skriv din alder: ");
                input = Console.ReadLine();
                try
                {
                    n = int.Parse(input);
                    done = true;
                }
                catch
                {
                    Console.WriteLine("Du kan ikke srive bogstaver, prøv igen");
                    done = false;

                }
            } while (done == false);

            Console.WriteLine("Din alder er: " + n);

```

Ovenfor kan et eksempel ses på brugen af et do while loop, hvor brugeren skal indtaste et tal, hvis brugeren derimod indtaster noget andet vil den gå tilbage til prompten indtil han skriver noget gyldigt.
