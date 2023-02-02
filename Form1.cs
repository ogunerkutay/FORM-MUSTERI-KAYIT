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
    public partial class Form1 : Form
    {
        public static Dictionary<int, Musteriler> musteriDictionary;
        
        public Form1()
        {
            InitializeComponent();
            musteriDictionary = new Dictionary<int, Musteriler>();
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Müşteri No : " + musteriDictionary[listBox1.SelectedIndex].musteriNo + "\nAdı Soyadı : " + musteriDictionary[listBox1.SelectedIndex].adSoyad + "\nDoğum Günü : " + musteriDictionary[listBox1.SelectedIndex].dogumTarihi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form form2 = new Form2(musteriDictionary);

            form2.ShowDialog();

            listBox1.Items.Clear();
            for (int i = 0; i < musteriDictionary.Keys.Count; i++)
            {
                listBox1.Items.Add(musteriDictionary[i].adSoyad);
            }
        }

    }
}
