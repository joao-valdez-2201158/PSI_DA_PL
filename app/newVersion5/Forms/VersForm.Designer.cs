﻿
namespace Projeto_DA_BooKids.Forms
{
    partial class VersForm
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
            this.lbVers = new System.Windows.Forms.Label();
            this.lbVersNr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbVers
            // 
            this.lbVers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVers.Location = new System.Drawing.Point(-1, 34);
            this.lbVers.Name = "lbVers";
            this.lbVers.Size = new System.Drawing.Size(345, 71);
            this.lbVers.TabIndex = 1;
            this.lbVers.Text = "Versao";
            this.lbVers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVersNr
            // 
            this.lbVersNr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVersNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersNr.Location = new System.Drawing.Point(4, 105);
            this.lbVersNr.Name = "lbVersNr";
            this.lbVersNr.Size = new System.Drawing.Size(340, 31);
            this.lbVersNr.TabIndex = 2;
            this.lbVersNr.Text = "7.0.0";
            this.lbVersNr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Vers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 199);
            this.Controls.Add(this.lbVersNr);
            this.Controls.Add(this.lbVers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Vers";
            this.Text = "Vers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbVers;
        private System.Windows.Forms.Label lbVersNr;
    }
}