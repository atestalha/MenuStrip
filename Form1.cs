using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hIZLIVEÖFKELİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Dominic Toretto, Los Angeles sokaklarına karanlık çöktükten sonra sınır tanımadan otomobil yarışları yapan bir grubun lideridir. Polis, sokaklarda dehşet saçan Toretto’nun aynı zamanda hırsızlık yaptığından; yüksek değerdeki elektronik aletleri çaldığından da şüphe etmektedir. Polise göre Toretto’yu yakalamanın en iyi yolu; aşırı hız düşkünü çetenin içine bir dedektif yerleştirmek ve onları suçüstü yakalamaktır. Bunun için genç dedektif Brian O'Conner görevlendirilir. Brian, Earl Spilner adıyla çeteye girer. Başta her şey umulduğu gibi gitmektedir. Ancak genç dedektif O'Conner, Dominic’in güzel ve çekici kız kardeşi Mia’ya aşık olunca işler değişir.";
            listBox1.Items.Add("HIZLI VE ÖFKELİ");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void gLADYAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kahramanlığıyla tanınan Romalı general Maximus, imparatorun kıskanç oğlu tarafından öldürülen ailesinin ve mahvolan hayatının intikamını almak için acımasız bir mücadeleye girişir";
            listBox1.Items.Add("GLADDYATOR");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void aMELIEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "nnesinin beklenmedik ölümü, babasının soğuk tavırları ve yaşadığı travmalar sonucu, sevimli ve boş şeylerle uğraşarak kendisine eğlence yaratmaya çalışsa da aslında hayatı sıkıcı bulduğu için kendisini son derece yalnız hissetmektedir";
            listBox1.Items.Add("AMELIE");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void tHENOTEBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ailesiyle birlikte tatile gelen Allie, burada yaşayan Noah isimli bir gençle yakınlaşmaya başlar. Aralarındaki sınıfsal ve ekonomik farklılıklara rağmen birbirlerine duydukları hissi engellemez, doyasıya yaşamaya başlarlar. Ancak onları bekleyen ayrılık 2. Dünya Savaşı'nın kızışmasıyla birlikte gelmek üzeredir.";
            listBox1.Items.Add("THE NOTEBOOK");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void fELEKTENBİRGECEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("FELEKTEN BİR GECE");
            listBox2.Items.Add(toolStripComboBox1.Text);
            richTextBox1.Text = "Warner Bros. Filmde, bekârlığa veda partisi için Las Vegas'a giden ve kaldıkları otelde geçirdikleri gecenin ardından hiçbir şey hatırlamayan dört arkadaşın başından geçen olaylar anlatılmaktadır.";
        }

        private void dÜGÜNDERNEKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("DÜGÜN DERNEK");
            listBox2.Items.Add(toolStripComboBox1.Text);
            richTextBox1.Text = "Film, Sivas'ın Esenyurt köyünde yaşayan İsmail'in yurt dışından dönen oğlu Tarık'a düğün yapma çabasını ve başlarına gelen komik olayları konu almaktadır";
        }

        private void yÜZÜKLERİNEFENDİSİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("YÜZÜKLERİN EFENDİSİ");
            listBox2.Items.Add(toolStripComboBox1.Text);
            richTextBox1.Text = "Yüzüklerin Efendisi: Yüzük Kardeşliği, dünyanın kaderini değişterecek olan yüzükten kurtulmak için verilen mücadeleyi konu ediyor";
        }

        private void hOBBİTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("hobbıt");
            listBox2.Items.Add(toolStripComboBox1.Text);
            richTextBox1.Text = "Roman, Tolkien'ın âdeta bir külliyat oluşturduğu Orta Dünya evreninde, evcimen bir hobbit olan Bilbo Baggins'in Smaug adındaki ejderhanın Erebor'da sahiplendiği hazineden bir pay alma çabasıyla çıktığı yolculuğa ve sonrasında gelişen olaylara odaklanır.";
        }
    }
}
