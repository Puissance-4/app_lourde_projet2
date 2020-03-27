using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.MySql;

namespace AppLourdeProjet2
{
    public partial class FormRechercheInfoLoc : Form
    {
        public FormRechercheInfoLoc()
        {
            InitializeComponent();
        }

     

        private void BtnRechercher_Click(object sender, EventArgs e)
        {   
            if(textBoxNumLoc.Text != "")
            {
                int id = Int32.Parse(textBoxNumLoc.Text);

                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT NUMLOCATION, IMMATRICULATION, DATELOCATION, MONTANTREGLE, DATEHREDEPARTPREVU, DATEHREDEPARTREEL, DATEHRERETOURPREVU, DATEHRERETOURREEL FROM LOCATION WHERE NUMLOCATION=" + id + ";", Program.mybdd.connection);  //on prepare une requete
                DataSet infosRes = new DataSet();   //on cree en memoire un nouveau jeu de donnees
                msda.Fill(infosRes);
                List<string> infos = new List<string>();

                for (int i = 0; i < 8; i++) //Boucle qui parcourt la requete sql et qui initialise les fiches dans la liste
                {

                    ViewInfoFiche[i, 0].Value = infosRes.Tables[0].Rows[0].ItemArray[i].ToString();

                }
            }
            else
            {
                MessageBox.Show("Merci d'entrer un nombre");
            }
        }

        private void textBoxNumLoc_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxNumLoc.Text, "[^0-9]"))
            {
                MessageBox.Show("Merci d'entrer un nombre");
                textBoxNumLoc.Text = textBoxNumLoc.Text.Remove(textBoxNumLoc.Text.Length - 1);
            }
        }
    }
}
