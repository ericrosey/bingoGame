namespace bingoGame
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameEntry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLetsGo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.lblWhatWeDo = new System.Windows.Forms.Label();
            this.lblDontHave = new System.Windows.Forms.Label();
            this.txtNumberCalled = new System.Windows.Forms.TextBox();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.lblBingoCard = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Game of BINGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your name at the right:";
            // 
            // txtNameEntry
            // 
            this.txtNameEntry.Location = new System.Drawing.Point(518, 49);
            this.txtNameEntry.Name = "txtNameEntry";
            this.txtNameEntry.Size = new System.Drawing.Size(100, 22);
            this.txtNameEntry.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Are you ready to Play?";
            // 
            // btnLetsGo
            // 
            this.btnLetsGo.Location = new System.Drawing.Point(374, 96);
            this.btnLetsGo.Name = "btnLetsGo";
            this.btnLetsGo.Size = new System.Drawing.Size(125, 23);
            this.btnLetsGo.TabIndex = 4;
            this.btnLetsGo.Text = "Yes! Let\'s GO!";
            this.btnLetsGo.UseVisualStyleBackColor = true;
            this.btnLetsGo.Click += new System.EventHandler(this.btnLetsGo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(556, 96);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "No! Exit!";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.AutoSize = true;
            this.lblHowToPlay.Location = new System.Drawing.Point(126, 144);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(571, 17);
            this.lblHowToPlay.TabIndex = 6;
            this.lblHowToPlay.Text = "We call one number at a time. Check your card for that number and if found click " +
    "that cell.";
            this.lblHowToPlay.Visible = false;
            // 
            // lblWhatWeDo
            // 
            this.lblWhatWeDo.AutoSize = true;
            this.lblWhatWeDo.Location = new System.Drawing.Point(126, 171);
            this.lblWhatWeDo.Name = "lblWhatWeDo";
            this.lblWhatWeDo.Size = new System.Drawing.Size(584, 17);
            this.lblWhatWeDo.TabIndex = 7;
            this.lblWhatWeDo.Text = "We will do the rest, checking for Bingo or not. The number called will appear to " +
    "the right. -->";
            this.lblWhatWeDo.Visible = false;
            // 
            // lblDontHave
            // 
            this.lblDontHave.AutoSize = true;
            this.lblDontHave.Location = new System.Drawing.Point(126, 199);
            this.lblDontHave.Name = "lblDontHave";
            this.lblDontHave.Size = new System.Drawing.Size(580, 17);
            this.lblDontHave.TabIndex = 8;
            this.lblDontHave.Text = "If you do not have the number called in your card, click the \"Don\'t Have\" button " +
    "to the right.";
            this.lblDontHave.Visible = false;
            // 
            // txtNumberCalled
            // 
            this.txtNumberCalled.Location = new System.Drawing.Point(737, 156);
            this.txtNumberCalled.Name = "txtNumberCalled";
            this.txtNumberCalled.Size = new System.Drawing.Size(100, 22);
            this.txtNumberCalled.TabIndex = 9;
            this.txtNumberCalled.Visible = false;
            // 
            // btnDontHave
            // 
            this.btnDontHave.Location = new System.Drawing.Point(737, 193);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(100, 23);
            this.btnDontHave.TabIndex = 10;
            this.btnDontHave.Text = "Don\'t Have";
            this.btnDontHave.UseVisualStyleBackColor = true;
            this.btnDontHave.Visible = false;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // lblBingoCard
            // 
            this.lblBingoCard.AutoSize = true;
            this.lblBingoCard.Location = new System.Drawing.Point(403, 230);
            this.lblBingoCard.Name = "lblBingoCard";
            this.lblBingoCard.Size = new System.Drawing.Size(112, 17);
            this.lblBingoCard.TabIndex = 11;
            this.lblBingoCard.Text = "Your Bingo Card";
            this.lblBingoCard.Visible = false;
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCard.Location = new System.Drawing.Point(129, 263);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(700, 700);
            this.pnlCard.TabIndex = 12;
            this.pnlCard.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 997);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblBingoCard);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.txtNumberCalled);
            this.Controls.Add(this.lblDontHave);
            this.Controls.Add(this.lblWhatWeDo);
            this.Controls.Add(this.lblHowToPlay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLetsGo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLetsGo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHowToPlay;
        private System.Windows.Forms.Label lblWhatWeDo;
        private System.Windows.Forms.Label lblDontHave;
        private System.Windows.Forms.TextBox txtNumberCalled;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.Label lblBingoCard;
        private System.Windows.Forms.Panel pnlCard;
    }
}

