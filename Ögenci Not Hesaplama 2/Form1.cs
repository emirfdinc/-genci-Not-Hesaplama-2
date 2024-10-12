using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ögenci_Not_Hesaplama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adı, soyadı;
            Int16 numarası;
            double sınav1, sınav2, sınav3,ortalama;

           adı=textBox1.Text;
           soyadı=textBox2.Text;
           numarası = Convert.ToInt16(textBox3.Text);
           sınav1 = Convert.ToDouble(textBox4.Text);
           sınav2 = Convert.ToDouble(textBox5.Text);
           sınav3 = Convert.ToDouble(textBox6.Text);
           ortalama = (sınav1 + sınav2 + sınav3) / 3;
           listBox1.Items.Add(adı + " " + soyadı + " " + "Numara:" + numarası + " " + "1.Sınavı:" + sınav1 + " " + "2.Sınavı:" + sınav2 + " " + "3.Sınavı:" + sınav3 + " " + "Not Ortalaması:" + ortalama);
           

        }
    }
    
    }

