using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DzienTygodnia pierwszy = DzienTygodnia.Poniedzialek;
            EtapPrania ostatni = EtapPrania.Suszenie;
            Posilek najwazniejszy = Posilek.Sniadanie;
            BierkaSzachowa najsilniejsza = BierkaSzachowa.Hetman;

            Console.WriteLine($"Pierwszy dzień tygodnia to: {pierwszy}");
            Console.WriteLine($"Ostatni etap prania to {ostatni}");
            Console.WriteLine($"Najważniejszy posiłek dnia to {najwazniejszy}");
            Console.WriteLine($"Najsilniejsza bierka szchowa to {najsilniejsza}");
        }
    }
}

enum DzienTygodnia
{
    Poniedzialek,
    Wtorek,
    Sroda,
    Czwartek,
    Piatek,
    Sobota,
    Niedziela
}

enum EtapPrania
{
    Napełnianie,
    PranieWstepne,
    GłównyCykl,
    Płukanie,
    Wirowanie,
    Suszenie
}

enum Posilek
{
    Sniadanie,
    DrugieSniadanie,
    Obiad,
    Podwieczorek,
    Kolacja
}

enum BierkaSzachowa
{
    Pionek,
    Wieza,
    Skoczek,
    Goniec,
    Hetman,
    Krol
}