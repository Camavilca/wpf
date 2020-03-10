using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace Semana2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["camavilca"].ConnectionString);


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void ListaAnios()
        {
            using ( SqlCommand cmd = new SqlCommand("Ups_ListaAnios", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using(DataSet df = new DataSet())
                    {
                        da.Fill(df, "ListaAnios");
                        CboAnios.DataSource = df.Tables["ListaAnios"];
                        CboAnios.DisplayMember = "Anios";
                        CboAnios.ValueMember = "Anios";
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaAnios();
        }

        private void CboAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void CboAnios_SelectedChangeCommitted(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Usp_Lista_Pedidos_Anios", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@anio", CboAnios.SelectedValue);
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "Pedidos");
                        table1.DataSource = df.Tables["Pedidos"];
                        LblMonto.Text = df.Tables["Pedidos"].Rows.Count.ToString();
                    }
                }
            }
        } 
        
        private void DgPedidos_DoubleClick(object sender, EventArgs e)
        {
            int Codigo;
            Codigo = Convert.ToInt32(table1.CurrentRow.Cells[0].Value);
            using (SqlCommand cmd = new SqlCommand("Usp_Detalle_Pedido", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@idpedido", Codigo);
                    //using (DataSet df = new DataSet())
                    //{


                    //    da.Fill(df);
                    //    table2.DataSource = df.Tables["Detalles"];
                    //    LblMonto.Text = df.Tables["Detalles"].Compute("Sum(Monto)","").ToString();
                    //}
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        table2.DataSource = dt;
                        monto.Text = dt.Compute("Sum(Monto)", "").ToString();
                    }
                }
            }
        }


    }
}
