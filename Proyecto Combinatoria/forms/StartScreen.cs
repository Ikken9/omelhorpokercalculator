using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Combinatoria
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            CardsManager.GenerateGame();
            new CardSelector().Show();
            this.Visible = false;
        }
    }
}
