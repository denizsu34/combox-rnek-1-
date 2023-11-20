using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combox_örnek_1_1681
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//formu çalıştırır
            //20 sayıyı burada oluşturabiliriz.metot bilgisi gerekiyor
        }

        private void btnSayılar_Click(object sender, EventArgs e)
        {
            cmbCiftSayilar.Items.Clear();
            //rastgele oluşturulmuş olan sayılar çift olanlarını aktar
            for (int i = 0; i < 20; i++)
            {
            int sayi = Convert.ToInt32(lbSayılar.Items[i]);
                if(sayi % 2 ==0)
               {
                   cmbCiftSayilar.Items.Add(sayi);
               }
            }

                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // rastgele 20 sayı olustur
            Random rnd = new Random();
            for (int i = 0; i < 20; i++) 
            {
lbSayılar.Items.Add(rnd.Next(1,101));
            }
            
        }   
    }
}
