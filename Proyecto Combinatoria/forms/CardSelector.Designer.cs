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
            this.carta2 = new System.Windows.Forms.Panel();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // carta1
            // 
            this.carta1.BackColor = System.Drawing.Color.Transparent;
            this.carta1.Location = new System.Drawing.Point(42, 80);
            this.carta1.Name = "carta1";
            this.carta1.Size = new System.Drawing.Size(163, 277);
            this.carta1.TabIndex = 0;
            this.carta1.Paint += new System.Windows.Forms.PaintEventHandler(this.carta1_Paint);
            // 
            // carta2
            // 
            this.carta2.BackColor = System.Drawing.Color.Transparent;
            this.carta2.Location = new System.Drawing.Point(250, 80);
            this.carta2.Name = "carta2";
            this.carta2.Size = new System.Drawing.Size(163, 277);
            this.carta2.TabIndex = 1;
            // 
            // panelResultados
            // 
            this.panelResultados.BackColor = System.Drawing.Color.Transparent;
            this.panelResultados.Location = new System.Drawing.Point(530, 80);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(286, 277);
            this.panelResultados.TabIndex = 2;
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
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.carta2);
            this.Controls.Add(this.carta1);
            this.Name = "CardSelector";
            this.Text = "Card selector";
            this.Load += new System.EventHandler(this.CardSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel carta1;
        private System.Windows.Forms.Panel carta2;
        private System.Windows.Forms.Panel panelResultados;
    }
}