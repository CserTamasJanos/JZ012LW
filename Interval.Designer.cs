
namespace Feladatok12
{
    partial class Interval
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
            this.labelUpperLimit = new System.Windows.Forms.Label();
            this.labelLowerLimit = new System.Windows.Forms.Label();
            this.textBoxLowerLimit = new System.Windows.Forms.TextBox();
            this.textBoxUpperLimit = new System.Windows.Forms.TextBox();
            this.textBoxGivenNumber = new System.Windows.Forms.TextBox();
            this.labelGivenNumber = new System.Windows.Forms.Label();
            this.buttonOperate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(17, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(203, 13);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Adjon meg egyintervallumot és egyszámot";
            // 
            // labelUpperLimit
            // 
            this.labelUpperLimit.AutoSize = true;
            this.labelUpperLimit.Location = new System.Drawing.Point(121, 33);
            this.labelUpperLimit.Name = "labelUpperLimit";
            this.labelUpperLimit.Size = new System.Drawing.Size(59, 13);
            this.labelUpperLimit.TabIndex = 1;
            this.labelUpperLimit.Text = "Felső határ";
            // 
            // labelLowerLimit
            // 
            this.labelLowerLimit.AutoSize = true;
            this.labelLowerLimit.Location = new System.Drawing.Point(10, 33);
            this.labelLowerLimit.Name = "labelLowerLimit";
            this.labelLowerLimit.Size = new System.Drawing.Size(58, 13);
            this.labelLowerLimit.TabIndex = 2;
            this.labelLowerLimit.Text = "ALsó határ";
            // 
            // textBoxLowerLimit
            // 
            this.textBoxLowerLimit.Location = new System.Drawing.Point(12, 49);
            this.textBoxLowerLimit.Name = "textBoxLowerLimit";
            this.textBoxLowerLimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxLowerLimit.TabIndex = 3;
            // 
            // textBoxUpperLimit
            // 
            this.textBoxUpperLimit.Location = new System.Drawing.Point(124, 49);
            this.textBoxUpperLimit.Name = "textBoxUpperLimit";
            this.textBoxUpperLimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpperLimit.TabIndex = 4;
            // 
            // textBoxGivenNumber
            // 
            this.textBoxGivenNumber.Location = new System.Drawing.Point(13, 95);
            this.textBoxGivenNumber.Name = "textBoxGivenNumber";
            this.textBoxGivenNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxGivenNumber.TabIndex = 5;
            // 
            // labelGivenNumber
            // 
            this.labelGivenNumber.AutoSize = true;
            this.labelGivenNumber.Location = new System.Drawing.Point(10, 79);
            this.labelGivenNumber.Name = "labelGivenNumber";
            this.labelGivenNumber.Size = new System.Drawing.Size(79, 13);
            this.labelGivenNumber.TabIndex = 6;
            this.labelGivenNumber.Text = "Megadott szám";
            // 
            // buttonOperate
            // 
            this.buttonOperate.Location = new System.Drawing.Point(124, 93);
            this.buttonOperate.Name = "buttonOperate";
            this.buttonOperate.Size = new System.Drawing.Size(100, 23);
            this.buttonOperate.TabIndex = 7;
            this.buttonOperate.Text = "Megállapít";
            this.buttonOperate.UseVisualStyleBackColor = true;
            this.buttonOperate.Click += new System.EventHandler(this.buttonOperate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(126, 148);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(10, 125);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(68, 13);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Az eredmény";
            // 
            // Interval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 181);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOperate);
            this.Controls.Add(this.labelGivenNumber);
            this.Controls.Add(this.textBoxGivenNumber);
            this.Controls.Add(this.textBoxUpperLimit);
            this.Controls.Add(this.textBoxLowerLimit);
            this.Controls.Add(this.labelLowerLimit);
            this.Controls.Add(this.labelUpperLimit);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Interval";
            this.Text = "Intervallum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelUpperLimit;
        private System.Windows.Forms.Label labelLowerLimit;
        private System.Windows.Forms.TextBox textBoxLowerLimit;
        private System.Windows.Forms.TextBox textBoxUpperLimit;
        private System.Windows.Forms.TextBox textBoxGivenNumber;
        private System.Windows.Forms.Label labelGivenNumber;
        private System.Windows.Forms.Button buttonOperate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelResult;
    }
}