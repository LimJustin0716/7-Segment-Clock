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
                second2G.UseVisualStyleBackColor = true;
            }

            else if (second2 == 1)
            {
                second2A.UseVisualStyleBackColor = true;
                second2B.PerformClick();
                second2C.PerformClick();
                second2D.UseVisualStyleBackColor = true;
                second2E.UseVisualStyleBackColor = true;
                second2F.UseVisualStyleBackColor = true;
                second2G.UseVisualStyleBackColor = true;
            }

            else if (second2 == 2)
            {
                second2A.PerformClick();
                second2B.PerformClick();
                second2C.UseVisualStyleBackColor = true;
                second2D.PerformClick();
                second2E.PerformClick();
                second2F.UseVisualStyleBackColor = true;
                second2G.PerformClick();
            }

            else if (second2 == 3)
            {
                second2A.PerformClick();
                second2B.PerformClick();
                second2C.PerformClick();
                second2D.PerformClick();
                second2E.UseVisualStyleBackColor = true;
                second2F.UseVisualStyleBackColor = true;
                second2G.PerformClick();
            }

            else if (second2 == 4)
            {
                second2A.UseVisualStyleBackColor = true;
                second2B.PerformClick();
                second2C.PerformClick();
                second2D.UseVisualStyleBackColor = true;
                second2E.UseVisualStyleBackColor = true;
                second2F.PerformClick();
                second2G.PerformClick();
            }

            else if (second2 == 5)
            {
                second2A.PerformClick();
                second2B.UseVisualStyleBackColor = true;
                second2C.PerformClick();
                second2D.PerformClick();
                second2E.UseVisualStyleBackColor = true;
                second2F.PerformClick();
                second2G.PerformClick();
            }

            else if (second2 == 6)
            {
                second2A.PerformClick();
                second2B.UseVisualStyleBackColor = true;
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
                second2D.UseVisualStyleBackColor = true;
                second2E.UseVisualStyleBackColor = true;
                second2F.UseVisualStyleBackColor = true;
                second2G.UseVisualStyleBackColor = true;
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
                second2D.UseVisualStyleBackColor = true;
                second2E.UseVisualStyleBackColor = true;
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
                second1G.UseVisualStyleBackColor = true;
            }

            else if (second1 == 1)
            {
                second1A.UseVisualStyleBackColor = true;
                second1B.PerformClick();
                second1C.PerformClick();
                second1D.UseVisualStyleBackColor = true;
                second1E.UseVisualStyleBackColor = true;
                second1F.UseVisualStyleBackColor = true;
                second1G.UseVisualStyleBackColor = true;
            }

            else if (second1 == 2)
            {
                second1A.PerformClick();
                second1B.PerformClick();
                second1C.UseVisualStyleBackColor = true;
                second1D.PerformClick();
                second1E.PerformClick();
                second1F.UseVisualStyleBackColor = true;
                second1G.PerformClick();
            }

            else if (second1 == 3)
            {
                second1A.PerformClick();
                second1B.PerformClick();
                second1C.PerformClick();
                second1D.PerformClick();
                second1E.UseVisualStyleBackColor = true;
                second1F.UseVisualStyleBackColor = true;
                second1G.PerformClick();
            }

            else if (second1 == 4)
            {
                second1A.UseVisualStyleBackColor = true;
                second1B.PerformClick();
                second1C.PerformClick();
                second1D.UseVisualStyleBackColor = true;
                second1E.UseVisualStyleBackColor = true;
                second1F.PerformClick();
                second1G.PerformClick();
            }

            else if (second1 == 5)
            {
                second1A.PerformClick();
                second1B.UseVisualStyleBackColor = true;
                second1C.PerformClick();
                second1D.PerformClick();
                second1E.UseVisualStyleBackColor = true;
                second1F.PerformClick();
                second1G.PerformClick();
            }

            else if (second1 == 6)
            {
                second1A.PerformClick();
                second1B.UseVisualStyleBackColor = true;
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
                second1D.UseVisualStyleBackColor = true;
                second1E.UseVisualStyleBackColor = true;
                second1F.UseVisualStyleBackColor = true;
                second1G.UseVisualStyleBackColor = true;
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
                second1D.UseVisualStyleBackColor = true;
                second1E.UseVisualStyleBackColor = true;
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
                    minute2G.UseVisualStyleBackColor = true;
                }

                else if (minute2 == 1)
                {
                    minute2A.UseVisualStyleBackColor = true;
                    minute2B.PerformClick();
                    minute2C.PerformClick();
                    minute2D.UseVisualStyleBackColor = true;
                    minute2E.UseVisualStyleBackColor = true;
                    minute2F.UseVisualStyleBackColor = true;
                    minute2G.UseVisualStyleBackColor = true;
                }

                else if (minute2 == 2)
                {
                    minute2A.PerformClick();
                    minute2B.PerformClick();
                    minute2C.UseVisualStyleBackColor = true;
                    minute2D.PerformClick();
                    minute2E.PerformClick();
                    minute2F.UseVisualStyleBackColor = true;
                    minute2G.PerformClick();
                }

                else if (minute2 == 3)
                {
                    minute2A.PerformClick();
                    minute2B.PerformClick();
                    minute2C.PerformClick();
                    minute2D.PerformClick();
                    minute2E.UseVisualStyleBackColor = true;
                    minute2F.UseVisualStyleBackColor = true;
                    minute2G.PerformClick();
                }

                else if (minute2 == 4)
                {
                    minute2A.UseVisualStyleBackColor = true;
                    minute2B.PerformClick();
                    minute2C.PerformClick();
                    minute2D.UseVisualStyleBackColor = true;
                    minute2E.UseVisualStyleBackColor = true;
                    minute2F.PerformClick();
                    minute2G.PerformClick();
                }

                else if (minute2 == 5)
                {
                    minute2A.PerformClick();
                    minute2B.UseVisualStyleBackColor = true;
                    minute2C.PerformClick();
                    minute2D.PerformClick();
                    minute2E.UseVisualStyleBackColor = true;
                    minute2F.PerformClick();
                    minute2G.PerformClick();
                }

                else if (minute2 == 6)
                {
                    minute2A.PerformClick();
                    minute2B.UseVisualStyleBackColor = true;
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
                    minute2D.UseVisualStyleBackColor = true;
                    minute2E.UseVisualStyleBackColor = true;
                    minute2F.UseVisualStyleBackColor = true;
                    minute2G.UseVisualStyleBackColor = true;
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
                    minute2D.UseVisualStyleBackColor = true;
                    minute2E.UseVisualStyleBackColor = true;
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
                    minute1G.UseVisualStyleBackColor = true;
                }

                else if (minute1 == 1)
                {
                    minute1A.UseVisualStyleBackColor = true;
                    minute1B.PerformClick();
                    minute1C.PerformClick();
                    minute1D.UseVisualStyleBackColor = true;
                    minute1E.UseVisualStyleBackColor = true;
                    minute1F.UseVisualStyleBackColor = true;
                    minute1G.UseVisualStyleBackColor = true;
                }

                else if (minute1 == 2)
                {
                    minute1A.PerformClick();
                    minute1B.PerformClick();
                    minute1C.UseVisualStyleBackColor = true;
                    minute1D.PerformClick();
                    minute1E.PerformClick();
                    minute1F.UseVisualStyleBackColor = true;
                    minute1G.PerformClick();
                }

                else if (minute1 == 3)
                {
                    minute1A.PerformClick();
                    minute1B.PerformClick();
                    minute1C.PerformClick();
                    minute1D.PerformClick();
                    minute1E.UseVisualStyleBackColor = true;
                    minute1F.UseVisualStyleBackColor = true;
                    minute1G.PerformClick();
                }

                else if (minute1 == 4)
                {
                    minute1A.UseVisualStyleBackColor = true;
                    minute1B.PerformClick();
                    minute1C.PerformClick();
                    minute1D.UseVisualStyleBackColor = true;
                    minute1E.UseVisualStyleBackColor = true;
                    minute1F.PerformClick();
                    minute1G.PerformClick();
                }

                else if (minute1 == 5)
                {
                    minute1A.PerformClick();
                    minute1B.UseVisualStyleBackColor = true;
                    minute1C.PerformClick();
                    minute1D.PerformClick();
                    minute1E.UseVisualStyleBackColor = true;
                    minute1F.PerformClick();
                    minute1G.PerformClick();
                }

                else if (minute1 == 6)
                {
                    minute1A.PerformClick();
                    minute1B.UseVisualStyleBackColor = true;
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
                    minute1D.UseVisualStyleBackColor = true;
                    minute1E.UseVisualStyleBackColor = true;
                    minute1F.UseVisualStyleBackColor = true;
                    minute1G.UseVisualStyleBackColor = true;
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
                    minute1D.UseVisualStyleBackColor = true;
                    minute1E.UseVisualStyleBackColor = true;
                    minute1F.PerformClick();
                    minute1G.PerformClick();
                }
            }
        }
    }
}