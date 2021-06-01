using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class AnaForm : Form
    {
        List<Mesaj> mesajlar = new List<Mesaj>();
        Mesaj msj;

        public AnaForm()
        {
            VerileriOku();
            InitializeComponent(); 
            Listele();
        }

        private void VerileriOku()
        {
            try
            {
                // verileri oku ve deserialize et
                string json = File.ReadAllText("data.json");
                mesajlar = JsonSerializer.Deserialize<List<Mesaj>>(json);


            }
            catch (Exception)
            {
                mesajlar = new List<Mesaj>();
                Listele();
            }
          
        }

        private void Listele()
        {
            lstYapilanlar.Items.Clear();
            foreach (var item in mesajlar)
            {
                lstYapilanlar.Items.Add(item);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtMesaj.TextLength == 0)
            {
                MessageBox.Show("Metin ekranı boş olduğundan ekleme yapılamaz,Lütfen eklenicek metni girin..");
                return;
            }

            Mesaj msj = new Mesaj();
            msj.Metin = txtMesaj.Text;
            if (dtpAnaForm.Checked == true)
            {
                msj.OlusturmaZamani = dtpAnaForm.Value;
            }
            else if (dtpAnaForm.Checked == false)
            {
                msj.OlusturmaZamani = DateTime.Now;
            }
            mesajlar.Add(msj);
            mesajlar.Sort();
            Listele();
            txtMesaj.Clear();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstYapilanlar.SelectedItem == null)
            {
                MessageBox.Show("Herhangi bir şey seçilmeden düzenleme yapılamaz,Lütfen bir satır seçin..");
                return;
            }
            new DuzenleForm((Mesaj)lstYapilanlar.SelectedItem).ShowDialog();
            Listele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstYapilanlar.SelectedItem == null)
            {
                MessageBox.Show("Herhangi bir şey seçilmeden silme işlemi yapılamaz,Lütfen bir satır seçin..");
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show(
                   "Seçili satır silinecektir,Onaylıyor Musunuz?",
                   "Satır Silme Onayı",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation,
                   MessageBoxDefaultButton.Button2
                   );
                if (dr == DialogResult.Yes)
                {
                    mesajlar.Remove((Mesaj)lstYapilanlar.SelectedItem);
                    Listele();
                }
            }
        }


        private void btnYildizla_Click(object sender, EventArgs e)
        {
            if (lstYapilanlar.SelectedItem != null)
            {
                Mesaj m = (Mesaj)lstYapilanlar.SelectedItem;
                m.YildizliMi = !m.YildizliMi;
                Listele();
            }
            else
            {
                MessageBox.Show("Herhangi bir şey seçilmeden yıldızlama yapılamaz,Lütfen bir satır seçin..");
                return;
            }
        }

        private void cbYildizlariGöster_CheckStateChanged(object sender, EventArgs e)
        {
            lstYapilanlar.Items.Clear();
            foreach (var item in mesajlar)
            {
                if (item.ToString().Contains("★"))
                {
                    lstYapilanlar.Items.Add(item);
                }
            }

            if (cbYildizlariGöster.Checked == false)
            {
                Listele();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtMesaj.Text;
            string zaman = dtpAnaForm.Value.ToString();

            lstYapilanlar.Items.Clear();
            foreach (var item in mesajlar)
            {
                if (item.ToString().ToLower().Contains(aranan.ToLower()) || item.ToString().ToLower().Contains(zaman.ToLower()))
                {
                    lstYapilanlar.Items.Add(item);
                }
            }

            if (aranan==null)
            {
                Listele();
            }
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();

        }

        private void VerileriKaydet()
        {
            var options = new JsonSerializerOptions() { WriteIndented = true }; 
            string json = JsonSerializer.Serialize(mesajlar, options);
            File.WriteAllText("data.json", json);
        }
    }
}
