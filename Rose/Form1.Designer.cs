namespace Rose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.roseface1 = new Rose.Roseface();
            this.rosebody1 = new Rose.Rosebody();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // roseface1
            // 
            this.roseface1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roseface1.Location = new System.Drawing.Point(0, 0);
            this.roseface1.Name = "roseface1";
            this.roseface1.Size = new System.Drawing.Size(828, 496);
            this.roseface1.TabIndex = 0;
            // 
            // rosebody1
            // 
            this.rosebody1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rosebody1.Location = new System.Drawing.Point(0, 0);
            this.rosebody1.Name = "rosebody1";
            this.rosebody1.Size = new System.Drawing.Size(828, 496);
            this.rosebody1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 496);
            this.Controls.Add(this.roseface1);
            this.Controls.Add(this.rosebody1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rose";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Roseface roseface1;
        private System.Windows.Forms.Timer timer1;
        private Rosebody rosebody1;
    }
}

