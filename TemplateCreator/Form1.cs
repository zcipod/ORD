using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float num = 0;
            if (!float.TryParse(textBox3.Text, out num))
            {
                System.Windows.Forms.MessageBox.Show("无效字符，请输入数字！");
            }
            if (num != 0)
            {
                textBox6.Text = num.ToString();
                textBox10.Text = num.ToString();
                textBox14.Text = num.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float w = 0;
            if (!float.TryParse(textBox2.Text, out w))
            {
                System.Windows.Forms.MessageBox.Show("无效字符，请输入数字！");
            }
            if (w != 0)
            {
                textBox7.Text = w.ToString();
                textBox11.Text = w.ToString();
                textBox15.Text = w.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writetofile wtfile = new writetofile();
            writetofile.Component component1 = wtfile.createsurface(1, 1, Convert.ToSingle(textBox2.Text), Convert.ToSingle(textBox1.Text), Convert.ToSingle(textBox3.Text), textBox4.Text);
            writetofile.Component component2 = wtfile.createsurface(1, 2, Convert.ToSingle(textBox7.Text), Convert.ToSingle(textBox8.Text), Convert.ToSingle(textBox6.Text), textBox5.Text, "G1C1_4",0,0);
            wtfile.ComponentList.Add(new List<writetofile.Component>());
            wtfile.addcomponent(1,component1);
            wtfile.addcomponent(1,component2);

            wtfile.write("test.itl");

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
