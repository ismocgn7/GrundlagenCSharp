//A1
Console.WriteLine(short.MaxValue);
Console.WriteLine(short.MinValue);
/*
    16 Bit
    32767
    -32767
  */

Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);
/*
    * 2147483647
    -2147483648
    */


//A2
string vorname;
string alter;
string frage;

Console.WriteLine("Ich stelle Ihnen jetzt éin Paar Fragen.");
Console.WriteLine("");
Console.WriteLine("1. Wie heißen Sie?");
vorname = Console.ReadLine();
Console.WriteLine("2. Wie alt sind Sie?");
alter = Console.ReadLine();
Console.WriteLine("3. Ist C# die erste Programiersprache, die Sie lernen?");
frage = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("Ihre Antworten:");
Console.WriteLine($"1. {vorname}\n2. {alter}\n3. {frage}");



//A3
/*
 int Dollarzahl = 36;
 char Dollar = Dollarzahl;
 */



//A4
Console.WriteLine("Geben sie die erste Variable ein!");
string v1_str = Console.ReadLine();

short v1_str = Convert.ToInt16(v1_str);