using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClubContribution
{
    public partial class Form1 : Form
    {
        Sportclub sportclub;
        String connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moniq\eindopdracht_cs\ClubContribution\ClubContribution\Database1.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.Show();
        }
        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMember add = new addMember();
            add.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            overviewMembers overview = new overviewMembers();
            overview.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void overviewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            overviewMembers overview = new overviewMembers();
            overview.Show();
        }

        private Sportclub loadDataFromDb()
        {
            string query = @"SELECT name, birthday, start_membership_date, playing_member 
                            FROM Member";

            DataSet result = new DataSet();

            SqlConnection con = new SqlConnection(connection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(result);

            foreach(DataRow data in result.Tables[0].Rows )
            {
                Member member = new Member(data[0].ToString(),
                                              (DateTime)data[1],
                                              (DateTime)data[2],
                                              Convert.ToInt16(data[3]));
                Contribution contribution = new Contribution(member);

                sportclub.AddMember(member);
                sportclub.addContribution(contribution);
            }
            return sportclub;
        }

        private void loadSportClubInfo()
        {
            loadDataFromDb();

            label4.Text = sportclub.showYoungestMember().ToString();
            label5.Text = "€ " + sportclub.calculateTotalProfit().ToString();
            label6.Text = sportclub.calculateAverageMembershipYears().ToString();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.Show();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sportclub = new Sportclub();
            loadSportClubInfo();
        }
    }
}
