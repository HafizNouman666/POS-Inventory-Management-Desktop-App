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
    public partial class viewSalesInvoices : Sample
    {
        public viewSalesInvoices()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            retrieval r = new retrieval();
            r.showDailySales(dateTimePicker1.Value,dataGridView1 , salidGV , userGv , totAmtGV , totDisGv , givenGV , returnedGV ,userIDgv);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.showWindow(s, this , MDI.ActiveForm);
        }
        public static int salesID=0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salesID = Convert.ToInt32(row.Cells["salidGV"].Value.ToString());
                SalesReport sr = new SalesReport();
                sr.Show();
            }
        }
    }
}
