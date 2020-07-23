using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Ürün Adı", 150);
            listView1.Columns.Add("Ek Maddeler", 150);
            string[] ürün = { "Rize Usulü Siyah Çay", "Rize Usulü Yeşil Çay", "Çin Usulü Siyah Çay", "Çin Usulü Yeşil Çay" };
            comboBox1.Items.AddRange(ürün);
            string[] ek = { "Şeker", "Tomurcuk", "Karanfil", "Limon" };
            comboBox2.Items.AddRange(ek);
            kayitsayisiyaz();
        }

        private void kayitsayisiyaz()
        {
            int kayitsayisi = listView1.Items.Count;
            label4.Text = Convert.ToString(kayitsayisi);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ürün = "", ek = "";
            ürün = comboBox1.Text; ek = comboBox2.Text;

            string[] bilgiler = { ürün, ek };
            bool aranankayitkontrolü = false;

            if (aranankayitkontrolü == false)
            {
                ListViewItem lst = new ListViewItem(bilgiler);
                if (ürün != "" && ek != "")
                {
                    listView1.Items.Add(lst);

                }
                else
                {
                    MessageBox.Show("Kayıt bilgilerinde eksiklik var! Tekrar deneyiniz!");
                }
            }
            kayitsayisiyaz();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secilensayisi = listView1.CheckedItems.Count;
            foreach (ListViewItem secilikayitbilgisi in listView1.CheckedItems)
            {
                secilikayitbilgisi.Remove();
            }

            MessageBox.Show(secilensayisi.ToString() + " Adet Kayıt Silindi.");
            kayitsayisiyaz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secilensayisi = listView1.SelectedItems.Count;
            foreach (ListViewItem secilikayitbilgisi in listView1.SelectedItems)
            {
                secilikayitbilgisi.Remove();
            }

            MessageBox.Show(secilensayisi.ToString() + " Adet Kayıt Silindi.");
            kayitsayisiyaz();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            kayitsayisiyaz();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true; comboBox2.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
