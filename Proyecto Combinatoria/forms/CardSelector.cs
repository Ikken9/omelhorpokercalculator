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
                Color.Yellow, 3, ButtonBorderStyle.Solid,
                Color.Yellow, 3, ButtonBorderStyle.Solid,
                Color.Yellow, 3, ButtonBorderStyle.Solid,
                Color.Yellow, 3, ButtonBorderStyle.Solid
                );
        }


        private void carta2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, carta2.ClientRectangle,
                Color.Yellow, 3, ButtonBorderStyle.Solid,
                Color.Yellow, 3, ButtonBorderStyle.Solid,
                Color.Yellow, 3, ButtonBorderStyle.Solid,
                Color.Yellow, 3, ButtonBorderStyle.Solid
                );
        }

        private void panelResultados_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelResultados.ClientRectangle,
               Color.Yellow, 3, ButtonBorderStyle.Solid,
               Color.Yellow, 3, ButtonBorderStyle.Solid,
               Color.Yellow, 3, ButtonBorderStyle.Solid,
               Color.Yellow, 3, ButtonBorderStyle.Solid
               );
        }

        private void jugadaColor_Click(object sender, EventArgs e)
        {

        }

        private void tituloJugadas_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Card[] heart = CardsManager.getHeartCards();
            Card[] clubs = CardsManager.getClubCards();
            Image image1 = CardSelector.ResizeImage(heart[0].CardImage, carta1.Width, carta1.Height);
            Image image2 = CardSelector.ResizeImage(clubs[9].CardImage, carta2.Width, carta2.Height);
            carta1.BackgroundImage = image1;
            carta2.BackgroundImage = image2;
            elegirCarta1.Text = string.Empty;
            elegirCarta2.Text = String.Empty;
        }


        private void elegirCarta1_Click(object sender, EventArgs e)
        {
            elegirCarta1Box.DroppedDown = true;
        }

        private void elegirCarta2_Click(object sender, EventArgs e)
        {

        }

        // Redimenziona una imagen que se le pasa como parámetro con el ancho y alto especificados.
        public static Image ResizeImage(Image image, int width, int height)
        {
            // Obtener el tamaño máximo.
            double Radio = Math.Max((double)width / image.Width, (double)height / image.Height);

            // Nuevo ancho y alto según el radio redimensionado
            int NewWidth = (int)Math.Round(image.Width * Radio);
            int NewHeight = (int)Math.Round(image.Height * Radio);

            // Creamos el bitmap con los nuevos tamaños.
            Bitmap newSize = new Bitmap(NewWidth, NewHeight);

            // Copiamos la imagen y la convertimos en bitmap.
            Graphics.FromImage(newSize).DrawImage(image, 0, 0, NewWidth, NewHeight);
            Bitmap finalImage = new Bitmap(newSize);
            return finalImage;
        }
    }
}
