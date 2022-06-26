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
            this.elegirNumeroBox1 = new System.Windows.Forms.ComboBox();
            this.elegirCarta1 = new System.Windows.Forms.Label();
            this.elegirCarta1Box = new System.Windows.Forms.ComboBox();
            this.carta2 = new System.Windows.Forms.Panel();
            this.elegirNumeroBox2 = new System.Windows.Forms.ComboBox();
            this.elegirCarta2Box = new System.Windows.Forms.ComboBox();
            this.elegirCarta2 = new System.Windows.Forms.Label();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.resultadoEscaleraReal = new System.Windows.Forms.Label();
            this.resultadoPoker = new System.Windows.Forms.Label();
            this.resultadoFullHouse = new System.Windows.Forms.Label();
            this.resultadoColor = new System.Windows.Forms.Label();
            this.tituloResultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloJugadas = new System.Windows.Forms.Label();
            this.jugadaEscaleraReal = new System.Windows.Forms.Label();
            this.jugadaPoker = new System.Windows.Forms.Label();
            this.jugadaFullHouse = new System.Windows.Forms.Label();
            this.jugadaColor = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.carta1.SuspendLayout();
            this.carta2.SuspendLayout();
            this.panelResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // carta1
            // 
            this.carta1.BackColor = System.Drawing.Color.Transparent;
            this.carta1.Controls.Add(this.elegirNumeroBox1);
            this.carta1.Controls.Add(this.elegirCarta1);
            this.carta1.Controls.Add(this.elegirCarta1Box);
            this.carta1.Location = new System.Drawing.Point(57, 147);
            this.carta1.Name = "carta1";
            this.carta1.Size = new System.Drawing.Size(198, 286);
            this.carta1.TabIndex = 0;
            this.carta1.Paint += new System.Windows.Forms.PaintEventHandler(this.carta1_Paint);
            // 
            // elegirNumeroBox1
            // 
            this.elegirNumeroBox1.Font = new System.Drawing.Font("Chinese Rocks Rg", 14.25F);
            this.elegirNumeroBox1.FormattingEnabled = true;
            this.elegirNumeroBox1.Location = new System.Drawing.Point(23, 122);
            this.elegirNumeroBox1.Name = "elegirNumeroBox1";
            this.elegirNumeroBox1.Size = new System.Drawing.Size(121, 31);
            this.elegirNumeroBox1.TabIndex = 4;
            this.elegirNumeroBox1.Visible = false;
            this.elegirNumeroBox1.SelectedIndexChanged += new System.EventHandler(this.elegirNumeroBox1_SelectedIndexChanged);
            // 
            // elegirCarta1
            // 
            this.elegirCarta1.AutoSize = true;
            this.elegirCarta1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elegirCarta1.Font = new System.Drawing.Font("Chinese Rocks Rg", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elegirCarta1.ForeColor = System.Drawing.Color.Black;
            this.elegirCarta1.Location = new System.Drawing.Point(17, 122);
            this.elegirCarta1.Name = "elegirCarta1";
            this.elegirCarta1.Size = new System.Drawing.Size(165, 35);
            this.elegirCarta1.TabIndex = 0;
            this.elegirCarta1.Text = "Elegir Carta 1";
            this.elegirCarta1.Click += new System.EventHandler(this.elegirCarta1_Click);
            // 
            // elegirCarta1Box
            // 
            this.elegirCarta1Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.elegirCarta1Box.Font = new System.Drawing.Font("Chinese Rocks Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elegirCarta1Box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.elegirCarta1Box.FormattingEnabled = true;
            this.elegirCarta1Box.ItemHeight = 23;
            this.elegirCarta1Box.Items.AddRange(new object[] {
            "Corazones",
            "Diamantes",
            "Picas",
            "Tréboles"});
            this.elegirCarta1Box.Location = new System.Drawing.Point(23, 123);
            this.elegirCarta1Box.Name = "elegirCarta1Box";
            this.elegirCarta1Box.Size = new System.Drawing.Size(121, 31);
            this.elegirCarta1Box.Sorted = true;
            this.elegirCarta1Box.TabIndex = 1;
            this.elegirCarta1Box.Visible = false;
            this.elegirCarta1Box.SelectedIndexChanged += new System.EventHandler(this.elegirCarta1Box_SelectedIndexChanged);
            // 
            // carta2
            // 
            this.carta2.BackColor = System.Drawing.Color.Transparent;
            this.carta2.Controls.Add(this.elegirNumeroBox2);
            this.carta2.Controls.Add(this.elegirCarta2Box);
            this.carta2.Controls.Add(this.elegirCarta2);
            this.carta2.Location = new System.Drawing.Point(392, 147);
            this.carta2.Name = "carta2";
            this.carta2.Size = new System.Drawing.Size(198, 286);
            this.carta2.TabIndex = 1;
            this.carta2.Paint += new System.Windows.Forms.PaintEventHandler(this.carta2_Paint);
            // 
            // elegirNumeroBox2
            // 
            this.elegirNumeroBox2.Font = new System.Drawing.Font("Chinese Rocks Rg", 14.25F);
            this.elegirNumeroBox2.FormattingEnabled = true;
            this.elegirNumeroBox2.Location = new System.Drawing.Point(19, 122);
            this.elegirNumeroBox2.Name = "elegirNumeroBox2";
            this.elegirNumeroBox2.Size = new System.Drawing.Size(121, 31);
            this.elegirNumeroBox2.TabIndex = 4;
            this.elegirNumeroBox2.Visible = false;
            this.elegirNumeroBox2.SelectedIndexChanged += new System.EventHandler(this.elegirNumeroBox2_SelectedIndexChanged);
            // 
            // elegirCarta2Box
            // 
            this.elegirCarta2Box.Font = new System.Drawing.Font("Chinese Rocks Rg", 14.25F);
            this.elegirCarta2Box.FormattingEnabled = true;
            this.elegirCarta2Box.ItemHeight = 23;
            this.elegirCarta2Box.Items.AddRange(new object[] {
            "Corazones",
            "Diamantes",
            "Picas",
            "Tréboles"});
            this.elegirCarta2Box.Location = new System.Drawing.Point(19, 122);
            this.elegirCarta2Box.Name = "elegirCarta2Box";
            this.elegirCarta2Box.Size = new System.Drawing.Size(121, 31);
            this.elegirCarta2Box.Sorted = true;
            this.elegirCarta2Box.TabIndex = 1;
            this.elegirCarta2Box.Visible = false;
            this.elegirCarta2Box.SelectedIndexChanged += new System.EventHandler(this.elegirCarta2Box_SelectedIndexChanged);
            // 
            // elegirCarta2
            // 
            this.elegirCarta2.AutoSize = true;
            this.elegirCarta2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elegirCarta2.Font = new System.Drawing.Font("Chinese Rocks Rg", 21.75F);
            this.elegirCarta2.ForeColor = System.Drawing.Color.Black;
            this.elegirCarta2.Location = new System.Drawing.Point(13, 122);
            this.elegirCarta2.Name = "elegirCarta2";
            this.elegirCarta2.Size = new System.Drawing.Size(169, 35);
            this.elegirCarta2.TabIndex = 0;
            this.elegirCarta2.Text = "Elegir Carta 2";
            this.elegirCarta2.Click += new System.EventHandler(this.elegirCarta2_Click);
            // 
            // panelResultados
            // 
            this.panelResultados.BackColor = System.Drawing.Color.Transparent;
            this.panelResultados.Controls.Add(this.resultadoEscaleraReal);
            this.panelResultados.Controls.Add(this.resultadoPoker);
            this.panelResultados.Controls.Add(this.resultadoFullHouse);
            this.panelResultados.Controls.Add(this.resultadoColor);
            this.panelResultados.Controls.Add(this.tituloResultado);
            this.panelResultados.Controls.Add(this.panel1);
            this.panelResultados.Controls.Add(this.tituloJugadas);
            this.panelResultados.Controls.Add(this.jugadaEscaleraReal);
            this.panelResultados.Controls.Add(this.jugadaPoker);
            this.panelResultados.Controls.Add(this.jugadaFullHouse);
            this.panelResultados.Controls.Add(this.jugadaColor);
            this.panelResultados.Location = new System.Drawing.Point(938, 156);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(286, 277);
            this.panelResultados.TabIndex = 2;
            this.panelResultados.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResultados_Paint);
            // 
            // resultadoEscaleraReal
            // 
            this.resultadoEscaleraReal.AutoSize = true;
            this.resultadoEscaleraReal.Font = new System.Drawing.Font("Chinese Rocks Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoEscaleraReal.ForeColor = System.Drawing.Color.White;
            this.resultadoEscaleraReal.Location = new System.Drawing.Point(200, 231);
            this.resultadoEscaleraReal.Name = "resultadoEscaleraReal";
            this.resultadoEscaleraReal.Size = new System.Drawing.Size(27, 25);
            this.resultadoEscaleraReal.TabIndex = 10;
            this.resultadoEscaleraReal.Text = "...";
            // 
            // resultadoPoker
            // 
            this.resultadoPoker.AutoSize = true;
            this.resultadoPoker.Font = new System.Drawing.Font("Chinese Rocks Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoPoker.ForeColor = System.Drawing.Color.White;
            this.resultadoPoker.Location = new System.Drawing.Point(200, 179);
            this.resultadoPoker.Name = "resultadoPoker";
            this.resultadoPoker.Size = new System.Drawing.Size(27, 25);
            this.resultadoPoker.TabIndex = 9;
            this.resultadoPoker.Text = "...";
            // 
            // resultadoFullHouse
            // 
            this.resultadoFullHouse.AutoSize = true;
            this.resultadoFullHouse.Font = new System.Drawing.Font("Chinese Rocks Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoFullHouse.ForeColor = System.Drawing.Color.White;
            this.resultadoFullHouse.Location = new System.Drawing.Point(200, 121);
            this.resultadoFullHouse.Name = "resultadoFullHouse";
            this.resultadoFullHouse.Size = new System.Drawing.Size(27, 25);
            this.resultadoFullHouse.TabIndex = 8;
            this.resultadoFullHouse.Text = "...";
            // 
            // resultadoColor
            // 
            this.resultadoColor.AutoSize = true;
            this.resultadoColor.Font = new System.Drawing.Font("Chinese Rocks Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoColor.ForeColor = System.Drawing.Color.White;
            this.resultadoColor.Location = new System.Drawing.Point(200, 71);
            this.resultadoColor.Name = "resultadoColor";
            this.resultadoColor.Size = new System.Drawing.Size(27, 25);
            this.resultadoColor.TabIndex = 7;
            this.resultadoColor.Text = "...";
            // 
            // tituloResultado
            // 
            this.tituloResultado.AutoSize = true;
            this.tituloResultado.Font = new System.Drawing.Font("Chinese Rocks Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloResultado.ForeColor = System.Drawing.Color.White;
            this.tituloResultado.Location = new System.Drawing.Point(170, 16);
            this.tituloResultado.Name = "tituloResultado";
            this.tituloResultado.Size = new System.Drawing.Size(96, 25);
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
            this.tituloJugadas.Font = new System.Drawing.Font("Chinese Rocks Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloJugadas.ForeColor = System.Drawing.Color.White;
            this.tituloJugadas.Location = new System.Drawing.Point(16, 18);
            this.tituloJugadas.Name = "tituloJugadas";
            this.tituloJugadas.Size = new System.Drawing.Size(84, 25);
            this.tituloJugadas.TabIndex = 4;
            this.tituloJugadas.Text = "Jugadas:";
            this.tituloJugadas.Click += new System.EventHandler(this.tituloJugadas_Click);
            // 
            // jugadaEscaleraReal
            // 
            this.jugadaEscaleraReal.AutoSize = true;
            this.jugadaEscaleraReal.Font = new System.Drawing.Font("Chinese Rocks Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugadaEscaleraReal.ForeColor = System.Drawing.Color.White;
            this.jugadaEscaleraReal.Location = new System.Drawing.Point(16, 231);
            this.jugadaEscaleraReal.Name = "jugadaEscaleraReal";
            this.jugadaEscaleraReal.Size = new System.Drawing.Size(128, 25);
            this.jugadaEscaleraReal.TabIndex = 3;
            this.jugadaEscaleraReal.Text = "Escalera Real:";
            // 
            // jugadaPoker
            // 
            this.jugadaPoker.AutoSize = true;
            this.jugadaPoker.Font = new System.Drawing.Font("Chinese Rocks Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugadaPoker.ForeColor = System.Drawing.Color.White;
            this.jugadaPoker.Location = new System.Drawing.Point(16, 179);
            this.jugadaPoker.Name = "jugadaPoker";
            this.jugadaPoker.Size = new System.Drawing.Size(62, 25);
            this.jugadaPoker.TabIndex = 2;
            this.jugadaPoker.Text = "Poker:";
            // 
            // jugadaFullHouse
            // 
            this.jugadaFullHouse.AutoSize = true;
            this.jugadaFullHouse.Font = new System.Drawing.Font("Chinese Rocks Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugadaFullHouse.ForeColor = System.Drawing.Color.White;
            this.jugadaFullHouse.Location = new System.Drawing.Point(16, 123);
            this.jugadaFullHouse.Name = "jugadaFullHouse";
            this.jugadaFullHouse.Size = new System.Drawing.Size(103, 25);
            this.jugadaFullHouse.TabIndex = 1;
            this.jugadaFullHouse.Text = "Full House:";
            // 
            // jugadaColor
            // 
            this.jugadaColor.AutoSize = true;
            this.jugadaColor.Font = new System.Drawing.Font("Chinese Rocks Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugadaColor.ForeColor = System.Drawing.Color.White;
            this.jugadaColor.Location = new System.Drawing.Point(16, 71);
            this.jugadaColor.Name = "jugadaColor";
            this.jugadaColor.Size = new System.Drawing.Size(64, 25);
            this.jugadaColor.TabIndex = 0;
            this.jugadaColor.Text = "Color:";
            this.jugadaColor.Click += new System.EventHandler(this.jugadaColor_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Transparent;
            this.calculateButton.Font = new System.Drawing.Font("Chinese Rocks Rg", 28F);
            this.calculateButton.ForeColor = System.Drawing.Color.Black;
            this.calculateButton.Location = new System.Drawing.Point(577, 607);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(171, 52);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "CALCULAR";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.Font = new System.Drawing.Font("Chinese Rocks Rg", 14F);
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(21, 636);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(91, 33);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "REINICIAR";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // salirButton
            // 
            this.salirButton.BackColor = System.Drawing.Color.Transparent;
            this.salirButton.Font = new System.Drawing.Font("Chinese Rocks Rg", 14F);
            this.salirButton.ForeColor = System.Drawing.Color.Black;
            this.salirButton.Location = new System.Drawing.Point(1152, 636);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(91, 33);
            this.salirButton.TabIndex = 5;
            this.salirButton.Text = "SALIR";
            this.salirButton.UseVisualStyleBackColor = false;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // CardSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Proyecto_Combinatoria.Properties.Resources.RedDeadOnline2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.carta2);
            this.Controls.Add(this.carta1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CardSelector";
            this.Text = "Seleccionar carta";
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
        private ComboBox elegirCarta1Box;
        private ComboBox elegirCarta2Box;
        private ComboBox elegirNumeroBox1;
        private ComboBox elegirNumeroBox2;
        private Button resetButton;
        private Button salirButton;
        private Label resultadoEscaleraReal;
        private Label resultadoPoker;
        private Label resultadoFullHouse;
        private Label resultadoColor;
    }
}