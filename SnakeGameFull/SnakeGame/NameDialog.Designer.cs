﻿namespace SnakeGame
{
    partial class NameDialog
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
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.Okbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlayerName.Location = new System.Drawing.Point(198, 146);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(324, 20);
            this.txtPlayerName.TabIndex = 0;
            // 
            // Okbtn
            // 
            this.Okbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Okbtn.BackColor = System.Drawing.Color.Transparent;
            this.Okbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okbtn.Location = new System.Drawing.Point(493, 304);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(134, 66);
            this.Okbtn.TabIndex = 1;
            this.Okbtn.Text = "Ok";
            this.Okbtn.UseVisualStyleBackColor = false;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancelbtn.BackColor = System.Drawing.Color.Transparent;
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(107, 304);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(134, 66);
            this.Cancelbtn.TabIndex = 2;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Titlelbl
            // 
            this.Titlelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.Titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(156, 48);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(471, 37);
            this.Titlelbl.TabIndex = 3;
            this.Titlelbl.Text = "Please enter a name to begin!";
            // 
            // NameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeGame.Properties.Resources.SnakeGame_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.txtPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NameDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter name";
            this.Load += new System.EventHandler(this.NameDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Label Titlelbl;
    }
}