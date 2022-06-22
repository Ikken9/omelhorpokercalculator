namespace Proyecto_Combinatoria
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundImage = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundImage
            // 
            this.backgroundImage.Image = ((System.Drawing.Image)(resources.GetObject("backgroundImage.Image")));
            this.backgroundImage.Location = new System.Drawing.Point(0, 0);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(850, 350);
            this.backgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backgroundImage.TabIndex = 3;
            this.backgroundImage.TabStop = false;
            this.backgroundImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.Start.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.Start.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(360, 466);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(155, 49);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.backgroundImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Background";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox backgroundImage;
        private System.Windows.Forms.Button Start;
    }
}

