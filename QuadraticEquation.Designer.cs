
namespace Feladatok12
{
    partial class QuadraticEquation
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
            this.labelXSquare = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelEqualToZero = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelResultX2 = new System.Windows.Forms.Label();
            this.labelResultX1 = new System.Windows.Forms.Label();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(61, 10);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(260, 13);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Adja meg az adatokat az x1 és az x2 kiszámolásához.";
            // 
            // labelXSquare
            // 
            this.labelXSquare.AutoSize = true;
            this.labelXSquare.Location = new System.Drawing.Point(71, 36);
            this.labelXSquare.Name = "labelXSquare";
            this.labelXSquare.Size = new System.Drawing.Size(33, 13);
            this.labelXSquare.TabIndex = 1;
            this.labelXSquare.Text = "x^2 +";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(170, 36);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(21, 13);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "x +";
            // 
            // labelEqualToZero
            // 
            this.labelEqualToZero.AutoSize = true;
            this.labelEqualToZero.Location = new System.Drawing.Point(257, 36);
            this.labelEqualToZero.Name = "labelEqualToZero";
            this.labelEqualToZero.Size = new System.Drawing.Size(22, 13);
            this.labelEqualToZero.TabIndex = 3;
            this.labelEqualToZero.Text = "= 0";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(10, 33);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(56, 20);
            this.textBoxA.TabIndex = 4;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(109, 33);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(56, 20);
            this.textBoxB.TabIndex = 4;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(196, 33);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(56, 20);
            this.textBoxC.TabIndex = 4;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(10, 64);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(27, 13);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "x1 =";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(10, 88);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(27, 13);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "x2 =";
            // 
            // labelResultX2
            // 
            this.labelResultX2.AutoSize = true;
            this.labelResultX2.Location = new System.Drawing.Point(40, 88);
            this.labelResultX2.Name = "labelResultX2";
            this.labelResultX2.Size = new System.Drawing.Size(0, 13);
            this.labelResultX2.TabIndex = 7;
            // 
            // labelResultX1
            // 
            this.labelResultX1.AutoSize = true;
            this.labelResultX1.Location = new System.Drawing.Point(40, 64);
            this.labelResultX1.Name = "labelResultX1";
            this.labelResultX1.Size = new System.Drawing.Size(0, 13);
            this.labelResultX1.TabIndex = 8;
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(285, 31);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(84, 23);
            this.buttonCount.TabIndex = 9;
            this.buttonCount.Text = "Kiszámol";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(10, 108);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(359, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // QuadraticEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 143);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.labelResultX1);
            this.Controls.Add(this.labelResultX2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelEqualToZero);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelXSquare);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuadraticEquation";
            this.Text = "Másodfokú egyenlet";
            this.Load += new System.EventHandler(this.QuadraticEquation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelXSquare;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelEqualToZero;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelResultX2;
        private System.Windows.Forms.Label labelResultX1;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonCancel;
    }
}