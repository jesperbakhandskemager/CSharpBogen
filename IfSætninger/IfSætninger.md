# Kapitel 3 If Sætninger
I programmering har man tit brug for at analysere det data man har gemt, og tage et valg om hvad man skal gøre. Til dette bruger vi _if sætninger_, som kan tage et valg på baggrund af en boolean værdi.

## If
Mønsteret for en If Sætning ser således ud
```csharp
if(<bool>) {
    //run if true
}
```

Det betyder at med følgende kode kan vi tjekke om værdien af en bool variabel er noget bestemt.
```csharp
bool myBooleanVariable;
if(myBooleanVariable) {
    Console.WriteLine("myBooleanVariable er sat til Sand");
}
```

Ofte tester man dog ikke direkte på boolean variabler. Eksempelvis kan det være man gerne vil sammenligne to variabler for at se om de er ens. Her kan vi bruge vores viden om operatorer til at omdanne de to værdier til én boolean værdi, som i følgende eksempel.
```csharp
int number1 = 15;
int number2 = 15;

//Tjek om de er ens
if(number1 == number2) {
    Console.WriteLine("De to værdier er ens");
}

//Tjek om number1 er mindre end number2
if(number1 < number2) {
    Console.WriteLine("Den ene er mindre end den anden")
}
```

Fordi vi ved at sammenlignings operatorer tager 2 værdier og laver om til én boolean værdi, kan vi konkludere at de kan bruges i if sætninger.

## Else
Nogen gange kan det være nødvendigt at definere noget kode som skal køre hvis en if sætning _ikke_ kører. Til dette kan man udvide en if sætning med en else sætning. Det følger følgende mønster
```csharp
if(<bool>) {
    //run if true
} else {
    //run if false
}
```

Det vil sige at vi kunne udvide ```myBooleanVariable``` eksemplet ovenfra
```csharp
bool myBooleanVariable;
if(myBooleanVariable) {
    Console.WriteLine("myBooleanVariable er sat til Sand");
} else {
    Console.WriteLine("myBooleanVariable er sat til Falsk");
}
//Kun en af de ovenstående linjer vil blive skrevet i konsollen.
```

Koden i else sætningen kører kun hvis den foregående if sætning ikke har evalueret til sand. Med andre ord kan if-koden og else-koden ikke begge to køre.

## Else If
Til mere avanceret logik kan det være nødvendigt at bruge _Else If_. 

```csharp
if(<bool1>) {
    //run if bool1 is true
} else if(<bool2>) {
    //run if bool2 is true
} else {
    //run if neither is true
}
```

Else If igangsætter en ny if sætning efter den foregående er fejlet. Den nye if sætning vil kun lave evaluering hvis den første if sætning er fejlet. Man kan lave flere end en else if i sin sturktur, som i eksemplet herunder. 
```csharp
int n;
if(n < 0) {
    Console.WriteLine("N is very small");
} else if(n < 10) {
    Console.WriteLine("N is small");
} else if(n < 20) {
    Console.WriteLine("N is big");
} else if(n < 30) {
    Console.WriteLine("N is very big");
} else {
    Console.WriteLine("N is really, really big");
}
```