
namespace Feladatok12
{
    partial class Dividers
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
            this.labelMain = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonShowDividers = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.listBoxDividers = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(10, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(250, 13);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Adjon meg egy számot az osztók megjelenítéséhez.";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(10, 37);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(33, 13);
            this.labelNumber.TabIndex = 1;
            this.labelNumber.Text = "Szám";
            // 
            // buttonShowDividers
            // 
            this.buttonShowDividers.Location = new System.Drawing.Point(155, 31);
            this.buttonShowDividers.Name = "buttonShowDividers";
            this.buttonShowDividers.Size = new System.Drawing.Size(97, 23);
            this.buttonShowDividers.TabIndex = 2;
            this.buttonShowDividers.Text = "Osztók";
            this.buttonShowDividers.UseVisualStyleBackColor = true;
            this.buttonShowDividers.Click += new System.EventHandler(this.buttonShowDividers_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(45, 34);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // listBoxDividers
            // 
            this.listBoxDividers.FormattingEnabled = true;
            this.listBoxDividers.Location = new System.Drawing.Point(12, 64);
            this.listBoxDividers.Name = "listBoxDividers";
            this.listBoxDividers.Size = new System.Drawing.Size(133, 95);
            this.listBoxDividers.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(155, 135);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Dividers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 166);
            this.Controls.Add(this.listBoxDividers);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonShowDividers);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dividers";
            this.Text = "Osztók";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonShowDividers;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.ListBox listBoxDividers;
        private System.Windows.Forms.Button buttonCancel;
    }
}