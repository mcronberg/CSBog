Console.WriteLine("Start på C#");
Console.WriteLine("-----------");

Console.WriteLine();
Console.WriteLine("Variabler");
// Forskellige variabler
int a = 100;
int b = 0;
string c = "Test";
bool d = true;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);

Console.WriteLine();
Console.WriteLine("Betingelse");

// betingelse
if (a > 100)
{
    Console.WriteLine("a > 100");
}
else
{
    Console.WriteLine("a <= 100");
}

Console.WriteLine();
Console.WriteLine("Løkke");

// løkke
do
{
    Console.WriteLine(a);
    a++; // eller a++
} while (a < 105);


Console.WriteLine();
Console.WriteLine("Fejlhåndtering");

// fejlhåndtering
try
{
    int r = a / b;  // ups - dividering med 0
}
catch (Exception ex)
{
    Console.WriteLine("Der er sket en fejl : " + ex.Message);
}

Console.WriteLine();
Console.WriteLine("Min egen terning");
Terning t = new ();
Console.WriteLine(t.Værdi);
t.Ryst();
Console.WriteLine(t.Værdi);

// ----------------------------------------
// Tilføj eventuelt lidt mere avancerede
// eksempler på objekt- og
// funktionsorienteret kode.
// ----------------------------------------

// Brug af funktionsorienteret kode
// Her er det især brugen af en lambda funktion (=>)
// og at Timer-klassen benytter en såkaldt delegate
// som består af en reference til en funktion som 
// afvikles hvert sekund.
Console.WriteLine();
Console.WriteLine("Funktionsorienteret kode");
Timer timer = new (s => Console.WriteLine("Tik/Tak"), null, 0, 1000);

// Afventer at brugeren klikker på en knap
Console.ReadKey();


// Din egen type som repræsenterer en terning.
// Her er der tale om en klasse (class) men det kunne
// også have været en struktur (struct)
class Terning
{
    public int Værdi { get; set; }
    public void Ryst()
    {
        this.Værdi = new Random().Next(1, 7);
    }
    public Terning()
    {
        this.Ryst();
    }
}