
namespace Feladatok12
{
    partial class Pythagorean
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
            this.labelLeg1 = new System.Windows.Forms.Label();
            this.labelLeg2 = new System.Windows.Forms.Label();
            this.labelHypotenuse = new System.Windows.Forms.Label();
            this.textBoxClamp1 = new System.Windows.Forms.TextBox();
            this.textBoxClamp2 = new System.Windows.Forms.TextBox();
            this.textBoxHypotenuse = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(82, 10);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(226, 13);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Adjon meg legalább két adatot a számoláshoz.";
            // 
            // labelLeg1
            // 
            this.labelLeg1.AutoSize = true;
            this.labelLeg1.Location = new System.Drawing.Point(10, 36);
            this.labelLeg1.Name = "labelLeg1";
            this.labelLeg1.Size = new System.Drawing.Size(53, 13);
            this.labelLeg1.TabIndex = 1;
            this.labelLeg1.Text = "Befogó, a";
            // 
            // labelLeg2
            // 
            this.labelLeg2.AutoSize = true;
            this.labelLeg2.Location = new System.Drawing.Point(10, 59);
            this.labelLeg2.Name = "labelLeg2";
            this.labelLeg2.Size = new System.Drawing.Size(53, 13);
            this.labelLeg2.TabIndex = 2;
            this.labelLeg2.Text = "Befogó, b";
            // 
            // labelHypotenuse
            // 
            this.labelHypotenuse.AutoSize = true;
            this.labelHypotenuse.Location = new System.Drawing.Point(10, 85);
            this.labelHypotenuse.Name = "labelHypotenuse";
            this.labelHypotenuse.Size = new System.Drawing.Size(50, 13);
            this.labelHypotenuse.TabIndex = 3;
            this.labelHypotenuse.Text = "Átfogó, c";
            // 
            // textBoxClamp1
            // 
            this.textBoxClamp1.Location = new System.Drawing.Point(66, 33);
            this.textBoxClamp1.Name = "textBoxClamp1";
            this.textBoxClamp1.Size = new System.Drawing.Size(100, 20);
            this.textBoxClamp1.TabIndex = 4;
            // 
            // textBoxClamp2
            // 
            this.textBoxClamp2.Location = new System.Drawing.Point(66, 59);
            this.textBoxClamp2.Name = "textBoxClamp2";
            this.textBoxClamp2.Size = new System.Drawing.Size(100, 20);
            this.textBoxClamp2.TabIndex = 4;
            // 
            // textBoxHypotenuse
            // 
            this.textBoxHypotenuse.Location = new System.Drawing.Point(66, 85);
            this.textBoxHypotenuse.Name = "textBoxHypotenuse";
            this.textBoxHypotenuse.Size = new System.Drawing.Size(100, 20);
            this.textBoxHypotenuse.TabIndex = 4;
            // 
            // listBoxResult
            // 
            this.listBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(176, 30);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(203, 132);
            this.listBoxResult.TabIndex = 5;
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(12, 111);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(158, 23);
            this.buttonCount.TabIndex = 6;
            this.buttonCount.Text = "Számol";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(13, 140);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(157, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Pythagorean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 172);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxHypotenuse);
            this.Controls.Add(this.textBoxClamp2);
            this.Controls.Add(this.textBoxClamp1);
            this.Controls.Add(this.labelHypotenuse);
            this.Controls.Add(this.labelLeg2);
            this.Controls.Add(this.labelLeg1);
            this.Controls.Add(this.labelMain);
            this.Name = "Pythagorean";
            this.Text = "Pitagorasz tétel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelLeg1;
        private System.Windows.Forms.Label labelLeg2;
        private System.Windows.Forms.Label labelHypotenuse;
        private System.Windows.Forms.TextBox textBoxClamp1;
        private System.Windows.Forms.TextBox textBoxClamp2;
        private System.Windows.Forms.TextBox textBoxHypotenuse;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonCancel;
    }
}