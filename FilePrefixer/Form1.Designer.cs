﻿namespace FilePrefixer
{
    partial class Form
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
            this.btnPrefix = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBroweser = new System.Windows.Forms.Button();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrefix
            // 
            this.btnPrefix.Location = new System.Drawing.Point(327, 49);
            this.btnPrefix.Name = "btnPrefix";
            this.btnPrefix.Size = new System.Drawing.Size(75, 23);
            this.btnPrefix.TabIndex = 0;
            this.btnPrefix.Text = "Prefix";
            this.btnPrefix.UseVisualStyleBackColor = true;
            this.btnPrefix.Click += new System.EventHandler(this.btnPrefix_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(76, 22);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(238, 20);
            this.txtDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directory:";
            // 
            // btnBroweser
            // 
            this.btnBroweser.Location = new System.Drawing.Point(327, 20);
            this.btnBroweser.Name = "btnBroweser";
            this.btnBroweser.Size = new System.Drawing.Size(75, 23);
            this.btnBroweser.TabIndex = 3;
            this.btnBroweser.Text = "Browse";
            this.btnBroweser.UseVisualStyleBackColor = true;
            this.btnBroweser.Click += new System.EventHandler(this.btnBroweser_Click);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(76, 49);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(238, 20);
            this.txtPrefix.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prefix";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 89);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.btnBroweser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.btnPrefix);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "File Prefixer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrefix;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBroweser;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label2;
    }
}

