namespace YilanOyunu
{
    partial class FormAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaForm));
            this.pnlArena = new System.Windows.Forms.Panel();
            this.pnlTemplate = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblSeviye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Seviye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArena
            // 
            this.pnlArena.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlArena.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlArena.BackgroundImage")));
            this.pnlArena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlArena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlArena.Location = new System.Drawing.Point(27, 23);
            this.pnlArena.Name = "pnlArena";
            this.pnlArena.Size = new System.Drawing.Size(600, 600);
            this.pnlArena.TabIndex = 0;
            // 
            // pnlTemplate
            // 
            this.pnlTemplate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pnlTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTemplate.Location = new System.Drawing.Point(637, 185);
            this.pnlTemplate.Name = "pnlTemplate";
            this.pnlTemplate.Size = new System.Drawing.Size(20, 20);
            this.pnlTemplate.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblSkor
            // 
            this.lblSkor.BackColor = System.Drawing.Color.Black;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSkor.ForeColor = System.Drawing.Color.White;
            this.lblSkor.Location = new System.Drawing.Point(633, 40);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(178, 39);
            this.lblSkor.TabIndex = 2;
            this.lblSkor.Text = "0";
            this.lblSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeviye
            // 
            this.lblSeviye.BackColor = System.Drawing.Color.Black;
            this.lblSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSeviye.ForeColor = System.Drawing.Color.White;
            this.lblSeviye.Location = new System.Drawing.Point(633, 134);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(178, 39);
            this.lblSeviye.TabIndex = 2;
            this.lblSeviye.Text = "1";
            this.lblSeviye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(633, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skor";
            // 
            // Seviye
            // 
            this.Seviye.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Seviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Seviye.Location = new System.Drawing.Point(633, 112);
            this.Seviye.Name = "Seviye";
            this.Seviye.Size = new System.Drawing.Size(178, 22);
            this.Seviye.TabIndex = 2;
            this.Seviye.Text = "Seviye";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(634, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 227);
            this.label2.TabIndex = 3;
            this.label2.Text = "(F2) \r\nYeni Oyun\r\n(Pause) \r\nDuraklat / Devam ettir\r\n(Ok tuslari)\r\nHareket\r\n------" +
                "-------------------------\r\n10 seviye vardir.\r\nHer 100 puanda seviye\r\nartar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(684, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 136);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 659);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Seviye);
            this.Controls.Add(this.lblSeviye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.pnlTemplate);
            this.Controls.Add(this.pnlArena);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yilan Oyunu v 0.1";
            this.Load += new System.EventHandler(this.FormAnaForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArena;
        private System.Windows.Forms.Panel pnlTemplate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblSeviye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Seviye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

