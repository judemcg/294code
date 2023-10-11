using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ufc294WindowsForm
{
    partial class ufc294
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
            this.btnFightCard = new System.Windows.Forms.Button();
            this.picChar = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnMakOlv = new System.Windows.Forms.Button();
            this.btnChiCos = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picChar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFightCard
            // 
            this.btnFightCard.BackColor = System.Drawing.Color.White;
            this.btnFightCard.Location = new System.Drawing.Point(0, 0);
            this.btnFightCard.Name = "btnFightCard";
            this.btnFightCard.Size = new System.Drawing.Size(75, 23);
            this.btnFightCard.TabIndex = 6;
            this.btnFightCard.Text = "Fight Card";
            this.btnFightCard.UseVisualStyleBackColor = false;
            this.btnFightCard.Click += new System.EventHandler(this.btnFightCard_Click);
            // 
            // picChar
            // 
            this.picChar.Location = new System.Drawing.Point(0, 0);
            this.picChar.Name = "picChar";
            this.picChar.Size = new System.Drawing.Size(100, 50);
            this.picChar.TabIndex = 0;
            this.picChar.TabStop = false;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(0, 0);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(100, 20);
            this.txtInfo.TabIndex = 0;
            // 
            // btnMakOlv
            // 
            this.btnMakOlv.Location = new System.Drawing.Point(0, 0);
            this.btnMakOlv.Name = "btnMakOlv";
            this.btnMakOlv.Size = new System.Drawing.Size(75, 23);
            this.btnMakOlv.TabIndex = 0;
            // 
            // btnChiCos
            // 
            this.btnChiCos.Location = new System.Drawing.Point(0, 0);
            this.btnChiCos.Name = "btnChiCos";
            this.btnChiCos.Size = new System.Drawing.Size(75, 23);
            this.btnChiCos.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 0;
            // 
            // ufc294
            // 
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(511, 515);
            this.Name = "ufc294";
            ((System.ComponentModel.ISupportInitialize)(this.picChar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picChar;
        private System.Windows.Forms.Button btnFightCard;
        private System.Windows.Forms.Button btnMakOlv;
        private System.Windows.Forms.Button btnChiCos;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox txtInfo;
    }
}

