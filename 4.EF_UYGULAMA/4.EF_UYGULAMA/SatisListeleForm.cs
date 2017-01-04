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
    public partial class SatisListeleForm : Form
    {
        public SatisListeleForm()
        {
            InitializeComponent();
        }

        public int personelId { get; set; }
        public int NakliyeId { get; set; }
        public string MusteriId { get; set; }

        private void SatisListeleForm_Load(object sender, EventArgs e)
        {
            KuzeyYeliDataContext db = new KuzeyYeliDataContext();
            //var sonuc = db.Satislars.Where(x => x.PersonelID == personelId
            //                    && x.MusteriID == MusteriId && x.ShipVia == NakliyeId).Select(x => new { 
            //                    x.SatisID,
            //                    x.PersonelID,
            //                    x.MusteriID,
            //                    NakliyeID = x.ShipVia,
            //                    x.SevkAdi
                                
            //                    });
            var sonuc = db.Satislars.Join(
                db.Personellers,
                sat => sat.PersonelID,
                per => per.PersonelID,
                (satis, personel) => new { satis, personel }).Join(
                db.Musterilers,
                sat => sat.satis.MusteriID,
                mus => mus.MusteriID,
                (x, musteri) => new
                {
                    x.satis.SatisID,
                    x.satis.SatisTarihi,
                    Personel = x.personel.Adi + "" + x.personel.SoyAdi,
                    musteri.SirketAdi,
                    musteri.MusteriID,
                    x.satis.PersonelID,
                    Musteri =x.satis.MusteriID
                }
                ).Where(a => a.PersonelID == personelId && a.MusteriID == MusteriId).Select(a => new {
                    a.SatisID,
                    a.Personel,
                    a.SirketAdi,
                    a.SatisTarihi,
                    a.Musteri
                });

            dataGridView1.DataSource = sonuc;


        }
    }
}
