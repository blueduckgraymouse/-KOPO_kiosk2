namespace WinFormsApp2
{
    partial class FormSelectName
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
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBack
            // 
            this.pictureBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBack.BackgroundImage = global::WinFormsApp2.Properties.Resources.뒤로가기2;
            this.pictureBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBack.Location = new System.Drawing.Point(945, 12);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(107, 118);
            this.pictureBack.TabIndex = 4;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHome.BackgroundImage = global::WinFormsApp2.Properties.Resources.home;
            this.pictureBoxHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHome.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(107, 118);
            this.pictureBoxHome.TabIndex = 5;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // FormSelectName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp2.Properties.Resources.배경_일러스트;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 1881);
            this.Controls.Add(this.pictureBoxHome);
            this.Controls.Add(this.pictureBack);
            this.Name = "FormSelectName";
            this.Text = "이름 선택";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBack;
        private Button button1;
        private PictureBox pictureBoxHome;
    }
}