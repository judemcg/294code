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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnMakOlv = new System.Windows.Forms.Button();
            this.btnChiCos = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.picChar = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // btnFightCard
            // 
            this.btnFightCard.BackColor = System.Drawing.Color.White;
            this.btnFightCard.Location = new System.Drawing.Point(305, 250);
            this.btnFightCard.Name = "btnFightCard";
            this.btnFightCard.Size = new System.Drawing.Size(75, 23);
            this.btnFightCard.TabIndex = 6;
            this.btnFightCard.Text = "Fight Card";
            this.btnFightCard.UseVisualStyleBackColor = false;
            this.btnFightCard.Click += new System.EventHandler(this.btnFightCard_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(52, 337);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(100, 20);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "Information";
            this.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // btnMakOlv
            // 
            this.btnMakOlv.Location = new System.Drawing.Point(422, 403);
            this.btnMakOlv.Name = "btnMakOlv";
            this.btnMakOlv.Size = new System.Drawing.Size(75, 23);
            this.btnMakOlv.TabIndex = 0;
            // 
            // btnChiCos
            // 
            this.btnChiCos.Location = new System.Drawing.Point(185, 403);
            this.btnChiCos.Name = "btnChiCos";
            this.btnChiCos.Size = new System.Drawing.Size(75, 23);
            this.btnChiCos.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(305, 403);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 0;
            // 
            // ufc294
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(704, 577);
            this.Controls.Add(this.btnFightCard);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnMakOlv);
            this.Controls.Add(this.btnChiCos);
            this.Controls.Add(this.btnInfo);
            this.Name = "ufc294";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UFC 294";
            this.Load += new System.EventHandler(this.form1_load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.picChar.Image = global::ufc294.Properties.Resources.simpsons;
            this.picChar.Location = new System.Drawing.Point(236, 12);
            this.picChar.Name = "picChar";
            this.picChar.Size = new System.Drawing.Size(425, 184);
            this.picChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChar.TabIndex = 1;
            this.picChar.TabStop = false;
        }

        #endregion
        private System.Windows.Forms.Button btnFightCard;
        private System.Windows.Forms.Button btnMakOlv;
        private System.Windows.Forms.Button btnChiCos;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.PictureBox picChar;
    }
}

