using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims
{
    class deletion
    {
        public void delete(object id, string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param , id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.ShowMSG(" Data Deleted successfully", "Success...", "Success");
                MainClass.con.Close();

            }
            catch (Exception e)
            {

                MainClass.ShowMSG(e.Message, "Error...", "Error");
                MainClass.con.Close();

            }

        }
    }
}
