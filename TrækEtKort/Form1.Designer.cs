namespace TrækEtKort {
    partial class TrækEtKort {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dealCard = new System.Windows.Forms.Button();
            this.cardResult = new System.Windows.Forms.TextBox();
            this.cardLbl = new System.Windows.Forms.Label();
            this.cardSuit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dealCard
            // 
            this.dealCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealCard.Location = new System.Drawing.Point(12, 51);
            this.dealCard.Name = "dealCard";
            this.dealCard.Size = new System.Drawing.Size(123, 77);
            this.dealCard.TabIndex = 0;
            this.dealCard.Text = "Stik mig et kort!";
            this.dealCard.UseVisualStyleBackColor = true;
            this.dealCard.Click += new System.EventHandler(this.dealCard_Click);
            // 
            // cardResult
            // 
            this.cardResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardResult.Location = new System.Drawing.Point(247, 93);
            this.cardResult.Name = "cardResult";
            this.cardResult.ReadOnly = true;
            this.cardResult.Size = new System.Drawing.Size(100, 35);
            this.cardResult.TabIndex = 1;
            this.cardResult.TabStop = false;
            this.cardResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardLbl
            // 
            this.cardLbl.AutoSize = true;
            this.cardLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardLbl.Location = new System.Drawing.Point(141, 61);
            this.cardLbl.Name = "cardLbl";
            this.cardLbl.Size = new System.Drawing.Size(145, 29);
            this.cardLbl.TabIndex = 2;
            this.cardLbl.Text = "Du fik kortet:";
            // 
            // cardSuit
            // 
            this.cardSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardSuit.ForeColor = System.Drawing.Color.Maroon;
            this.cardSuit.Location = new System.Drawing.Point(141, 93);
            this.cardSuit.Name = "cardSuit";
            this.cardSuit.Size = new System.Drawing.Size(100, 35);
            this.cardSuit.TabIndex = 3;
            this.cardSuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TrækEtKort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 251);
            this.Controls.Add(this.cardSuit);
            this.Controls.Add(this.cardLbl);
            this.Controls.Add(this.cardResult);
            this.Controls.Add(this.dealCard);
            this.Name = "TrækEtKort";
            this.Text = "TrækEtKortWeb3 - Funktion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dealCard;
        private System.Windows.Forms.TextBox cardResult;
        private System.Windows.Forms.Label cardLbl;
        private System.Windows.Forms.TextBox cardSuit;
    }
}

