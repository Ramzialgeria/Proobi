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
    }
}
