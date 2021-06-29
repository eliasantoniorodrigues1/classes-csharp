using System;

namespace Construtores_de_Classe
{
    class Círculo
{
    private double _Raio;

    public double Raio
    {
        get { return _Raio; }
        set { _Raio = value; }
    }

    public Círculo()
    {
        _Raio = 0;
    }

    public Círculo(int R)
    {
        _Raio = R;
    }
        
    public double CalculaÁrea()
    {
        return Math.PI * Math.Pow(_Raio, 2);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
