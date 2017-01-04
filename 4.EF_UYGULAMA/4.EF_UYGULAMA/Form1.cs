using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _4.EF_UYGULAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KuzeyYeliDataContext db = new KuzeyYeliDataContext();
            dgv_urunler.DataSource = db.Urunlers;
            cmb_Musteri.DataSource = db.Musterilers;
            cmb_Musteri.DisplayMember = "SirketAdi";
            cmb_Musteri.ValueMember = "MusteriID";
            cmb_Nakliye.DataSource = db.Nakliyecilers;
            cmb_Nakliye.DisplayMember = "SirketAdi";
            cmb_Nakliye.ValueMember = "NakliyeciId";
            //cmb_personel.DataSource = from per in db.Personellers
            //                          select new { 
            //                          per.PersonelID,
            //                          AdSoyad = per.Adi+""+per.SoyAdi
                                      
            //                          };
            cmb_personel.DataSource = db.Personellers.Select(per => new { 
                                                              per.PersonelID,
                                                              AdSoyad = per.Adi+""+per.SoyAdi
            
                                                            });
            cmb_personel.DisplayMember = "AdSoyad";
            cmb_personel.ValueMember = "PersonelId";
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (dgv_urunler.CurrentRow == null)
                return;
            DataGridViewRow row =dgv_urunler.CurrentRow;
            ListViewItem li = new ListViewItem();
            li.Text = row.Cells["UrunAdi"].Value.ToString();
            li.SubItems.Add(row.Cells["Fiyat"].Value.ToString());
            li.SubItems.Add(num_Adet.Value.ToString());
            li.SubItems.Add(num_indirim.Value.ToString());
            li.Tag = row.Cells["UrunID"].Value;

            if((short)row.Cells["Stok"].Value<num_Adet.Value)
                MessageBox.Show("Dikkat Stokta Yeteri Kadar Yok");

            list_urunler.Items.Add(li);

            num_indirim.Value = 0;
            num_Adet.Value = 1;


            

        }

        private void btn_SipOnayla_Click(object sender, EventArgs e)
        {
            if (cmb_Musteri.SelectedItem == null || cmb_Nakliye.SelectedItem == null || cmb_personel.SelectedItem == null)
            {
                MessageBox.Show("Eksik bilgi");
                return;
            }
            KuzeyYeliDataContext db = new KuzeyYeliDataContext();

            Satislar satis = new Satislar();
            satis.SatisTarihi = DateTime.Now;
            satis.MusteriID = cmb_Musteri.SelectedValue.ToString();
            satis.PersonelID = (int)cmb_personel.SelectedValue;
            satis.ShipVia = (int)cmb_Nakliye.SelectedValue;


            db.Satislars.InsertOnSubmit(satis);

            db.SubmitChanges();

            foreach (ListViewItem item in list_urunler.Items)
            {
                SatisDetay sd = new SatisDetay();
                sd.SatisID = satis.SatisID;
                sd.UrunID = (int)item.Tag;
                sd.Fiyat = decimal.Parse(item.SubItems[1].Text);
                sd.Adet = short.Parse(item.SubItems[2].Text);
                sd.Indirim = float.Parse(item.SubItems[3].Text) / 100;

                db.SatisDetays.InsertOnSubmit(sd);
                db.SubmitChanges();

                list_urunler.Items.Clear();
                cmb_Musteri.SelectedIndex =cmb_Nakliye.SelectedIndex = -1;

                
            }


                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SatisListeleForm form = new SatisListeleForm();
            form.NakliyeId = (int)cmb_Nakliye.SelectedValue;
            form.MusteriId = cmb_Musteri.SelectedValue.ToString();
            form.personelId = (int)cmb_personel.SelectedValue;
            form.Show();
        }
    }
}
