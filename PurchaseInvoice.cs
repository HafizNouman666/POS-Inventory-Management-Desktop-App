﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Transactions;

namespace ims
{
    public partial class PurchaseInvoice : Sample2
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        Int64 productID;
        float gt;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }
        int co;
        updation u =  new updation();
        public override void sveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                Int64 purchaseInvoiceID;
                insertion i = new insertion();
                using(TransactionScope sc = new TransactionScope())
                {
                    purchaseInvoiceID = i.InsertPurchaseInvoice(DateTime.Today, retrieval.USER_ID, Convert.ToInt32(supplierDD.SelectedValue));

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                       
                        co += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quanGV"].Value.ToString()), Convert.ToSingle(row.Cells["TotGV"].Value.ToString()));
                        

                        if (r.CheckProductPriceExist(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString())))
                        {
                            u.updateProductPrice(Convert.ToInt32(row.Cells["ProIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
                        }
                        else
                        {
                            i.InsertProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
                        }

                       

                        int q;
                        object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));

                        //if ((int)ob == 0)
                        //{
                        //    ob = null;
                        //}

                        if (ob != null)
                       {   
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quanGV"].Value.ToString());
                            u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()),q);
                        }
                        else
                        {
                           i.insertStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quanGV"].Value.ToString()));
                        }
                        
                    }
                    if (co > 0)
                    {
                        MainClass.ShowMSG("Purchase Invoice Create Successfully.", "Success", "Success");
                                             
                    }
                    else
                    {
                        MainClass.ShowMSG("Unable to Create purchase invoice.", "Error", "Error");
                    }
                    sc.Complete();
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
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.showWindow(pid, this, MDI.ActiveForm);
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            r.getlist("st_getSupplierList", supplierDD, "Company", "ID");
        }
        string[] prodARR = new string[6];
        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void barcodeTxt_Validated(object sender, EventArgs e)
        {
            
        }

        private void quanTxt_TextChanged(object sender, EventArgs e)
        {
            if (quanTxt.Text != "")
            {
                if (rg.Match(quanTxt.Text).Success)
                {
                    float quan, price, tot;
                    quan = Convert.ToSingle(quanTxt.Text);
                    price = Convert.ToSingle(pupTxt.Text);
                    tot = quan * price;
                    totLabel.Text = tot.ToString("###########,##");

                }
                else
                {
                    quanTxt.SelectAll();
                }
            }
            else
            {
                totLabel.Text = "0.00";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                    grossLabel.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
        if (supplierDD.SelectedIndex == -1){suppErrorLabel.Visible = true;}else{suppErrorLabel.Visible = false;}
        if (quanTxt.Text == "") { quantityErrorLabel.Visible = true; } else { quantityErrorLabel.Visible = false;}
        if (barcodeTxt.Text == "") { barErrorLabel.Visible = true; } else { barErrorLabel.Visible = false;}
            if (suppErrorLabel.Visible || quantityErrorLabel.Visible || barErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "stop", "Error");
            }
            else 
            {
            dataGridView1.Rows.Add(productID, productTxt.Text, quanTxt.Text, pupTxt.Text, totLabel.Text);
            gt += Convert.ToSingle(totLabel.Text);
            grossLabel.Text = gt.ToString();
            productID = 0;
            productTxt.Text = "";
            pupTxt.Text = "";
            barcodeTxt.Text = "";
            totLabel.Text = "0.00";
            quanTxt.Text = "";
            Array.Clear(prodARR, 0, prodARR.Length);
                      

            }
            
        }

        private void pupTxt_TextChanged(object sender, EventArgs e)
        {
            if (pupTxt.Text != "")
            {
                if (!rg.Match(pupTxt.Text).Success)
                {
                    pupTxt.Text = "";
                    pupTxt.Focus();
                }
            }
        }

        private void barcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTxt.Text != "")
            {
                prodARR = r.getProductsWRTBarcode(barcodeTxt.Text);
                productID = Convert.ToInt64(prodARR[0]);
                productTxt.Text = prodARR[1];
                String barco = prodARR[2];
                productTxt.Enabled = false;

                if (barco != null)
                {
                    pupTxt.Focus();
                }

            }
            else
            {
                productID = 0;
                productTxt.Text = "";
                pupTxt.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);

            }
        }
    }
}
