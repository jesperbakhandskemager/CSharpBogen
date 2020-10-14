# Kapitel 4: Arrays

Med de typer af variabler vi har brugt indtil videre kan man gemme mange ting. Dog kan man kun med disse typer kun lave variabler der kan gemme en ting ad gangen. I dette kapitel vil vi introducere en ny særlig type, som hedder Array, som kan gemme på flere af den samme type værdi.

## Uden Arrays
Lad os sige at vi har en case der hedder at vi skal gemme alle navnene på elever i en klasse. Hvis vi ikke kan bruge arrays vil vi ende med at gøre noget i den her stil:
```csharp
int student1 = "Mads";

int student2 = "Jakup";

int student3 = "René";
```
For et så begrænset eksempel som det ovenstående vil det måske være fint nok. Men den løsning skalerer ikke så godt. Når man skal samle flere ting af den samme type data, så er det bedre at bruge arrays.

## Ærklære Arrays
Et array er en samling (_collection_), som betyder det er en datatype som kan indeholde mere end én værdi. Når man ærklærer et array skal man vide på forhånd hvor mange værdier man skal have plads til i arrayet. Mønsteret for at oprette et array er det følgende:
```csharp
<type>[] <identifier> = new <type>[<length>]
````
Med vores ovenstående case vil vi derfor skulle skrive:
```csharp
int[] students = new int[3];
````
Altså skal vi oprette et array der kan indeholde ints, og gøre plads til 3 værdier deri.

## Array I/O
Når man har oprettet et array kan man begynde at fylde data deri, således:
```csharp
int[] students = new int[3];
students[0] = "Mads";
students[1] = "Jakup";
students[2] = "René";
````
Læg mærke til konstruktionen at vi skriver arrayets identifier og bruger _square brackets_ bagefter til at indikere at vi vil tilgå en værdi inde i arrayet. Det tal vi skriver inde i disse square brackets er det _index_ som vi gerne vil indgå. Arrays i C# starter ved index 0. Det vil sige at vi bruger index 0 til at tilgå første plads i arrayet, 1 til at tilgå anden plads, og så videre.

Vi bruger samme konstruktion hvis vi vil læse værdierne i et array:
```csharp
Console.WriteLine(students[0]);
Console.WriteLine(students[1]);
Console.WriteLine(students[2]);
/*
Mads
Jakup
Renè
*/
```
Det at bruge arrays minder derfor om den måde vi allerede arbejder med variabler på.

## Hvorfor
Vi bruger arrays i C# for at samle data under et navn, i stedet for at samle det under flere navne. Det vil gøre det nemmere at arbejde med dataen, især når vi introducerer løkker i et senere kapitel. For nu, så bare vid at vi bruger arrays til at samle data af samme type under et navn. 
