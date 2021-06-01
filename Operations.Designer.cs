
namespace Feladatok12
{
    partial class Operations
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
            this.textBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.textBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelFirstNumber = new System.Windows.Forms.Label();
            this.labelSecondNumber = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonSubstraction = new System.Windows.Forms.Button();
            this.buttonAdding = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstNumber
            // 
            this.textBoxFirstNumber.Location = new System.Drawing.Point(12, 48);
            this.textBoxFirstNumber.Name = "textBoxFirstNumber";
            this.textBoxFirstNumber.Size = new System.Drawing.Size(130, 20);
            this.textBoxFirstNumber.TabIndex = 0;
            // 
            // textBoxSecondNumber
            // 
            this.textBoxSecondNumber.Location = new System.Drawing.Point(151, 48);
            this.textBoxSecondNumber.Name = "textBoxSecondNumber";
            this.textBoxSecondNumber.Size = new System.Drawing.Size(130, 20);
            this.textBoxSecondNumber.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 92);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(130, 20);
            this.textBoxResult.TabIndex = 2;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(52, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(183, 13);
            this.labelMain.TabIndex = 3;
            this.labelMain.Text = "Adja meg kétszámot a műveletekhez.";
            // 
            // labelFirstNumber
            // 
            this.labelFirstNumber.AutoSize = true;
            this.labelFirstNumber.Location = new System.Drawing.Point(12, 32);
            this.labelFirstNumber.Name = "labelFirstNumber";
            this.labelFirstNumber.Size = new System.Drawing.Size(54, 13);
            this.labelFirstNumber.TabIndex = 4;
            this.labelFirstNumber.Text = "Első szám";
            // 
            // labelSecondNumber
            // 
            this.labelSecondNumber.AutoSize = true;
            this.labelSecondNumber.Location = new System.Drawing.Point(148, 32);
            this.labelSecondNumber.Name = "labelSecondNumber";
            this.labelSecondNumber.Size = new System.Drawing.Size(74, 13);
            this.labelSecondNumber.TabIndex = 5;
            this.labelSecondNumber.Text = "Második szám";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(9, 76);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(112, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "A művelet eredménye:";
            // 
            // buttonSubstraction
            // 
            this.buttonSubstraction.Location = new System.Drawing.Point(148, 122);
            this.buttonSubstraction.Name = "buttonSubstraction";
            this.buttonSubstraction.Size = new System.Drawing.Size(100, 25);
            this.buttonSubstraction.TabIndex = 7;
            this.buttonSubstraction.Text = "Kivonás";
            this.buttonSubstraction.UseVisualStyleBackColor = true;
            // 
            // buttonAdding
            // 
            this.buttonAdding.Location = new System.Drawing.Point(42, 122);
            this.buttonAdding.Name = "buttonAdding";
            this.buttonAdding.Size = new System.Drawing.Size(100, 25);
            this.buttonAdding.TabIndex = 8;
            this.buttonAdding.Text = "Összeadás";
            this.buttonAdding.UseVisualStyleBackColor = true;
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(148, 151);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(100, 25);
            this.buttonDivision.TabIndex = 9;
            this.buttonDivision.Text = "Osztás";
            this.buttonDivision.UseVisualStyleBackColor = true;
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Location = new System.Drawing.Point(42, 151);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(100, 25);
            this.buttonMultiplication.TabIndex = 10;
            this.buttonMultiplication.Text = "Szorzás";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(12, 186);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(75, 23);
            this.buttonErase.TabIndex = 11;
            this.buttonErase.Text = "Törlés";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(206, 186);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 221);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonAdding);
            this.Controls.Add(this.buttonSubstraction);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSecondNumber);
            this.Controls.Add(this.labelFirstNumber);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxSecondNumber);
            this.Controls.Add(this.textBoxFirstNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Operations";
            this.Text = "Műveletek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstNumber;
        private System.Windows.Forms.TextBox textBoxSecondNumber;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelFirstNumber;
        private System.Windows.Forms.Label labelSecondNumber;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonSubstraction;
        private System.Windows.Forms.Button buttonAdding;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonCancel;
    }
}