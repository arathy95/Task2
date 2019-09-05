using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;

namespace Task2
{
    public partial class ImageUpload : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D2RS25A9\SQLEXPRESS;Initial Catalog=ImageUpload;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnupload_Click(object sender, EventArgs e)
        {
            try
            {
                //byte[] imgdata = uploadimage.FileBytes;

                string dirpath = Server.MapPath("images");
                if(Directory.Exists(dirpath))
                {
                    Directory.CreateDirectory(dirpath);
                }
                string filepath = dirpath + "\\" + uploadimage.FileName;
                uploadimage.SaveAs(filepath);

                string url = "~/images/" + uploadimage.FileName;

                
                SqlCommand cmd = new SqlCommand("insert into tbl_image (imageurl) values (@imageurl)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@imageurl", url);
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

            
        }
    }
}