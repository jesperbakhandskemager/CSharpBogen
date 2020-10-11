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

Læg mærke til i ovenstående eksempel at vi bruger den sammme linje 2 gange, men fordi variablen har ændret værdi imellem, gør den to forskellige ting. Læg også mærke til at vi ikke skriver typen (```int```) igen, når vi ændrer værdien. Det er fordi vi ikke skal oprette variablen igen, vi ændrer bare en variabel 

### Regler for Identifiers

## Typer

## Værdier

## Hvorfor?