using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class categories : Sample2
    {
        int edit = 0; //This 0 is an indication to save operation and 1 is indication to update operation.
        int catID;
        short stat;
        insertion i = new insertion();
        retrieval r = new retrieval();
        updation u = new updation();
        public categories()
        {
            InitializeComponent();
        }

        private void categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void sveBtn_Click(object sender, EventArgs e)
        {
            if (catTxt.Text == "") { catErrorLabel.Visible = true; } else { catErrorLabel.Visible = false; }

            if (activeDD.SelectedIndex == -1) { activeErrorLabel.Visible = true; } else { activeErrorLabel.Visible = false; }
            if (activeErrorLabel.Visible || catErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Error", "Error"); //Error is the type of message
            }
            else
            {

                if (activeDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else
                {
                    stat = 0;
                }
                if (edit == 0)//Code for Save Operation
                {
                    
                    i.InsertNewCategory(catTxt.Text, stat);
                    r.showCategories(catGridView, catIDGV, NameGV, statusGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1)//Code for Update Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure,you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        
                        u.UpdateCategory(catID, catTxt.Text, stat);
                        r.showCategories(catGridView, catIDGV, NameGV, statusGV);
                        MainClass.disable_reset(leftPanel);

                    }


                }

            }
        }


        public override void delBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {

                DialogResult dr = MessageBox.Show("Are you sure , you want to delete record?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    deletion d = new deletion();
                    d.delete(catID, "st_deleteCategory", "@id");
                    r.showCategories(catGridView, catIDGV, NameGV, statusGV);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCategories(catGridView, catIDGV, NameGV, statusGV);
        }

        private void catGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = catGridView.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                catTxt.Text = row.Cells["NameGV"].Value.ToString();
                activeDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}
