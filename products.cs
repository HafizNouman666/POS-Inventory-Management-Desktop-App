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
    public partial class Products : Sample2
    {

        int edit = 0; // 0 for save and 1 for update
        Int64 prodID; //variable for userID
        insertion i = new insertion();
        retrieval R = new retrieval();
        updation U = new updation();
        public Products()
        {
            InitializeComponent();
        }

        retrieval r = new retrieval();

        private void Products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.getCategoriesList("st_getCategoriesData", categoryDD, "Category", "ID");
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
            if (proTxt.Text == "") { proErrorLabel.Visible = true; } else { proErrorLabel.Visible = false; }

            if (barcodeTxt.Text == "") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
            if (expiryPicker.Value < DateTime.Now) { expiryErrorLabel.Visible = true; expiryErrorLabel.Text = "Invalid Error "; } else { expiryErrorLabel.Visible = false; }
            if (expiryPicker.Value.Date == DateTime.Now.Date) { expiryErrorLabel.Visible = false; }
            // if (priceTxt.Text == "") { priceErrorLabel.Visible = true; } else { priceErrorLabel.Visible = false; }
            if (categoryDD.SelectedIndex == 0 || categoryDD.SelectedIndex == -1) { catErrorLabel.Visible = true; } else { catErrorLabel.Visible = false; }
            if (proErrorLabel.Visible || barcodeErrorLabel.Visible || expiryErrorLabel.Visible || catErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Error", "Error"); //Error is the type of message
            }
            else
            {

                if (edit == 0)//Code for Save Operation
                {
                    if (expiryPicker.Value.Date == DateTime.Now.Date)
                    {
                        i.InsertNewProduct(proTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue) , expiryPicker.Value);

                    }
                    else
                    {
                        i.InsertNewProduct(proTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue), expiryPicker.Value);

                    }
                    R.getAllProducts(dataGridView1, proIDGV, proGV, expiryGV,catGV, barcodeGV, catIDGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1)//Code for Update Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure,you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (expiryPicker.Value.Date == DateTime.Now.Date)
                        {
                            U.UpdateProduct(prodID, proTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue));

                        }
                        else
                        {
                            U.UpdateProduct(prodID, proTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue), expiryPicker.Value);

                        }
                        R.getAllProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, barcodeGV, catIDGV);
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
                    d.delete(prodID, "s_productDelete", "@proid");
                    R.getAllProducts(dataGridView1, proIDGV, proGV, expiryGV,catGV, barcodeGV, catIDGV);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            R.getAllProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, barcodeGV, catIDGV);
        }

        private void proTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                prodID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                proTxt.Text = row.Cells["proGV"].Value.ToString();
                barcodeTxt.Text = row.Cells["barcodeGV"].Value.ToString();
                
                
                if (row.Cells["expiryGV"].FormattedValue.ToString()  == "")
                {
                    expiryPicker.Value = DateTime.Now;
                }
                else
                {
                    expiryPicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value);
                }
                
                categoryDD.SelectedItem = row.Cells["catGV"].Value.ToString();
                MainClass.disable(leftPanel);

            }
        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void expiryLable_Click(object sender, EventArgs e)
        {

        }

        private void categoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void catErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
