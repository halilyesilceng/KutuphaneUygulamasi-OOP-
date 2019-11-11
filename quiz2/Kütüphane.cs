using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
   public class Kütüphane
    {
        public List<Kitap> KitapListesi { get; set; } = new List<Kitap>();
        
        public void KayıtlariSil(Kitap k)
        {
            KitapListesi.Remove(k);

        }
        public void KitapEkle(Kitap k)
        {
            KitapListesi.Add(k);
        }
        public string KitaplariListele()
        {

            string bilgi = "";

            foreach (Kitap ktb in KitapListesi)
            {
                bilgi+= "\nİSBN :" + ktb.kitapOzellik.ISBN+"Kitap Adı :" +ktb.kitapOzellik.KitapAdi + "Yazar :"+ktb.kitapOzellik.Yazar+ "Alış Tarihi :"+ktb.AlisTarihi.ToShortDateString()+"İade Tarihi:"+ktb.IadeTarihi.ToShortDateString();
            }

            return bilgi;
        }



    }
}
