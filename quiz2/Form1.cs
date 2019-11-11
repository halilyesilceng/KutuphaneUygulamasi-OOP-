using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
     
       Kütüphane kutup = new Kütüphane();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //  int b = Convert.ToInt32(txtISBNNo.Text);
           int b = Convert.ToInt32(txtISBNNo.Text);
          
              Kitap ktb = new Kitap();
            ktb.kitapOzellik = new KitapOzellik(b);
            ktb.AlisTarihi = Convert.ToDateTime(txtAlisTarihi.Text);
            ktb.IadeTarihi = Convert.ToDateTime(txtIadeTarihi.Text);
            ktb.kitapOzellik.KitapAdi = txtKitapAdi.Text;
            ktb.kitapOzellik.Yazar = txtYazar.Text;
            

            kutup.KitapEkle(ktb);
           
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            txtGoster.Text = kutup.KitaplariListele();
        }
    }
}
