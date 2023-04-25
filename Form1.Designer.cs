namespace EindProjectTamagotchi
{
    partial class frmOpdracht
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
            System.Windows.Forms.Label lblEten;
            this.pbEten = new EindProjectTamagotchi.CustomProgressBar();
            this.pbDrinken = new EindProjectTamagotchi.CustomProgressBar();
            this.pbGezondheid = new EindProjectTamagotchi.CustomProgressBar();
            this.lblGezondheid = new System.Windows.Forms.Label();
            this.lblDrinken = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbxScore = new System.Windows.Forms.PictureBox();
            this.pbxTwee = new System.Windows.Forms.PictureBox();
            this.btnEten = new System.Windows.Forms.Button();
            this.btnDrinken = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            lblEten = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTwee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEten
            // 
            lblEten.AutoSize = true;
            lblEten.Location = new System.Drawing.Point(14, 25);
            lblEten.Name = "lblEten";
            lblEten.Size = new System.Drawing.Size(37, 16);
            lblEten.TabIndex = 4;
            lblEten.Text = "Eten:";
            // 
            // pbEten
            // 
            this.pbEten.Location = new System.Drawing.Point(73, 25);
            this.pbEten.Name = "pbEten";
            this.pbEten.Size = new System.Drawing.Size(246, 60);
            this.pbEten.TabIndex = 0;
            this.pbEten.Value = 100;
            // 
            // pbDrinken
            // 
            this.pbDrinken.Location = new System.Drawing.Point(73, 104);
            this.pbDrinken.Name = "pbDrinken";
            this.pbDrinken.Size = new System.Drawing.Size(246, 60);
            this.pbDrinken.TabIndex = 1;
            this.pbDrinken.Value = 100;
            this.pbDrinken.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // pbGezondheid
            // 
            this.pbGezondheid.Location = new System.Drawing.Point(466, 90);
            this.pbGezondheid.Name = "pbGezondheid";
            this.pbGezondheid.Size = new System.Drawing.Size(288, 30);
            this.pbGezondheid.TabIndex = 2;
            this.pbGezondheid.Value = 100;
            // 
            // lblGezondheid
            // 
            this.lblGezondheid.AutoSize = true;
            this.lblGezondheid.Location = new System.Drawing.Point(376, 90);
            this.lblGezondheid.Name = "lblGezondheid";
            this.lblGezondheid.Size = new System.Drawing.Size(83, 16);
            this.lblGezondheid.TabIndex = 3;
            this.lblGezondheid.Text = "Gezondheid:";
            // 
            // lblDrinken
            // 
            this.lblDrinken.AutoSize = true;
            this.lblDrinken.Location = new System.Drawing.Point(2, 104);
            this.lblDrinken.Name = "lblDrinken";
            this.lblDrinken.Size = new System.Drawing.Size(56, 16);
            this.lblDrinken.TabIndex = 5;
            this.lblDrinken.Text = "Drinken:";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Location = new System.Drawing.Point(12, 192);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(46, 16);
            this.lblScore1.TabIndex = 6;
            this.lblScore1.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(64, 192);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(14, 16);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "0";
            // 
            // pbxScore
            // 
            this.pbxScore.Image = global::EindProjectTamagotchi.Properties.Resources.sterretje2;
            this.pbxScore.Location = new System.Drawing.Point(84, 182);
            this.pbxScore.Name = "pbxScore";
            this.pbxScore.Size = new System.Drawing.Size(50, 39);
            this.pbxScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxScore.TabIndex = 8;
            this.pbxScore.TabStop = false;
            this.pbxScore.Click += new System.EventHandler(this.pbxScore_Click);
            // 
            // pbxTwee
            // 
            this.pbxTwee.Image = global::EindProjectTamagotchi.Properties.Resources.tamagotchi2;
            this.pbxTwee.Location = new System.Drawing.Point(256, 192);
            this.pbxTwee.Name = "pbxTwee";
            this.pbxTwee.Size = new System.Drawing.Size(289, 233);
            this.pbxTwee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTwee.TabIndex = 9;
            this.pbxTwee.TabStop = false;
            // 
            // btnEten
            // 
            this.btnEten.Location = new System.Drawing.Point(67, 344);
            this.btnEten.Name = "btnEten";
            this.btnEten.Size = new System.Drawing.Size(144, 81);
            this.btnEten.TabIndex = 10;
            this.btnEten.Text = "Eten";
            this.btnEten.UseVisualStyleBackColor = true;
            this.btnEten.Click += new System.EventHandler(this.btnEten_Click);
            // 
            // btnDrinken
            // 
            this.btnDrinken.Location = new System.Drawing.Point(610, 344);
            this.btnDrinken.Name = "btnDrinken";
            this.btnDrinken.Size = new System.Drawing.Size(144, 81);
            this.btnDrinken.TabIndex = 11;
            this.btnDrinken.Text = "Drinken";
            this.btnDrinken.UseVisualStyleBackColor = true;
            this.btnDrinken.Click += new System.EventHandler(this.btnDrinken_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmOpdracht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDrinken);
            this.Controls.Add(this.btnEten);
            this.Controls.Add(this.pbxTwee);
            this.Controls.Add(this.pbxScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lblDrinken);
            this.Controls.Add(lblEten);
            this.Controls.Add(this.lblGezondheid);
            this.Controls.Add(this.pbGezondheid);
            this.Controls.Add(this.pbDrinken);
            this.Controls.Add(this.pbEten);
            this.Name = "frmOpdracht";
            this.Text = "Opdracht";
            this.Load += new System.EventHandler(this.frmOpdracht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTwee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGezondheid;
        private System.Windows.Forms.Label lblDrinken;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbxScore;
        private System.Windows.Forms.PictureBox pbxTwee;
        private System.Windows.Forms.Button btnEten;
        private System.Windows.Forms.Button btnDrinken;
        private System.Windows.Forms.Timer timer1;
        private CustomProgressBar pbEten;
        private CustomProgressBar pbDrinken;
        private CustomProgressBar pbGezondheid;
    }
}

