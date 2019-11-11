using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    public class KitapOzellik
    {

        public string Yazar { get; set; }
        public string KitapAdi { get; set; }
        public  int ISBN{ get;private set; }
        public KitapOzellik(int b)
        {
            this.ISBN = b;
        }
       /* public KitapOzellik(b)
        {
            this.kitapOzellik.ISBN = b;
        }*/
    }
}
