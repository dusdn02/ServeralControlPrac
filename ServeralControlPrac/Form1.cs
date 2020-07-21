using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServeralControlPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckBox cb1 = new CheckBox();
            CheckBox cb2 = new CheckBox();
            CheckBox cb3 = new CheckBox();
            Button btn = new Button();

            cb1.Text = "감자";
            cb2.Text = "고구마";
            cb3.Text = "토마토";
            btn.Text = "클릭";

            cb1.Location = new Point(10, 10);
            cb2.Location = new Point(10, 40);
            cb3.Location = new Point(10, 70);
            btn.Location = new Point(10, 100);

            btn.Click += Buttonclick;
            Controls.Add(cb1);
            Controls.Add(cb2);
            Controls.Add(cb3);
            Controls.Add(btn);
        }

        private void Buttonclick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.co.kr");
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
