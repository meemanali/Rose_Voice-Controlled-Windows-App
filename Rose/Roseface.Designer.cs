namespace Rose
{
    partial class Roseface
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.combomusic = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lstcommandsrf = new System.Windows.Forms.ListBox();
            this.lstmycommandsrf = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstnotificationpanelrf = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labeltitle);
            this.panel1.Controls.Add(this.combomusic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 85);
            this.panel1.TabIndex = 4;
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.SystemColors.Window;
            this.labeltitle.Location = new System.Drawing.Point(349, 28);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(42, 20);
            this.labeltitle.TabIndex = 4;
            this.labeltitle.Text = "Title:";
            this.labeltitle.Visible = false;
            // 
            // combomusic
            // 
            this.combomusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combomusic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combomusic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combomusic.BackColor = System.Drawing.Color.Black;
            this.combomusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combomusic.ForeColor = System.Drawing.SystemColors.Window;
            this.combomusic.FormattingEnabled = true;
            this.combomusic.Location = new System.Drawing.Point(407, 27);
            this.combomusic.Name = "combomusic";
            this.combomusic.Size = new System.Drawing.Size(50, 21);
            this.combomusic.TabIndex = 3;
            this.combomusic.Visible = false;
            this.combomusic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combomusic_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 85);
            this.panel3.TabIndex = 5;
            this.panel3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 14;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lstcommandsrf
            // 
            this.lstcommandsrf.BackColor = System.Drawing.Color.Black;
            this.lstcommandsrf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstcommandsrf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstcommandsrf.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstcommandsrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstcommandsrf.ForeColor = System.Drawing.SystemColors.Window;
            this.lstcommandsrf.FormattingEnabled = true;
            this.lstcommandsrf.ItemHeight = 15;
            this.lstcommandsrf.Location = new System.Drawing.Point(589, 85);
            this.lstcommandsrf.Name = "lstcommandsrf";
            this.lstcommandsrf.Size = new System.Drawing.Size(230, 324);
            this.lstcommandsrf.TabIndex = 7;
            this.lstcommandsrf.Visible = false;
            this.lstcommandsrf.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstcommandsrf_MouseDoubleClick);
            // 
            // lstmycommandsrf
            // 
            this.lstmycommandsrf.BackColor = System.Drawing.Color.Black;
            this.lstmycommandsrf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstmycommandsrf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstmycommandsrf.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstmycommandsrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstmycommandsrf.ForeColor = System.Drawing.SystemColors.Window;
            this.lstmycommandsrf.FormattingEnabled = true;
            this.lstmycommandsrf.ItemHeight = 15;
            this.lstmycommandsrf.Items.AddRange(new object[] {
            "Commands Given By me:",
            ""});
            this.lstmycommandsrf.Location = new System.Drawing.Point(0, 85);
            this.lstmycommandsrf.Name = "lstmycommandsrf";
            this.lstmycommandsrf.Size = new System.Drawing.Size(230, 324);
            this.lstmycommandsrf.TabIndex = 8;
            this.lstmycommandsrf.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Rose.Properties.Resources.My_Eye_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 494);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lstnotificationpanelrf
            // 
            this.lstnotificationpanelrf.BackColor = System.Drawing.Color.Black;
            this.lstnotificationpanelrf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstnotificationpanelrf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstnotificationpanelrf.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstnotificationpanelrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstnotificationpanelrf.ForeColor = System.Drawing.SystemColors.Window;
            this.lstnotificationpanelrf.FormattingEnabled = true;
            this.lstnotificationpanelrf.ItemHeight = 15;
            this.lstnotificationpanelrf.Items.AddRange(new object[] {
            "Notification Panel:"});
            this.lstnotificationpanelrf.Location = new System.Drawing.Point(230, 85);
            this.lstnotificationpanelrf.Name = "lstnotificationpanelrf";
            this.lstnotificationpanelrf.Size = new System.Drawing.Size(230, 324);
            this.lstnotificationpanelrf.TabIndex = 9;
            this.lstnotificationpanelrf.Visible = false;
            // 
            // Roseface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstnotificationpanelrf);
            this.Controls.Add(this.lstmycommandsrf);
            this.Controls.Add(this.lstcommandsrf);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Roseface";
            this.Size = new System.Drawing.Size(819, 494);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox lstcommandsrf;
        private System.Windows.Forms.ListBox lstmycommandsrf;
        private System.Windows.Forms.ListBox lstnotificationpanelrf;        
        private System.Windows.Forms.ComboBox combomusic;
        private System.Windows.Forms.Label labeltitle;

    }
}
