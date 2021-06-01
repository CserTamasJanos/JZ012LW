
namespace Feladatok12
{
    partial class StonePaperScissors
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
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonStone = new System.Windows.Forms.Button();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.buttonCPaper = new System.Windows.Forms.Button();
            this.buttonCStone = new System.Windows.Forms.Button();
            this.buttonCScissors = new System.Windows.Forms.Button();
            this.labelGamerPoints = new System.Windows.Forms.Label();
            this.labelComputerPoints = new System.Windows.Forms.Label();
            this.buttonConsolStyle = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxGamer = new System.Windows.Forms.GroupBox();
            this.groupBoxComputer = new System.Windows.Forms.GroupBox();
            this.groupBoxGamer.SuspendLayout();
            this.groupBoxComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(63, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(207, 13);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Kattintson a Játékos gombra a kezdéshez.";
            // 
            // buttonPaper
            // 
            this.buttonPaper.Location = new System.Drawing.Point(88, 19);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(76, 40);
            this.buttonPaper.TabIndex = 3;
            this.buttonPaper.Tag = "2";
            this.buttonPaper.Text = "Papír";
            this.buttonPaper.UseVisualStyleBackColor = true;
            // 
            // buttonStone
            // 
            this.buttonStone.Location = new System.Drawing.Point(6, 19);
            this.buttonStone.Name = "buttonStone";
            this.buttonStone.Size = new System.Drawing.Size(76, 40);
            this.buttonStone.TabIndex = 3;
            this.buttonStone.Tag = "1";
            this.buttonStone.Text = "Kő";
            this.buttonStone.UseVisualStyleBackColor = true;
            // 
            // buttonScissors
            // 
            this.buttonScissors.Location = new System.Drawing.Point(170, 19);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(76, 40);
            this.buttonScissors.TabIndex = 3;
            this.buttonScissors.Tag = "3";
            this.buttonScissors.Text = "Olló";
            this.buttonScissors.UseVisualStyleBackColor = true;
            // 
            // buttonCPaper
            // 
            this.buttonCPaper.Location = new System.Drawing.Point(88, 19);
            this.buttonCPaper.Name = "buttonCPaper";
            this.buttonCPaper.Size = new System.Drawing.Size(76, 40);
            this.buttonCPaper.TabIndex = 3;
            this.buttonCPaper.Tag = "5";
            this.buttonCPaper.Text = "Papír";
            this.buttonCPaper.UseVisualStyleBackColor = true;
            // 
            // buttonCStone
            // 
            this.buttonCStone.Location = new System.Drawing.Point(6, 19);
            this.buttonCStone.Name = "buttonCStone";
            this.buttonCStone.Size = new System.Drawing.Size(76, 40);
            this.buttonCStone.TabIndex = 3;
            this.buttonCStone.Tag = "4";
            this.buttonCStone.Text = "Kő";
            this.buttonCStone.UseVisualStyleBackColor = true;
            // 
            // buttonCScissors
            // 
            this.buttonCScissors.Location = new System.Drawing.Point(170, 19);
            this.buttonCScissors.Name = "buttonCScissors";
            this.buttonCScissors.Size = new System.Drawing.Size(76, 40);
            this.buttonCScissors.TabIndex = 3;
            this.buttonCScissors.Tag = "6";
            this.buttonCScissors.Text = "Olló";
            this.buttonCScissors.UseVisualStyleBackColor = true;
            // 
            // labelGamerPoints
            // 
            this.labelGamerPoints.AutoSize = true;
            this.labelGamerPoints.Location = new System.Drawing.Point(266, 31);
            this.labelGamerPoints.Name = "labelGamerPoints";
            this.labelGamerPoints.Size = new System.Drawing.Size(13, 13);
            this.labelGamerPoints.TabIndex = 4;
            this.labelGamerPoints.Text = "0";
            // 
            // labelComputerPoints
            // 
            this.labelComputerPoints.AutoSize = true;
            this.labelComputerPoints.Location = new System.Drawing.Point(266, 31);
            this.labelComputerPoints.Name = "labelComputerPoints";
            this.labelComputerPoints.Size = new System.Drawing.Size(13, 13);
            this.labelComputerPoints.TabIndex = 4;
            this.labelComputerPoints.Text = "0";
            // 
            // buttonConsolStyle
            // 
            this.buttonConsolStyle.Location = new System.Drawing.Point(12, 193);
            this.buttonConsolStyle.Name = "buttonConsolStyle";
            this.buttonConsolStyle.Size = new System.Drawing.Size(207, 23);
            this.buttonConsolStyle.TabIndex = 5;
            this.buttonConsolStyle.Tag = "10";
            this.buttonConsolStyle.Text = "Konzolos Változat Indítása";
            this.buttonConsolStyle.UseVisualStyleBackColor = true;
            this.buttonConsolStyle.Click += new System.EventHandler(this.buttonConsolStyle_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(225, 193);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Tag = "11";
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxGamer
            // 
            this.groupBoxGamer.Controls.Add(this.buttonPaper);
            this.groupBoxGamer.Controls.Add(this.buttonStone);
            this.groupBoxGamer.Controls.Add(this.labelGamerPoints);
            this.groupBoxGamer.Controls.Add(this.buttonScissors);
            this.groupBoxGamer.Location = new System.Drawing.Point(12, 38);
            this.groupBoxGamer.Name = "groupBoxGamer";
            this.groupBoxGamer.Size = new System.Drawing.Size(313, 72);
            this.groupBoxGamer.TabIndex = 7;
            this.groupBoxGamer.TabStop = false;
            this.groupBoxGamer.Text = "Játékos";
            // 
            // groupBoxComputer
            // 
            this.groupBoxComputer.Controls.Add(this.buttonCPaper);
            this.groupBoxComputer.Controls.Add(this.buttonCStone);
            this.groupBoxComputer.Controls.Add(this.labelComputerPoints);
            this.groupBoxComputer.Controls.Add(this.buttonCScissors);
            this.groupBoxComputer.Location = new System.Drawing.Point(12, 116);
            this.groupBoxComputer.Name = "groupBoxComputer";
            this.groupBoxComputer.Size = new System.Drawing.Size(313, 71);
            this.groupBoxComputer.TabIndex = 8;
            this.groupBoxComputer.TabStop = false;
            this.groupBoxComputer.Text = "Számítógép";
            // 
            // StonePaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 224);
            this.Controls.Add(this.groupBoxComputer);
            this.Controls.Add(this.groupBoxGamer);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConsolStyle);
            this.Controls.Add(this.labelMain);
            this.Name = "StonePaperScissors";
            this.Text = "Kő Papír Olló";
            this.groupBoxGamer.ResumeLayout(false);
            this.groupBoxGamer.PerformLayout();
            this.groupBoxComputer.ResumeLayout(false);
            this.groupBoxComputer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonStone;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Button buttonCPaper;
        private System.Windows.Forms.Button buttonCStone;
        private System.Windows.Forms.Button buttonCScissors;
        private System.Windows.Forms.Label labelGamerPoints;
        private System.Windows.Forms.Label labelComputerPoints;
        private System.Windows.Forms.Button buttonConsolStyle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxGamer;
        private System.Windows.Forms.GroupBox groupBoxComputer;
    }
}