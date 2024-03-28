using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            /*Les codes entre ces tirets sont optionnels*/
            /*------------------------------------------------*/
            errorProvider1.Clear();
            if (nameTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nameTextBox, "Must be filled!");
                nameTextBox.Focus();
            } else if (phoneTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(phoneTextBox, "Must be filled!");
                phoneTextBox.Focus();
            } else if(mailTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(mailTextBox, "Must be filled!");
                mailTextBox.Focus();
            } else if (adressTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(adressTextBox, "Must be filled!");
                adressTextBox.Focus();
            }
            /*------------------------------------------------------*/
            else
            { 
                /*Mais ce qui suit prend tout les text de chaque composant et les met dans la liste "list"*/
                List<string> list = new List<string>();
                foreach(var item in this.Controls.OfType<TextBox>()) //Boucle sur tout les Composant de type TextBox (Donc: Nom, telefon...)
                {
                    list.Add(item.Text); //Ajout a la liste
                }
                foreach(var item in this.Controls.OfType<ComboBox>()) //Boucle sur tout les Composant de type ComboBox
                {
                    list.Add(item.Text.ToString());
                }
                foreach(var item in this.Controls.OfType<ListBox>()) //Boucle sur tout les Composant de type ListBox
                {
                    list.Add(item.Text.ToString());
                }
                
                StreamWriter file = new StreamWriter(@".\FilledForm.txt"); //Creation ou ouverture du fichier FilledForm.txt
                foreach(var text in list) //Boucle sur la liste precedement completee
                {
                    file.WriteLine(text.ToString()); //Ecriture dans le fichier
                }
                file.Close(); //Faut JAMAIS oublier de fermer le fichier!
                MessageBox.Show($"File saved as FilledForm.txt", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls.OfType<TextBox>()) //Tout les component de type TextBox
            {
                item.Text = string.Empty;
            }
        }
    }
}
