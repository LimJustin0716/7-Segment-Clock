using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Segment_Timer
{
    public partial class Form1 : Form
    {
        int second1;
        int second2;
        int minute1;
        int minute2;
        int hour1;
        int hour2;
        string live_second1;
        string live_second2;
        string live_minute1;
        string live_minute2;
        string live_hour1;
        string live_hour2;

        public Form1()
        {
            InitializeComponent();
        }

        private void clockTime(object sender, EventArgs e)
        {
            Button numClick = (Button)sender;
            numClick.BackColor = System.Drawing.Color.Red;
        }

        private void Clock(object sender, EventArgs e)
        {
            live_second2 = DateTime.Now.ToString("ss");
            second2 = Convert.ToInt32(live_second2.Substring(live_second2.Length - 1));

            if (second2 == 0)
            {
                second2A.PerformClick();
                second2B.PerformClick();
                second2C.PerformClick();
                second2D.PerformClick();
                second2E.PerformClick();
                second2F.PerformClick();
                second2G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (second2 == 1)
            {
                second2A.BackColor = System.Drawing.Color.Transparent;
                second2B.PerformClick();
                second2C.PerformClick();
                second2D.BackColor = System.Drawing.Color.Transparent;
                second2E.BackColor = System.Drawing.Color.Transparent;
                second2F.BackColor = System.Drawing.Color.Transparent;
                second2G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (second2 == 2)
            {
                second2A.PerformClick();
                second2B.PerformClick();
                second2C.BackColor = System.Drawing.Color.Transparent;
                second2D.PerformClick();
                second2E.PerformClick();
                second2F.BackColor = System.Drawing.Color.Transparent;
                second2G.PerformClick();
            }

            else if (second2 == 3)
            {
                second2A.PerformClick();
                second2B.PerformClick();
                second2C.PerformClick();
                second2D.PerformClick();
                second2E.BackColor = System.Drawing.Color.Transparent;
                second2F.BackColor = System.Drawing.Color.Transparent;
                second2G.PerformClick();
            }

            else if (second2 == 4)
            {
                second2A.BackColor = System.Drawing.Color.Transparent;
                second2B.PerformClick();
                second2C.PerformClick();
                second2D.BackColor = System.Drawing.Color.Transparent;
                second2E.BackColor = System.Drawing.Color.Transparent;
                second2F.PerformClick();
                second2G.PerformClick();
            }

            else if (second2 == 5)
            {
                second2A.PerformClick();
                second2B.BackColor = System.Drawing.Color.Transparent;
                second2C.PerformClick();
                second2D.PerformClick();
                second2E.BackColor = System.Drawing.Color.Transparent;
                second2F.PerformClick();
                second2G.PerformClick();
            }

            else if (second2 == 6)
            {
                second2A.PerformClick();
                second2B.BackColor = System.Drawing.Color.Transparent;
                second2C.PerformClick();
                second2D.PerformClick();
                second2E.PerformClick();
                second2F.PerformClick();
                second2G.PerformClick();
            }

            else if (second2 == 7)
            {
                second2A.PerformClick();
                second2B.PerformClick();
                second2C.PerformClick();
                second2D.BackColor = System.Drawing.Color.Transparent;
                second2E.BackColor = System.Drawing.Color.Transparent;
                second2F.BackColor = System.Drawing.Color.Transparent;
                second2G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (second2 == 8)
            {
                second2A.PerformClick();
                second2B.PerformClick();
                second2C.PerformClick();
                second2D.PerformClick();
                second2E.PerformClick();
                second2F.PerformClick();
                second2G.PerformClick();
            }

            else if (second2 == 9)
            {
                second2A.PerformClick();
                second2B.PerformClick();
                second2C.PerformClick();
                second2D.BackColor = System.Drawing.Color.Transparent;
                second2E.BackColor = System.Drawing.Color.Transparent;
                second2F.PerformClick();
                second2G.PerformClick();
            }

            live_second1 = DateTime.Now.ToString("ss");
            second1 = Convert.ToInt32(live_second1.Substring(0, 1));

            if (second1 == 0)
            {
                second1A.PerformClick();
                second1B.PerformClick();
                second1C.PerformClick();
                second1D.PerformClick();
                second1E.PerformClick();
                second1F.PerformClick();
                second1G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (second1 == 1)
            {
                second1A.BackColor = System.Drawing.Color.Transparent;
                second1B.PerformClick();
                second1C.PerformClick();
                second1D.BackColor = System.Drawing.Color.Transparent;
                second1E.BackColor = System.Drawing.Color.Transparent;
                second1F.BackColor = System.Drawing.Color.Transparent;
                second1G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (second1 == 2)
            {
                second1A.PerformClick();
                second1B.PerformClick();
                second1C.BackColor = System.Drawing.Color.Transparent;
                second1D.PerformClick();
                second1E.PerformClick();
                second1F.BackColor = System.Drawing.Color.Transparent;
                second1G.PerformClick();
            }

            else if (second1 == 3)
            {
                second1A.PerformClick();
                second1B.PerformClick();
                second1C.PerformClick();
                second1D.PerformClick();
                second1E.BackColor = System.Drawing.Color.Transparent;
                second1F.BackColor = System.Drawing.Color.Transparent;
                second1G.PerformClick();
            }

            else if (second1 == 4)
            {
                second1A.BackColor = System.Drawing.Color.Transparent;
                second1B.PerformClick();
                second1C.PerformClick();
                second1D.BackColor = System.Drawing.Color.Transparent;
                second1E.BackColor = System.Drawing.Color.Transparent;
                second1F.PerformClick();
                second1G.PerformClick();
            }

            else if (second1 == 5)
            {
                second1A.PerformClick();
                second1B.BackColor = System.Drawing.Color.Transparent;
                second1C.PerformClick();
                second1D.PerformClick();
                second1E.BackColor = System.Drawing.Color.Transparent;
                second1F.PerformClick();
                second1G.PerformClick();
            }

            else if (second1 == 6)
            {
                second1A.PerformClick();
                second1B.BackColor = System.Drawing.Color.Transparent;
                second1C.PerformClick();
                second1D.PerformClick();
                second1E.PerformClick();
                second1F.PerformClick();
                second1G.PerformClick();
            }

            else if (second1 == 7)
            {
                second1A.PerformClick();
                second1B.PerformClick();
                second1C.PerformClick();
                second1D.BackColor = System.Drawing.Color.Transparent;
                second1E.BackColor = System.Drawing.Color.Transparent;
                second1F.BackColor = System.Drawing.Color.Transparent;
                second1G.BackColor = System.Drawing.Color.Transparent;
            }

            else if (second1 == 8)
            {
                second1A.PerformClick();
                second1B.PerformClick();
                second1C.PerformClick();
                second1D.PerformClick();
                second1E.PerformClick();
                second1F.PerformClick();
                second1G.PerformClick();
            }

            else if (second1 == 9)
            {
                second1A.PerformClick();
                second1B.PerformClick();
                second1C.PerformClick();
                second1D.BackColor = System.Drawing.Color.Transparent;
                second1E.BackColor = System.Drawing.Color.Transparent;
                second1F.PerformClick();
                second1G.PerformClick();
            }

            //Minutes in 1s place
            live_minute2 = DateTime.Now.ToString("mm");
            minute2 = Convert.ToInt32(live_minute2.Substring(live_minute2.Length - 1));
            {
                if (minute2 == 0)
                {
                    minute2A.PerformClick();
                    minute2B.PerformClick();
                    minute2C.PerformClick();
                    minute2D.PerformClick();
                    minute2E.PerformClick();
                    minute2F.PerformClick();
                    minute2G.BackColor = System.Drawing.Color.Transparent;
                }

                else if (minute2 == 1)
                {
                    minute2A.BackColor = System.Drawing.Color.Transparent;
                    minute2B.PerformClick();
                    minute2C.PerformClick();
                    minute2D.BackColor = System.Drawing.Color.Transparent;
                    minute2E.BackColor = System.Drawing.Color.Transparent;
                    minute2F.BackColor = System.Drawing.Color.Transparent;
                    minute2G.BackColor = System.Drawing.Color.Transparent;
                }

                else if (minute2 == 2)
                {
                    minute2A.PerformClick();
                    minute2B.PerformClick();
                    minute2C.BackColor = System.Drawing.Color.Transparent;
                    minute2D.PerformClick();
                    minute2E.PerformClick();
                    minute2F.BackColor = System.Drawing.Color.Transparent;
                    minute2G.PerformClick();
                }

                else if (minute2 == 3)
                {
                    minute2A.PerformClick();
                    minute2B.PerformClick();
                    minute2C.PerformClick();
                    minute2D.PerformClick();
                    minute2E.BackColor = System.Drawing.Color.Transparent;
                    minute2F.BackColor = System.Drawing.Color.Transparent;
                    minute2G.PerformClick();
                }

                else if (minute2 == 4)
                {
                    minute2A.BackColor = System.Drawing.Color.Transparent;
                    minute2B.PerformClick();
                    minute2C.PerformClick();
                    minute2D.BackColor = System.Drawing.Color.Transparent;
                    minute2E.BackColor = System.Drawing.Color.Transparent;
                    minute2F.PerformClick();
                    minute2G.PerformClick();
                }

                else if (minute2 == 5)
                {
                    minute2A.PerformClick();
                    minute2B.BackColor = System.Drawing.Color.Transparent;
                    minute2C.PerformClick();
                    minute2D.PerformClick();
                    minute2E.BackColor = System.Drawing.Color.Transparent;
                    minute2F.PerformClick();
                    minute2G.PerformClick();
                }

                else if (minute2 == 6)
                {
                    minute2A.PerformClick();
                    minute2B.BackColor = System.Drawing.Color.Transparent;
                    minute2C.PerformClick();
                    minute2D.PerformClick();
                    minute2E.PerformClick();
                    minute2F.PerformClick();
                    minute2G.PerformClick();
                }

                else if (minute2 == 7)
                {
                    minute2A.PerformClick();
                    minute2B.PerformClick();
                    minute2C.PerformClick();
                    minute2D.BackColor = System.Drawing.Color.Transparent;
                    minute2E.BackColor = System.Drawing.Color.Transparent;
                    minute2F.BackColor = System.Drawing.Color.Transparent;
                    minute2G.BackColor = System.Drawing.Color.Transparent;
                }

                else if (minute2 == 8)
                {
                    minute2A.PerformClick();
                    minute2B.PerformClick();
                    minute2C.PerformClick();
                    minute2D.PerformClick();
                    minute2E.PerformClick();
                    minute2F.PerformClick();
                    minute2G.PerformClick();
                }

                else if (minute2 == 9)
                {
                    minute2A.PerformClick();
                    minute2B.PerformClick();
                    minute2C.PerformClick();
                    minute2D.BackColor = System.Drawing.Color.Transparent;
                    minute2E.BackColor = System.Drawing.Color.Transparent;
                    minute2F.PerformClick();
                    minute2G.PerformClick();
                }

                live_minute1 = DateTime.Now.ToString("mm");
                minute1 = Convert.ToInt32(live_minute1.Substring(0, 1));

                if (minute1 == 0)
                {
                    minute1A.PerformClick();
                    minute1B.PerformClick();
                    minute1C.PerformClick();
                    minute1D.PerformClick();
                    minute1E.PerformClick();
                    minute1F.PerformClick();
                    minute1G.BackColor = System.Drawing.Color.Transparent;
                }

                else if (minute1 == 1)
                {
                    minute1A.BackColor = System.Drawing.Color.Transparent;
                    minute1B.PerformClick();
                    minute1C.PerformClick();
                    minute1D.BackColor = System.Drawing.Color.Transparent;
                    minute1E.BackColor = System.Drawing.Color.Transparent;
                    minute1F.BackColor = System.Drawing.Color.Transparent;
                    minute1G.BackColor = System.Drawing.Color.Transparent;
                }

                else if (minute1 == 2)
                {
                    minute1A.PerformClick();
                    minute1B.PerformClick();
                    minute1C.BackColor = System.Drawing.Color.Transparent;
                    minute1D.PerformClick();
                    minute1E.PerformClick();
                    minute1F.BackColor = System.Drawing.Color.Transparent;
                    minute1G.PerformClick();
                }

                else if (minute1 == 3)
                {
                    minute1A.PerformClick();
                    minute1B.PerformClick();
                    minute1C.PerformClick();
                    minute1D.PerformClick();
                    minute1E.BackColor = System.Drawing.Color.Transparent;
                    minute1F.BackColor = System.Drawing.Color.Transparent;
                    minute1G.PerformClick();
                }

                else if (minute1 == 4)
                {
                    minute1A.BackColor = System.Drawing.Color.Transparent;
                    minute1B.PerformClick();
                    minute1C.PerformClick();
                    minute1D.BackColor = System.Drawing.Color.Transparent;
                    minute1E.BackColor = System.Drawing.Color.Transparent;
                    minute1F.PerformClick();
                    minute1G.PerformClick();
                }

                else if (minute1 == 5)
                {
                    minute1A.PerformClick();
                    minute1B.BackColor = System.Drawing.Color.Transparent;
                    minute1C.PerformClick();
                    minute1D.PerformClick();
                    minute1E.BackColor = System.Drawing.Color.Transparent;
                    minute1F.PerformClick();
                    minute1G.PerformClick();
                }

                else if (minute1 == 6)
                {
                    minute1A.PerformClick();
                    minute1B.BackColor = System.Drawing.Color.Transparent;
                    minute1C.PerformClick();
                    minute1D.PerformClick();
                    minute1E.PerformClick();
                    minute1F.PerformClick();
                    minute1G.PerformClick();
                }

                else if (minute1 == 7)
                {
                    minute1A.PerformClick();
                    minute1B.PerformClick();
                    minute1C.PerformClick();
                    minute1D.BackColor = System.Drawing.Color.Transparent;
                    minute1E.BackColor = System.Drawing.Color.Transparent;
                    minute1F.BackColor = System.Drawing.Color.Transparent;
                    minute1G.BackColor = System.Drawing.Color.Transparent;
                }

                else if (minute1 == 8)
                {
                    minute1A.PerformClick();
                    minute1B.PerformClick();
                    minute1C.PerformClick();
                    minute1D.PerformClick();
                    minute1E.PerformClick();
                    minute1F.PerformClick();
                    minute1G.PerformClick();
                }

                else if (minute1 == 9)
                {
                    minute1A.PerformClick();
                    minute1B.PerformClick();
                    minute1C.PerformClick();
                    minute1D.BackColor = System.Drawing.Color.Transparent;
                    minute1E.BackColor = System.Drawing.Color.Transparent;
                    minute1F.PerformClick();
                    minute1G.PerformClick();
                }

                //Hour in 1s place
                live_hour2 = DateTime.Now.ToString("HH");
                hour2 = Convert.ToInt32(live_hour2.Substring(live_hour2.Length - 1));

                if (hour2 == 0)
                {
                    hour2A.PerformClick();
                    hour2B.PerformClick();
                    hour2C.PerformClick();
                    hour2D.PerformClick();
                    hour2E.PerformClick();
                    hour2F.PerformClick();
                    hour2G.BackColor = System.Drawing.Color.Transparent;
                }

                else if (hour2 == 1)
                {
                    hour2A.BackColor = System.Drawing.Color.Transparent;
                    hour2B.PerformClick();
                    hour2C.PerformClick();
                    hour2D.BackColor = System.Drawing.Color.Transparent;
                    hour2E.BackColor = System.Drawing.Color.Transparent;
                    hour2F.BackColor = System.Drawing.Color.Transparent;
                    hour2G.BackColor = System.Drawing.Color.Transparent;
                }

                else if (hour2 == 2)
                {
                    hour2A.PerformClick();
                    hour2B.PerformClick();
                    hour2C.BackColor = System.Drawing.Color.Transparent;
                    hour2D.PerformClick();
                    hour2E.PerformClick();
                    hour2F.BackColor = System.Drawing.Color.Transparent;
                    hour2G.PerformClick();
                }

                else if (hour2 == 3)
                {
                    hour2A.PerformClick();
                    hour2B.PerformClick();
                    hour2C.PerformClick();
                    hour2D.PerformClick();
                    hour2E.BackColor = System.Drawing.Color.Transparent;
                    hour2F.BackColor = System.Drawing.Color.Transparent;
                    hour2G.PerformClick();
                }

                else if (hour2 == 4)
                {
                    hour2A.BackColor = System.Drawing.Color.Transparent;
                    hour2B.PerformClick();
                    hour2C.PerformClick();
                    hour2D.BackColor = System.Drawing.Color.Transparent;
                    hour2E.BackColor = System.Drawing.Color.Transparent;
                    hour2F.PerformClick();
                    hour2G.PerformClick();
                }

                else if (hour2 == 5)
                {
                    hour2A.PerformClick();
                    hour2B.BackColor = System.Drawing.Color.Transparent;
                    hour2C.PerformClick();
                    hour2D.PerformClick();
                    hour2E.BackColor = System.Drawing.Color.Transparent;
                    hour2F.PerformClick();
                    hour2G.PerformClick();
                }

                else if (hour2 == 6)
                {
                    hour2A.PerformClick();
                    hour2B.BackColor = System.Drawing.Color.Transparent;
                    hour2C.PerformClick();
                    hour2D.PerformClick();
                    hour2E.PerformClick();
                    hour2F.PerformClick();
                    hour2G.PerformClick();
                }

                else if (hour2 == 7)
                {
                    hour2A.PerformClick();
                    hour2B.PerformClick();
                    hour2C.PerformClick();
                    hour2D.BackColor = System.Drawing.Color.Transparent;
                    hour2E.BackColor = System.Drawing.Color.Transparent;
                    hour2F.BackColor = System.Drawing.Color.Transparent;
                    hour2G.BackColor = System.Drawing.Color.Transparent;
                }

                else if (hour2 == 8)
                {
                    hour2A.PerformClick();
                    hour2B.PerformClick();
                    hour2C.PerformClick();
                    hour2D.PerformClick();
                    hour2E.PerformClick();
                    hour2F.PerformClick();
                    hour2G.PerformClick();
                }

                else if (hour2 == 9)
                {
                    hour2A.PerformClick();
                    hour2B.PerformClick();
                    hour2C.PerformClick();
                    hour2D.BackColor = System.Drawing.Color.Transparent;
                    hour2E.BackColor = System.Drawing.Color.Transparent;
                    hour2F.PerformClick();
                    hour2G.PerformClick();
                }

                //Hour in 10s place
                live_hour1 = DateTime.Now.ToString("HH");
                hour1 = Convert.ToInt32(live_hour1.Substring(0, 1));

                if (hour1 == 0)
                {
                    hour1A.PerformClick();
                    hour1B.PerformClick();
                    hour1C.PerformClick();
                    hour1D.PerformClick();
                    hour1E.PerformClick();
                    hour1F.PerformClick();
                    hour1G.BackColor = System.Drawing.Color.Transparent;
                }

                else if (hour1 == 1)
                {
                    hour1A.BackColor = System.Drawing.Color.Transparent;
                    hour1B.PerformClick();
                    hour1C.PerformClick();
                    hour1D.BackColor = System.Drawing.Color.Transparent;
                    hour1E.BackColor = System.Drawing.Color.Transparent;
                    hour1F.BackColor = System.Drawing.Color.Transparent;
                    hour1G.BackColor = System.Drawing.Color.Transparent;
                }

                else if (hour1 == 2)
                {
                    hour1A.PerformClick();
                    hour1B.PerformClick();
                    hour1C.BackColor = System.Drawing.Color.Transparent;
                    hour1D.PerformClick();
                    hour1E.PerformClick();
                    hour1F.BackColor = System.Drawing.Color.Transparent;
                    hour1G.PerformClick();
                }

                else if (hour1 == 3)
                {
                    hour1A.PerformClick();
                    hour1B.PerformClick();
                    hour1C.PerformClick();
                    hour1D.PerformClick();
                    hour1E.BackColor = System.Drawing.Color.Transparent;
                    hour1F.BackColor = System.Drawing.Color.Transparent;
                    hour1G.PerformClick();
                }

                else if (hour1 == 4)
                {
                    hour1A.BackColor = System.Drawing.Color.Transparent;
                    hour1B.PerformClick();
                    hour1C.PerformClick();
                    hour1D.BackColor = System.Drawing.Color.Transparent;
                    hour1E.BackColor = System.Drawing.Color.Transparent;
                    hour1F.PerformClick();
                    hour1G.PerformClick();
                }

                else if (hour1 == 5)
                {
                    hour1A.PerformClick();
                    hour1B.BackColor = System.Drawing.Color.Transparent;
                    hour1C.PerformClick();
                    hour1D.PerformClick();
                    hour1E.BackColor = System.Drawing.Color.Transparent;
                    hour1F.PerformClick();
                    hour1G.PerformClick();
                }

                else if (hour1 == 6)
                {
                    hour1A.PerformClick();
                    hour1B.BackColor = System.Drawing.Color.Transparent;
                    hour1C.PerformClick();
                    hour1D.PerformClick();
                    hour1E.PerformClick();
                    hour1F.PerformClick();
                    hour1G.PerformClick();
                }

                else if (hour1 == 7)
                {
                    hour1A.PerformClick();
                    hour1B.PerformClick();
                    hour1C.PerformClick();
                    hour1D.BackColor = System.Drawing.Color.Transparent;
                    hour1E.BackColor = System.Drawing.Color.Transparent;
                    hour1F.BackColor = System.Drawing.Color.Transparent;
                    hour1G.BackColor = System.Drawing.Color.Transparent;
                }

                else if (hour1 == 8)
                {
                    hour1A.PerformClick();
                    hour1B.PerformClick();
                    hour1C.PerformClick();
                    hour1D.PerformClick();
                    hour1E.PerformClick();
                    hour1F.PerformClick();
                    hour1G.PerformClick();
                }

                else if (hour1 == 9)
                {
                    hour1A.PerformClick();
                    hour1B.PerformClick();
                    hour1C.PerformClick();
                    hour1D.BackColor = System.Drawing.Color.Transparent;
                    hour1E.BackColor = System.Drawing.Color.Transparent;
                    hour1F.PerformClick();
                    hour1G.PerformClick();
                }
            }
        }
    }
}