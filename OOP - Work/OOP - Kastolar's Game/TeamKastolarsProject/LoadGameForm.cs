using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamKastolarsProject
{
    public partial class LoadGameForm : Form
    {
        private Game game;
        public LoadGameForm()
        {
            InitializeComponent();
            game = new Game(this);
        }

        private void LoadGameForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            game.HandleKeyPress(e);
        }
    }
}
