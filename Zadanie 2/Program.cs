using System;

namespace Zadanie_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var autor_programu = new Student();
            autor_programu.Imie = "Kamil";
            autor_programu.Nazwisko = "Lukaszewicz";
            autor_programu.NumerIndeksu = 146101;
            autor_programu.Kierunek = "Informatyka";
        }
    }
}

public struct Student
{
    public string Imie;
    public string Nazwisko;
    public int NumerIndeksu;
    public string Kierunek;
}

public struct Przedmiot
{
    public string Nazwa;
    public string Wydzial;
    public string Prowadzacy;
}

public struct NauczycielAkademicki
{
    public string Imie;
    public string Nazwisko;
    public string TytulNaukowy;
    public string Wydzial;
}
