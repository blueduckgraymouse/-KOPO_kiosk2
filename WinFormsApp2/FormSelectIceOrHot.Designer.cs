namespace WinFormsApp2
{
    partial class FormSelectIceOrHot
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
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.BackgroundImage = global::WinFormsApp2.Properties.Resources.뒤로가기2;
            this.pictureBoxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBack.Location = new System.Drawing.Point(945, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(107, 118);
            this.pictureBoxBack.TabIndex = 3;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHome.BackgroundImage = global::WinFormsApp2.Properties.Resources.home;
            this.pictureBoxHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHome.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(107, 118);
            this.pictureBoxHome.TabIndex = 2;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // FormSelectIceOrHot
            // 
            this.BackgroundImage = global::WinFormsApp2.Properties.Resources.배경_일러스트;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 1881);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureBoxHome);
            this.Name = "FormSelectIceOrHot";
            this.Text = "핫 / 아이스 선택";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxBack;
        private PictureBox pictureBoxHome;
    }
}