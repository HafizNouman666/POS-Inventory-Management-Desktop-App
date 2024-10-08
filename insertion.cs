using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Transactions;

namespace ims
{
    class insertion
    {
        public void InsertNewUser(string name, string username, string pass, string email, string phoneno, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@phone", phoneno);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);


                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.ShowMSG(name + " added to system successfully", "Success...", "Success");
                MainClass.con.Close();

            }
            catch (Exception e)
            {

                MainClass.ShowMSG(e.Message, "Error...", "Error");
                MainClass.con.Close();

            }

        }
        public void InsertNewCategory(string name, int isActive)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", isActive);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.ShowMSG(name + " added to system successfully", "Success...", "Success");
                MainClass.con.Close();

            }
            catch (Exception e)
            {

                MainClass.ShowMSG(e.Message, "Error...", "Error");
                MainClass.con.Close();

            }

        }

        public void InsertNewProduct(string product, string barcode, int catID, DateTime? expiry = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_productInsert", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
              
                if (expiry == null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                }
                cmd.Parameters.AddWithValue("@catID", catID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.ShowMSG(product + " added to system successfully", "Success...", "Success");
                MainClass.con.Close();
            }
            catch (Exception e)
            {
                MainClass.ShowMSG(e.Message, "Error...", "Error");
                MainClass.con.Close();

            }

        }
        public void InsertSupplier(string company, string person, string phone1, string address, Int16 sataus, string phone2 = null, string ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSupplier", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@conPerson", person);
                cmd.Parameters.AddWithValue("@phone1", phone1);


                if (phone2 == null)
                {
                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);
                }
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@status", sataus);

                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", ntn);
                }



                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.ShowMSG(company + " added to system successfully", "Success...", "Success");
                MainClass.con.Close();

            }
            catch (Exception e)
            {

                MainClass.ShowMSG(e.Message, "Error...", "Error");
                MainClass.con.Close();

            }

        }
        private Int64 purchaseInvoiceID;
        public Int64 InsertPurchaseInvoice(DateTime date, int doneby, int suppID)
        {
            try
            {


                SqlCommand cmd = new SqlCommand("st_insertPurchaseINvoice", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doneby", doneby);
                cmd.Parameters.AddWithValue("@suppID", suppID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "st_getLastPurchaseID";
                cmd.Parameters.Clear();
                purchaseInvoiceID = Convert.ToInt64(cmd.ExecuteScalar());

                MainClass.con.Close();




            }
            catch (Exception e)
            {

                MainClass.ShowMSG(e.Message, "Error...", "Error");
                MainClass.con.Close();

            }
            return purchaseInvoiceID;
        }
        int pidCount;
        public int insertPurchaseInvoiceDetails(Int64 purID, Int64 proID, int quan, float totPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PurchaseID", purID);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@totprice", totPrice);
                MainClass.con.Open();
                pidCount = cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();

            }
            return pidCount;

        }
        public void insertStock(Int64 proID, int quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void InsertDeletedItem(Int64 pid, Int64 proid, int quan, int userid, DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertDeletedItemPI", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pi", pid);
                cmd.Parameters.AddWithValue("@userID", userid);
                cmd.Parameters.AddWithValue("@proId", proid);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@date", date);



                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception e)
            {

                MainClass.ShowMSG(e.Message, "Error...", "Error");
                MainClass.con.Close();

            }

        }

        public void InsertProductPrice(Int64 proID,float buyingAmount)
        {
            try
            {


                SqlCommand cmd = new SqlCommand("st_insertProductPrice", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", buyingAmount);
                
                
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();




            }
            catch (Exception e)
            {

                MainClass.ShowMSG(e.Message, "Error...", "Error");
                MainClass.con.Close();

            }
            
        }

        int salCount = 0;
        Int64 salesID;
        retrieval r = new retrieval();
        updation u = new updation();
        public void insertSales(DataGridView gv,string proIDgv, string proQuanGV , int doneBy, DateTime dt, float tAmount, float tDiscount, float aGiven, float aReturned, string payType)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("insertSales", MainClass.con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@done", doneBy);
                    cmd.Parameters.AddWithValue("@date", dt);
                    cmd.Parameters.AddWithValue("@totamt", tAmount);
                    cmd.Parameters.AddWithValue("@totdis", tDiscount);
                    cmd.Parameters.AddWithValue("@given", aGiven);
                    cmd.Parameters.AddWithValue("@return", aReturned);
                    
                    if (payType == "Cash")
                    {
                        cmd.Parameters.AddWithValue("@pyType", 0);
                    }
                    else if (payType == "Debit Card")
                    {
                        cmd.Parameters.AddWithValue("@pyType", 1);
                    }
                    else if (payType == "Credit Card")
                    {
                        cmd.Parameters.AddWithValue("@pyType", 2);
                    }
                    MainClass.con.Open();
                    salCount = cmd.ExecuteNonQuery();
                    if (salCount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("st_getSalesID", MainClass.con);
                        cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                        salesID = Convert.ToInt64(cmd2.ExecuteScalar());
                        

                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd3 = new SqlCommand("st_insertSalesDetails", MainClass.con);
                            cmd3.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@salID", salesID);
                            cmd3.Parameters.AddWithValue("@proID", Convert.ToInt64(row.Cells[proIDgv].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@quan", Convert.ToInt32(row.Cells[proQuanGV].Value.ToString()));
                            cmd3.ExecuteNonQuery();
                            int stockofProduct = Convert.ToInt32(r.getProductQuantityWithoutConnection(Convert.ToInt64(row.Cells[proIDgv].Value.ToString())));
                            int currentQuanofProduct = Convert.ToInt32(row.Cells[proQuanGV].Value.ToString());
                            int finalProductQuantity = stockofProduct - currentQuanofProduct;
                            u.updateStockWithoutConnection(Convert.ToInt64(row.Cells[proIDgv].Value.ToString()) , finalProductQuantity);
                        }
                    }
                    MainClass.con.Close();
                    MainClass.ShowMSG("Sales Successfull ", "Success", "Success");
                    sc.Complete();
                }

            }


            catch (Exception e)
            {

                MainClass.ShowMSG(e.Message, "Error...", "Error");
                MainClass.con.Close();

            }

        }
    }
}
    