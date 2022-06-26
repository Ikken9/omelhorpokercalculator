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

        public Card Card1 => card1;
        public Card Card2 => card2;
        
        

        private Card[] suit1;
        private Card[] suit2;

        public CardSelector()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void CardSelector_Load(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proyecto_Combinatoria.Properties.Resources));
            Image initialBackground = ResizeImage((System.Drawing.Image)(resources.GetObject("RDR2_FINAL")), carta1.Width, carta1.Height);
            carta1.BackgroundImage = initialBackground;
            carta2.BackgroundImage = initialBackground;
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

        }


        private void elegirCarta1_Click(object sender, EventArgs e)
        {
            elegirCarta1Box.DroppedDown = true;
        }

        private void elegirCarta2_Click(object sender, EventArgs e)
        {
            elegirCarta2Box.DroppedDown = true;
        }

        private void elegirCarta1Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            suit1 = CardsManager.GetSuit(elegirCarta1Box.SelectedItem.ToString());
            elegirNumeroBox1.Items.Clear();
            foreach (Card card in suit1)
            {
                elegirNumeroBox1.Items.Add(card.Value);
            }

            elegirNumeroBox1.DroppedDown = true;
        }

        private void elegirCarta2Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            suit2 = CardsManager.GetSuit(elegirCarta2Box.SelectedItem.ToString());
            elegirNumeroBox2.Items.Clear();
            foreach (Card card in suit2)
            {
                elegirNumeroBox2.Items.Add(card.Value);
            }

            elegirNumeroBox2.DroppedDown = true;
        }

        private void elegirNumeroBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = elegirNumeroBox1.SelectedIndex;
            card1 = CardsManager.GetCard(suit1, index);
            Image image = ResizeImage(card1.CardImage, carta1.Width, carta1.Height);
            carta1.BackgroundImage = image;
            elegirCarta1.Text = String.Empty;
            resetButton.Visible = true;
        }

        private void elegirNumeroBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = elegirNumeroBox2.SelectedIndex;
            card2 = CardsManager.GetCard(suit2, index);
            Image image = ResizeImage(card2.CardImage, carta2.Width, carta2.Height);
            carta2.BackgroundImage = image;
            elegirCarta2.Text = String.Empty;
            resetButton.Visible = true;
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

        private void salirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            card1 = null;
            elegirCarta1.Text = "Elegir Carta 1";
            card2 = null;
            elegirCarta2.Text = "Elegir Carta 2";
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proyecto_Combinatoria.Properties.Resources));
            Image initialBackground = ResizeImage((System.Drawing.Image)(resources.GetObject("RDR2_FINAL")), carta1.Width, carta1.Height);
            carta1.BackgroundImage = initialBackground;
            carta2.BackgroundImage = initialBackground;
            resetButton.Visible = false;
        }
    }
}
