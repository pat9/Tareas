using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class Form1 : Form
    {
        Chihuahua objChi = new Chihuahua();
        Bulldog objBull = new Bulldog();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objChi.Ladrar());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objBull.Ladrar());
        }
    }
}
