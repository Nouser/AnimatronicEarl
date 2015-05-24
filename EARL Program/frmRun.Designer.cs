namespace EARL_Program
{
    partial class frmRun
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
            this.btnAbout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnFAQ2 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudScript = new System.Windows.Forms.NumericUpDown();
            this.nud48 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAudio = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud48)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.DimGray;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(3, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(181, 72);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "Frequently Asked Questions";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.btnAbout);
            this.panel2.Location = new System.Drawing.Point(189, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 79);
            this.panel2.TabIndex = 3;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(476, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnFAQ2
            // 
            this.btnFAQ2.Location = new System.Drawing.Point(243, 244);
            this.btnFAQ2.Name = "btnFAQ2";
            this.btnFAQ2.Size = new System.Drawing.Size(75, 23);
            this.btnFAQ2.TabIndex = 9;
            this.btnFAQ2.Text = "FAQ 2";
            this.btnFAQ2.UseVisualStyleBackColor = true;
            this.btnFAQ2.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.DimGray;
            this.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(3, 3);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(343, 112);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "Begin Presentation";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnBegin);
            this.panel1.Location = new System.Drawing.Point(106, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 119);
            this.panel1.TabIndex = 2;
            // 
            // nudScript
            // 
            this.nudScript.Location = new System.Drawing.Point(109, 191);
            this.nudScript.Name = "nudScript";
            this.nudScript.Size = new System.Drawing.Size(65, 20);
            this.nudScript.TabIndex = 12;
            // 
            // nud48
            // 
            this.nud48.Location = new System.Drawing.Point(109, 217);
            this.nud48.Name = "nud48";
            this.nud48.Size = new System.Drawing.Size(65, 20);
            this.nud48.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dialog Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Movement Output";
            // 
            // btnAudio
            // 
            this.btnAudio.Location = new System.Drawing.Point(60, 159);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(75, 23);
            this.btnAudio.TabIndex = 16;
            this.btnAudio.Text = "Test Audio";
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // frmRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(570, 285);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud48);
            this.Controls.Add(this.nudScript);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnFAQ2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E.A.R.L. Presentation";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudScript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud48)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnFAQ2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudScript;
        private System.Windows.Forms.NumericUpDown nud48;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAudio;
    }
}