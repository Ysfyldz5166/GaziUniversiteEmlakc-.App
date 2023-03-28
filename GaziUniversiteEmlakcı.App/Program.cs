using System;

namespace GaziUniversiteEmlakcı.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ev evim = new Ev();//Ev class'ından bir nesne türetildi.
            //evim.odasayısı = 6;
            //evim.alan = 250;
            //evim.semt = "Gazi";
            //evim.katno = 5;

            //Ev evim2 = new Ev();
            //evim2.katno = 6;
            //evim2.semt = "Gazi";
            //evim2.alan = 100;
            //evim2.odasayısı = 2;
            Ev evim=new Ev();
            Console.WriteLine("Alan bilgisini giriniz");
            evim.alan=int.Parse(Console.ReadLine());
            Console.WriteLine("Kat no giriniz");
            evim.katno=int.Parse(Console.ReadLine());
            Console.WriteLine("semt bilgisini giriniz");
            evim.semt=Console.ReadLine();
            Console.WriteLine("Oda sayısı bilgisini giriniz");
            evim.odasayısı=int.Parse(Console.ReadLine());

            Console.WriteLine(evim.EvBilgileri());
        }

    }

    class Ev
    {
        public Ev()
        {
            // class dan nesne türetildiğinde yapılması gereken işlemleri yapabiliriz.
            //ctor anahtar kelimesini yazıp tab*2 ile getirilebilir.
        }

        public int odasayısı;//field
        public int katno;
        public string semt;
        public int alan;
        public string EvBilgileri() => $"Oda sayısı:{this.odasayısı}\nAIan Sayısı:" +
        $"{this.alan}\nKat no:{this.katno}.)\nSemt: {this.semt}";

    }
}
/*C1ass: Nesnelerin sahip olması gereken özelliklerin ve eylemlerin tanımlandığı kod
bloklarıdır.Classlar aynı zamanda bir veri tipidir*/
/*private: Gizli anlamına gelir. Private üyelere sadece içinde bulunduğu class tarafından
erişilebilir.*/

/* static olarak tanımlanan nesne referansı ile erişilemez, Bu[iyeler nesnelerin
bir parçash o)arak - tanimianırlar.*/
