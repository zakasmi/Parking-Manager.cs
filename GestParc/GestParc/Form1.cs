using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace GestParc
{
    
    public partial class Form1 : Form
    {
        
        SqlConnection cnx = new SqlConnection(@"Data Source=DELL;Initial Catalog=DB;Integrated Security=True");
        SqlDataReader dr;
        int pos = 0;

        public Form1()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            InitializeComponent();
          
        }
////////////////////////////              Form Load            ////////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            
        
            //--------------------- remplir combobox vehicule --------------------------------
            try {
                SqlCommand cmd = new SqlCommand("select *from Vehicule",cnx);
                cnx.Open();
                dr=cmd.ExecuteReader();
               
                while(dr.Read()){

                    CB_immatricule.Items.Add(dr[0]);
                
                }

                cnx.Close();
            
            
            }
            catch (Exception e1){
                MessageBox.Show(""+e1.Message);
            }
            finally {
                cnx.Close();
            }
        //--------------------- remplir combobox vehicule --------------------------------
            try
            {
                SqlCommand cmd = new SqlCommand("select *from Conducteur", cnx);
                cnx.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    CB_IdConducteur.Items.Add(dr[0]);

                }

                cnx.Close();
        //--------------------- remplir les textbox et datetimepicker --------------------------------       
                bouge(0);


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
//////////////////////////// ///////////           Ajouter               /////////////////////////////////////////

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
              


                //DTP_DateDebut.Value //DTP_DateFin.Value
                SqlCommand cmd = new SqlCommand("insert into HistoConducteur values('" + TB_IdHC.Text + "','" + CB_immatricule.SelectedItem + "','" + CB_IdConducteur.SelectedItem + "','" + DTP_DateDebut.Value + "','" + DTP_DateFin.Value + "')", cnx);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("la Collone est ajouté","Ajouter");

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
////////////////////////////////// ///////        Supprimer            ////////////////////////////////////////////
        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from HistoConducteur  where IdHc='"+TB_IdHC.Text+"'", cnx);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("la Collone a éte supprimé ", "Supprimer");
                bouge(0);

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
///////////////////////////////////               Modifier               ////////////////////////////////////////////////

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update HistoConducteur set  Immat='" + CB_immatricule.SelectedItem + "',IdConducteur='" + CB_IdConducteur.SelectedItem + "',DateDebut='" + DTP_DateDebut.Value + "',DateFin='" + DTP_DateFin.Value + "'  where IdHc='" + TB_IdHC.Text + "'", cnx);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("la Collone a éte Modifier ", "Modifier");

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
        //------------------------ Debut -----------------------------------
        private void BTN_debut_Click(object sender, EventArgs e)
        {
            pos = 0;
            bouge(pos);
        }
        //------------------------ Fin -----------------------------------
        private void BTN_fin_Click(object sender, EventArgs e)
        {
            pos = countrows() - 1;
            bouge(pos);
        }
        //------------------------ Precedent -----------------------------------
        private void BTN_precedent_Click(object sender, EventArgs e)
        {
            if (0 < pos)
            {
                pos -= 1;
                bouge(pos);
            }
            else MessageBox.Show("Debut");
      
        }
        //------------------------ Suivant -----------------------------------
        private void BTN_suivant_Click(object sender, EventArgs e)
        {
            if (pos < (countrows() - 1))
            {
                pos += 1;
                bouge(pos);
            }
            else MessageBox.Show("Debut");
        }

        ////////////////////////////////         Fill The controls        //////////////////////////////////////////////// //

        public void Remplir() { 
        
        TB_IdHC.Text =dr[0].ToString();
        CB_immatricule.SelectedItem =dr[1].ToString();
        CB_IdConducteur.SelectedItem=dr[2].ToString();
        DTP_DateDebut.Value=DateTime.Parse(dr[3].ToString());
        DTP_DateFin.Value = DateTime.Parse(dr[4].ToString()); 
    
        }

        ///////////////////////////////////      Move to Specific Row     //////////////////////////////////////////// //
        public void bouge(int i) { 
        
            try{
         SqlCommand cmd = new SqlCommand("select *from HistoConducteur", cnx);
         cnx.Open();
                dr=cmd.ExecuteReader();
                int x=0;
                for (x = 0; x <= i;x++ )
                {
                    dr.Read();
                }
               Remplir();


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

        //////////////////////// Compter le nombre de ligne dans un tableau ////// //
        public int countrows() {
            int rows;
            SqlCommand count = new SqlCommand("select count(*) from HistoConducteur", cnx);
            cnx.Open();
            rows = int.Parse(count.ExecuteScalar().ToString());
            cnx.Close();

            return rows;
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Panne p1 = new Panne();
            p1.Show();
            this.Hide();

        }

       

        

       
    }
}
