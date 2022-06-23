using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Combinatoria
{
    public partial class CardSelector : Form
    {
        private Card card1;
        private Card card2;

        public Card Card1
        {
            get => card1;
  
            set
            {
                if (this.card1 == null)
                {
                    this.card1 = value;
                }
            }
        }

        public Card Card2
        {
            get => this.card2;
            set
            { 
                if (card2 == null)
                {
                    this.card2 = value;
                }
            } 
        }

        public CardSelector()
        {
            InitializeComponent();
        }

        private void CardSelector_Load(object sender, EventArgs e)
        {

        }


        private void carta1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, carta1.ClientRectangle,
                Color.Yellow, 4, ButtonBorderStyle.Solid,
                Color.Yellow, 4, ButtonBorderStyle.Solid,
                Color.Yellow, 4, ButtonBorderStyle.Solid,
                Color.Yellow, 4, ButtonBorderStyle.Solid
                );
        }


        private void carta2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, carta2.ClientRectangle,
                Color.Yellow, 4, ButtonBorderStyle.Solid,
                Color.Yellow, 4, ButtonBorderStyle.Solid,
                Color.Yellow, 4, ButtonBorderStyle.Solid,
                Color.Yellow, 4, ButtonBorderStyle.Solid
                );
        }

        private void panelResultados_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelResultados.ClientRectangle,
               Color.Yellow, 4, ButtonBorderStyle.Solid,
               Color.Yellow, 4, ButtonBorderStyle.Solid,
               Color.Yellow, 4, ButtonBorderStyle.Solid,
               Color.Yellow, 4, ButtonBorderStyle.Solid
               );
        }

        private void jugadaColor_Click(object sender, EventArgs e)
        {

        }

        private void tituloJugadas_Click(object sender, EventArgs e)
        {

        }
    }
}
