
namespace Feladatok12
{
    partial class TextFormat
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
            this.labelAdjust = new System.Windows.Forms.Label();
            this.buttonBlueLetter = new System.Windows.Forms.Button();
            this.buttonWhiteBackground = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonBasicState = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRightCenter = new System.Windows.Forms.Button();
            this.buttonCenterCenter = new System.Windows.Forms.Button();
            this.buttonLeftCenter = new System.Windows.Forms.Button();
            this.buttonDecrease = new System.Windows.Forms.Button();
            this.buttonEncrease = new System.Windows.Forms.Button();
            this.buttonBigLetter = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAdjust
            // 
            this.labelAdjust.Location = new System.Drawing.Point(65, 37);
            this.labelAdjust.Name = "labelAdjust";
            this.labelAdjust.Size = new System.Drawing.Size(200, 100);
            this.labelAdjust.TabIndex = 0;
            this.labelAdjust.Text = "Igazítandó szöveg.";
            // 
            // buttonBlueLetter
            // 
            this.buttonBlueLetter.Location = new System.Drawing.Point(15, 140);
            this.buttonBlueLetter.Name = "buttonBlueLetter";
            this.buttonBlueLetter.Size = new System.Drawing.Size(100, 23);
            this.buttonBlueLetter.TabIndex = 1;
            this.buttonBlueLetter.Text = "Kék Betű";
            this.buttonBlueLetter.UseVisualStyleBackColor = true;
            this.buttonBlueLetter.Click += new System.EventHandler(this.buttonBlueLetter_Click);
            // 
            // buttonWhiteBackground
            // 
            this.buttonWhiteBackground.Location = new System.Drawing.Point(121, 140);
            this.buttonWhiteBackground.Name = "buttonWhiteBackground";
            this.buttonWhiteBackground.Size = new System.Drawing.Size(100, 23);
            this.buttonWhiteBackground.TabIndex = 2;
            this.buttonWhiteBackground.Text = "Fehér Háttér";
            this.buttonWhiteBackground.UseVisualStyleBackColor = true;
            this.buttonWhiteBackground.Click += new System.EventHandler(this.buttonWhiteBackground_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(227, 140);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(100, 23);
            this.buttonErase.TabIndex = 3;
            this.buttonErase.Text = "Töröl";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // buttonBasicState
            // 
            this.buttonBasicState.Location = new System.Drawing.Point(15, 254);
            this.buttonBasicState.Name = "buttonBasicState";
            this.buttonBasicState.Size = new System.Drawing.Size(75, 23);
            this.buttonBasicState.TabIndex = 4;
            this.buttonBasicState.Text = "Alaphelyzet";
            this.buttonBasicState.UseVisualStyleBackColor = true;
            this.buttonBasicState.Click += new System.EventHandler(this.buttonBasicState_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(252, 254);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRightCenter
            // 
            this.buttonRightCenter.Location = new System.Drawing.Point(227, 169);
            this.buttonRightCenter.Name = "buttonRightCenter";
            this.buttonRightCenter.Size = new System.Drawing.Size(100, 23);
            this.buttonRightCenter.TabIndex = 8;
            this.buttonRightCenter.Text = "Jobb Közép";
            this.buttonRightCenter.UseVisualStyleBackColor = true;
            this.buttonRightCenter.Click += new System.EventHandler(this.buttonRightCenter_Click);
            // 
            // buttonCenterCenter
            // 
            this.buttonCenterCenter.Location = new System.Drawing.Point(121, 169);
            this.buttonCenterCenter.Name = "buttonCenterCenter";
            this.buttonCenterCenter.Size = new System.Drawing.Size(100, 23);
            this.buttonCenterCenter.TabIndex = 7;
            this.buttonCenterCenter.Text = "Közép Közép";
            this.buttonCenterCenter.UseVisualStyleBackColor = true;
            this.buttonCenterCenter.Click += new System.EventHandler(this.buttonCenterCenter_Click);
            // 
            // buttonLeftCenter
            // 
            this.buttonLeftCenter.Location = new System.Drawing.Point(15, 169);
            this.buttonLeftCenter.Name = "buttonLeftCenter";
            this.buttonLeftCenter.Size = new System.Drawing.Size(100, 23);
            this.buttonLeftCenter.TabIndex = 6;
            this.buttonLeftCenter.Text = "Bal közép";
            this.buttonLeftCenter.UseVisualStyleBackColor = true;
            this.buttonLeftCenter.Click += new System.EventHandler(this.buttonLeftCenter_Click);
            // 
            // buttonDecrease
            // 
            this.buttonDecrease.Location = new System.Drawing.Point(227, 198);
            this.buttonDecrease.Name = "buttonDecrease";
            this.buttonDecrease.Size = new System.Drawing.Size(100, 23);
            this.buttonDecrease.TabIndex = 11;
            this.buttonDecrease.Text = "Kicsinyít";
            this.buttonDecrease.UseVisualStyleBackColor = true;
            this.buttonDecrease.Click += new System.EventHandler(this.buttonDecrease_Click);
            // 
            // buttonEncrease
            // 
            this.buttonEncrease.Location = new System.Drawing.Point(121, 198);
            this.buttonEncrease.Name = "buttonEncrease";
            this.buttonEncrease.Size = new System.Drawing.Size(100, 23);
            this.buttonEncrease.TabIndex = 10;
            this.buttonEncrease.Text = "Nagyít";
            this.buttonEncrease.UseVisualStyleBackColor = true;
            this.buttonEncrease.Click += new System.EventHandler(this.buttonEncrease_Click);
            // 
            // buttonBigLetter
            // 
            this.buttonBigLetter.Location = new System.Drawing.Point(15, 198);
            this.buttonBigLetter.Name = "buttonBigLetter";
            this.buttonBigLetter.Size = new System.Drawing.Size(100, 23);
            this.buttonBigLetter.TabIndex = 9;
            this.buttonBigLetter.Text = "Nagybetűs";
            this.buttonBigLetter.UseVisualStyleBackColor = true;
            this.buttonBigLetter.Click += new System.EventHandler(this.buttonBigLetter_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(55, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(223, 13);
            this.labelMain.TabIndex = 12;
            this.labelMain.Text = "A szöveg igazításához használja a gombokat.";
            // 
            // TextFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 289);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.buttonDecrease);
            this.Controls.Add(this.buttonEncrease);
            this.Controls.Add(this.buttonBigLetter);
            this.Controls.Add(this.buttonRightCenter);
            this.Controls.Add(this.buttonCenterCenter);
            this.Controls.Add(this.buttonLeftCenter);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonBasicState);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonWhiteBackground);
            this.Controls.Add(this.buttonBlueLetter);
            this.Controls.Add(this.labelAdjust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TextFormat";
            this.Text = "Szöveg Formázás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdjust;
        private System.Windows.Forms.Button buttonBlueLetter;
        private System.Windows.Forms.Button buttonWhiteBackground;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonBasicState;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRightCenter;
        private System.Windows.Forms.Button buttonCenterCenter;
        private System.Windows.Forms.Button buttonLeftCenter;
        private System.Windows.Forms.Button buttonDecrease;
        private System.Windows.Forms.Button buttonEncrease;
        private System.Windows.Forms.Button buttonBigLetter;
        private System.Windows.Forms.Label labelMain;
    }
}