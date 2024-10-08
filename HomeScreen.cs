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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            
            MDI.logoutToolStripMenuItem.Enabled = true;
            userLabel.Text = retrieval.EMP_NAME;

        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void suppbtn_Click(object sender, EventArgs e)
        {
            Supplier u = new Supplier();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice u = new PurchaseInvoice();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            categories u = new categories();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

       

        private void Stockbtn_Click(object sender, EventArgs e)
        {
            Stocks u = new Stocks();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void probtn_Click_1(object sender, EventArgs e)
        {
            Products u = new Products();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void Salesbtn_Click(object sender, EventArgs e)
        {

            Sales u = new Sales();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void propbtn_Click(object sender, EventArgs e)
        {
            ProductPricing u = new ProductPricing();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }
    }
}
