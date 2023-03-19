
namespace StoppenLicht
{
    partial class frmStoppenLicht
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
            this.btnReset = new System.Windows.Forms.Button();
            this.txtStartTijd = new System.Windows.Forms.TextBox();
            this.btnRood = new System.Windows.Forms.Button();
            this.btnPauze = new System.Windows.Forms.Button();
            this.btnWerk = new System.Windows.Forms.Button();
            this.pbxVerkeerslicht = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnBoven = new System.Windows.Forms.Panel();
            this.lblTijd = new System.Windows.Forms.Label();
            this.pnOnder = new System.Windows.Forms.Panel();
            this.pnMidden = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerkeerslicht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.pnBoven.SuspendLayout();
            this.pnOnder.SuspendLayout();
            this.pnMidden.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(212, 26);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 45);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtStartTijd
            // 
            this.txtStartTijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTijd.Location = new System.Drawing.Point(305, 26);
            this.txtStartTijd.Multiline = true;
            this.txtStartTijd.Name = "txtStartTijd";
            this.txtStartTijd.Size = new System.Drawing.Size(123, 45);
            this.txtStartTijd.TabIndex = 4;
            // 
            // btnRood
            // 
            this.btnRood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRood.BackColor = System.Drawing.SystemColors.Window;
            this.btnRood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRood.ForeColor = System.Drawing.Color.Red;
            this.btnRood.Location = new System.Drawing.Point(718, 26);
            this.btnRood.Name = "btnRood";
            this.btnRood.Size = new System.Drawing.Size(38, 45);
            this.btnRood.TabIndex = 5;
            this.btnRood.Text = "●";
            this.btnRood.UseVisualStyleBackColor = false;
            this.btnRood.Click += new System.EventHandler(this.btnRood_Click);
            // 
            // btnPauze
            // 
            this.btnPauze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPauze.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPauze.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauze.Location = new System.Drawing.Point(110, 26);
            this.btnPauze.Name = "btnPauze";
            this.btnPauze.Size = new System.Drawing.Size(96, 45);
            this.btnPauze.TabIndex = 8;
            this.btnPauze.Text = "Pauze";
            this.btnPauze.UseVisualStyleBackColor = false;
            // 
            // btnWerk
            // 
            this.btnWerk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWerk.BackColor = System.Drawing.Color.Lime;
            this.btnWerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWerk.Location = new System.Drawing.Point(12, 26);
            this.btnWerk.Name = "btnWerk";
            this.btnWerk.Size = new System.Drawing.Size(92, 45);
            this.btnWerk.TabIndex = 9;
            this.btnWerk.Text = "Werk";
            this.btnWerk.UseVisualStyleBackColor = false;
            this.btnWerk.Click += new System.EventHandler(this.btnWerk_Click);
            // 
            // pbxVerkeerslicht
            // 
            this.pbxVerkeerslicht.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbxVerkeerslicht.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pbxVerkeerslicht.Image = global::StoppenLicht.Properties.Resources.Geel;
            this.pbxVerkeerslicht.Location = new System.Drawing.Point(601, 106);
            this.pbxVerkeerslicht.Name = "pbxVerkeerslicht";
            this.pbxVerkeerslicht.Size = new System.Drawing.Size(312, 594);
            this.pbxVerkeerslicht.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVerkeerslicht.TabIndex = 3;
            this.pbxVerkeerslicht.TabStop = false;
            this.pbxVerkeerslicht.Click += new System.EventHandler(this.pbxVerkeerslicht_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(762, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "●";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnGeel_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(806, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "●";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnGroen_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.Color.White;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(850, 26);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(63, 45);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Q";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(12, 105);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(100, 50);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxFoto.TabIndex = 11;
            this.pbxFoto.TabStop = false;
            this.pbxFoto.Click += new System.EventHandler(this.pbxFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnBoven
            // 
            this.pnBoven.BackColor = System.Drawing.Color.SteelBlue;
            this.pnBoven.Controls.Add(this.lblTijd);
            this.pnBoven.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBoven.Location = new System.Drawing.Point(0, 0);
            this.pnBoven.Name = "pnBoven";
            this.pnBoven.Size = new System.Drawing.Size(925, 100);
            this.pnBoven.TabIndex = 12;
            // 
            // lblTijd
            // 
            this.lblTijd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTijd.Font = new System.Drawing.Font("DSEG14 Classic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTijd.ForeColor = System.Drawing.Color.White;
            this.lblTijd.Location = new System.Drawing.Point(297, 9);
            this.lblTijd.Name = "lblTijd";
            this.lblTijd.Size = new System.Drawing.Size(278, 76);
            this.lblTijd.TabIndex = 0;
            this.lblTijd.Text = "0:00";
            this.lblTijd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnOnder
            // 
            this.pnOnder.BackColor = System.Drawing.Color.Teal;
            this.pnOnder.Controls.Add(this.btnWerk);
            this.pnOnder.Controls.Add(this.btnReset);
            this.pnOnder.Controls.Add(this.btnPauze);
            this.pnOnder.Controls.Add(this.button2);
            this.pnOnder.Controls.Add(this.btnQuit);
            this.pnOnder.Controls.Add(this.button1);
            this.pnOnder.Controls.Add(this.txtStartTijd);
            this.pnOnder.Controls.Add(this.btnRood);
            this.pnOnder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOnder.Location = new System.Drawing.Point(0, 706);
            this.pnOnder.Name = "pnOnder";
            this.pnOnder.Size = new System.Drawing.Size(925, 83);
            this.pnOnder.TabIndex = 13;
            // 
            // pnMidden
            // 
            this.pnMidden.Controls.Add(this.pbxVerkeerslicht);
            this.pnMidden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMidden.Location = new System.Drawing.Point(0, 0);
            this.pnMidden.Name = "pnMidden";
            this.pnMidden.Size = new System.Drawing.Size(925, 789);
            this.pnMidden.TabIndex = 14;
            // 
            // frmStoppenLicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(925, 789);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.pnOnder);
            this.Controls.Add(this.pnBoven);
            this.Controls.Add(this.pnMidden);
            this.Name = "frmStoppenLicht";
            this.Text = "Stoppenlicht";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerkeerslicht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.pnBoven.ResumeLayout(false);
            this.pnOnder.ResumeLayout(false);
            this.pnOnder.PerformLayout();
            this.pnMidden.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbxVerkeerslicht;
        private System.Windows.Forms.TextBox txtStartTijd;
        private System.Windows.Forms.Button btnRood;
        private System.Windows.Forms.Button btnPauze;
        private System.Windows.Forms.Button btnWerk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnBoven;
        private System.Windows.Forms.Panel pnOnder;
        private System.Windows.Forms.Panel pnMidden;
        private System.Windows.Forms.Label lblTijd;
    }
}

