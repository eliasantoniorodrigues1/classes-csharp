using System;

namespace Teoria_e_Exemplo_de_Classes
{

    class Eq2Grau       // Classe para trabalhar com uma Equação do 2º Grau.
    {
        // Encapsulamento de métodos
        private double _a;

        public double a
        {
            get {return _a; }
            set {_a = value;}   
        }

        private double _b;

        public double b
        {
            get {return _b;}
            set {_b = value;}
        }

        private double _c;

        public double c
        {
            get {return _c;}
            set {_c = value;}
        }

        private double _Delta;

        public double Delta
        {
            get {return _Delta;}
            //set { _Delta = value;}  // Nâo pode setar valor para o Delta de forma alguma.
        }

        private double _Raiz1;

        public double Raiz1
        {
            get {return _Raiz1;}
            //set {_Raiz1 = value;}
        }

        private double _Raiz2;

        public double Raiz2
        {
            get {return _Raiz2;}
            //set {_Raiz2 = value;}
        }

        public void CalcDelta()
        {
            _Delta = Math.Pow(b, 2) - 4 * a * c;
        }

        public void CalcRaizes()
        {
            _Raiz1 = (-b + Math.Sqrt(Delta)) / (2 * a);
            _Raiz2 = (-b - Math.Sqrt(Delta)) / (2 * a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Eq2Grau Equacao = new Eq2Grau();

            Console.Write("a = ");
            Equacao.a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            Equacao.b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            Equacao.c = double.Parse(Console.ReadLine());

            Equacao.CalcDelta();  // Calcula o delta
            Console.WriteLine($"\nDelta = {Equacao.Delta:F2}\n");

            if (Equacao.Delta >= 0)
            {
                Equacao.CalcRaizes();       // Calcula Raízes...
                Console.WriteLine($"Raiz 1 = {Equacao.Raiz1:F2}");
                Console.WriteLine($"Raiz 2 = {Equacao.Raiz2:F2}");
            }
            else
            {
                Console.WriteLine($"A Equação não possui Raízes Reais!!!");
            } 

            Console.ReadKey();
        }
    }
}
