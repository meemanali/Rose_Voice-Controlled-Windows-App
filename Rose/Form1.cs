using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Diagnostics;
using System.Threading;
using WMPLib; // by using this we can play audio (audio or video but in background)
//using System.Media;// this can play only .wav files

namespace Rose
{    
    public partial class Form1 : Form
    {
        public static Form1 instanceofform;               

        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine();        
        //SpeechRecognitionEngine openmukhtarep = new SpeechRecognitionEngine();
        

        SpeechSynthesizer rose = new SpeechSynthesizer();

        Random rnd = new Random();

        public static WindowsMediaPlayer windowmediaplayer = new WindowsMediaPlayer(); // it is an interface        


        //bool search;
        //string chatter = "";

        public Form1()
        {
            InitializeComponent();

            instanceofform = this;

                     

            //recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(num))));//we can also give array here

            //recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer_SpeechRecognized);


            //roseface1.BringToFront();

            rose.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);            
            //rose.SelectVoice("Microsoft Zira Desktop");

            recognizer.SetInputToDefaultAudioDevice();
            recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DafaultCommands.txt")))));
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);
            recognizer.RecognizeAsync(RecognizeMode.Multiple);            
            

            startlistening.SetInputToDefaultAudioDevice();
            //startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DafaultCommands.txt")))));
            startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices("Wake up"))));
            startlistening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(startlistening_SpeechRecognized);


            ////this code will give array values from 0 to 100:
            //string[] epnumberstorer = new string[41];
            //for (int i = 0; i < 41; i++)
            //{
            //    epnumberstorer[i] = (i+1).ToString();

            //    //num[i] = Convert.ToString(i + 1);                                              
            //}


            // these lines will show installed voices in computer:
            //Roseface.instance.lstmc.Items.Clear();
            //foreach (var item in rose.GetInstalledVoices())
            //{
            //    Roseface.instance.lstmc.Items.Add(item.VoiceInfo.Name);
            //}



            //openmukhtarep.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(openmukhtarep_Speechrecognized);
        }
        //private void openmukhtarep_Speechrecognized(object sender, SpeechRecognizedEventArgs e)
        //{
        //    string speech = e.Result.Text;
        //    Roseface.instance.lstmc.Items.Add(e.Result.Text.ToString());

        //    Process.Start(@"F:\Islamic Movies\Mukhtar Namah\ep-" + speech);            
        //}

        string speech = "";
        private void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            speech = e.Result.Text;

            roseface1.lstmc.Items.Add(speech);

            commandexe(speech);
            
            
            //below code will genrate error if speech is other than 0 to 100 cause of convert func
            //if (Convert.ToInt32(speech) >= 0 && Convert.ToInt32(speech) <= 100)
            //{                
            //    SendKeys.Send(speech);
            //}               
        }

        private void startlistening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {            
            roseface1.lstmc.Items.Add(e.Result.Text.ToString());

            if (e.Result.Text == "Wake up")
            {
                startlistening.RecognizeAsyncCancel();
                rose.SpeakAsync("Yes boss i am here");
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        public void commandexe(string speech)
        {
            int rannum;

            switch (speech)
            {
                //questions and answers

                case "Hello":
                case "Hi":
                case "Whatsup":
                    rannum = rnd.Next(0, 2);
                    if (rannum==0)
                    {
                        rose.SpeakAsync("Hi");
                    }
                    else
                    {
                        rose.SpeakAsync("Hello");
                    }
                    break;
                    
                case "What is your name":
                    rose.SpeakAsync("My name is rose. Nice to meet you");
                    //if (chatter=="")
                    //{
                        //rose.SpeakAsync("What is your name");
                    //}
                    break;               

                case "Hey rose":
                case "Rose":
                case "Are you listening":
                case "R u listening":
                    rose.SpeakAsync("Yes");
                    break;

                case "Introduce yourself":
                    rose.SpeakAsync("My name is rose, I am developed by Muhaammad Eemaan Alee. I can do any work with this laptop, if u need me just ask");
                    break;

                case "What are you doing":
                    rannum = rnd.Next(0, 1);
                    if (rannum==0)
                    {
                        rose.SpeakAsync("Nothing, just talking to u");
                    }
                    else
                    {
                        rose.SpeakAsync("What do u want me to do");
                    }
                    break;

                case "Thank you":
                    rose.SpeakAsync("You r always welcome");
                    break;

                case "Sorry":
                    rose.SpeakAsync("Its ok");
                    break;

                case "How are you":
                    rose.SpeakAsync("I am working normally");
                    break;

                case "What time is it":
                    rose.SpeakAsync(DateTime.Now.ToString("h mm tt"));
                    break;

                case "What exactly time is it":
                    rose.SpeakAsync(DateTime.Now.ToString());
                    break;

                case "What date is it":
                    rose.SpeakAsync(DateTime.Now.ToString("d"));
                    break;

                case "What hour is it":
                    rose.SpeakAsync(DateTime.Now.Hour.ToString());
                    break;

                case "What day is it":
                    rose.SpeakAsync(DateTime.Now.DayOfWeek.ToString());
                    break;

                case "What month is it":
                    rose.SpeakAsync(DateTime.Now.Month.ToString());
                    break;

                case "What year is it":
                    rose.SpeakAsync(DateTime.Now.Year.ToString());
                    break;

                case "Rose i love you":
                case "I love you":
                    rose.SpeakAsync("i love u too");
                    break;

                case "Change your voice":            
                        //rose.SelectVoice("Microsoft David Desktop");
                        //rose.SelectVoice("Microsoft Hedda Desktop");
                        //rose.SelectVoice("Microsoft Zira Desktop");
                        //rose.SelectVoice("Microsoft Irina Desktop");
                        //rose.SelectVoice("Microsoft Huihui Desktop");
                        //rose.SelectVoice("Microsoft Tracy Desktop");
                        //rose.SelectVoice("Microsoft Hanhan Desktop");
                        //rose.SpeakAsync("Boss i have changed my voice to Hedda");

                        //if (rose.Voice.Name == "Microsoft Zira Desktop")
                        //rose.SelectVoiceByHints(VoiceGender.Male);
                        //roseface1.lstmc.Items.Add(rose.Voice.Name); // it adds Microsoft Zira Desktop
                        break;

                case "Play a demo of all your voices":
                case "Play your all voices":
                case "Play voices available in this computer":
                        rose.SpeakAsync("This is voice of " + rose.Voice.Name);

                        rose.SelectVoice("Microsoft David Desktop");
                        rose.SpeakAsync("This is voice of " + rose.Voice.Name);

                        rose.SelectVoice("Microsoft Hedda Desktop");
                        rose.SpeakAsync("This is voice of " + rose.Voice.Name);
                        
                        rose.SelectVoice("Microsoft Zira Desktop");
                        rose.SpeakAsync("This is voice of " + rose.Voice.Name);

                        rose.SelectVoice("Microsoft Irina Desktop");
                        rose.SpeakAsync("This is voice of " + rose.Voice.Name);

                        rose.SelectVoice("Microsoft Huihui Desktop");
                        rose.SpeakAsync("This is voice of " + rose.Voice.Name);
                        
                        rose.SelectVoice("Microsoft Tracy Desktop");
                        rose.SpeakAsync("This is voice of " + rose.Voice.Name);

                        rose.SelectVoice("Microsoft Hanhan Desktop");
                        rose.SpeakAsync("This is voice of " + rose.Voice.Name);
                        break;

                case "I hate you":
                    rose.SpeakAsync("But why");
                    roseface1.picbox1.Image = Properties.Resources.Roseeye;
                    timer1.Start();
                    break;

                case "Do you love eemaan":
                    rose.SpeakAsync("Offcourse i love emaan, he developed me");
                    break;

                case "Stop":
                case "Shut up":
                case "Rose Behave":
                case "Behave rose":
                    rose.SpeakAsyncCancelAll();                    
                    rose.SpeakAsync("ok");                    
                    break;

                //showing commands

                case "Show commands":                    
                    roseface1.lstc.Items.Clear();//if we dont do this,these commands r also print with previous same commands
                    roseface1.lstc.Visible = true;
                    blinkingstoper();
                    
                    foreach (string command in File.ReadAllLines(@"DafaultCommands.txt"))
                    {
                        roseface1.lstc.Items.Add(command);
                    }

                    //we can also use this method(by declaring an array):
                    //string[] commands = File.ReadAllLines(@"DafaultCommands.txt");
                    //foreach (string command in commands)
                    //{                    
                    //    roseface1.lstc.Items.Add(command);
                    //}                    
                    break;

                case "Hide commands":                    
                    roseface1.lstc.Visible = false;
                    roseface1.tmr1.Stop();
                    roseface1.tmr2.Stop();                    
                    break;
                
                case "Show my commands":
                case "Show commands given by me":
                    blinkingstoper();                    
                    roseface1.lstmc.Visible = true;
                    break;

                case "Hide my commands":
                    
                    roseface1.lstmc.Visible = false;
                    roseface1.tmr1.Stop();
                    roseface1.tmr2.Stop();                    
                    break;

                case "Show all commands":
                    blinkingstoper();                    
                    roseface1.lstc.Items.Clear();//if we dont do this,these commands r also print with previous same commands
                    roseface1.lstc.Visible = true;

                    foreach (string command in File.ReadAllLines(@"DafaultCommands.txt"))
                    {
                        roseface1.lstc.Items.Add(command);
                    }                     
                    roseface1.lstmc.Visible = true;
                    break;

                case "Hide all listboxes":                     
                    roseface1.lstc.Visible = false;
                    roseface1.lstmc.Visible = false;
                    roseface1.lstnotific.Visible = false;
                                        
                    roseface1.tmr1.Start();
                    roseface1.tmr2.Start();
                    break;

                case "Hide all items":         
                    roseface1.lstc.Visible = false;
                    roseface1.lstmc.Visible = false;
                    roseface1.lstnotific.Visible = false;
                    roseface1.cbmusic.Visible = false;
                    roseface1.cbmusic.SelectedText = string.Empty;
                    roseface1.lbltitle.Visible = false;


                    //below will remove picturebox also
                    //foreach (Control item in roseface1.Controls)
                    //{
                    //    item.Visible = false;
                    //}                    
                    break;

                case "Show all items":
                    roseface1.lstc.Visible = true;
                    roseface1.lstmc.Visible = true;
                    roseface1.lstnotific.Visible = true;
                    roseface1.cbmusic.Visible = true;
                    roseface1.lbltitle.Visible = true;
                    break;

                case "Minimize window":
                    this.WindowState = FormWindowState.Minimized;
                    break;

                case "Maximize window":
                    this.WindowState = FormWindowState.Maximized;
                    break;

                case "Normal window":
                case "Un maximized window":
                    this.WindowState = FormWindowState.Normal;
                    break;

                case "Show CPU monitor":
                case "Open CPU monitor":
                    rose.SpeakAsync("Opening cpu monitor developed by emaan");
                    Process.Start(@"E:\Courses & Programming\C#\C# Programs\Window Form Applications\CPU And RAM Monitor\CPU And RAM Monitor\bin\Debug\CPU And RAM Monitor.exe");
                    break;

                case "Show current running application":
                    blinkingstoper();
                    roseface1.lstnotific.Visible = true;
                    roseface1.lstnotific.Items.Add("Current Running App: " + Process.GetCurrentProcess().ProcessName);
                    break;

                case "Show notification panel":
                    roseface1.lstnotific.Visible = true;
                    break;

                case "Hide notification panel":
                    roseface1.lstnotific.Visible = false;
                    break;

                case "Remove borders of my commands listbox":
                    roseface1.lstmc.BorderStyle = BorderStyle.None;
                    break;

                case "Remove borders of commands listbox":
                    roseface1.lstc.BorderStyle = BorderStyle.None;
                    break;

                case "Remove borders of notifications listbox":
                    roseface1.lstnotific.BorderStyle = BorderStyle.None;
                    break;

                case "Remove borders of all listboxes":
                    roseface1.lstmc.BorderStyle = BorderStyle.None;
                    roseface1.lstc.BorderStyle = BorderStyle.None;
                    roseface1.lstnotific.BorderStyle = BorderStyle.None;
                    break;

                case "Add borders of my commands listbox":
                    roseface1.lstmc.BorderStyle = BorderStyle.FixedSingle;
                    break;

                case "Add borders of commands listbox":
                    roseface1.lstc.BorderStyle = BorderStyle.FixedSingle;
                    break;

                case "Add borders of notifications listbox":
                    roseface1.lstnotific.BorderStyle = BorderStyle.FixedSingle;
                    break;

                case "Add borders of all listboxes":
                    roseface1.lstmc.BorderStyle = BorderStyle.FixedSingle;
                    roseface1.lstc.BorderStyle = BorderStyle.FixedSingle;
                    roseface1.lstnotific.BorderStyle = BorderStyle.FixedSingle;
                    break;

                case "Speak normaly":
                    rose.Rate = 0;
                    rose.SpeakAsync("ok i will speak normly");                    
                    break;

                case "Speak slowly":
                    if (rose.Rate == -2)
                    {
                        rose.SpeakAsync("I am already Speaking slowly");
                    }
                    else
                    {
                        rose.Rate = -2;
                        rose.SpeakAsync("ok i will speak slowly");
                    }                                        
                    break;

                case "Speak very slowly":
                    if (rose.Rate == 4)
                    {
                        rose.SpeakAsync("I am already Speaking very slowly");
                    }
                    else
                    {
                        rose.Rate = -4;
                        rose.SpeakAsync("ok i will speak very slowly");
                        //rose.Rate = Convert.ToInt16(1 / 8);// this will nothing do cause  i think convert class convert it to 1
                    }                    
                    break;

                case "Speak faster":
                    if (rose.Rate == 2)
                    {
                        rose.SpeakAsync("I am already Speaking faster");
                    }
                    else
                    {
                        rose.Rate = 2;
                        rose.SpeakAsync("ok i will speak faster");                        
                    }
                    break;

                case "Speak very faster":
                    if (rose.Rate == 4)
                    {
                        rose.SpeakAsync("I am already Speaking very faster");
                    }
                    else
                    {
                        rose.Rate = 4;
                        rose.SpeakAsync("ok i will speak very faster");
                        //rose.Rate = Convert.ToInt16(1 / 8);// this will nothing do cause i think convert class convert it to 1
                    }
                    break;

                case "Mute yourself rose":
                case "Mute yourself":
                    rose.Volume = 0;                    
                    break;

                case "Unmute yourself rose":
                case "Unmute yourself":
                    rose.Volume = 100;
                    rose.SpeakAsync("Unmuted");
                    break;

                //case "Decrease volume":
                //    rose.SpeakAsync("Decreasing volume");
                //    SendKeys.Send("FN");
                //    break;

                //case "Increase volume":
                //    break;

                case "I am feeling bored":
                case "I am getting bored":
                case "I am very bored":
                case "Rose i feel boring":
                case "I feel boring":
                case "I think i am getting bored":
                    rannum = rnd.Next(0, 5);
                    if (rannum == 0)
                    {
                        rose.SpeakAsync("eemaan, u want to watch movies");
                    }
                    if (rannum == 1)
                    {
                        rose.SpeakAsync("eemaan, can i open any movie for u");
                    }
                    if (rannum == 2)
                    {
                        rose.SpeakAsync("eemaan, how can i faraway your boredom");
                    }
                    if (rannum == 3)
                    {
                        rose.SpeakAsync("eemaan, i suggest u to go out and meet your friends");
                    }
                    if (rannum == 4)
                    {
                        rose.SpeakAsync("ok talk to me then");
                    }
                    break;

                //opening and terminating processes

                case "Select all":                    
                    SendKeys.Send("^{a}");
                    break;

                case "Copy":
                    SendKeys.Send("^{c}");
                    break;

                case "Cut":
                    SendKeys.Send("^{x}");
                    break;

                case "Paste":
                    SendKeys.Send("^{v}");
                    break;                

                case "Open notepad":
                    rose.SpeakAsync("Opening notepad");
                    Process.Start("notepad.exe");

                    //Process a = Process.Start("notepad.exe");
                    //a.Kill();
                    //Process a = Process.GetCurrentProcess();
                    break;

                case "Close notepad":                    
                    if (!roseface1.Focused)
                    {
                        rose.SpeakAsync("Closing notepad");
                        SendKeys.Send("%{F4}");
                    }
                    else
                    {
                        rose.SpeakAsync("Sorry i did not find notepad");
                    }
                    //if (Process.Equals("notepad.exe",Process.GetCurrentProcess()))
                    //{
                    //    rose.SpeakAsync("Closing notepad");
                    //}                    
                    break;

                case "Open task manager":
                    rose.SpeakAsync("Opening task manager");
                    Process.Start("taskmgr.exe");
                    break;

                case "Open courses":
                    rose.SpeakAsync("Opening courses");
                    Process.Start(@"E:\Courses & Programming");
                    break;

                case "Open files":
                case "Open files manager":
                    rose.SpeakAsync("Opening file manager");
                    Process.Start("explorer.exe");
                    blinkingstoper();
                    break;

                case "Open mukhtaar nama":
                    rose.SpeakAsync("opening mukhtaar nama");                    
                    Process.Start(@"F:\Islamic Movies\Mukhtar Namah",ProcessWindowStyle.Hidden.ToString());
                    rose.SpeakAsync("eemaan, which episode you want to watch");
                    Thread.Sleep(3000);
                    SendKeys.Send("^{e}");
                    blinkingstoper();
                    //below code will only gets the name of file which we select or open in ofd:
                    //OpenFileDialog ofd = new OpenFileDialog();
                    //ofd.InitialDirectory = @"F:\Islamic Movies\Mukhtar Namah";
                    //ofd.Title = "Mukhtar Nama";
                    //ofd.ShowDialog();
                    break;                

                case "Open movies":
                    rose.SpeakAsync("Opening movies");
                    Process.Start(@"F:\Movies");
                    blinkingstoper();
                    break;                

                case "Open islamic movies":
                    rose.SpeakAsync("Opening islamic movies");
                    Process.Start(@"F:\Islamic Movies");
                    blinkingstoper();
                    break;

                case "Open songs":
                    rose.SpeakAsync("Opening songs");
                    Process.Start(@"F:\Eeman Data\Songs");
                    blinkingstoper();
                    break;

                case "Play peaky blinders music in vlc":
                    Process.Start(@"F:\Eeman Data\Songs\peaky blinders music.mp3");
                    break;                    

                case "Play peaky blinders music":                    
                    windowmediaplayer.URL = @"F:\Eeman Data\Songs\peaky blinders music.mp3";
                    windowmediaplayer.controls.play();
                    break;

                case "Stop your music":
                    windowmediaplayer.controls.stop();
                    break;

                case "Pause your music":
                    windowmediaplayer.controls.pause();
                    break;

                case "Resume your music":
                    windowmediaplayer.controls.play();
                    break;

                case "Show music list":
                    roseface1.cbmusic.Visible = true;
                    roseface1.lbltitle.Visible = true;
                    roseface1.cbmusic.Focus();
                    blinkingstoper();                       

                    //roseface1.lbltitle.Text = roseface1.Controls.Count.ToString(); //shows 6                
                    break;

                case "Hide music list":
                    roseface1.cbmusic.Visible = false;
                    roseface1.cbmusic.SelectedText = string.Empty;
                    roseface1.cbmusic.Items.Clear();
                    roseface1.lbltitle.Visible = false;
                    roseface1.lbltitle.Text = "Title:";

                    if (roseface1.lstc.Visible == false && roseface1.lstmc.Visible == false && roseface1.cbmusic.Visible == false)
                    {
                        roseface1.tmr1.Start();
                        roseface1.tmr2.Start();
                    }
                    break;

                case "Show all available songs":
                case "Show all songs":
                    roseface1.cbmusic.Visible = true;
                    roseface1.lbltitle.Visible = true;
                    roseface1.lbltitle.Text = "Songs:";

                    string[] songs = Directory.GetFiles(@"F:\Eeman Data\Songs");
                    foreach (string item in songs)
                    {
                        roseface1.cbmusic.Items.Add(item.Substring(20)); // substring(20) will remove path and shows only song
                    }             
                    roseface1.cbmusic.Focus();
                    blinkingstoper();
                    break;

                case "Show all nohay":
                case "Show all nohaas":
                    roseface1.cbmusic.Visible = true;
                    roseface1.lbltitle.Visible = true;
                    roseface1.lbltitle.Text = "Nohay:";

                    string[] nohay = Directory.GetFiles(@"F:\Eeman Data\Nohay");
                    foreach (string item in nohay)
                    {
                        roseface1.cbmusic.Items.Add(item.Substring(20)); // substring(20) will remove path and shows only song
                    }             
                    roseface1.cbmusic.Focus();
                    blinkingstoper();
                    break;
                
                case "Change your grammer to default":
                case "Set your grammer as default":
                    rose.SpeakAsync("Changed my grammer to default");                    
                    recognizer.LoadGrammarAsync(new DictationGrammar());
                    break;
                
                case "Change your grammer to specific":
                case "Set your grammer as specific":
                    rose.SpeakAsync("Changed my grammer to specific");                    
                    recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DafaultCommands.txt")))));
                    break;

                //case "Search for":
                //    recognizer.LoadGrammarAsync(new DictationGrammar());
                //    search = true;
                //    timer1.Start();
                //    break;

                case "Open chrome":
                    rose.SpeakAsync("Opening Chrome");
                    Process.Start("chrome.exe");
                    blinkingstoper();
                    break;                
                    
                case "Open vlc":
                    rose.SpeakAsync("Opening vlc");
                    Process.Start("vlc.exe");
                    blinkingstoper();
                    break;

                case "Show your picture":
                    blinkingstoper();
                    rose.SpeakAsync("Here is my picture");                    
                    roseface1.picbox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    rannum = rnd.Next(0, 4);
                    if (rannum == 1)
                    {                     
                        roseface1.picbox1.Image = Properties.Resources.images_98_;
                    }
                    if (rannum == 2)
                    {
                        roseface1.picbox1.Image = Properties.Resources.images_96_;
                    }
                    if(rannum == 3)
                    {                        
                        roseface1.picbox1.Image = Properties.Resources.Screenshot_20211117_172120;
                    }                    
                    break;

                case "Hide your picture":
                    rose.SpeakAsync("ok");
                    roseface1.picbox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    roseface1.picbox1.Image = Properties.Resources.My_Eye_1;
                    //roseface1.tmr1.Stop();
                    //roseface1.tmr2.Stop();
                    break;

                case "Close it":
                    rose.SpeakAsync("Closing");
                    SendKeys.Send("%{F4}");                                        
                    break;

                case "See your left":
                case "See to the right":
                    roseface1.picbox1.Image = Properties.Resources.My_Eye_2;
                    timer1.Start();
                    break;

                case "See your right":
                case "See to the left":
                    roseface1.picbox1.Image = Properties.Resources.My_Eye_3;
                    timer1.Start();                   
                    break;

                case "Stop blinking your eye":
                    rose.SpeakAsync("ok");
                    blinkingstoper();
                    break;

                case "You can blink your eye":
                    if (roseface1.lstc.Visible == false && roseface1.lstmc.Visible == false && roseface1.cbmusic.Visible == false)
                    {
                        rose.SpeakAsync("Thank you");
                        roseface1.tmr1.Start();
                        roseface1.tmr2.Start();                        
                    }
                    else
                    {
                        rose.SpeakAsync("I cant blink due to some restrictions");
                    }
                    break;

                case "Show me restrictions":
                case "Show restrictions":
                    //
                    break;

                case "Show me yourself":
                case "Show yourself":
                case "Show me your complete body":
                case "Show your body":
                case "I want to see you":
                    //rosebody1.BringToFront();

                    blinkingstoper();
                    roseface1.pnl1.Visible = false;
                    roseface1.pnl3.Visible = false;
                    //roseface1.picbox1.i
                    roseface1.picbox1.Image = Properties.Resources._220901cc812754399033b09cc7755741;


                    foreach (Control lstitem in roseface1.Controls) // as there are also controls other than listbox so we write here control not listbox
                    {
                        if (lstitem is ListBox)
                        {
                            lstitem.ForeColor = Color.Black;
                            lstitem.BackColor = Color.White;
                        }                        
                    }
                    break;

                case "Show me your face only":
                case "Show your face only":
                case "Hide your body":
                case "Hide yourself":
                    //roseface1.BringToFront();

                    roseface1.picbox1.Image = Properties.Resources.My_Eye_1;
                    blinkingstoper();
                    roseface1.pnl1.Visible = true;
                    roseface1.pnl3.Visible = true;

                    foreach (Control lstitem in roseface1.Controls)
                    {
                        if (lstitem is ListBox)
                        {
                            lstitem.ForeColor = Color.White;
                            lstitem.BackColor = Color.Black;
                        }
                    }
                    break;

                    //Sending keys

                //case "Send numbers":
                //    try
                //    {
                //        if (Convert.ToInt32(speech) >= 0 && Convert.ToInt32(speech) <= 100)
                //        {
                //            SendKeys.Send(speech);
                //        }
                //    }
                //    catch
                //    {
                //        rose.SpeakAsync("Please give only numeric");
                //    }                    
                //    break;                
                

                case "F":
                    SendKeys.Send("f");//if we give F, it wouldnt full screen vlc
                    break;

                case "Full screen":
                    SendKeys.Send("f");
                    break;

                case "Escape":
                    FindForm();
                    SendKeys.Send("{ESC}");
                    break;

                case "Up":
                    SendKeys.Send("{UP}");
                    break;

                case "Down":
                    SendKeys.Send("{DOWN}");
                    break;

                case "Right":
                    SendKeys.Send("{RIGHT}");
                    break;

                case "Left":
                    SendKeys.Send("{LEFT}");
                    break;

                case "Page up":
                    SendKeys.Send("{PGUP}");
                    break;

                case "Page down":
                    SendKeys.Send("{PGDN}");
                    break;

                case "Space":
                    SendKeys.Send(" ");//it send space keyword
                    break;

                case "Enter":
                    SendKeys.Send("{ENTER}");
                    break;

                case "Backspace":
                    SendKeys.Send("{BKSP}");
                    break;

                case "Tab":
                    SendKeys.Send("{Tab}");
                    break;

                case "Search":
                    SendKeys.Send("^{e}");//it doesnt work on E
                    break;
                
                case "Stop listening":
                    rose.SpeakAsync("ok. if you need me just ask");
                    recognizer.RecognizeAsyncCancel();
                    startlistening.RecognizeAsync(RecognizeMode.Multiple);
                    break;

                case "0":
                    SendKeys.Send("0");
                    break;

                case "1":
                    SendKeys.Send("1");
                    break;

                case "2":
                    SendKeys.Send("2");
                    break;

                case "3":
                    SendKeys.Send("3");
                    break;

                case "4":
                    SendKeys.Send("4");
                    break;

                case "5":
                    SendKeys.Send("5");
                    break;

                case "6":
                    SendKeys.Send("6");
                    break;

                case "7":
                    SendKeys.Send("7");
                    break;

                case "8":
                    SendKeys.Send("8");
                    break;

                case "9":
                    SendKeys.Send("9");
                    break;

                //if (true) it shows warning by saying unreachable code detected                


                default:                    
                    rose.SpeakAsync("Sorry, I Do Not Understand");
                    break;

                //case "10":
                //    SendKeys.Send("10");
                //    break;

                //case "11":
                //    SendKeys.Send("11");
                //    break;

                //case "12":
                //    SendKeys.Send("12");
                //    break;

                //case "13":
                //    SendKeys.Send("13");
                //    break;

                //case "14":
                //    SendKeys.Send("14");
                //    break;

                //case "15":
                //    SendKeys.Send("15");
                //    break;

                //case "16":
                //    SendKeys.Send("16");
                //    break;

                //case "17":
                //    SendKeys.Send("17");
                //    break;

                //case "18":
                //    SendKeys.Send("18");
                //    break;

                //case "19":
                //    SendKeys.Send("19");
                //    break;

                //case "20":
                //    SendKeys.Send("20");
                //    break;

                //case "21":
                //    SendKeys.Send("21");
                //    break;

                //case "22":
                //    SendKeys.Send("22");
                //    break;

                //case "23":
                //    SendKeys.Send("23");
                //    break;

                //case "24":
                //    SendKeys.Send("24");
                //    break;

                //case "25":
                //    SendKeys.Send("25");
                //    break;

                //case "26":
                //    SendKeys.Send("26");
                //    break;

                //case "27":
                //    SendKeys.Send("27");
                //    break;

                //case "28":
                //    SendKeys.Send("28");
                //    break;

                //case "29":
                //    SendKeys.Send("29");
                //    break;

                //case "30":
                //    SendKeys.Send("30");
                //    break;

                //case "31":
                //    SendKeys.Send("31");
                //    break;

                //case "32":
                //    SendKeys.Send("32");
                //    break;

                //case "33":
                //    SendKeys.Send("33");
                //    break;

                //case "34":
                //    SendKeys.Send("34");
                //    break;

                //case "35":
                //    SendKeys.Send("35");
                //    break;

                //case "36":
                //    SendKeys.Send("36");
                //    break;

                //case "37":
                //    SendKeys.Send("37");
                //    break;

                //case "38":
                //    SendKeys.Send("38");
                //    break;

                //case "39":
                //    SendKeys.Send("39");
                //    break;

                //case "40":
                //    SendKeys.Send("40");
                //    break;

                //case "41":
                //    SendKeys.Send("41");
                //    break;

                //case "42":
                //    SendKeys.Send("42");
                //    break;

                //case "43":
                //    SendKeys.Send("43");
                //    break;

                //case "44":
                //    SendKeys.Send("44");
                //    break;

                //case "45":
                //    SendKeys.Send("45");
                //    break;

                //case "46":
                //    SendKeys.Send("46");
                //    break;

                //case "47":
                //    SendKeys.Send("47");
                //    break;

                //case "48":
                //    SendKeys.Send("48");
                //    break;

                //case "49":
                //    SendKeys.Send("49");
                //    break;

                //case "50":
                //    SendKeys.Send("50");
                //    break;
            
            }
        }
        

        void blinkingstoper()
        {
            roseface1.tmr1.Stop();
            roseface1.tmr2.Stop();
            roseface1.pnl1.Height = 85;
            roseface1.pnl3.Height = 85;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            roseface1.picbox1.Image = Properties.Resources.My_Eye_1; 
            timer1.Stop();
            //recognizer.RecognizeAsyncCancel();
            //recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DafaultCommands.txt")))));
            //recognizer.RecognizeAsync(RecognizeMode.Multiple);

            //search = false;
        }        
    }
}