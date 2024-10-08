using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims
{
    class updation
    {
        public  void UpdateUser(int id ,string name, string username, string pass, string email, string phoneno, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@phone", phoneno);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.ShowMSG(name + " updated to system successfully", "Success...", "Success");
                MainClass.con.Close();

            }
            catch (Exception e)
            {

                MainClass.ShowMSG(e.Message, "Error...", "Error");
                MainClass.con.Close();

            }

        }
        public void UpdateCategory(int id, string name, Int16 isActive)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", isActive);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                int ucheck = cmd.ExecuteNonQuery();
                if (ucheck > 0)
                {
                    MainClass.ShowMSG(name + " Category in system successfully", "Success...", "Success");
                    MainClass.con.Close();
                }
                else
                {
                    MainClass.ShowMSG(" Category not updated", "Error...", "Error");
                    MainClass.con.Close();
                }

                MainClass.con.Close();
            }
            catch (Exception e)
            {
                MainClass.ShowMSG(e.Message, "Error...", "Error");
                MainClass.con.Close();

            }

        }

        public void UpdateProduct(Int64 proID, string product, string barcode, int catID, DateTime? expiry = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProducts", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", proID);
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
                MainClass.ShowMSG(product + " Updated to system successfully", "Success...", "Success");
                MainClass.con.Close();
            }
            catch (Exception )
            {
                MainClass.ShowMSG("Product not updated", "Error...", "Error");
                MainClass.con.Close();

            }

        }
        public void updateStock(Int64 proID, int quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                
            }

        }

        public void updateStockWithoutConnection(Int64 proID, int quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);
                
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                MainClass.con.Close();

            }

        }
        public void updateSupplier(int supID, string company, string person, string phone1, string address, Int16 sataus, string phone2 = null, string ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSupplier", MainClass.con);
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
                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", ntn);
                }

                cmd.Parameters.AddWithValue("@status", sataus);
                cmd.Parameters.AddWithValue("@suppID", supID);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.ShowMSG(company + " updated system successfully", "Success...", "Success");
                MainClass.con.Close();

            }
            catch (Exception e)
            {

                MainClass.ShowMSG(e.Message, "Error...", "Error");
                MainClass.con.Close();

            }

        }
        public void updateProductPrice(Int64 proID, float bp,float sp=0,float dis = 0,float profitPerc=0)
        {

            try
            {
                SqlCommand cmd;
                if (sp == 0 && dis ==0 && profitPerc ==0)
                {
                    cmd = new SqlCommand("st_updateProductPrice1", MainClass.con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@proID", proID);
                    cmd.Parameters.AddWithValue("@bp", bp);
                }
                else
                {
                    cmd = new SqlCommand("st_updateProductPrice", MainClass.con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@proID", proID);
                    cmd.Parameters.AddWithValue("@bp", bp);
                    cmd.Parameters.AddWithValue("@sp", sp);
                    cmd.Parameters.AddWithValue("@dis", dis);
                    cmd.Parameters.AddWithValue("@profPer", profitPerc);
                }

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                throw;
            }

        }

    }
}
