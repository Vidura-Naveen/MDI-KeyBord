using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;

namespace MDIKEYBORD
{
    public partial class Form1 : Form
    {
        OutputDevice outputdevice;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            outputdevice = OutputDevice.InstalledDevices[0];
            outputdevice.Open();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(48, 49, 1154, 264));
            g.DrawRectangle(Pens.Black, new Rectangle(47, 48, 1156, 266));
            //g.DrawRectangle(Pens.Black, new Rectangle(50, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(105, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(160, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(215, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(270, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(325, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(380, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(435, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(490, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(545, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(600, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(655, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(710, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(765, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(820, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(875, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(930, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(985, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(1040, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(1095, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(1150, 50, 50, 260));
            //g.DrawRectangle(Pens.Black, new Rectangle(1205, 50, 50, 260));



            for (int i = 0; i <1155 ; i+=55)
                {
                    
                    g.DrawRectangle(Pens.Black, new Rectangle(50 + i, 50, 50, 260));
                    g.FillRectangle(Brushes.White, new Rectangle(50 + i+2, 50+2, 50-4, 260-4));

                }



            /*g.DrawRectangle(Pens.Black, new Rectangle(80, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(135, 50, 45, 160));
            //g.DrawRectangle(Pens.Black, new Rectangle(190, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(245, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(300, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(355, 50, 45, 160));
            //g.DrawRectangle(Pens.Black, new Rectangle(410, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(465, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(520, 50, 45, 160));
            //g.DrawRectangle(Pens.Black, new Rectangle(575, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(630, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(685, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(740, 50, 45, 160));
            //g.DrawRectangle(Pens.Black, new Rectangle(795, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(850, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(905, 50, 45, 160));
            //g.DrawRectangle(Pens.Black, new Rectangle(960, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(1015, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(1070, 50, 45, 160));
            g.DrawRectangle(Pens.Black, new Rectangle(1125, 50, 45, 160));
            //g.DrawRectangle(Pens.Black, new Rectangle(1180, 50, 45, 160));*/


            for (int j = 0; j < 1100; j+=55)
            {
                if (j==110)
                {
                    continue;
                }
                else if (j==330)
                {
                    continue;
                }
                else if (j == 495)
                {
                    continue;
                }
                else if (j == 715)
                {
                    continue;
                }
                else if (j == 880)
                {
                    continue;
                }
                else
                {
                    g.DrawRectangle(Pens.Black, new Rectangle(j + 80, 50, 45, 160));
                    g.FillRectangle(Brushes.Black, new Rectangle(j + 80 + 2, 50, 45 - 4, 160 - 2));
                }
            }


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //c3
            if (((e.X >= 50 && e.X <= 100) && (e.Y >= 210 && e.Y <= 310)) || ((e.X >= 50 && e.X <= 80) && (e.Y >= 50 && e.Y <= 210)))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.C3, 127);
            }
            //c#
            else if ((e.X >= 80 && e.X <= 125) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.CSharp3, 127);
            }
            //D3
            else if ((e.X >= 105 && e.X <= 155) && (e.Y >= 210 && e.Y <= 310))
            { 

                outputdevice.SendNoteOn(Channel.Channel1, Pitch.D3, 127);
            }
            //D#
            else if ((e.X >= 135 && e.X <= 180) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.DSharp3, 127);
            }
            //E3
            else if (((e.X >= 160 && e.X <= 210) && (e.Y >= 210 && e.Y <= 310)) || ((e.X >= 180 && e.X <= 210) && (e.Y >= 50 && e.Y <= 210)))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.E3, 127);
            }
            //f3
            else if (((e.X >= 215 && e.X <= 265) && (e.Y >= 210 && e.Y <= 310)) || ((e.X >= 215 && e.X <= 245) && (e.Y >= 50 && e.Y <= 210)))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.F3, 127);
            }
            //f#
            else if ((e.X >= 245 && e.X <= 290) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.FSharp3, 127);
            }
            //G3
            else if ((e.X >= 270 && e.X <= 320) && (e.Y >= 210 && e.Y <= 310))
            {

                outputdevice.SendNoteOn(Channel.Channel1, Pitch.G3, 127);
            }
            //G#
            else if ((e.X >= 300 && e.X <= 345) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.GSharp3, 127);
            }
            //A3
            else if ((e.X >= 325 && e.X <= 375) && (e.Y >= 210 && e.Y <= 310))
            {

                outputdevice.SendNoteOn(Channel.Channel1, Pitch.A3, 127);
            }
            //A#
            else if ((e.X >= 355 && e.X <= 400) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.ASharp3, 127);
            }
            //B3
            else if (((e.X >= 380 && e.X <= 430) && (e.Y >= 210 && e.Y <= 310)) || ((e.X >= 400 && e.X <= 430) && (e.Y >= 50 && e.Y <= 210)))
            {

                outputdevice.SendNoteOn(Channel.Channel1, Pitch.B3, 127);
            }







            //c4
            if (((e.X >= 435 && e.X <= 485) && (e.Y >= 210 && e.Y <= 310)) || ((e.X >= 435 && e.X <= 465) && (e.Y >= 50 && e.Y <= 210)))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.C4, 127);
            }
            //c#
            else if ((e.X >= 465 && e.X <= 510) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.CSharp4, 127);
            }
            //D4
            else if ((e.X >= 490 && e.X <= 540) && (e.Y >= 210 && e.Y <= 310))
            {

                outputdevice.SendNoteOn(Channel.Channel1, Pitch.D4, 127);
            }
            //D#
            else if ((e.X >= 520 && e.X <= 565) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.DSharp4, 127);
            }
            //E4
            else if (((e.X >=545 && e.X <= 595) && (e.Y >= 210 && e.Y <= 310)) || ((e.X >= 565 && e.X <= 595) && (e.Y >= 50 && e.Y <= 210)))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.E4, 127);
            }
            //f4
            else if (((e.X >= 600 && e.X <= 650) && (e.Y >= 210 && e.Y <= 310)) || ((e.X >= 600 && e.X <= 630) && (e.Y >= 50 && e.Y <= 210)))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.F4, 127);
            }
            //f#
            else if ((e.X >= 630 && e.X <= 675) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.FSharp4, 127);
            }
            //G4
            else if ((e.X >= 655 && e.X <= 705) && (e.Y >= 210 && e.Y <= 310))
            {

                outputdevice.SendNoteOn(Channel.Channel1, Pitch.G4, 127);
            }
            //G#
            else if ((e.X >= 685 && e.X <= 730) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.GSharp4, 127);
            }
            //A4
            else if ((e.X >= 710 && e.X <= 760) && (e.Y >= 210 && e.Y <= 310))
            {

                outputdevice.SendNoteOn(Channel.Channel1, Pitch.A4, 127);
            }
            //A#
            else if ((e.X >= 740 && e.X <= 785) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.ASharp4, 127);
            }
            //B4
            else if (((e.X >= 765 && e.X <= 815) && (e.Y >= 210 && e.Y <= 310)) || ((e.X >= 785 && e.X <= 815) && (e.Y >= 50 && e.Y <= 210)))
            {

                outputdevice.SendNoteOn(Channel.Channel1, Pitch.B4, 127);

            }









            //c5
            if (((e.X >= 820 && e.X <= 870) && (e.Y >= 210 && e.Y <= 310)) || ((e.X >= 820 && e.X <= 850) && (e.Y >= 50 && e.Y <= 210)))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.C5, 127);
            }
            //c#
            else if ((e.X >= 850 && e.X <= 895) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.CSharp5, 127);
            }
            //D5
            else if ((e.X >= 875 && e.X <= 925) && (e.Y >= 210 && e.Y <= 310))
            {

                outputdevice.SendNoteOn(Channel.Channel1, Pitch.D5, 127);
            }
            //D#
            else if ((e.X >= 905 && e.X <= 950) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.DSharp5, 127);
            }
            //E5
            else if (((e.X >= 930 && e.X <= 980) && (e.Y >= 210 && e.Y <= 310)) || ((e.X >= 950 && e.X <= 980) && (e.Y >= 50 && e.Y <= 210)))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.E5, 127);
            }
            //f5
            else if (((e.X >= 985 && e.X <= 1035) && (e.Y >= 210 && e.Y <= 310)) || ((e.X >= 985 && e.X <= 1015) && (e.Y >= 50 && e.Y <= 210)))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.F5, 127);
            }
            //f#
            else if ((e.X >= 1015 && e.X <= 1060) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.FSharp5, 127);
            }
            //G5
            else if ((e.X >= 1040 && e.X <= 1090) && (e.Y >= 210 && e.Y <= 310))
            {

                outputdevice.SendNoteOn(Channel.Channel1, Pitch.G5, 127);
            }
            //G#
            else if ((e.X >= 1070 && e.X <= 1115) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.GSharp5, 127);
            }
            //A5
            else if ((e.X >= 1095 && e.X <= 1145) && (e.Y >= 210 && e.Y <= 310))
            {

                outputdevice.SendNoteOn(Channel.Channel1, Pitch.A5, 127);
            }
            //A#
            else if ((e.X >= 1125 && e.X <= 1170) && (e.Y >= 50 && e.Y <= 210))
            {
                outputdevice.SendNoteOn(Channel.Channel1, Pitch.ASharp5, 127);
            }
            //B5
            else if (((e.X >= 1150 && e.X <= 1200) && (e.Y >= 210 && e.Y <= 310)) || ((e.X >= 1170 && e.X <= 1200) && (e.Y >= 50 && e.Y <= 210)))
            {

                outputdevice.SendNoteOn(Channel.Channel1, Pitch.B5, 127);
            }


        }
    }
}
