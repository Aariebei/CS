using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace AlarmClocks
{
    class AlarmClock
    {
        private string _alarm;
        public string Alarm
        {
            set { _alarm = value; }
        }
        private string _time;
        DispatcherTimer timer = new DispatcherTimer();
        private Label _lblTime;
        public Label lblTime
        {
            set { _lblTime = value; }
        }
        public string Time
        {
            get
            {
                DateTime now = DateTime.Now;
                return now.ToString("HH:mm:ss");
            }
        }
        public AlarmClock()
        {
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _time = Time;
            _lblTime.Content = Time;
            if (this.IsExpired())
            {
                SystemSounds.Beep.Play();
                timer.Stop();
                MessageBox.Show("De timer is verlopen!");
            }
        }

        public bool IsExpired()
        {
            if (_alarm == _time)
            {
                return true;
            }
            return false;
        }
    }
}
