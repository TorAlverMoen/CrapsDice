namespace CrapsDice
{
    partial class GameRules
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRules));
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox.Location = new System.Drawing.Point(9, 9);
            this.textBox.Margin = new System.Windows.Forms.Padding(10);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(441, 162);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOk.Location = new System.Drawing.Point(350, 184);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 30);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // GameRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(459, 222);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameRules";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rules of the game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button btnOk;
    }
}
