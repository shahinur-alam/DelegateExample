using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegeate_Example
{
    public delegate void DelegateExample(string text);

    public partial class Form1 : Form
    {
        // Declare Delegate
        public DelegateExample DelegateValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstWindow fw = new FirstWindow();
            // Subscribe Delegate
            this.DelegateValue += new DelegateExample(fw.TargetedDelegateFunction);
            fw.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            DelegateValue(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecondWindow sw = new SecondWindow();
            // Subscribe Delegate
            this.DelegateValue += new DelegateExample(sw.TargetedDelegateFunction);
            sw.Show();
        }
    }
}
