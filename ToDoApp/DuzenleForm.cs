using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class DuzenleForm : Form
    {
        private readonly Mesaj _msj;

        public DuzenleForm(Mesaj msj)
        {
            _msj = msj;
            InitializeComponent();
            txtYapilan.Text = _msj.Metin;
            dtpZaman.Value = _msj.OlusturmaZamani.Value;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AnaForm af = new AnaForm();
            string metin = txtYapilan.Text;
            if (metin == "")
            {

                MessageBox.Show("Düzenlemek istediğiniz metni girin..");
                return;
            }

            if (_msj == null)
            {

                txtYapilan.Text = _msj.Metin;
                dtpZaman.Value = _msj.OlusturmaZamani.Value;
            }
            else
            {
                _msj.Metin = txtYapilan.Text;
                _msj.OlusturmaZamani = dtpZaman.Value;
            }

                af.lstYapilanlar.SelectedItem = _msj;
            Close();
        }
    }
}
