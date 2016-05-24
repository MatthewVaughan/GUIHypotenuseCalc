namespace Lab11
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblSide1 = new System.Windows.Forms.Label();
            this.lblSide2 = new System.Windows.Forms.Label();
            this.lblHyp = new System.Windows.Forms.Label();
            this.txtFirstSide = new System.Windows.Forms.TextBox();
            this.txtSecondSide = new System.Windows.Forms.TextBox();
            this.txtHypotenuse = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureHypotenuse = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHypotenuse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSide1
            // 
            this.lblSide1.AutoSize = true;
            this.lblSide1.Location = new System.Drawing.Point(87, 229);
            this.lblSide1.Name = "lblSide1";
            this.lblSide1.Size = new System.Drawing.Size(135, 17);
            this.lblSide1.TabIndex = 0;
            this.lblSide1.Text = "Length of First Side:";
            // 
            // lblSide2
            // 
            this.lblSide2.AutoSize = true;
            this.lblSide2.Location = new System.Drawing.Point(87, 284);
            this.lblSide2.Name = "lblSide2";
            this.lblSide2.Size = new System.Drawing.Size(156, 17);
            this.lblSide2.TabIndex = 1;
            this.lblSide2.Text = "Length of Second Side:";
            // 
            // lblHyp
            // 
            this.lblHyp.AutoSize = true;
            this.lblHyp.Location = new System.Drawing.Point(316, 284);
            this.lblHyp.Name = "lblHyp";
            this.lblHyp.Size = new System.Drawing.Size(152, 17);
            this.lblHyp.TabIndex = 2;
            this.lblHyp.Text = "Length of Hypotenuse:";
            // 
            // txtFirstSide
            // 
            this.txtFirstSide.Location = new System.Drawing.Point(104, 249);
            this.txtFirstSide.Name = "txtFirstSide";
            this.txtFirstSide.Size = new System.Drawing.Size(100, 22);
            this.txtFirstSide.TabIndex = 3;
            // 
            // txtSecondSide
            // 
            this.txtSecondSide.Location = new System.Drawing.Point(104, 304);
            this.txtSecondSide.Name = "txtSecondSide";
            this.txtSecondSide.Size = new System.Drawing.Size(100, 22);
            this.txtSecondSide.TabIndex = 4;
            // 
            // txtHypotenuse
            // 
            this.txtHypotenuse.Location = new System.Drawing.Point(344, 304);
            this.txtHypotenuse.Name = "txtHypotenuse";
            this.txtHypotenuse.ReadOnly = true;
            this.txtHypotenuse.Size = new System.Drawing.Size(100, 22);
            this.txtHypotenuse.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(319, 238);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(149, 33);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureHypotenuse
            // 
            this.pictureHypotenuse.Image = ((System.Drawing.Image)(resources.GetObject("pictureHypotenuse.Image")));
            this.pictureHypotenuse.Location = new System.Drawing.Point(78, 31);
            this.pictureHypotenuse.Name = "pictureHypotenuse";
            this.pictureHypotenuse.Size = new System.Drawing.Size(390, 167);
            this.pictureHypotenuse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHypotenuse.TabIndex = 8;
            this.pictureHypotenuse.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 420);
            this.Controls.Add(this.pictureHypotenuse);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtHypotenuse);
            this.Controls.Add(this.txtSecondSide);
            this.Controls.Add(this.txtFirstSide);
            this.Controls.Add(this.lblHyp);
            this.Controls.Add(this.lblSide2);
            this.Controls.Add(this.lblSide1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Hypotenuse Calculater";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHypotenuse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSide1;
        private System.Windows.Forms.Label lblSide2;
        private System.Windows.Forms.Label lblHyp;
        private System.Windows.Forms.TextBox txtFirstSide;
        private System.Windows.Forms.TextBox txtSecondSide;
        private System.Windows.Forms.TextBox txtHypotenuse;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureHypotenuse;
    }
}

