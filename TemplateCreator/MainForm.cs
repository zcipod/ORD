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
    




    public partial class MainForm : Form
    {
        public writetofile wtfile = new writetofile();
        public float slope1;
        public float slope2;
        public float slope3;
        public float slope4;
        public float slope5;
        private bool[] Visible_List_1 = new bool[40];
        //private bool[] Visible_List_2 = new bool[40];
        //private bool[] Visible_List_3 = new bool[40];
        //private bool[] Visible_List_4 = new bool[40];
        //private bool[] Visible_List_5 = new bool[40];
        //private bool[] Visible_List_6 = new bool[40];

        


        public MainForm()
        {
            InitializeComponent();
        }

        private void Group1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Group1.Text != "添加组")
            {
                foreach (Control i in this.Controls)
                {
                    i.Visible = true;
                }
                No_G1_C1.Visible = true;
                Category_G1_C1.Visible = true;
                Infor_G1_C1.Visible = true;
                def_G1_C1.Visible = true;
            }
            else
            {
                No_G1_C1.Visible = false;
                Category_G1_C1.Visible = false;
                Infor_G1_C1.Visible = false;
                def_G1_C1.Visible = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            getVisible1();
            
        }






        //实现自动隐藏、显示的代码
        private void hide(bool[] visiblelist, int index)
        {
            for (int i = index; i< 40; i++)
            {
                visiblelist[i] = false;
            }
        }
        private void show(bool[] visiblelist, int index)
        {
            for (int i = 0; i < index+4; i++)
            {
                visiblelist[i] = true;
            }
        }
        private void getVisible1()
        {
            Visible_List_1[0] = No_G1_C1.Visible;
            Visible_List_1[1] = Category_G1_C1.Visible;
            Visible_List_1[2] = Infor_G1_C1.Visible;
            Visible_List_1[3] = def_G1_C1.Visible;
            Visible_List_1[4] = No_G1_C2.Visible;
            Visible_List_1[5] = Category_G1_C2.Visible;
            Visible_List_1[6] = Infor_G1_C2.Visible;
            Visible_List_1[7] = def_G1_C2.Visible;
            Visible_List_1[8] = No_G1_C3.Visible;
            Visible_List_1[9] = Category_G1_C3.Visible;
            Visible_List_1[10] = Infor_G1_C3.Visible;
            Visible_List_1[11] = def_G1_C3.Visible;
            Visible_List_1[12] = No_G1_C4.Visible;
            Visible_List_1[13] = Category_G1_C4.Visible;
            Visible_List_1[14] = Infor_G1_C4.Visible;
            Visible_List_1[15] = def_G1_C4.Visible;
            Visible_List_1[16] = No_G1_C5.Visible;
            Visible_List_1[17] = Category_G1_C5.Visible;
            Visible_List_1[18] = Infor_G1_C5.Visible;
            Visible_List_1[19] = def_G1_C5.Visible;
            Visible_List_1[20] = No_G1_C6.Visible;
            Visible_List_1[21] = Category_G1_C6.Visible;
            Visible_List_1[22] = Infor_G1_C6.Visible;
            Visible_List_1[23] = def_G1_C6.Visible;
            Visible_List_1[24] = No_G1_C7.Visible;
            Visible_List_1[25] = Category_G1_C7.Visible;
            Visible_List_1[26] = Infor_G1_C7.Visible;
            Visible_List_1[27] = def_G1_C7.Visible;
            Visible_List_1[28] = No_G1_C8.Visible;
            Visible_List_1[29] = Category_G1_C8.Visible;
            Visible_List_1[30] = Infor_G1_C8.Visible;
            Visible_List_1[31] = def_G1_C8.Visible;
            Visible_List_1[32] = No_G1_C9.Visible;
            Visible_List_1[33] = Category_G1_C9.Visible;
            Visible_List_1[34] = Infor_G1_C9.Visible;
            Visible_List_1[35] = def_G1_C9.Visible;
            Visible_List_1[36] = No_G1_C10.Visible;
            Visible_List_1[37] = Category_G1_C10.Visible;
            Visible_List_1[38] = Infor_G1_C10.Visible;
            Visible_List_1[39] = def_G1_C10.Visible;

        }
        private void giveVisible1()
        {
            No_G1_C1.Visible = Visible_List_1[0];
            Category_G1_C1.Visible = Visible_List_1[1];
            Infor_G1_C1.Visible = Visible_List_1[2];
            def_G1_C1.Visible = Visible_List_1[3];
            No_G1_C2.Visible = Visible_List_1[4];
            Category_G1_C2.Visible = Visible_List_1[5];
            Infor_G1_C2.Visible = Visible_List_1[6];
            def_G1_C2.Visible = Visible_List_1[7];
            No_G1_C3.Visible = Visible_List_1[8];
            Category_G1_C3.Visible = Visible_List_1[9];
            Infor_G1_C3.Visible = Visible_List_1[10];
            def_G1_C3.Visible = Visible_List_1[11];
            No_G1_C4.Visible = Visible_List_1[12];
            Category_G1_C4.Visible = Visible_List_1[13];
            Infor_G1_C4.Visible = Visible_List_1[14];
            def_G1_C4.Visible = Visible_List_1[15];
            No_G1_C5.Visible = Visible_List_1[16];
            Category_G1_C5.Visible = Visible_List_1[17];
            Infor_G1_C5.Visible = Visible_List_1[18];
            def_G1_C5.Visible = Visible_List_1[19];
            No_G1_C6.Visible = Visible_List_1[20];
            Category_G1_C6.Visible = Visible_List_1[21];
            Infor_G1_C6.Visible = Visible_List_1[22];
            def_G1_C6.Visible = Visible_List_1[23];
            No_G1_C7.Visible = Visible_List_1[24];
            Category_G1_C7.Visible = Visible_List_1[25];
            Infor_G1_C7.Visible = Visible_List_1[26];
            def_G1_C7.Visible = Visible_List_1[27];
            No_G1_C8.Visible = Visible_List_1[28];
            Category_G1_C8.Visible = Visible_List_1[29];
            Infor_G1_C8.Visible = Visible_List_1[30];
            def_G1_C8.Visible = Visible_List_1[31];
            No_G1_C9.Visible = Visible_List_1[32];
            Category_G1_C9.Visible = Visible_List_1[33];
            Infor_G1_C9.Visible = Visible_List_1[34];
            def_G1_C9.Visible = Visible_List_1[35];
            No_G1_C10.Visible = Visible_List_1[36];
            Category_G1_C10.Visible = Visible_List_1[37];
            Infor_G1_C10.Visible = Visible_List_1[38];
            def_G1_C10.Visible = Visible_List_1[39];
        }

        

        //第一组自动隐藏代码
        private void Category1_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category_G1_C1.Text != "" && Category_G1_C1.Text != "无")
            {
                show(Visible_List_1, 4);
            }
            else
            {
                hide(Visible_List_1, 4);
            }
            giveVisible1();
        }
        private void Category_G1_C2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category_G1_C2.Text != "" && Category_G1_C2.Text != "无")
            {
                show(Visible_List_1, 8);
            }
            else
            {
                hide(Visible_List_1, 8);
            }
            giveVisible1();
        }

        private void Category_G1_C3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category_G1_C3.Text != "" && Category_G1_C3.Text != "无")
            {
                show(Visible_List_1, 12);
            }
            else
            {
                hide(Visible_List_1, 12);
            }
            giveVisible1();
        }

        private void Category_G1_C4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category_G1_C4.Text != "" && Category_G1_C4.Text != "无")
            {
                show(Visible_List_1, 16);
            }
            else
            {
                hide(Visible_List_1, 16);
            }
            giveVisible1();
        }
        private void Category_G1_C5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category_G1_C5.Text != "" && Category_G1_C5.Text != "无")
            {
                show(Visible_List_1, 20);
            }
            else
            {
                hide(Visible_List_1, 20);
            }
            giveVisible1();
        }
        private void Category_G1_C6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category_G1_C6.Text != "" && Category_G1_C6.Text != "无")
            {
                show(Visible_List_1, 24);
            }
            else
            {
                hide(Visible_List_1, 24);
            }
            giveVisible1();
        }
        private void Category_G1_C7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category_G1_C7.Text != "" && Category_G1_C7.Text != "无")
            {
                show(Visible_List_1, 28);
            }
            else
            {
                hide(Visible_List_1, 28);
            }
            giveVisible1();
        }
        private void Category_G1_C8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category_G1_C8.Text != "" && Category_G1_C8.Text != "无")
            {
                show(Visible_List_1, 32);
            }
            else
            {
                hide(Visible_List_1, 32);
            }
            giveVisible1();
        }
        private void Category_G1_C9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category_G1_C9.Text != "" && Category_G1_C9.Text != "无")
            {
                show(Visible_List_1, 36);
            }
            else
            {
                hide(Visible_List_1, 36);
            }
            giveVisible1();
        }
        private void Category_G1_C10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            wtfile.write("test.itl");
        }

        private void def_G1_C1_Click(object sender, EventArgs e)
        {
            if (Category_G1_C1.Text == "面层")
            {
               surface_def f1 = new surface_def();
               if(f1.ShowDialog() == DialogResult.OK)
                {
                    float width = f1.w;
                    float thick = f1.th;
                    slope1 = f1.s;
                    string mesh = f1.m;
                    writetofile.Component component1 = wtfile.createsurface(1, 1, width, thick/100, slope1/100, mesh);
                    if(wtfile.ComponentList.Count() != 0)
                    {
                        wtfile.ComponentList[0][0] = component1;
                    }
                    else
                    {
                        wtfile.ComponentList.Add(new List<writetofile.Component>());
                        wtfile.addcomponent(1, component1);
                    }
                    
                    Infor_G1_C1.Text = thick + "cm-" + width + "m";
                }
            }
            else if(Category_G1_C1.Text == "基层")
            {

            }
        }

        private void def_G1_C2_Click(object sender, EventArgs e)
        {
            if (Category_G1_C2.Text == "面层")
            {
                surface_def2 f2 = new surface_def2();
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    float width = f2.w;
                    float thick = f2.th;
                    string mesh = f2.m;
                    writetofile.Component component = wtfile.createsurface(1, 2, width, thick / 100, slope1/100, mesh, "G1C1_4");
                    if (wtfile.ComponentList[0].Count != 1)
                    {
                        wtfile.ComponentList[0][1] = component;
                    }
                    else
                    {
                        wtfile.addcomponent(1, component);
                    }
                    Infor_G1_C2.Text = thick + "cm-" + width + "m";
                }
            }
            else if(Category_G1_C2.Text == "基层")
            {
                pavement_def p1 = new pavement_def();
                if (p1.ShowDialog() == DialogResult.OK)
                {
                    float width = p1.w;
                    float thick = p1.th;
                    string mesh = p1.m;
                    float h = p1.h;
                    float ww = p1.ww;
                    writetofile.Component component = wtfile.createpavement(1, 1, width, thick / 100, slope1 / 100, mesh, h, ww);
                    if (wtfile.ComponentList[0].Count() != 1)
                    {
                        wtfile.ComponentList[0][1] = component;
                    }
                    else
                    {
                        wtfile.ComponentList.Add(new List<writetofile.Component>());
                        wtfile.addcomponent(1, component);
                    }

                    Infor_G1_C2.Text = thick + "cm-" + width + "m";
                }
            }
        }
    }
}
