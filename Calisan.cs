using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Yapıcı_Metodu
{
    public class Calisan
    {
        private int calisanID { get; set; }

        private string isim { get; set; }

        private string soyisim { get; set; }

        private static int maas { get; set; }

        static Calisan() // Bir kere çalışır ve erişilebilir, Önceliği vardır, parametre almazlar!!! //
        {
            maas = 2500;
        }

        public Calisan(int _calisanID, string _isim, string _soyisim)
        {
            calisanID = _calisanID;
            isim = _isim;
            soyisim = _soyisim;
        }

        public void bilgileriGoster()
        {
            Console.WriteLine("Çalışan Bilgileri ");
            Console.WriteLine("Çalışan Kimliği : " + calisanID);
            Console.WriteLine("İsim : " + isim);
            Console.WriteLine("Soyisim : " + soyisim);
            Console.WriteLine("Maaşı : " + maas);
        }

        public void zamYap(int zamMiktari)
        {
            Console.WriteLine("Çalışana zam yapılıyor...");
            Console.WriteLine("Güncel Maaş : " + (maas + zamMiktari));
        }

    }
}
