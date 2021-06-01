
namespace Feladatok12
{
    partial class HundredRandom
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
            this.labelSmallestNumber = new System.Windows.Forms.Label();
            this.labelBiggestNumber = new System.Windows.Forms.Label();
            this.buttonGenerateNumbers = new System.Windows.Forms.Button();
            this.textBoxSmallest = new System.Windows.Forms.TextBox();
            this.textBoxBiggest = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(12, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(221, 13);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Milyen intervallumból generáljam a számokat?";
            // 
            // labelSmallestNumber
            // 
            this.labelSmallestNumber.AutoSize = true;
            this.labelSmallestNumber.Location = new System.Drawing.Point(19, 37);
            this.labelSmallestNumber.Name = "labelSmallestNumber";
            this.labelSmallestNumber.Size = new System.Drawing.Size(86, 13);
            this.labelSmallestNumber.TabIndex = 1;
            this.labelSmallestNumber.Text = "Legkisebb szám:";
            // 
            // labelBiggestNumber
            // 
            this.labelBiggestNumber.AutoSize = true;
            this.labelBiggestNumber.Location = new System.Drawing.Point(19, 63);
            this.labelBiggestNumber.Name = "labelBiggestNumber";
            this.labelBiggestNumber.Size = new System.Drawing.Size(96, 13);
            this.labelBiggestNumber.TabIndex = 2;
            this.labelBiggestNumber.Text = "Legnagyobb szám:";
            // 
            // buttonGenerateNumbers
            // 
            this.buttonGenerateNumbers.Location = new System.Drawing.Point(49, 86);
            this.buttonGenerateNumbers.Name = "buttonGenerateNumbers";
            this.buttonGenerateNumbers.Size = new System.Drawing.Size(153, 23);
            this.buttonGenerateNumbers.TabIndex = 3;
            this.buttonGenerateNumbers.Text = "Számok generálása";
            this.buttonGenerateNumbers.UseVisualStyleBackColor = true;
            this.buttonGenerateNumbers.Click += new System.EventHandler(this.buttonGenerateNumbers_Click);
            // 
            // textBoxSmallest
            // 
            this.textBoxSmallest.Location = new System.Drawing.Point(120, 34);
            this.textBoxSmallest.Name = "textBoxSmallest";
            this.textBoxSmallest.Size = new System.Drawing.Size(101, 20);
            this.textBoxSmallest.TabIndex = 4;
            // 
            // textBoxBiggest
            // 
            this.textBoxBiggest.Location = new System.Drawing.Point(121, 60);
            this.textBoxBiggest.Name = "textBoxBiggest";
            this.textBoxBiggest.Size = new System.Drawing.Size(100, 20);
            this.textBoxBiggest.TabIndex = 5;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(22, 115);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(199, 107);
            this.textBoxResult.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(49, 228);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(153, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // HundredRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 256);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxBiggest);
            this.Controls.Add(this.textBoxSmallest);
            this.Controls.Add(this.buttonGenerateNumbers);
            this.Controls.Add(this.labelBiggestNumber);
            this.Controls.Add(this.labelSmallestNumber);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HundredRandom";
            this.Text = "100 véletlen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelSmallestNumber;
        private System.Windows.Forms.Label labelBiggestNumber;
        private System.Windows.Forms.Button buttonGenerateNumbers;
        private System.Windows.Forms.TextBox textBoxSmallest;
        private System.Windows.Forms.TextBox textBoxBiggest;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonCancel;
    }
}