# Kapitel 1: Variabler

Variabler kan bruges af programmer til at gemme data. I dette kapitel vil vi sammen gennemgå hvordan man opretter (eller 'ærklærer') variabler, hvilke forskellige typer af variabler der er til rådighed i C# og hvordan man giver data.

## Ærklæring
For at man kan bruger variabler i C# skal man først ærklære dem (på engelsk "declare"). Hvis man f.eks. vil lave en variabel som gemmer et tal, skriver man følgende.
```csharp
int age = 30;
````
Der sker meget i det ovenstående eksempel. I korte termer gør linjen at vi opretter en heltals (på engelsk, "integer") variabel og giver den værdien 30. Variabel ærklæringer følger typisk dette mønster
```
<type> <identifier> = <value>;
````
"type" er hvilken type data vi gerne vil gemme i vores variabel. Det kommer vi tilbage til. "identifier" er navnet på variablen, så vi kan bruge den senere i koden. Og "value" er den værdi vi gerne vil have variablen har.

Når en variabel er ærklæret kan vi bruge den senere i koden.
```csharp
int age = 30;
Console.WriteLine("Jeg er " + age + " år gammel");
//"Jeg er 30 år gammel"
```

Vi kan også godt oprette en variabel uden at give den en værdi. Men i det tilfælde forventer programmet at vi giver den en værdi _inden_ vi bruger variablen, som i eksemplet herunder.
```csharp
int age;
Console.WriteLine("Jeg er " + age + " år gammel"); //Programmet vil crashe på denne linje
```
Vær derfor varsom hvis du vælge at bruge unassigned variabler. 

## Ændring af variabler
Man kan derefter ændre variablens værdi, ved at give den en ny med '=' tegnet.

```csharp
int age = 30;
Console.WriteLine("Jeg er " + age + " år gammel");
age = 13;
Console.WriteLine("Jeg er " + age + " år gammel");
//"Jeg er 30 år gammel"
//"Jeg er 13 år gammel"
```

Læg mærke til i ovenstående eksempel at vi bruger den sammme linje 2 gange, men fordi variablen har ændret værdi imellem, gør den to forskellige ting. Læg også mærke til at vi ikke skriver typen (```int```) igen, når vi ændrer værdien. Det er fordi vi ikke skal oprette variablen igen, vi ændrer bare på variablens værdi. 

### Regler for Identifiers

Du kan selv vælge dine identifiers. Med andre ord, hvad variablen skal hedde. Der er dog nogle regler som er gode at have i mente når du gør:

 - Identifiers må ikke starte med et tal (f.eks. ```3rdClient```, ```42```, ```2ndNumber```)
   - Identifiers må godt indeholde tal senere dog  (f.eks. ```client3```, ```number2```)
 - Identifiers må ikke være det samme som et C# keyword (f.eks. ```if```, ```class```, ```namespace```, etc.)
   - [Denne side har et liste over alle C# keywords](https://www.programiz.com/csharp-programming/keywords-identifiers)
 - Identifiers må ikke starte med symboler (f.eks. ```#age```, ```$balance```, etc.)
 - Identifiers er case-sensitive (Ergo, er ```myname``` og ```myName``` to forskellige værdier)
 - Man kan ikke have mellemrum i en identifier.

Udover hårde regler som i listen ovenover, så er der nogle forslag til god kutyme når man laver identifiers.

 - Indiker ordopdeling (skriv ikke f.eks. ```numberofstudents```)
   - Brug enten camelCase (```numberOfStudents```)
     - camelCase er det anbefalede til C#
   - Eller hyphen-case (```number-of-students```)
     - anbefalet i mange web-sprog
 - Start altid variabel identifiers med lower-case (altså ikke ```NumberOfStudents```)
   - Man bruger identifiers med upper-case startbogstav til andre typer objekter i C#, men det kommer vi tilbage til.
 - Din identifier skal beskrive din variabels formål så godt som muligt.

Hvis man følger mønsteret ovenfor når man laver variabler, så er det nemmere for andre der skal bruge din kode at læse.

## Typer
Variabler i C# kan være forskellige typer. Når vi snakker om typer i programmering, så refererer man til hvilken for for data vi har. I eksemplet ovenfor har vi ```int``` typen. Men en værdi af typen int kan kun holde hel-tal. Der er rigtig mange andre typer man kan bruge i C#. I denne bog kommer vi for det meste til at beskæftige os med ```int```, ```string```, ```bool``` og ```double```.

### int
int kommer af det engelske ord _Interger_ som betyder _heltal_. Med andre ord kan en int variabel indeholde et enkelt heltal. Dette tal må gerne være negativt. Når man skal give en værdi til en int varibel skriver man simpelthen blot et tal.

__Eksempler__
```csharp
int fortyTwo = 42;
int negativeNumber = -13;
int zipCode = 9400;
```

### string
string er en type der indikere at noget data er en såkaldt __tekststreng__. I almindelig snak er der tale om at en string kan indeholde et stykke tekst. Man indikerer en string ved at skrive sin tekst i mellem double-qoutes (```" "```).

__Eksempler__
```csharp
string name = "Mads";
string greeting = "Hello, my name is Mads";
string emptyString = "";
```
### bool
bool er en booleansk værdi, hvilket betyder at det er en værdi som kan være enten true eller false. Kun de to værdier. Dette er rigtig smart senere når vi skal arbejde med if-sætninger. Man indikere true eller false, ved at skrive den tekst _uden_ double qoutes. Man skal ikke skrive qoutes for at indikere at det _ikke_ er en string.

__Eksempler__
```csharp
bool isRaining = false;
bool isSunny = true;
```
### double
double indeholder ligesom int et tal. Dette tal kan dog godt være et komma-tal. Man indikerer en double ved at skrive et tal med et ```.``` som komma. Man bruger komma, da man i C# bruger engelsk decimal notation.

__Eksempler__
```csharp
double temperature = 7.2;
double temperatureInGreenland = -3.4;
double fuelLeft = 3.0;
```

### Andre Typer
Du kan komme ud for nogle andre typer, enten når man læser dokumentation, eller senere i din uddannelse. Grunden til at vi fokuserer på de fire beskrevet ovenfor er for at holde et skarpt fokus på at blive god til et sæt variabler som virker i næsten alle sammenhænge. Det er dog godt at vide følgende:

 - ```float``` er ligesom en double, men den er ikke lige så præcis. Nogle gamle libraries bruger den stadig.
 - ```uint``` er ligesom en int, men den kan ikke indeholde negative værdier. Kaldes en unsigned integer.
   - ```udouble``` er samme historie.
 - ```char``` er en type data som indeholder ét bogstav. I modsætning til string som kan indeholde et vilkårligt antal bogstaver.
 - ```byte``` er en int som kun kan indeholde værdierne 0-255.

## Konstanter
Man kan gøre sin variabel konstant ved at skrive ```const``` keywordet foran ærklæringen.
```csharp
const int age = 30;
Console.WriteLine("Jeg er " + age + " år gammel");
//"Jeg er 30 år gammel"
```
Det betyder at man så ikke kan ændre den senere. Det nedenstående kode vil f.eks. ikke køre.

```csharp
const int age = 30;
Console.WriteLine("Jeg er " + age + " år gammel");
age = 13; //Programmet vil crashe her.
Console.WriteLine("Jeg er " + age + " år gammel");
```

Konstanter er gode hvis man skal huske noget data som ikke skal ændre sig.