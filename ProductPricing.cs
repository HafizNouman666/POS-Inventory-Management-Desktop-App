using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class ProductPricing : Sample2
    {   
        updation u = new updation();
        retrieval r = new retrieval();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public ProductPricing()
        {
            InitializeComponent();
            r.getCategoriesList("st_getCategoriesData", categoryDD, "Category", "ID");
        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryDD.SelectedIndex != -1 && categoryDD.SelectedIndex !=0)
            {
                r.ShowproductWRTCategory(Convert.ToInt32(categoryDD.SelectedValue.ToString()), dataGridView1, proIDGV, proGV, buyingPRiceGV,FinalPriceGV,discountGV,ProfitMarginGV);  
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex !=-1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["profitMarginGV"].Value != null && rg.Match(row.Cells["profitMarginGV"].Value.ToString()).Success)
                {
                    float buyingPrice = Convert.ToSingle(row.Cells["buyingPRiceGV"].Value.ToString());
                    float profitMargin = Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString()) / 100;
                    float amountToincrease = profitMargin * buyingPrice;

                    

                    float finalsellingprice = buyingPrice + amountToincrease;

                    float discountper;
                    if (row.Cells["discountGV"].Value != null && rg.Match(row.Cells["discountGV"].Value.ToString()).Success)
                    {
                        discountper = finalsellingprice * (Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / 100);
                    }
                    else
                    {
                        discountper = 0;
                    }
                    
                    row.Cells["FinalPriceGV"].Value = finalsellingprice-discountper;

                }
                else
                {
                    row.Cells["FinalPriceGV"].Value = null;
                    row.Cells["discountGV"].Value = null;
                    row.Cells["profitMarginGV"].Value = null;
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {

                dataGridView1.BeginEdit(true);
            }
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void sveBtn_Click(object sender, EventArgs e)
        {
            int che = 0;
            if (categoryDD.SelectedIndex != -1 && categoryDD.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows )
                {
                    if ((bool)row.Cells["selectGV"].FormattedValue == true)
                    {
                        che++;
                        Int64 pID;
                       
                        float disc, pm, bp, sp;
                        pID = Convert.ToInt64(row.Cells["proIDGV"].Value.ToString());
                        bp = Convert.ToSingle(row.Cells["buyingPRiceGV"].Value.ToString());
                        sp = Convert.ToSingle(row.Cells["FinalPriceGV"].Value.ToString());
                        disc = row.Cells["discountGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                        pm = row.Cells["profitMarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString());
                        if (disc == 0 && pm == 0)
                        {
                            sp = bp;
                        }
                        else
                        {
                            sp = Convert.ToSingle(row.Cells["FinalPriceGV"].Value.ToString());
                        }
                        u.updateProductPrice(pID,bp,sp,disc,pm);
                     

                    }
                }
                if (che > 0)
                {
                    MainClass.ShowMSG("Product Pricing update Successfully...", "Success", "Success");
                    che = 0;
                }
                else
                {
                    MainClass.ShowMSG("Please Select any Product first.....", "Error", "Error");
                }
               
            }

        }

        public override void delBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProductPricing_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
