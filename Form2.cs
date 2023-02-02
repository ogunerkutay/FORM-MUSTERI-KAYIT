using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_MUSTERI_KAYIT
{
    public partial class Form2 : Form
    {
        int musteriSayisi;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Dictionary<int, Musteriler> musteriSayisi)
        {
            InitializeComponent();
            this.musteriSayisi = musteriSayisi.Keys.Count;
        }



        private void buttonListeyeDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void buttonKayit_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            musteri.musteriNo = musteriSayisi;
            musteri.adSoyad = textBoxAdSoyad.Text.ToLower().Trim();
            musteri.dogumTarihi = dateTimePicker1.Value.ToString("hh:mm:ss tt dd/MM/yyyy");

            try
            {    
                Form1.musteriDictionary.Add(musteri.musteriNo, musteri);
                musteriSayisi++;
            }
            catch (Exception)
            {
                MessageBox.Show("Bu müşteriNo'suna sahip müşteri mevcut!");
            }

        }
    }
}
