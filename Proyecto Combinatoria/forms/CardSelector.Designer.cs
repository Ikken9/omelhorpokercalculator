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
            this.elegirPaloComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // elegirPaloComboBox
            // 
            this.elegirPaloComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.elegirPaloComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elegirPaloComboBox.FormattingEnabled = true;
            this.elegirPaloComboBox.Items.AddRange(new object[] {
            "Corazones",
            "Diamantes",
            "Picas",
            "Tréboles"});
            this.elegirPaloComboBox.Location = new System.Drawing.Point(130, 33);
            this.elegirPaloComboBox.Name = "elegirPaloComboBox";
            this.elegirPaloComboBox.Size = new System.Drawing.Size(121, 25);
            this.elegirPaloComboBox.Sorted = true;
            this.elegirPaloComboBox.TabIndex = 0;
            this.elegirPaloComboBox.SelectedIndexChanged += new System.EventHandler(this.elegirPaloComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elegir palo ";
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elegirPaloComboBox);
            this.Name = "CardSelector";
            this.Text = "Card selector";
            this.Load += new System.EventHandler(this.CardSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox elegirPaloComboBox;
        private System.Windows.Forms.Label label1;
    }
}