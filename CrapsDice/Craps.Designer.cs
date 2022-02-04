namespace CrapsDice
{
    partial class Craps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craps));
            this.btnRoll = new System.Windows.Forms.Button();
            this.groupDiceRoll = new System.Windows.Forms.GroupBox();
            this.labelTurns = new System.Windows.Forms.Label();
            this.displayTurns = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.displayPoints = new System.Windows.Forms.Label();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupDiceRoll.SuspendLayout();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRoll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRoll.Location = new System.Drawing.Point(290, 52);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(100, 75);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "ROLL DICE";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // groupDiceRoll
            // 
            this.groupDiceRoll.Controls.Add(this.pictureBox1);
            this.groupDiceRoll.Controls.Add(this.pictureBox2);
            this.groupDiceRoll.Controls.Add(this.btnRoll);
            this.groupDiceRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupDiceRoll.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupDiceRoll.Location = new System.Drawing.Point(25, 25);
            this.groupDiceRoll.Name = "groupDiceRoll";
            this.groupDiceRoll.Size = new System.Drawing.Size(420, 170);
            this.groupDiceRoll.TabIndex = 5;
            this.groupDiceRoll.TabStop = false;
            // 
            // labelTurns
            // 
            this.labelTurns.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTurns.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTurns.Location = new System.Drawing.Point(26, 30);
            this.labelTurns.Name = "labelTurns";
            this.labelTurns.Size = new System.Drawing.Size(100, 25);
            this.labelTurns.TabIndex = 6;
            this.labelTurns.Text = "Turns";
            this.labelTurns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayTurns
            // 
            this.displayTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.displayTurns.Location = new System.Drawing.Point(26, 60);
            this.displayTurns.Name = "displayTurns";
            this.displayTurns.Size = new System.Drawing.Size(100, 25);
            this.displayTurns.TabIndex = 7;
            this.displayTurns.Text = "[turn]";
            this.displayTurns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(26, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Points";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayPoints
            // 
            this.displayPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.displayPoints.Location = new System.Drawing.Point(26, 130);
            this.displayPoints.Name = "displayPoints";
            this.displayPoints.Size = new System.Drawing.Size(100, 25);
            this.displayPoints.TabIndex = 9;
            this.displayPoints.Text = "[points]";
            this.displayPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.labelTurns);
            this.groupInfo.Controls.Add(this.displayPoints);
            this.groupInfo.Controls.Add(this.displayTurns);
            this.groupInfo.Controls.Add(this.label1);
            this.groupInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupInfo.Location = new System.Drawing.Point(460, 25);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(160, 170);
            this.groupInfo.TabIndex = 10;
            this.groupInfo.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewGame.Location = new System.Drawing.Point(190, 220);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(110, 35);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRules.Location = new System.Drawing.Point(350, 220);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(110, 35);
            this.btnRules.TabIndex = 12;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbout.Location = new System.Drawing.Point(25, 220);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(110, 35);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(510, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 35);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(160, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Craps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(644, 281);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.groupDiceRoll);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Craps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crap (a simplified version of Craps)";
            this.Load += new System.EventHandler(this.Craps_Load);
            this.groupDiceRoll.ResumeLayout(false);
            this.groupInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.GroupBox groupDiceRoll;
        private System.Windows.Forms.Label labelTurns;
        private System.Windows.Forms.Label displayTurns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayPoints;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
    }
}

