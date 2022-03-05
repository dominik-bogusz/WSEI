using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek u1 = new Ulamek();
        }
    }

    public class Ulamek
    {
        private int licznik { get; }
        private int mianownik { get; }

        public Ulamek(){}

        public Ulamek(int licznik, int mianownik){}

        public Ulamek(Ulamek zadanie)
        {
            licznik = zadanie.licznik;
            mianownik = zadanie.mianownik;
        }

        public static Ulamek operator +(Ulamek licznik) => licznik;
        public static Ulamek operator -(Ulamek licznik) => licznik;
        public static Ulamek operator *(Ulamek a, Ulamek b)
            => new Ulamek(a.licznik * b.mianownik, b.licznik * a.mianownik);
        public static Ulamek operator /(Ulamek a, Ulamek b)
            => new Ulamek(a.licznik / b.mianownik, b.licznik / a.mianownik);

        public void ToString() { }

        

        public interface IEquatable{}
        public interface IComparable { }
    }
}
