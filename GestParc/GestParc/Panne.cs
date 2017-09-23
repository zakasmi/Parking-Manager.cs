using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GestParc
{
    public partial class Panne : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DELL;Initial Catalog=DB;Integrated Security=True");
        SqlDataReader dr;

        public Panne()
        {
            InitializeComponent();
        }

        
////////////////////////////              Form Load            ////////////////////////////////////////////////////
        
        private void Panne_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select *from Vehicule", cnx);
                cnx.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    comboBox1.Items.Add(dr[0]);

                }

                cnx.Close();


            }
            catch (Exception e1)
            {
                MessageBox.Show("" + e1.Message);
            }
            finally
            {
                cnx.Close();
            }
        }
////////////////////////////    comboBox1_SelectedIndexChanged     ////////////////////////////////////////////////////
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("select P.IdPanne,P.Immat ,V.Marque,V.Modele,P.DatePanne,P.DateReprise,P.DescPanne from Panne P inner join Vehicule V on P.Immat=V.Immat where V.Immat = '"+comboBox1.SelectedItem+"' ", cnx);
                cnx.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
                   

                }

                cnx.Close();


            }
            catch (Exception e1)
            {
                MessageBox.Show("" + e1.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==7){

                try
                {
                    SqlCommand cmd = new SqlCommand("delete from Panne  where IdPanne='"+dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()+"'", cnx);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    comboBox1_SelectedIndexChanged(sender, e);
                    MessageBox.Show("la Collone a éte supprimé ", "Supprimer");
                   

                }
                catch (Exception e1)
                {
                    MessageBox.Show("" + e1.Message);
                }
                finally
                {
                    cnx.Close();
                }
            
            }
        }

        private void Panne_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

    }
}
