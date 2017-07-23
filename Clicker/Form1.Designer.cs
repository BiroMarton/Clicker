namespace Clicker
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tier1 = new System.Windows.Forms.Button();
            this.tier2 = new System.Windows.Forms.Button();
            this.tier3 = new System.Windows.Forms.Button();
            this.tier4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.winThis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.moneyPerSec = new System.Windows.Forms.Timer(this.components);
            this.Something = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mPS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money:  ";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Location = new System.Drawing.Point(65, 21);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(0, 13);
            this.Money.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Make money!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tier1
            // 
            this.tier1.Location = new System.Drawing.Point(27, 122);
            this.tier1.Name = "tier1";
            this.tier1.Size = new System.Drawing.Size(102, 23);
            this.tier1.TabIndex = 3;
            this.tier1.Text = "Tier 1 (50$)";
            this.tier1.UseVisualStyleBackColor = true;
            this.tier1.Click += new System.EventHandler(this.button2_Click);
            // 
            // tier2
            // 
            this.tier2.Location = new System.Drawing.Point(27, 166);
            this.tier2.Name = "tier2";
            this.tier2.Size = new System.Drawing.Size(102, 23);
            this.tier2.TabIndex = 5;
            this.tier2.Text = "Tier 2 (250$)";
            this.tier2.UseVisualStyleBackColor = true;
            this.tier2.Click += new System.EventHandler(this.tier2_Click);
            // 
            // tier3
            // 
            this.tier3.Location = new System.Drawing.Point(27, 215);
            this.tier3.Name = "tier3";
            this.tier3.Size = new System.Drawing.Size(102, 23);
            this.tier3.TabIndex = 6;
            this.tier3.Text = "Tier 3(1000$)";
            this.tier3.UseVisualStyleBackColor = true;
            this.tier3.Click += new System.EventHandler(this.tier3_Click);
            // 
            // tier4
            // 
            this.tier4.Location = new System.Drawing.Point(27, 259);
            this.tier4.Name = "tier4";
            this.tier4.Size = new System.Drawing.Size(102, 23);
            this.tier4.TabIndex = 7;
            this.tier4.Text = "Tier 4(1750$)";
            this.tier4.UseVisualStyleBackColor = true;
            this.tier4.Click += new System.EventHandler(this.tier4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // winThis
            // 
            this.winThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winThis.Location = new System.Drawing.Point(308, 232);
            this.winThis.Name = "winThis";
            this.winThis.Size = new System.Drawing.Size(192, 73);
            this.winThis.TabIndex = 9;
            this.winThis.Text = "Win this game by earning 5000$!";
            this.winThis.UseVisualStyleBackColor = true;
            this.winThis.Visible = false;
            this.winThis.Click += new System.EventHandler(this.winThis_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Money per click:";
            // 
            // moneyPerSec
            // 
            this.moneyPerSec.Enabled = true;
            this.moneyPerSec.Interval = 1000;
            this.moneyPerSec.Tick += new System.EventHandler(this.moneyPerSec_Tick);
            // 
            // Something
            // 
            this.Something.Location = new System.Drawing.Point(164, 76);
            this.Something.Name = "Something";
            this.Something.Size = new System.Drawing.Size(101, 23);
            this.Something.TabIndex = 11;
            this.Something.Text = "4$/s (120$)";
            this.Something.UseVisualStyleBackColor = true;
            this.Something.Click += new System.EventHandler(this.Something_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Money per sec:";
            // 
            // mPS
            // 
            this.mPS.AutoSize = true;
            this.mPS.Location = new System.Drawing.Point(244, 47);
            this.mPS.Name = "mPS";
            this.mPS.Size = new System.Drawing.Size(0, 13);
            this.mPS.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 325);
            this.Controls.Add(this.mPS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Something);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.winThis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tier4);
            this.Controls.Add(this.tier3);
            this.Controls.Add(this.tier2);
            this.Controls.Add(this.tier1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Idiot Clicker 4000 Deluxe!";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tier1;
        private System.Windows.Forms.Button tier2;
        private System.Windows.Forms.Button tier3;
        private System.Windows.Forms.Button tier4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button winThis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer moneyPerSec;
        private System.Windows.Forms.Button Something;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mPS;
    }
}

