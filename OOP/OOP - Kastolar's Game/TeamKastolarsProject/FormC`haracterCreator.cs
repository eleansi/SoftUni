using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamKastolarsProject.CharacterClasses;
using TeamKastolarsProject.Enumerations;

namespace TeamKastolarsProject
{
    public partial class FormC_haracterCreator : Form
    {
        public FormC_haracterCreator()
        {
            InitializeComponent();
        }

        private void FormC_haracterCreator_Load(object sender, EventArgs e)
        {

        }

        private void Btn_SaveCharacter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_CharacterName.Text) || String.IsNullOrEmpty(Gbox_Gender.Text) || 
                String.IsNullOrEmpty(Cbo_CharacterClass.Text))
            {
                MessageBox.Show("You are missing an important information. Whitout it the character cannot be made!");
                return;
            }
            else
            {
                String output = "";
                output += "Congratulations!\nYou have made a character.";
                output += Environment.NewLine;
                output += String.Format("\nName: {0}", Txt_CharacterName.Text);
                // Get Gender
                output += String.Format("\nGender: {0}", (string)(this.Rdo_GenderMale.Checked ? "Male" : "Female"));
                //Get Class
                output += String.Format("\nClass: {0}", Cbo_CharacterClass.Text);
                output += "\n";
                output += Environment.NewLine;
                output += "Prepare for battle!";
                // Test the output
                MessageBox.Show(output);
            }
            
        }

        public void Cbo_CharacterClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
