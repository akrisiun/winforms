using System;
using System.Windows.Forms;

namespace HelloForms
{
    public class Form1 : Form
    {
        public Label lbl;
        public TextBox txt;
        public Button btn;

        public Form1()
        {
            // this.Children
            Text = "Created";

            Controls.Add((lbl = new Label()));
            Controls.Add((txt = new TextBox()));
            Controls.Add((btn = new Button()));

            lbl.Top = 30;
            lbl.Left = 10;
            lbl.Text = "Label 1";
            lbl.AutoSize = true;

            txt.Top = lbl.Top;
            btn.Top = 400;
            btn.Left = 100;
            txt.Left = 50;
            txt.Width = 100;
            txt.Height = 32;
            txt.Text = "Loading..";
            btn.Text = "Click 1";
            btn.AutoSize = true;
            btn.Height = 24;
            btn.Click += Btn_Click;

            lbl.Visible = true;
            txt.Visible = true;
            btn.Visible = true;
            Height = 300;
            Width = 800;
        }
        
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
        }
        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
        }

        void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, $"Clicked {txt.Text}", Text, MessageBoxButtons.OK);
        }

        protected override void OnShown(EventArgs e)
        {
            Text = "Shown";

            base.OnShown(e);
        }
    }
}
