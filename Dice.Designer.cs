
namespace Feladatok12
{
    partial class Dice
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
            this.labelNumberOfTurns = new System.Windows.Forms.Label();
            this.textBoxGivenNumber = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonThrow = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(49, 7);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(184, 13);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Adj megszámot a kocka dobásokhoz.";
            // 
            // labelNumberOfTurns
            // 
            this.labelNumberOfTurns.AutoSize = true;
            this.labelNumberOfTurns.Location = new System.Drawing.Point(10, 33);
            this.labelNumberOfTurns.Name = "labelNumberOfTurns";
            this.labelNumberOfTurns.Size = new System.Drawing.Size(134, 13);
            this.labelNumberOfTurns.TabIndex = 1;
            this.labelNumberOfTurns.Text = "Hány kocka dobást késrz?";
            // 
            // textBoxGivenNumber
            // 
            this.textBoxGivenNumber.Location = new System.Drawing.Point(152, 30);
            this.textBoxGivenNumber.Name = "textBoxGivenNumber";
            this.textBoxGivenNumber.Size = new System.Drawing.Size(120, 20);
            this.textBoxGivenNumber.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(152, 148);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonThrow
            // 
            this.buttonThrow.Location = new System.Drawing.Point(10, 148);
            this.buttonThrow.Name = "buttonThrow";
            this.buttonThrow.Size = new System.Drawing.Size(120, 23);
            this.buttonThrow.TabIndex = 4;
            this.buttonThrow.Text = "Dobás";
            this.buttonThrow.UseVisualStyleBackColor = true;
            this.buttonThrow.Click += new System.EventHandler(this.buttonThrow_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 56);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(259, 86);
            this.textBoxResult.TabIndex = 5;
            // 
            // Dice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonThrow);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxGivenNumber);
            this.Controls.Add(this.labelNumberOfTurns);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dice";
            this.Text = "Kockadobások";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelNumberOfTurns;
        private System.Windows.Forms.TextBox textBoxGivenNumber;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonThrow;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}