using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WFKuzeyYeli.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        ProjeContext.ProjeContext db = new ProjeContext.ProjeContext();
        private void ReportForm_Load(object sender, EventArgs e)
        {
            //Kategoriye göre ürün sayısı

            // select c.CategoryName,COUNT(p.CategoryID) from Products p join Categories c on p.CategoryID = c.CategoryID group by c.CategoryName

            var result = db.Products.GroupBy(x => x.Category.CategoryName).Select(x => new { Kategori = x.Key, UrunSayisi = x.Count() }).ToList();

            foreach (var urun in result)
            {
                listBox1.Items.Add($"{urun.Kategori} {urun.UrunSayisi}");
            }

            //ülkelere göre calışan sayısı

            //var result1 = db.Employees.GroupBy(x => x.Country).Select(x => new { Ulke = x.Key, CalisanSayisi = x.Count() }).ToList();

            //foreach (var a in result1)
            //{
            //    listBox3.Items.Add($"{a.Ulke} --- {a.CalisanSayisi}");
            //}

            //çalışanların almış oldugu siparişler

            //var result2 = db.Orders.GroupBy(x => x.Employee.FirstName).Select(x => new
            //{
            //    Calısan=x.Key,
            //    SiparisSayısı=x.Count()

            //}).ToList();
            //foreach (var a in result2)
            //{
            //    listBox2.Items.Add($"{a.Calısan} --- {a.SiparisSayısı}");
            //}

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //tarih aralıgına göre siparişler

            DateTime baslangicTarihi = dateTimePicker1.Value;
            DateTime bitisTarihi = dateTimePicker2.Value;

            var result = db.Orders.Where(x => x.OrderDate >= baslangicTarihi && x.OrderDate <= bitisTarihi).Select(x => new { OrderId = x.OrderID, OrderDate = x.OrderDate }).ToList();

            foreach (var item in result.ToList())
            {
                listBox4.Items.Add($"{item.OrderId} ---{item.OrderDate.ToLongDateString()}");
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            //çalışana göre siparişler
            //string calisan = textBox1.Text;

            //if (calisan != "")
            //{
            //    var result = db.Orders.Where(x => x.Employee.FirstName == calisan).Select(x => new
            //    {
            //        OrderId = x.OrderID,
            //        OrderDate = x.OrderDate
            //    }).ToList();

            //    foreach (var siparis in result)
            //    {
            //        listBox5.Items.Add($"{siparis.OrderId}---{siparis.OrderDate.Value.ToLongDateString()}");
            //    }
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fiyat aralıgına göre siparişler

            //decimal fiyat1 = numericUpDown1.Value;
            //decimal fiyat2 = numericUpDown2.Value;

            //var result = db.Order_Details.Where(x => x.UnitPrice >= fiyat1 && x.UnitPrice <= fiyat2).Select(x => new
            //{
            //  OrderId=x.OrderID,
            //    Fiyat=x.UnitPrice

            //}).ToList();
            //foreach (var item in result)
            //{
            //    listBox6.Items.Add($"{item.OrderId}---{item.Fiyat}");
            //}
        }
    }
}
