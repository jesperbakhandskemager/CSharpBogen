# Ekstra Opgaver

Basseret på den information du har lært fra de andre opgaver og med hjælp fra internettet skal du kunne udføre de følgende opgaver.

## Arrays

- [ ] I denne opgave skal du lave et array, der indeholder navnene på alle i din klasse, giv variablen et passende navn.

Nu skal du bruge et loop af eget valg til at printe alle navnene ud på skærmen. Der må kun bruges 1 Console.WriteLine!

Du kan herefter eventuelt lave et nyt array med elevernes alder, og vis noget som følgende.

Jens - 17 år
Peter - 21 år
Kasper - 18 år

## Lists

C# har en funktion der hedder list, det minder meget om et array men imodsætning til et array som har en statisk størrelse er en liste dynamisk og der kan tilføjes nye opslag som programmet køre videre.

[Official Dokumentation](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1)

Et eksempel på en liste kan ses her
```csharp=
List<string> elever = new List<string>()
{
    "Kasper Madsen",
    "Jonas Mikkelsen",
    "Joe Doe"
}
```

Det er en liste der hedder elever og som indeholder de 3 vædier vi smed i den, de kan så tilgås på samme måde som en array. f.eks.
```csharp=
Console.WriteLine(elever[0])
```
Ville skrive 'Kasper Madsen' ud i terminalen.

Du ville også kunne tilføje flere elever til listen senere hen i koden.
```csharp=
new elever() {"Mike Pence"}
```



### Quiz Spil

- [ ] Du skal nu lave et kort quiz spil, hvor alle spørgsmålene og svar er gemt i en liste.
 
Brugeren vil blive spurgt om et spørgsmål og skal have 2 svar muligheder, et rigtigt svar og et falsk, og skal kunne svare ved at taste 1 eller 2 (eller a/b) på tasteturet.

Der skal være mindst 10 spørgsmål, du bestemmer selv hvilket.

NOTE: Sørg for at de både spørgsmålene og svarene har den samme index værdi.

- [ ] Gør så efter spillet har brugeren mulighed for at tilføje et spørgsmål og de 2 svar muligheder og spille igen hvor de nye svar er med.
- [ ] Indfør et point system, så brugeren vinder når han får 10 point og han taber hvis han svare mere end 3 forkerte.


```This document is released into the public domain, and is licensed under the unlicense```

