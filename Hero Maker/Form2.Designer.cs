﻿namespace Hero_Maker
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Heroes = new System.Windows.Forms.ListBox();
            this.textBox_Dossier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heroes:";
            // 
            // listBox_Heroes
            // 
            this.listBox_Heroes.FormattingEnabled = true;
            this.listBox_Heroes.Location = new System.Drawing.Point(15, 25);
            this.listBox_Heroes.Name = "listBox_Heroes";
            this.listBox_Heroes.Size = new System.Drawing.Size(120, 251);
            this.listBox_Heroes.TabIndex = 1;
            this.listBox_Heroes.SelectedIndexChanged += new System.EventHandler(this.listBox_Heroes_SelectedIndexChanged);
            // 
            // textBox_Dossier
            // 
            this.textBox_Dossier.Location = new System.Drawing.Point(141, 25);
            this.textBox_Dossier.Multiline = true;
            this.textBox_Dossier.Name = "textBox_Dossier";
            this.textBox_Dossier.Size = new System.Drawing.Size(261, 251);
            this.textBox_Dossier.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dossier:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Dossier);
            this.Controls.Add(this.listBox_Heroes);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Heroes;
        private System.Windows.Forms.TextBox textBox_Dossier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}