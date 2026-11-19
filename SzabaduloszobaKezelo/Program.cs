using SzabaduloszobaKezelo;

Console.WriteLine("Adatok beolvasása");
Console.WriteLine();

List<Jatek> jatekok = new List<Jatek>();
string[] sorok = File.ReadAllLines("kemping.txt");

for (int i = 1; i < sorok.Length; i++)
{
    if (!string.IsNullOrWhiteSpace(sorok[i]))
    {
        jatekok.Add(new Jatek(sorok[i]));
    }
}

Console.WriteLine("Rögzített foglalások:");
foreach (Jatek J in jatekok)
{
    Console.WriteLine(J);
}

int osszesvendeg = 0;
int teljesbevetel = 0;
int tartozkodasiido = 0;
Jatek legtobbetfizetovendeg = Jatek[0];

foreach (Jatek J in jatekok)
{
    int fizetendo = J.FizetendoOsszeg();
    teljesbevetel += fizetendo;
    osszesvendeg += J.Jatekosszama;
    tartozkodasiido += J.Idotartamperc;
    if (fizetendo > legtobbetfizetovendeg.FizetendoOsszeg())
    {
        legtobbetfizetovendeg = J;
    }
    if (J.Palyatipus == "klasszikus")
    { }

int atlagoskijutasiido = (int)((double)tartozkodasiido / jatekok.Count + 0.5);

Console.WriteLine();
Console.WriteLine("Összesített statisztika:");
Console.WriteLine($"Kemping teljes bevétele: {teljesbevetel} Ft");
Console.WriteLine($"Összes vendég létszáma: {osszesvendeg} fő");
Console.WriteLine($"Átlagos tartózkodási idő: {tartozkodasiido} éjszaka");
Console.WriteLine($"Legtobbet fizeto csapat: {legtobbetfizetovendeg.Csapatnev} ({legtobbetfizetovendeg.FizetendoOsszeg()} Ft)");