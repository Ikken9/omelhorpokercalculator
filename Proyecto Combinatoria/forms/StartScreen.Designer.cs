using System.Drawing;

namespace Proyecto_Combinatoria
{
    partial class StartScreen
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
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.Start.Font = new System.Drawing.Font("Chinese Rocks Rg", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(560, 620);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(166, 49);
            this.Start.TabIndex = 4;
            this.Start.Text = "COMENZAR";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.BackgroundImage = global::Proyecto_Combinatoria.Properties.Resources.RedDeadOnline2;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.Text = "Pantalla principal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Start;
    }
}

