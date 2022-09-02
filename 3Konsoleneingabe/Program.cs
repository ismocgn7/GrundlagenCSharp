// See https://aka.ms/new-console-template for more information
string Vorname;
string Alter;
string Klasse;

Console.WriteLine("Geben Sie ihre Daten ein");
Vorname = Console.ReadLine();
Alter = Console.ReadLine();
Klasse = Console.ReadLine();

Console.WriteLine($" {Vorname} ist {Alter} Jahre alt und besucht die {Klasse} des Georg-Simon-Ohm Berufskollegs.");
