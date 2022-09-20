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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WinFormsApp2.Properties.Resources.폴리텍;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(415, 1700);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(442, 1814);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "ⓒ 최수혁. 임현덕, 주재영";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 1881);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBasket);
            this.Controls.Add(this.pictureOrder);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
        private PictureBox pictureOrder;
        private PictureBox pictureBasket;
        private PictureBox pictureBox1;
        private Label label1;
    }
}