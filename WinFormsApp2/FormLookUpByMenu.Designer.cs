namespace WinFormsApp2
{
    partial class FormLookUpByMenu
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
            this.dataGridView_selectByMenu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectByMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView_selectByMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_selectByMenu.Location = new System.Drawing.Point(12, 55);
            this.dataGridView_selectByMenu.Name = "dataGridView_selectByMenu";
            this.dataGridView_selectByMenu.RowTemplate.Height = 25;
            this.dataGridView_selectByMenu.Size = new System.Drawing.Size(812, 653);
            this.dataGridView_selectByMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_selectByMenu);
            // 
            // FormLookUpByMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_selectByMenu);
            this.Name = "FormLookUpByMenu";
            this.Text = "메뉴별조회";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectByMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_selectByMenu;
        private Button button1;
    }
}