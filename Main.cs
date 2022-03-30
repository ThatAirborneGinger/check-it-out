using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC24Helper
{
    public partial class Main : Form
    {
        public static string[] usedSquawks = new string[] { "7500", "7700", "1200", "1000" };
        PDCModal pdcModal = new PDCModal();

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pdcModal.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("PDC has been copied to your clipboard!", "PDC Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
