using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proobi_1._0
{
    public partial class MainForm : Form
    {
        int Steps;
        int Timerstepes = 0;
        int Angle;
        int Timerangle = 0;

        #region Functions

        Point Move(Point CurrentPosition, int Steps)
        {
            Point NewPosition = new Point(CurrentPosition.X + Steps, CurrentPosition.Y);
            return NewPosition;
        }

        void InitializeBlockLocations()
        {
            panelSteps1.Location = new Point(10, 30);
            panelSteps2.Location = new Point(10, 30);
            panelSteps3.Location = new Point(10, 30);
            panelSteps4.Location = new Point(10, 30);
            panelSteps5.Location = new Point(10, 30);

        }

        #endregion Functions

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            ControlExtension.Draggable(panelSteps1, true);
            ControlExtension.Draggable(panelSteps2, true);
            ControlExtension.Draggable(panelSteps3, true);
            ControlExtension.Draggable(panelSteps4, true);
            ControlExtension.Draggable(panelSteps5, true);

            InitializeBlockLocations();

            panelCode.Size = new Size(this.Size.Width * 2 / 3, panelCode.Size.Height);

            panelFunctions.Size = new Size(panelCode.Size.Width - 60, panelCode.Size.Height);
            panelCode2.Size = new Size(panelFunctions.Size.Width -200, panelCode2.Size.Height);
            panelMainCode.Size = new Size(panelCode2.Size.Width + 100 , panelCode2.Size.Height + 800);
            panelMainCode.Location = new Point(0, 0);

           
        }

        private void panelClose_MouseEnter(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void panelClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.Transparent;
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); this.Close();
        }

        private void panelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelMinimize_MouseEnter(object sender, EventArgs e)
        {
            panelMinimize.BackColor = Color.FromArgb(0, 100, 181);
        }

        private void panelMinimize_MouseLeave(object sender, EventArgs e)
        {
            panelMinimize.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Timerstepes <= Steps)
            {
                Timerstepes += 1;
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                
            }
            else
            {
                timer2.Start();
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (Timerangle >= Angle)
            {
                Timerangle -= 1;
                pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);

            }
            else
            {

                timer2.Stop();
            }
        }

        private void panelSteps1_Click(object sender, EventArgs e)
        {
            Steps = 10;
            Timerstepes = 0;
            Angle = -5;
            Timerangle = 0;
            timer1.Start();
        }

        private void panelSteps1_MouseUp(object sender, MouseEventArgs e)
        {
            if (panelSteps1.Location.X < panelCode2.Location.X || panelSteps1.Location.X > panelCode2.Location.X + panelCode2.Width)
            {                
                panelSteps1.Location = new Point(10, 30);
            }

            if (panelSteps1.Location.X > panelCode2.Location.X && panelSteps1.Location.X < panelCode2.Location.X + panelCode2.Width)
            {
                
                panelFunctions.Controls.Remove(panelSteps1);
                panelMainCode.Controls.Add(panelSteps1);
                panelSteps1.Location = new Point(panelSteps1.Location.X - 200, panelSteps1.Location.Y);

            }
        }

        private void panelSteps1_MouseDown(object sender, MouseEventArgs e)
        {
            if (panelMainCode.Controls.Contains(panelSteps1))
            {
                panelMainCode.Controls.Remove(panelSteps1);
                panelFunctions.Controls.Add(panelSteps1);
                panelSteps1.BringToFront();
            }
        }

        private void panelSteps2_MouseUp(object sender, MouseEventArgs e)
        {
            if (panelSteps2.Location.X < panelCode2.Location.X || panelSteps2.Location.X > panelCode2.Location.X + panelCode2.Width)
            {
                panelSteps2.Location = new Point(10, 30);
            }

            if (panelSteps2.Location.X > panelCode2.Location.X && panelSteps2.Location.X < panelCode2.Location.X + panelCode2.Width)
            {

                panelFunctions.Controls.Remove(panelSteps2);
                panelMainCode.Controls.Add(panelSteps2);
                panelSteps2.Location = new Point(panelSteps2.Location.X - 200, panelSteps2.Location.Y);

            }
        }

        private void panelSteps2_MouseDown(object sender, MouseEventArgs e)
        {
            if (panelMainCode.Controls.Contains(panelSteps2))
            {
                panelMainCode.Controls.Remove(panelSteps2);
                panelFunctions.Controls.Add(panelSteps2);
                panelSteps2.BringToFront();
            }
        }

        private void panelSteps3_MouseUp(object sender, MouseEventArgs e)
        {
            if (panelSteps3.Location.X < panelCode2.Location.X || panelSteps3.Location.X > panelCode2.Location.X + panelCode2.Width)
            {
                panelSteps3.Location = new Point(10, 30);
            }

            if (panelSteps3.Location.X > panelCode2.Location.X && panelSteps3.Location.X < panelCode2.Location.X + panelCode2.Width)
            {

                panelFunctions.Controls.Remove(panelSteps3);
                panelMainCode.Controls.Add(panelSteps3);
                panelSteps3.Location = new Point(panelSteps3.Location.X - 200, panelSteps3.Location.Y);

            }
        }

        private void panelSteps3_MouseDown(object sender, MouseEventArgs e)
        {
            if (panelMainCode.Controls.Contains(panelSteps3))
            {
                panelMainCode.Controls.Remove(panelSteps3);
                panelFunctions.Controls.Add(panelSteps3);
                panelSteps3.BringToFront();
            }
        }

        private void panelSteps4_MouseUp(object sender, MouseEventArgs e)
        {
            if (panelSteps4.Location.X < panelCode2.Location.X || panelSteps4.Location.X > panelCode2.Location.X + panelCode2.Width)
            {
                panelSteps4.Location = new Point(10, 30);
            }

            if (panelSteps4.Location.X > panelCode2.Location.X && panelSteps4.Location.X < panelCode2.Location.X + panelCode2.Width)
            {

                panelFunctions.Controls.Remove(panelSteps4);
                panelMainCode.Controls.Add(panelSteps4);
                panelSteps4.Location = new Point(panelSteps4.Location.X - 200, panelSteps4.Location.Y);

            }
        }

        private void panelSteps4_MouseDown(object sender, MouseEventArgs e)
        {
            if (panelMainCode.Controls.Contains(panelSteps4))
            {
                panelMainCode.Controls.Remove(panelSteps4);
                panelFunctions.Controls.Add(panelSteps4);
                panelSteps4.BringToFront();
            }
        }

        private void panelSteps5_MouseUp(object sender, MouseEventArgs e)
        {
            if (panelSteps5.Location.X < panelCode2.Location.X || panelSteps5.Location.X > panelCode2.Location.X + panelCode2.Width)
            {
                panelSteps5.Location = new Point(10, 30);
            }

            if (panelSteps5.Location.X > panelCode2.Location.X && panelSteps5.Location.X < panelCode2.Location.X + panelCode2.Width)
            {

                panelFunctions.Controls.Remove(panelSteps5);
                panelMainCode.Controls.Add(panelSteps5);
                panelSteps5.Location = new Point(panelSteps5.Location.X - 200, panelSteps5.Location.Y);

            }
        }

        private void panelSteps5_MouseDown(object sender, MouseEventArgs e)
        {
            if (panelMainCode.Controls.Contains(panelSteps5))
            {
                panelMainCode.Controls.Remove(panelSteps5);
                panelFunctions.Controls.Add(panelSteps5);
                panelSteps5.BringToFront();
            }
        }
    }
}
