using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AlarmApp
{
    public partial class AlarmForm : Form
    {
        System.Timers.Timer timer;
        public AlarmForm()
        {
            InitializeComponent();
        }

        private void AlarmForm_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        delegate void UpdateLabel(Label lbl, string value);

        void UpdateDataLabel(Label lbl, string value)
        {
            lbl.Text = value;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if(currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    UpdateLabel upd = UpdateDataLabel;
                    if (label1.InvokeRequired)
                        Invoke(upd, label1, "Stop");
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                    player.PlayLooping();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            timer.Start();
            label1.Text = "Running...";
        }

        private void buttonstop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            label1.Text = "Stop";
            SoundPlayer player = new SoundPlayer();
            player.Stop();
        }
    }
}
