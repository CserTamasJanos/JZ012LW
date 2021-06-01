
namespace Feladatok12
{
    partial class ButtonEvents
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
            this.buttonForPractice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonForPractice
            // 
            this.buttonForPractice.Location = new System.Drawing.Point(44, 54);
            this.buttonForPractice.Name = "buttonForPractice";
            this.buttonForPractice.Size = new System.Drawing.Size(301, 46);
            this.buttonForPractice.TabIndex = 0;
            this.buttonForPractice.Text = "Egy egy gomb az események gyakorlására";
            this.buttonForPractice.UseVisualStyleBackColor = true;
            this.buttonForPractice.Click += new System.EventHandler(this.buttonForPractice_Click);
            this.buttonForPractice.MouseEnter += new System.EventHandler(this.buttonForPractice_MouseEnter);
            this.buttonForPractice.MouseLeave += new System.EventHandler(this.buttonForPractice_MouseLeave);
            this.buttonForPractice.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonForPractice_MouseMove);
            // 
            // ButtonEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.buttonForPractice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ButtonEvents";
            this.Text = "Gomb események";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonForPractice;
    }
}