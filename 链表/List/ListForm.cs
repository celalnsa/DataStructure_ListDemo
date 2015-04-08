using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace List
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }
        LinkList linklist;
        CircularList circularlist;
        DoubleList doublelist;
        enum DrawMode { Link, Circular, Double ,None};
        DrawMode drawmode = DrawMode.None;
        string DrawStr="";

        private void button11_Click(object sender, EventArgs e)
        {
            string Str = text1.Text;
            if (Str.Length < 1)
            {
                MessageBox.Show("请输入用于建立单链表的字符串！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            linklist = new LinkList(Str);
            DrawStr = linklist.ToString();
            drawmode = DrawMode.Link;
            Panel1.Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (linklist == null)
            {
                MessageBox.Show("请先建立单链表！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string Str=text1.Text;
            if (Str.Length < 1)
            {
                MessageBox.Show("请输入要插入的字符！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            linklist.Insert(Str);
            DrawStr = linklist.ToString();
            drawmode = DrawMode.Link;
            Panel1.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (linklist == null)
            {
                MessageBox.Show("请先建立单链表！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string Str = text1.Text;
            if (Str.Length < 1)
            {
                MessageBox.Show("请输入要查找的字符！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            linklist.Search(Str);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (linklist == null)
            {
                MessageBox.Show("请先建立单链表！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string Str = text1.Text;
            if (Str.Length < 1)
            {
                MessageBox.Show("请输入要删除的字符！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            linklist.Delete(Str);
            DrawStr = linklist.ToString();
            drawmode = DrawMode.Link;
            Panel1.Refresh();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string Str = text2.Text;
            if (Str.Length < 1)
            {
                MessageBox.Show("请输入用于建立循环链表的字符串！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            circularlist = new CircularList(Str);
            DrawStr = circularlist.ToString();
            drawmode = DrawMode.Circular;
            Panel1.Refresh();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (circularlist == null||circularlist.Head==null)
            {
                MessageBox.Show("请先建立循环链表！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string Str = text2.Text;
            if (Str.Length < 1)
            {
                MessageBox.Show("请输入要插入的字符！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            circularlist.Insert(Str);
            DrawStr = circularlist.ToString();
            drawmode = DrawMode.Circular;
            Panel1.Refresh();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (circularlist == null || circularlist.Head == null)
            {
                MessageBox.Show("请先建立循环链表！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string Str = text2.Text;
            if (Str.Length < 1)
            {
                MessageBox.Show("请输入要查找的字符！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            circularlist.Search(Str);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (circularlist == null || circularlist.Head == null)
            {
                MessageBox.Show("请先建立循环链表！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string Str = text2.Text;
            if (Str.Length < 1)
            {
                MessageBox.Show("请输入要删除的字符！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            circularlist.Delete(Str);
            DrawStr = circularlist.ToString();
            drawmode = DrawMode.Circular;
            Panel1.Refresh();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string Str = text3.Text;
            if (Str.Length < 1)
            {
                MessageBox.Show("请输入用于建立单链表的字符串！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            doublelist = new DoubleList(Str);
            DrawStr = doublelist.ToString();
            drawmode = DrawMode.Double;
            Panel1.Refresh();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (doublelist == null)
            {
                MessageBox.Show("请先建立双向链表！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string Str = text3.Text;
            if (Str.Length < 1)
            {
                MessageBox.Show("请输入要插入的字符！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            doublelist.Insert(Str);
            DrawStr = doublelist.ToString();
            drawmode = DrawMode.Double;
            Panel1.Refresh();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (doublelist == null)
            {
                MessageBox.Show("请先建立双向链表！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string Str = text3.Text;
            if (Str.Length < 1)
            {
                MessageBox.Show("请输入要查找的字符！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            doublelist.Search(Str);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (doublelist == null)
            {
                MessageBox.Show("请先建立双向链表！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string Str = text3.Text;
            if (Str.Length < 1)
            {
                MessageBox.Show("请输入要删除的字符！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            doublelist.Delete(Str);
            DrawStr = doublelist.ToString();
            drawmode = DrawMode.Double;
            Panel1.Refresh();
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromName("LightSeaGreen");
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromName("Turquoise");
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromName("LightSeaGreen");
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromName("Turquoise");
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromName("LightSeaGreen");
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromName("Turquoise");
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.BackColor = Color.FromName("LightSeaGreen");
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = Color.FromName("Turquoise");
        }

        private void ListTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ListTab.SelectedTab.Name.ToString())
            {
                case "Linktab":
                    if (linklist != null) 
                    {
                        DrawStr = linklist.ToString();
                        drawmode = DrawMode.Link;
                        Panel1.Refresh(); 
                    }break;
                case "Circulartab": 
                    if (circularlist != null) 
                    {
                        DrawStr = circularlist.ToString();
                        drawmode = DrawMode.Circular;
                        Panel1.Refresh(); 
                    }break;
                case "Doubletab":
                    if (doublelist != null)
                    {
                        DrawStr = doublelist.ToString();
                        drawmode = DrawMode.Double;
                        Panel1.Refresh(); 
                     }break;
                default: break;
            }
        }

    }
}
