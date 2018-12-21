using System;
using System.Windows.Forms;

namespace FormsBrowser
{
    public class Form1 : Form
    {
        public Label lbl;
        public TextBox txt;
        public Button btn;

        public WebBrowser web;
        public string Url { get;set; }

        public Form1()
        {
            Text = "Created";

            Controls.Add((lbl = new Label()));
            Controls.Add((txt = new TextBox()));
            Controls.Add((btn = new Button()));

            lbl.Top = 5;
            lbl.Left = 5;
            lbl.Text = "A&ddress:";
            lbl.AutoSize = true;

            txt.Top = lbl.Top - 3;
            btn.Top = lbl.Top - 4;
            txt.Left = 70;
            txt.Height = 32;
            txt.Text = "about:blank";
            btn.Text = "&GO";
            btn.AutoSize = true;
            btn.Height = 24;
            btn.Click += Btn_Click;

            lbl.Visible = true;
            txt.Visible = true;
            btn.Visible = true;

            web = new WebBrowser();
            web.Top = lbl.Top + lbl.Height + 4;
            web.Visible = true;
            Controls.Add(web);

            if (Height < 600) {
                Height = 600;
            }
            Width = 800;
            web.Left = 0;
            this.Resize += OnResize;     
            OnResize(this, EventArgs.Empty);

            txt.Text = "https://github.com/dotnet/winforms/";
            Url = txt.Text;
        }
        
        void OnResize(object sender, EventArgs e)
        {
            txt.Width = Width - 200;
            btn.Left = Width - 100;

            web.Width = Width;
            web.Height = Height - web.Top - 2;
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
            // MessageBox.Show(this, $"Clicked {txt.Text}", Text, MessageBoxButtons.OK);
            Url = txt.Text;
            if (!Url.StartsWith("http")) {
               Url = "https://" + Url;
            }
            web.Navigate(Url);
        }

        protected override void OnShown(EventArgs e)
        {
            Text = "Forms Browser";
            web.Navigate(Url);

            base.OnShown(e);
        }
    }
}
