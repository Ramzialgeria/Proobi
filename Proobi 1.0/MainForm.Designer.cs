namespace Proobi_1._0
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMinimize = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCode = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelFunctions = new System.Windows.Forms.Panel();
            this.panelMainCode = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelCode2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCode.SuspendLayout();
            this.panelFunctions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panelCode2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(6, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 32);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.panelMinimize);
            this.panel2.Controls.Add(this.panelClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 14, 8, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 40);
            this.panel2.TabIndex = 14;
            // 
            // panelMinimize
            // 
            this.panelMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(181)))));
            this.panelMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMinimize.BackgroundImage")));
            this.panelMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMinimize.Location = new System.Drawing.Point(761, 0);
            this.panelMinimize.Margin = new System.Windows.Forms.Padding(8, 16, 8, 16);
            this.panelMinimize.Name = "panelMinimize";
            this.panelMinimize.Size = new System.Drawing.Size(40, 40);
            this.panelMinimize.TabIndex = 13;
            this.panelMinimize.Click += new System.EventHandler(this.panelMinimize_Click);
            this.panelMinimize.MouseEnter += new System.EventHandler(this.panelMinimize_MouseEnter);
            this.panelMinimize.MouseLeave += new System.EventHandler(this.panelMinimize_MouseLeave);
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelClose.BackgroundImage")));
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelClose.Location = new System.Drawing.Point(801, 0);
            this.panelClose.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(40, 40);
            this.panelClose.TabIndex = 3;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelClose_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(653, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 87);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 40);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(841, 50);
            this.panelTop.TabIndex = 16;
            // 
            // panelCode
            // 
            this.panelCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCode.Controls.Add(this.panelFunctions);
            this.panelCode.Controls.Add(this.panelLeft);
            this.panelCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCode.Location = new System.Drawing.Point(0, 90);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(495, 596);
            this.panelCode.TabIndex = 17;
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(59, 594);
            this.panelLeft.TabIndex = 0;
            // 
            // panelFunctions
            // 
            this.panelFunctions.Controls.Add(this.panel1);
            this.panelFunctions.Controls.Add(this.panelCode2);
            this.panelFunctions.Controls.Add(this.tabControl1);
            this.panelFunctions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFunctions.Location = new System.Drawing.Point(59, 0);
            this.panelFunctions.Name = "panelFunctions";
            this.panelFunctions.Size = new System.Drawing.Size(435, 594);
            this.panelFunctions.TabIndex = 1;
            // 
            // panelMainCode
            // 
            this.panelMainCode.Location = new System.Drawing.Point(0, 0);
            this.panelMainCode.Name = "panelMainCode";
            this.panelMainCode.Size = new System.Drawing.Size(311, 700);
            this.panelMainCode.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelCode2
            // 
            this.panelCode2.AutoScroll = true;
            this.panelCode2.Controls.Add(this.panelMainCode);
            this.panelCode2.Location = new System.Drawing.Point(147, 5);
            this.panelCode2.Name = "panelCode2";
            this.panelCode2.Size = new System.Drawing.Size(275, 594);
            this.panelCode2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 686);
            this.Controls.Add(this.panelCode);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCode.ResumeLayout(false);
            this.panelFunctions.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panelCode2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMinimize;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelFunctions;
        private System.Windows.Forms.Panel panelMainCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelCode2;
    }
}

