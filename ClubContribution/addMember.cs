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
    public partial class addMember : Form
    {
        public addMember()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int playingMember = 0;

            if (checkBox1.Checked == true)
            {
                playingMember = 1;
            }

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "YYYY-MM-dd";

            DateTime birthday = dateTimePicker1.Value;
            DateTime membership = dateTimePicker2.Value;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moniq\eindopdracht_cs\ClubContribution\ClubContribution\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Member(name, birthday, start_membership_date, playing_member) VALUES(@name, @birthday, @start_membership_date, @playing_member)", con);

            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@birthday", birthday);
            cmd.Parameters.AddWithValue("@start_membership_date", membership);
            cmd.Parameters.AddWithValue("@playing_member", playingMember);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void addMember_Load(object sender, EventArgs e)
        {

        }
    }
}
