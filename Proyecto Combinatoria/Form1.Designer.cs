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
            this.chooseCard = new System.Windows.Forms.ComboBox();
            this.chooseSuit = new System.Windows.Forms.ComboBox();
            this.backgroundImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseCard
            // 
            this.chooseCard.FormattingEnabled = true;
            this.chooseCard.Location = new System.Drawing.Point(112, 498);
            this.chooseCard.Name = "chooseCard";
            this.chooseCard.Size = new System.Drawing.Size(121, 21);
            this.chooseCard.TabIndex = 1;
            // 
            // chooseSuit
            // 
            this.chooseSuit.FormattingEnabled = true;
            this.chooseSuit.Location = new System.Drawing.Point(614, 498);
            this.chooseSuit.Name = "chooseSuit";
            this.chooseSuit.Size = new System.Drawing.Size(121, 21);
            this.chooseSuit.TabIndex = 2;
            this.chooseSuit.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.backgroundImage);
            this.Controls.Add(this.chooseSuit);
            this.Controls.Add(this.chooseCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Background";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox chooseCard;
        private System.Windows.Forms.ComboBox chooseSuit;
        private System.Windows.Forms.PictureBox backgroundImage;
    }
}

