using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTAP13032026
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QLLH_Button(object sender, EventArgs e)
        {
            this.Hide();
            ClassList sl = new ClassList();
            sl.FormClosed += (s, args) => this.Show();
            sl.ShowDialog();
        }

        private void QLSV_Button(object sender, EventArgs e)
        {
            this.Hide();
            StudentList sl = new StudentList();
            sl.FormClosed += (s, args) => this.Show();
            sl.ShowDialog();
        }

        private void Sl_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
