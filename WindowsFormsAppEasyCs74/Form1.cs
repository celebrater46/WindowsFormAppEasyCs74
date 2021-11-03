using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs74
{
    public partial class Form1 : Form
    {
        private Label lb, lb2;
        private TextBox tb;
        private ListBox lbx;
        private FlowLayoutPanel flp;

        public void Display()
        {
            Application.Run(new Form1());
        }
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "TextBox and ListBox";
            this.Width = 250;
            this.Height = 200;

            string[] str = new string[]{
                "Car",
                "Train",
                "Air plain",
                "Bike",
                "Bicycle",
                "Rocket",
                "Horse"
            };

            lb = new Label();
            lb.Text = "Welcome.";
            lb.Dock = DockStyle.Top;
            
            tb = new TextBox();
            tb.Dock = DockStyle.Bottom;
            
            lb2 = new Label();
            lb2.Text = "Welcome2.";
            lb2.Dock = DockStyle.Top;
            lb2.Top = tb.Bottom;

            lbx = new ListBox();
            for (int i = 0; i < str.Length; i++)
            {
                lbx.Items.Add(str[i]);
            }
            lbx.Top = lb2.Bottom;

            lb.Parent = flp;
            tb.Parent = flp;
            lb2.Parent = flp;
            lbx.Parent = flp;

            tb.KeyDown += new KeyEventHandler(TbKeyDown);

            lbx.SelectedIndexChanged += new EventHandler(LbxSelectedIndexChanged);

            flp.Parent = this;
        }

        public void TbKeyDown(Object sender, KeyEventArgs e)
        {
            TextBox temp = (TextBox) sender;
            if (e.KeyCode == Keys.Enter)
            {
                lb.Text = string.Format("Selected {0}.", temp.Text);
            }
        }

        public void LbxSelectedIndexChanged(Object sender, EventArgs e)
        {
            ListBox temp = (ListBox) sender;
            lb2.Text = String.Format("Selected {0}.", temp.Text);
        }
    }
}