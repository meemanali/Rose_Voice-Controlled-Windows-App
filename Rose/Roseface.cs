using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

namespace Rose
{
    public partial class Roseface : UserControl
    {        
        public ListBox lstc,lstmc,lstnotific;
        public Timer tmr1, tmr2;
        public Panel pnl1, pnl3;
        public PictureBox picbox1;
        public ComboBox cbmusic;
        public Label lbltitle;

        Stopwatch stopwarch = new Stopwatch();
        

        public Roseface()
        {
            InitializeComponent();
            
            lstc = lstcommandsrf;
            lstmc = lstmycommandsrf;
            lstnotific = lstnotificationpanelrf;
            tmr1 = timer1;
            tmr2 = timer2;
            pnl1 = panel1;
            pnl3 = panel3;
            picbox1 = pictureBox1;
            cbmusic = combomusic;
            lbltitle = labeltitle;

            
            timer2.Start();

            
            //timer3.Start();


            //timer1.Start();
            //pictureBox2.Location = new Point(12, 12);
        }

        


        //int panelx = Form1.ActiveForm.Width;

        //bool check = true;    

       
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //stopwarch.Start();

            //int count = 0;//if we declare this shit here it will again reset count as 0 when it ticks
            if (count > 1)
            {
                timer1.Stop();
                count = 0;

                //stopwarch.Stop();
                //labeltitle.Text = stopwarch.Elapsed.Milliseconds.ToString();
                //this stop watch some time shows 781,202,681,87,861 milliseconds etc

            }

            if (panel1.Height < 381)
            {
                panel1.Height += 20;
                panel3.Height += 20;
            }

            else if (panel1.Height > 380)
            {
                panel1.Height = 85;
                panel3.Height = 85;
                count += 1;

                //panel1.Height -= 10;
                //panel3.Height -= 10;
            }


            //tableLayoutPanel1.SetRowSpan(panel3, 4);
            //tableLayoutPanel1.SetRowSpan(panel1, 2);            

            //tableLayoutPanel1.ColumnStyles.RemoveAt(1); //removes column of given index
            //tableLayoutPanel1.SetRow(panel1, 2); //panel1 will moves to 3rd row


            //panelx -= 10;
            //pictureBox2.Size = new Size(pictureBox1.Width, panelx);

            //if (panelx<1)
            //{
            //    pictureBox1.Hide();
            //    timer1.Enabled = false;
            //}



            //this program opens pic1 after 1 seconds and pic2
            //if (check)
            //{
            //    pictureBox2.BringToFront();
            //    check = false;              
            //}
            //else//if 'if' condition is true it will not go under else block
            //{
            //    pictureBox1.BringToFront();
            //    check = true ;             
            //}

            //else if (pictureBox2.IsAccessible)
            //{
            //    pictureBox1.BringToFront();
            //    //pictureBox2.SendToBack();
            //}

            //label1.Text = timer1.Container.ToString();

            //label1.Text = timer1.Interval.ToString();


            //Environment.Exit(Convert.ToInt32(MessageBox.Show("0")));//this will gives message and then exits the applicaltion
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Start();

            //label1.Text = pictureBox1.Location.X.ToString()+pictureBox1.Location.Y;
            //label1.Text = pictureBox1.Size.Width.ToString() + pictureBox1.Size.Height.ToString();
        }

        private void lstcommandsrf_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lstmycommandsrf.Items.Add(lstcommandsrf.SelectedItem.ToString());
            Form1.instanceofform.commandexe(lstcommandsrf.SelectedItem.ToString());
        }

        private void panel3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //blinking stoper
            timer1.Stop();
            timer2.Stop();
            panel1.Height = 85;
            panel3.Height = 85;
            
            //commands from file
            lstcommandsrf.Items.Clear();
            lstcommandsrf.Visible = true;

            foreach (string command in File.ReadAllLines(@"DafaultCommands.txt"))
            {
                lstcommandsrf.Items.Add(command);
            }
        }

        private void combomusic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cbmusic.SelectedText != string.Empty)
            {
                if (labeltitle.Text == "Nohay:")
                {
                    Form1.windowmediaplayer.URL = @"F:\Eeman Data\Nohay\" + cbmusic.SelectedText;
                    Form1.windowmediaplayer.controls.play();
                }
                else if (labeltitle.Text == "Songs:")
                {
                    Form1.windowmediaplayer.URL = @"F:\Eeman Data\Songs\" + cbmusic.SelectedText;
                    Form1.windowmediaplayer.controls.play();
                }                             

                //Process.Start(@"F:\Eeman Data\Songs\" + cbmusic.SelectedText); // this will open it in vlc
            }
        }

        //int a = 1;
        private void timer3_Tick(object sender, EventArgs e)
        {
            //pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
            //if (pictureBox1.Location.X < -6)
            //{


            //}
            //else
            //{
            //    pictureBox1.Location = new Point(0, 0);
            //    //pictureBox1.Location.Y = 0;
            //}            

            //pictureBox1.Location = new Point(pictureBox1.Location.X - 5);
            //if (pictureBox1.Location.X<-6)
            //{
            //    pictureBox1.Location = new Point(0, 0);
            //}
            //pictureBox1.Location = new Point(pictureBox1.Location.Y - 5);
            //if (pictureBox1.Location.Y<-6)
            //{
            //    pictureBox1.Location = new Point(0, 0);
            //}


            //if (a==1)
            //{
            //    pictureBox1.Image = Properties.Resources.My_Eye_1;
            //    a++;
            //}
            //else if (a==2)
            //{
            //    pictureBox1.Image = Properties.Resources.My_Eye_2;
            //    a++;
            //}
            //else if (a==3)
            //{
            //    pictureBox1.Image = Properties.Resources.My_Eye_1;
            //    a++;
            //}
            //else if (a==4)
            //{
            //    pictureBox1.Image = Properties.Resources.My_Eye_3;
            //    a = 1;
            //}
        }
    }
}
