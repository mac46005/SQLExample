
namespace SQLExample
{
    partial class DashBoard
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
            this.peopleFoundLIstBox = new System.Windows.Forms.ListBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.seatchButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundLIstBox
            // 
            this.peopleFoundLIstBox.FormattingEnabled = true;
            this.peopleFoundLIstBox.ItemHeight = 16;
            this.peopleFoundLIstBox.Location = new System.Drawing.Point(68, 120);
            this.peopleFoundLIstBox.Name = "peopleFoundLIstBox";
            this.peopleFoundLIstBox.Size = new System.Drawing.Size(289, 292);
            this.peopleFoundLIstBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(220, 48);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "LastName";
            // 
            // seatchButon
            // 
            this.seatchButon.Location = new System.Drawing.Point(130, 81);
            this.seatchButon.Name = "seatchButon";
            this.seatchButon.Size = new System.Drawing.Size(75, 23);
            this.seatchButon.TabIndex = 3;
            this.seatchButon.Text = "Search";
            this.seatchButon.UseVisualStyleBackColor = true;
            this.seatchButon.Click += new System.EventHandler(this.seatchButon_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seatchButon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.peopleFoundLIstBox);
            this.Name = "DashBoard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundLIstBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button seatchButon;
    }
}

