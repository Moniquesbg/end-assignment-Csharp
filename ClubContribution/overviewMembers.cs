using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubContribution
{
    public partial class overviewMembers : Form
    {
        public overviewMembers()
        {
            InitializeComponent();
        }

        private void sportclubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void overviewMembers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.database1DataSet.Member);

        }
    }
}
