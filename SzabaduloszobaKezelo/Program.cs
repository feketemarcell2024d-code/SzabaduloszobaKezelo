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

int osszesvendeg = 0;
int teljesbevetel = 0;
int tartozkodasiido = 0;
int legtobbetfizetovendeg = jatekok.Max(x =>x.FizetendoOsszeg());

foreach (Jatek J in jatekok)
{
    int fizetendo = J.FizetendoOsszeg();
    teljesbevetel += fizetendo;
    osszesvendeg += J.Jatekosszama;
    tartozkodasiido += J.Idotartamperc;
    if (fizetendo > legtobbetfizetovendeg.())
    {
        legtobbetfizetovendeg = J;
    }
    if (J.Palyatipus == "klasszikus")
    { }

int atlagoskijutasiido = (int)((double)tartozkodasiido / jatekok.Count + 0.5);

Console.WriteLine();
Console.WriteLine("Összesített statisztika:");
Console.WriteLine($"teljes bevétele: {teljesbevetel} Ft");
Console.WriteLine($"Összes jatekos létszáma: {osszesvendeg} fő");
Console.WriteLine($"Átlagos tartózkodási idő: {tartozkodasiido} éjszaka");
Console.WriteLine($"Legtobbet fizeto csapat: {legtobbetfizetovendeg.Csapatnev} ({legtobbetfizetovendeg.FizetendoOsszeg()} Ft)");