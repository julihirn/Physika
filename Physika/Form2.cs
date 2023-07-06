using Physika.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Physika {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void labelPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            pictureBox1.Image = UnitConverter.DrawEquation(Color.Black, textBox1.Text, 100, label1.Font);
        }
    }
}
