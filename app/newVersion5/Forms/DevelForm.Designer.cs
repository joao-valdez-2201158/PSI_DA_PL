
namespace Projeto_DA_BooKids.Forms
{
    partial class DevelForm
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
            this.components = new System.ComponentModel.Container();
            this.lbDevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // lbDevel
            // 
            this.lbDevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevel.Location = new System.Drawing.Point(2, 27);
            this.lbDevel.Name = "lbDevel";
            this.lbDevel.Size = new System.Drawing.Size(793, 71);
            this.lbDevel.TabIndex = 0;
            this.lbDevel.Text = "Desenvolvedores";
            this.lbDevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 223);
            this.label1.TabIndex = 1;
            this.label1.Text = "Este trabalho foi desenvolvido por Tiago Tavares, Eduardo Amado e João Pedro Vald" +
    "ez";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // DevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DevelForm";
            this.Text = "Desenvolvedores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}