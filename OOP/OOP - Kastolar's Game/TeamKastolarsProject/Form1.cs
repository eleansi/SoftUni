using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace TeamKastolarsProject
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_CreateCharacter_Click(object sender, EventArgs e)
        {
            FormC_haracterCreator charCreator = new FormC_haracterCreator();
            charCreator.Show();
        }

        private void Lbl_GameTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Btn_LoadGame_Click(object sender, EventArgs e)
        {
            LoadGameForm loadGame = new LoadGameForm();
            loadGame.Show();
        }
    }
}
