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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectName));
            this.pictureBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBack
            // 
            this.pictureBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBack.BackgroundImage = global::WinFormsApp2.Properties.Resources.뒤로가기;
            this.pictureBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBack.Location = new System.Drawing.Point(945, 12);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(107, 118);
            this.pictureBack.TabIndex = 4;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormSelectName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 1881);
            this.Controls.Add(this.pictureBack);
            this.Name = "FormSelectName";
            this.Text = "FormSelectName";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBack;
        private Button button1;
    }
}