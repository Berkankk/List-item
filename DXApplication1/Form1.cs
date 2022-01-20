using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if((!dtStartDate.Text.ToString().Equals(""))&& (!dtFinishDate.Text.ToString().Equals("")))
            {
                labelControl1.Text = "";
                DataTable table = new DataTable();
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=CAN-MAC\SQLEXPRESS;Initial Catalog=Test;Integrated Security=true";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                SqlCommand cmd = new SqlCommand("Test", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Malkodu", SqlDbType.VarChar).Value = txtProduct.Text.ToString();
                cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = dtStartDate.EditValue.ToString();
                cmd.Parameters.Add("@FinishDate", SqlDbType.DateTime).Value = dtFinishDate.EditValue.ToString();

                //cnn.Open();
                cmd.ExecuteNonQuery();

                decimal toplam = 0;

                using (var da = new SqlDataAdapter(cmd))
                {
                  
                    da.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        if (row["IslemTur"].ToString().Equals("Giris"))
                        {
                            toplam += Convert.ToDecimal(row["GirisMiktar"].ToString());
                        }
                        else
                        {
                            toplam -= Convert.ToDecimal(row["CikisMiktar"].ToString());
                        }
                        row["StockMiktar"] = Decimal.ToInt32(toplam);
                    }


                    gridControl1.DataSource = table;
                    cnn.Close();
                }
            }
            else
            {
                labelControl1.Text = "Lütfen Tarihleri Giriniz";
            }
            



           
        }


        public void connect()
        {

        }
    }
}
