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
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(128, 116);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonOrder.TabIndex = 0;
            this.buttonOrder.Text = "주문";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(297, 116);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 1;
            this.buttonResult.Text = "조회";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 309);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonOrder);
            this.Name = "FormMain";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);

    }

    #endregion

    private Button buttonOrder;
    private Button buttonResult;
}
}