using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtsiskaitymasNr2
{
    

    class Program
    {
        static void Main(string[] args)
        {
            //1 užduotis

            int[] sveikujuSkaiciuMasyvas = new int[10];
            //arba
            int[] sveikujuSkaiciuMasyvas1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            NelyginiaiMasyvoElementai(sveikujuSkaiciuMasyvas1);

            //2 užduotis
            /* Konstruktorius - metodas, kurio pagalba yra sukuriamas objektas.
             * Jei konstruktorius klasėje nėra aprašomas, jis būna sukuriamas automatiškai.
             * Konstruktorius visada bus tokio pat pavadinimo kaip ir klasė, kurioje jis yra.
             * Konstruktorius susideda iš access-modifier'io (private, public), static arba ne,
             * tipo (data type) - int, string, void ir t.t. ir pavadinimo().
             * 
             * */

            //Pvz.:
            /* public class Klase
             * {
             *      public void Klase() <-- Konstruktorius
             *      {
             *        --Kodas--
             *      }
             *      
             *      --Galima overload'inti konstruktoriu, pvz.:
             *      
             *      public void Klase(int skaicius) <-- Overlaod'intas konstruktorius
             *      {
             *        --Kodas--
             *      }
             *      
             *      --Tokiu atveju, kuriant objekta, galima pasirinkti, kurį konstruktoriaus variantą
             *      naudoti (pass'inant int tipo kintamaji, arba ne)
             * }
             * */

        }

        //3 užduotis

        public static void NelyginiaiMasyvoElementai(int[] masyvas)
        {
            string nelyginiai = string.Empty;

            foreach (var item in masyvas)
            {
                if (item%2 != 0)
                {
                    nelyginiai += item.ToString() + " ";
                }
            }

            Console.WriteLine($"Nelyginiai masyvo skaiciai: {nelyginiai}");
        }
    }

    //4 užduotis

    public class Mokykla
    {
        public int klasesSkaicius;
        public char klasesRaide;
        public int mokiniuSkaicius;
        public DateTime mokymosiPradziosMetai;
               
        public TimeSpan KiekLaikoMokosi(DateTime pradziosMetai)
        {
            mokymosiPradziosMetai = pradziosMetai;

            return DateTime.Today.Subtract(pradziosMetai);
        }

    }

    //5 užduotis

    public class Klase : Mokykla
    {
        public List<int> mokiniuVardai;
        public double[] vidurkiai;
    }
}
