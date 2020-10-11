# Kapitel 2 Operatorer
I C# kan vi bruge operatorer til at lave forskellige former for udregninger. En stor del af styrken ved computersoftware er muligheden for at lave mange udregninger, så det er vigtigt at lære. I dette kapitel vil vi gennemgå de vigtigste aritmiske, boolske og sammenlignings operatorer.

Fælles for de operatorer som vil blive gennemgået i dette kapitel er at de kombinerer 2 værdier og laver en tredje værdi. 

## Aritmiske operatorer
Den første samling operatorer er let-genkendelige fra matematikken. Disse operatorer tager to værdier og returnerer det tilsvarende matematiske resultat heraf.

| Operator | Resultat                                                         | Eksempel                      |
| -------- |:----------------------------------------------------------------:| -----------------------------:|
| +        | summen af to værdier                                             | ```int sum = 2 + 2;```        |
| -        | den ene værdi trukket fra den anden                              | ```int subtrahend = 3 - 3;``` | 
| *        | to værdier ganget med hinanden                                   | ```int product = 4*4;```      |
| /        | den ene værdi dividere med den anden                             | ```int dividend = 5/5;```     |
| %        | divisions-resten efter en division af de to (se modolo herunder) | ```int remainder = 6%6;```    |

Som du kan se fra eksemplerne herover kan man gemme resultatet af en udregning i en variabel. Man kan også bruge variabler i en udregning, i stedet for faste værdier.

```csharp
int number = 25;
int sum = 7 + number;
Console.WriteLine(sum);
//32
```

### Modolo
Modolo(%) er en særlig aritmisk operator, som returnerer resten efter heltals-division, i stedet for det normale resultat. Tag for eksempel regnestykket ```6 / 4```. Resultatet af denne division er ```1.5```, men når man arbejder med heltal kan man ikke få et heltal. Derfor vil følgende kode give 1, fordi den runder ned til nærmeste heltal automatisk:
```csharp
int number = 6 / 4; //1
```
Men der vil være en rest på 2 efter den division. Det er den del af 5 som ikke er blevet taget med i divisionen endnu. Derfor vil man kunne udvide koden
```csharp
int number = 6 / 4; //1
int remainder = 6 % 4; //2
```
### Regnehierakiet
Man kan sagtens bruge flere operatorer i samme expression. På den måde kan man lave længere mere komplicerede udregninger.
```csharp
int complexCalculation = 5 + 3 * 2; //11
```
complexCalculation vil, efter den linje, være 11. Det er fordi at C# følger reglerne for regnehierakiet. Det vil sige at gange og dividere bliver udregnet før plus og minus. Man kan dog bruge parantes til at prioritere nogle udregninger før andre.
```csharp
int complexCalculation = (5 + 3) * 2; //16
```


[En fuld liste over hierakiet af operatorer i C#](https://www.tutorialspoint.com/csharp/csharp_operators_precedence.htm)

### String Interpolation

\+ operatoren kan også bruges til at sætte strings sammen med. Det vil sige at man kan sætte strings på enden af andre strings på følgende måde.
```csharp
string text1 = "C# er";
string text2 = "sjovt!";
string interpolatedText = text1 + " " + text2;//C# er sjovt!
```
Det kaldes også _string interpolation_

## Sammenlignings operatorer
De følgende operatorer bruges til at sammenligne to værdier, og returnere en boolean værdi, dvs. true eller false.

| Operator | Er true hvis...                                       | 
| -------- |:-----------------------------------------------------:| 
| ==       | begge værdier er ens                                  | 
| !=       | begge værdier _ikke_ er ens                           | 
| <        | den første værdi er mindre end den                    | 
| <=       | den første værdi er mindre end eller ligmed den anden | 
| >        | den første værdi er større end den anden              | 
| >=       | den første værdi er større end eller ligmed den anden | 

Det vil sige at man kan få følgende boolean værdier
```csharp
bool one   = 3 < 5; //true
bool two   = 4 == 4; //true
bool three = 4 == 5; //false
bool four  = 3 >= 3; //true
```
Disse er vigtige at være god til når man skal blive god til if-sætninger.

## Boolske operatorer
Disse operatorer bruges til at sammenligne 2 boolean værdier, og resultatet af dem er også en boolean værdi.

| Operator | Også Kaldt | Er true hvis...                              | 
| -------- |:----------:| --------------------------------------------:|
| &&       |AND         | begge værdier er true                        | 
| \|\|     |OR          | mindst en af værdierne er true               | 
| ^        |XOR         | præcis en af værdierne er true               | 
| !        |NOT         | efterfølgende værdi er false(kun en værdi)   | 

Det vil sige at man kan få følgende booleans.
```csharp
bool one   = true && false; //false
bool two   = true || false ; //true
bool three = true ^ true; //false
bool four  = !true; //false
```