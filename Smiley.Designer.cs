
namespace Feladatok12
{
    partial class Smiley
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
            this.pictureBoxContainer = new System.Windows.Forms.PictureBox();
            this.textBoxFavoriteText = new System.Windows.Forms.TextBox();
            this.buttonDisapear = new System.Windows.Forms.Button();
            this.buttonComeBack = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(53, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(243, 13);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Kattintson a képre vagy írja be a kedvenc szavát.";
            // 
            // pictureBoxContainer
            // 
            this.pictureBoxContainer.Location = new System.Drawing.Point(12, 60);
            this.pictureBoxContainer.Name = "pictureBoxContainer";
            this.pictureBoxContainer.Size = new System.Drawing.Size(332, 140);
            this.pictureBoxContainer.TabIndex = 1;
            this.pictureBoxContainer.TabStop = false;
            this.pictureBoxContainer.Click += new System.EventHandler(this.pictureBoxContainer_Click);
            this.pictureBoxContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxContainer_MouseMove);
            // 
            // textBoxFavoriteText
            // 
            this.textBoxFavoriteText.Location = new System.Drawing.Point(12, 34);
            this.textBoxFavoriteText.Name = "textBoxFavoriteText";
            this.textBoxFavoriteText.Size = new System.Drawing.Size(332, 20);
            this.textBoxFavoriteText.TabIndex = 2;
            this.textBoxFavoriteText.TextChanged += new System.EventHandler(this.textBoxFavoriteText_TextChanged);
            // 
            // buttonDisapear
            // 
            this.buttonDisapear.Location = new System.Drawing.Point(12, 206);
            this.buttonDisapear.Name = "buttonDisapear";
            this.buttonDisapear.Size = new System.Drawing.Size(86, 36);
            this.buttonDisapear.TabIndex = 3;
            this.buttonDisapear.Text = "Tűnj el";
            this.buttonDisapear.UseVisualStyleBackColor = true;
            this.buttonDisapear.Click += new System.EventHandler(this.buttonDisapear_Click);
            // 
            // buttonComeBack
            // 
            this.buttonComeBack.Location = new System.Drawing.Point(258, 206);
            this.buttonComeBack.Name = "buttonComeBack";
            this.buttonComeBack.Size = new System.Drawing.Size(86, 36);
            this.buttonComeBack.TabIndex = 3;
            this.buttonComeBack.Text = "Gyere vissza";
            this.buttonComeBack.UseVisualStyleBackColor = true;
            this.buttonComeBack.Click += new System.EventHandler(this.buttonComeBack_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 248);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(332, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Smiley
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 280);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonComeBack);
            this.Controls.Add(this.buttonDisapear);
            this.Controls.Add(this.textBoxFavoriteText);
            this.Controls.Add(this.pictureBoxContainer);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Smiley";
            this.Text = "Smiley";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.PictureBox pictureBoxContainer;
        private System.Windows.Forms.TextBox textBoxFavoriteText;
        private System.Windows.Forms.Button buttonDisapear;
        private System.Windows.Forms.Button buttonComeBack;
        private System.Windows.Forms.Button buttonCancel;
    }
}