namespace WinFormsApp2
{
    partial class FormAdmin
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
            this.buttonResultByName = new System.Windows.Forms.Button();
            this.buttonResultByMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonResultByName
            // 
            this.buttonResultByName.Location = new System.Drawing.Point(204, 72);
            this.buttonResultByName.Name = "buttonResultByName";
            this.buttonResultByName.Size = new System.Drawing.Size(75, 23);
            this.buttonResultByName.TabIndex = 0;
            this.buttonResultByName.Text = "이름별조회";
            this.buttonResultByName.UseVisualStyleBackColor = true;
            this.buttonResultByName.Click += new System.EventHandler(this.buttonResultByName_Click);
            // 
            // buttonResultByMenu
            // 
            this.buttonResultByMenu.Location = new System.Drawing.Point(300, 72);
            this.buttonResultByMenu.Name = "buttonResultByMenu";
            this.buttonResultByMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonResultByMenu.TabIndex = 1;
            this.buttonResultByMenu.Text = "메뉴별조회";
            this.buttonResultByMenu.UseVisualStyleBackColor = true;
            this.buttonResultByMenu.Click += new System.EventHandler(this.buttonResultByMenu_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1200);
            this.Controls.Add(this.buttonResultByName);
            this.Controls.Add(this.buttonResultByMenu);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonResultByName;
        private Button buttonResultByMenu;
    }
}