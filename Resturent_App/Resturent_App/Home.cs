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

namespace Resturent_App
{
    public partial class Home : Form
    {

        Functions Con;
        private string query;

        public Home()
        {
            InitializeComponent();
            Con = new Functions();
            showhome();
        }

        private void showhome()
        {

            try
            {
                String qurey = "Select * From CategoryTbl";
                categorylist.DataSource = Con.GetData(query);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homebox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeadd_Click(object sender, EventArgs e)
        {
            if (homebox1.Text == "" || homebox2.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    this.Con.Open();
                    Functions Con = this.Con;
                    SqlCommand cmd = new SqlCommand(
                        "insert into CategoryTbl(CatName,CatDesc) values(@CN,@CD)",
                        Con);

                    cmd.Parameters.AddWithValue("@CN", homebox1.Text);
                    cmd.Parameters.AddWithValue("@CD", homebox2.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();


                }
            }
        }

        private void categorylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homecategory_Click(object sender, EventArgs e)
        {

        }
    }
}
