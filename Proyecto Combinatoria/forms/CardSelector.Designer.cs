using System.Windows.Forms;

namespace Proyecto_Combinatoria
{
    partial class CardSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.carta1 = new System.Windows.Forms.Panel();
            this.elegirCarta1 = new System.Windows.Forms.Label();
            this.carta2 = new System.Windows.Forms.Panel();
            this.elegirCarta2 = new System.Windows.Forms.Label();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.tituloResultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloJugadas = new System.Windows.Forms.Label();
            this.jugadaEscaleraReal = new System.Windows.Forms.Label();
            this.jugadaPoker = new System.Windows.Forms.Label();
            this.jugadaFullHouse = new System.Windows.Forms.Label();
            this.jugadaColor = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.carta1.SuspendLayout();
            this.carta2.SuspendLayout();
            this.panelResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // carta1
            // 
            this.carta1.BackColor = System.Drawing.Color.Transparent;
            this.carta1.Controls.Add(this.elegirCarta1);
            this.carta1.Location = new System.Drawing.Point(42, 80);
            this.carta1.Name = "carta1";
            this.carta1.Size = new System.Drawing.Size(163, 277);
            this.carta1.TabIndex = 0;
            this.carta1.Paint += new System.Windows.Forms.PaintEventHandler(this.carta1_Paint);
            // 
            // elegirCarta1
            // 
            this.elegirCarta1.AutoSize = true;
            this.elegirCarta1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elegirCarta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.elegirCarta1.ForeColor = System.Drawing.Color.White;
            this.elegirCarta1.Location = new System.Drawing.Point(20, 122);
            this.elegirCarta1.Name = "elegirCarta1";
            this.elegirCarta1.Size = new System.Drawing.Size(122, 24);
            this.elegirCarta1.TabIndex = 0;
            this.elegirCarta1.Text = "Elegir Carta 1";
            // 
            // carta2
            // 
            this.carta2.BackColor = System.Drawing.Color.Transparent;
            this.carta2.Controls.Add(this.elegirCarta2);
            this.carta2.Location = new System.Drawing.Point(250, 80);
            this.carta2.Name = "carta2";
            this.carta2.Size = new System.Drawing.Size(163, 277);
            this.carta2.TabIndex = 1;
            this.carta2.Paint += new System.Windows.Forms.PaintEventHandler(this.carta2_Paint);
            // 
            // elegirCarta2
            // 
            this.elegirCarta2.AutoSize = true;
            this.elegirCarta2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elegirCarta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.elegirCarta2.ForeColor = System.Drawing.Color.White;
            this.elegirCarta2.Location = new System.Drawing.Point(20, 122);
            this.elegirCarta2.Name = "elegirCarta2";
            this.elegirCarta2.Size = new System.Drawing.Size(122, 24);
            this.elegirCarta2.TabIndex = 0;
            this.elegirCarta2.Text = "Elegir Carta 2";
            // 
            // panelResultados
            // 
            this.panelResultados.BackColor = System.Drawing.Color.Transparent;
            this.panelResultados.Controls.Add(this.tituloResultado);
            this.panelResultados.Controls.Add(this.panel1);
            this.panelResultados.Controls.Add(this.tituloJugadas);
            this.panelResultados.Controls.Add(this.jugadaEscaleraReal);
            this.panelResultados.Controls.Add(this.jugadaPoker);
            this.panelResultados.Controls.Add(this.jugadaFullHouse);
            this.panelResultados.Controls.Add(this.jugadaColor);
            this.panelResultados.Location = new System.Drawing.Point(530, 80);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(286, 277);
            this.panelResultados.TabIndex = 2;
            this.panelResultados.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResultados_Paint);
            // 
            // tituloResultado
            // 
            this.tituloResultado.AutoSize = true;
            this.tituloResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tituloResultado.ForeColor = System.Drawing.Color.White;
            this.tituloResultado.Location = new System.Drawing.Point(179, 18);
            this.tituloResultado.Name = "tituloResultado";
            this.tituloResultado.Size = new System.Drawing.Size(86, 20);
            this.tituloResultado.TabIndex = 6;
            this.tituloResultado.Text = "Resultado:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 4);
            this.panel1.TabIndex = 5;
            // 
            // tituloJugadas
            // 
            this.tituloJugadas.AutoSize = true;
            this.tituloJugadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tituloJugadas.ForeColor = System.Drawing.Color.White;
            this.tituloJugadas.Location = new System.Drawing.Point(16, 18);
            this.tituloJugadas.Name = "tituloJugadas";
            this.tituloJugadas.Size = new System.Drawing.Size(74, 20);
            this.tituloJugadas.TabIndex = 4;
            this.tituloJugadas.Text = "Jugadas:";
            this.tituloJugadas.Click += new System.EventHandler(this.tituloJugadas_Click);
            // 
            // jugadaEscaleraReal
            // 
            this.jugadaEscaleraReal.AutoSize = true;
            this.jugadaEscaleraReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jugadaEscaleraReal.ForeColor = System.Drawing.Color.White;
            this.jugadaEscaleraReal.Location = new System.Drawing.Point(16, 214);
            this.jugadaEscaleraReal.Name = "jugadaEscaleraReal";
            this.jugadaEscaleraReal.Size = new System.Drawing.Size(112, 20);
            this.jugadaEscaleraReal.TabIndex = 3;
            this.jugadaEscaleraReal.Text = "Escalera Real:";
            // 
            // jugadaPoker
            // 
            this.jugadaPoker.AutoSize = true;
            this.jugadaPoker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jugadaPoker.ForeColor = System.Drawing.Color.White;
            this.jugadaPoker.Location = new System.Drawing.Point(16, 170);
            this.jugadaPoker.Name = "jugadaPoker";
            this.jugadaPoker.Size = new System.Drawing.Size(54, 20);
            this.jugadaPoker.TabIndex = 2;
            this.jugadaPoker.Text = "Poker:";
            // 
            // jugadaFullHouse
            // 
            this.jugadaFullHouse.AutoSize = true;
            this.jugadaFullHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jugadaFullHouse.ForeColor = System.Drawing.Color.White;
            this.jugadaFullHouse.Location = new System.Drawing.Point(16, 122);
            this.jugadaFullHouse.Name = "jugadaFullHouse";
            this.jugadaFullHouse.Size = new System.Drawing.Size(89, 20);
            this.jugadaFullHouse.TabIndex = 1;
            this.jugadaFullHouse.Text = "Full House:";
            // 
            // jugadaColor
            // 
            this.jugadaColor.AutoSize = true;
            this.jugadaColor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugadaColor.ForeColor = System.Drawing.Color.White;
            this.jugadaColor.Location = new System.Drawing.Point(17, 71);
            this.jugadaColor.Name = "jugadaColor";
            this.jugadaColor.Size = new System.Drawing.Size(50, 18);
            this.jugadaColor.TabIndex = 0;
            this.jugadaColor.Text = "Color:";
            this.jugadaColor.Click += new System.EventHandler(this.jugadaColor_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Yellow;
            this.calculateButton.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.Black;
            this.calculateButton.Location = new System.Drawing.Point(367, 437);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(133, 39);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "CALCULAR";
            this.calculateButton.UseVisualStyleBackColor = false;
            // 
            // CardSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Proyecto_Combinatoria.Properties.Resources.fondo_mesa_poker_color_verde_47243_1094;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 506);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.carta2);
            this.Controls.Add(this.carta1);
            this.Name = "CardSelector";
            this.Text = "Card selector";
            this.Load += new System.EventHandler(this.CardSelector_Load);
            this.carta1.ResumeLayout(false);
            this.carta1.PerformLayout();
            this.carta2.ResumeLayout(false);
            this.carta2.PerformLayout();
            this.panelResultados.ResumeLayout(false);
            this.panelResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel carta1;
        private System.Windows.Forms.Panel carta2;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tituloJugadas;
        private System.Windows.Forms.Label jugadaEscaleraReal;
        private System.Windows.Forms.Label jugadaPoker;
        private System.Windows.Forms.Label jugadaFullHouse;
        private System.Windows.Forms.Label jugadaColor;
        private System.Windows.Forms.Label tituloResultado;
        private Label elegirCarta1;
        private Label elegirCarta2;
        private Button calculateButton;
    }
}