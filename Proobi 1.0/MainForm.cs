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

            ControlExtension.Draggable(panel1, true);

            panelCode.Size = new Size(this.Size.Width * 2 / 3, panelCode.Size.Height);
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

        private void panel1_Click(object sender, EventArgs e)
        {
            Steps = 10;
            Timerstepes = 0;
            Angle = -5;
            Timerangle = 0;
            timer1.Start();
        }
    }
}
