using System;

namespace abstract_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            NewFocus newFocus = new();
            Console.WriteLine(newFocus.HangiMarkanınAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur());
            Console.WriteLine(newFocus.StandartRengiNe().ToString());

            NewCivic newCivic = new();
            Console.WriteLine(newCivic.HangiMarkanınAraci().ToString());
            Console.WriteLine(newCivic.KacTekerlektenOlusur());
            Console.WriteLine(newCivic.StandartRengiNe().ToString());
        }
    }
}