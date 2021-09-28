using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int fıyat = Convert.ToInt32(txt1.Text);

            int kdv = Convert.ToInt32(txt2.Text);

            int sonuc = (fıyat * kdv) / 100 + fıyat;

            string sonuc1 = Convert.ToString(sonuc);

            txt3.Text = sonuc1;
            

           
                


        }

        
    }
}
