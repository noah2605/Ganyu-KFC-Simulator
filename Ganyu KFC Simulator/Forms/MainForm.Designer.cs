namespace Ganyu_KFC_Simulator.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ganyubox = new System.Windows.Forms.PictureBox();
            this.chickenbox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.scorelabel = new System.Windows.Forms.Label();
            this.chickenbucketbox = new System.Windows.Forms.PictureBox();
            this.flowerbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ganyubox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chickenbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chickenbucketbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerbox)).BeginInit();
            this.SuspendLayout();
            // 
            // ganyubox
            // 
            this.ganyubox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ganyubox.BackColor = System.Drawing.Color.Transparent;
            this.ganyubox.Location = new System.Drawing.Point(588, 188);
            this.ganyubox.Name = "ganyubox";
            this.ganyubox.Size = new System.Drawing.Size(200, 250);
            this.ganyubox.TabIndex = 0;
            this.ganyubox.TabStop = false;
            // 
            // chickenbox
            // 
            this.chickenbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chickenbox.BackColor = System.Drawing.Color.Transparent;
            this.chickenbox.Location = new System.Drawing.Point(12, 374);
            this.chickenbox.Name = "chickenbox";
            this.chickenbox.Size = new System.Drawing.Size(64, 64);
            this.chickenbox.TabIndex = 1;
            this.chickenbox.TabStop = false;
            this.chickenbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chickenbox_MouseDown);
            this.chickenbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chickenbox_MouseUp);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // scorelabel
            // 
            this.scorelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scorelabel.AutoSize = true;
            this.scorelabel.Location = new System.Drawing.Point(363, 9);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(48, 15);
            this.scorelabel.TabIndex = 2;
            this.scorelabel.Text = "Score: 0";
            this.scorelabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chickenbucketbox
            // 
            this.chickenbucketbox.BackColor = System.Drawing.Color.Transparent;
            this.chickenbucketbox.Location = new System.Drawing.Point(12, 304);
            this.chickenbucketbox.Name = "chickenbucketbox";
            this.chickenbucketbox.Size = new System.Drawing.Size(64, 64);
            this.chickenbucketbox.TabIndex = 3;
            this.chickenbucketbox.TabStop = false;
            this.chickenbucketbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chickenbucketbox_MouseDown);
            this.chickenbucketbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chickenbucketbox_MouseUp);
            // 
            // flowerbox
            // 
            this.flowerbox.BackColor = System.Drawing.Color.Transparent;
            this.flowerbox.Location = new System.Drawing.Point(12, 234);
            this.flowerbox.Name = "flowerbox";
            this.flowerbox.Size = new System.Drawing.Size(64, 64);
            this.flowerbox.TabIndex = 4;
            this.flowerbox.TabStop = false;
            this.flowerbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowerbox_MouseDown);
            this.flowerbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowerbox_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowerbox);
            this.Controls.Add(this.chickenbucketbox);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.chickenbox);
            this.Controls.Add(this.ganyubox);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganyu chicken kfc simulator 3000";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ganyubox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chickenbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chickenbucketbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ganyubox;
        private System.Windows.Forms.PictureBox chickenbox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.PictureBox chickenbucketbox;
        private System.Windows.Forms.PictureBox flowerbox;
    }
}

