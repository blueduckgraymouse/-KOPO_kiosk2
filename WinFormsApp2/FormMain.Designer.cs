namespace WinFormsApp2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureOrder = new System.Windows.Forms.PictureBox();
            this.pictureBasket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOrder
            // 
            this.pictureOrder.BackColor = System.Drawing.Color.Transparent;
            this.pictureOrder.BackgroundImage = global::WinFormsApp2.Properties.Resources.클릭;
            this.pictureOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureOrder.Location = new System.Drawing.Point(264, 386);
            this.pictureOrder.Name = "pictureOrder";
            this.pictureOrder.Size = new System.Drawing.Size(496, 440);
            this.pictureOrder.TabIndex = 2;
            this.pictureOrder.TabStop = false;
            this.pictureOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // pictureBasket
            // 
            this.pictureBasket.BackColor = System.Drawing.Color.Transparent;
            this.pictureBasket.BackgroundImage = global::WinFormsApp2.Properties.Resources.장바구니2;
            this.pictureBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBasket.Location = new System.Drawing.Point(867, 37);
            this.pictureBasket.Name = "pictureBasket";
            this.pictureBasket.Size = new System.Drawing.Size(171, 110);
            this.pictureBasket.TabIndex = 3;
            this.pictureBasket.TabStop = false;
            this.pictureBasket.Click += new System.EventHandler(this.buttonBasket_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 1881);
            this.Controls.Add(this.pictureBasket);
            this.Controls.Add(this.pictureOrder);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBasket)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
        private PictureBox pictureOrder;
        private PictureBox pictureBasket;
    }
}