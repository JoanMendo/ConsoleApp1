using System;

namespace Ex4
{
    public class program
    {
        public static void Main ()
        {
            

            Console.WriteLine($"L'àrea del quadrat és {Rectangle(Amplitud(), Altura())}.");

            Console.WriteLine($"L'àrea del rectangle és {Rectangle(Amplitud(), Altura())}.");

            Console.WriteLine($"L'àrea del cercle és {Cercle()}.");

            Console.WriteLine($"L'àrea del pentàgon és {Pentagon(Amplitud(), Apotema())}.");





        }

        public static decimal Amplitud()
        {
            const string Amplitud = "Introdueix la base de la figura";
            Console.WriteLine(Amplitud);
            return (Convert.ToDecimal(Console.ReadLine()));
        }


        public static decimal Altura()
        {
            const string Altura = "Introdueix l'altura de la figura";
            Console.WriteLine(Altura);
            return (Convert.ToDecimal(Console.ReadLine()));

        }
        public static decimal Apotema()
        {
            const string Apotema = "Introdueix l'apotema de la figura";
            Console.WriteLine(Apotema);
            return (Convert.ToDecimal(Console.ReadLine()));

        }
        public static double Cercle()
        {
            const double PI = 3.1415926535897931;
            const string Radi = "Introdueix el radi de la figura";
            Console.WriteLine(Radi);
            return Convert.ToDouble(Console.ReadLine()) * PI;
        }
        public static decimal Rectangle(decimal amplitud, decimal altura)
        {
            decimal area = amplitud * altura;
            return area;
        }
        public static decimal Pentagon(decimal amplitud, decimal apotema)
        {
            decimal area = ((amplitud * 5) * apotema)/2;
            return area;
        }
    }
}
