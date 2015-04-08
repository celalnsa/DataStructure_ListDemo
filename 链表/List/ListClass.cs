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
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string DrawChar = "";
            Font font = new Font("幼圆", 15);
            Point hpoint = new Point(20, 40);
            Point tpoint = new Point(0, 0);
            Pen pen = new Pen(Color.Tomato, 1);
            Pen pen1 = new Pen(Color.Green, 1);
            AdjustableArrowCap arrow = new AdjustableArrowCap(2, 2, false);
            pen.CustomEndCap = arrow;
            pen1.CustomEndCap = arrow;
            int step = 60;
            switch (drawmode)
            {
                case DrawMode.Link:
                    DrawChar += "_head";
                    g.DrawString(DrawChar, font, Brushes.Teal, hpoint.X - 5, hpoint.Y - 10);
                    hpoint.X += 100;
                    for (int i = 0; i < DrawStr.Length; i++)
                    {
                        if (step > 0)
                        {
                            DrawChar = "";
                            DrawChar += DrawStr[i];
                            g.DrawLine(pen, hpoint.X - 46, hpoint.Y, hpoint.X - 20, hpoint.Y);
                            g.DrawRectangle(Pens.Turquoise, hpoint.X - 20, hpoint.Y - 20, 28, 40);
                            g.DrawRectangle(Pens.Turquoise, hpoint.X + 8, hpoint.Y - 20, 12, 40);
                            g.DrawString(DrawChar, font, Brushes.Teal, hpoint.X - 16, hpoint.Y - 10);
                            hpoint.X += step;
                        }
                        else
                        {
                            DrawChar = "";
                            DrawChar += DrawStr[i];
                            g.DrawLine(pen, hpoint.X + 46, hpoint.Y, hpoint.X + 20, hpoint.Y);
                            g.DrawRectangle(Pens.Turquoise, hpoint.X - 20, hpoint.Y - 20, 12, 40);
                            g.DrawRectangle(Pens.Turquoise, hpoint.X - 8, hpoint.Y - 20, 28, 40);
                            g.DrawString(DrawChar, font, Brushes.Teal, hpoint.X - 4, hpoint.Y - 10);
                            hpoint.X += step;
                        }
                        if (hpoint.X + step / 2 > Panel1.Width && i+1 < DrawStr.Length)
                        {
                            step = -60;
                            hpoint.X += step;
                            hpoint.Y += 60;
                            DrawChar = "";
                            DrawChar += DrawStr[++i];
                            g.DrawRectangle(Pens.Turquoise, hpoint.X - 20, hpoint.Y - 20, 12, 40);
                            g.DrawRectangle(Pens.Turquoise, hpoint.X - 8, hpoint.Y - 20, 28, 40);
                            g.DrawString(DrawChar, font, Brushes.Teal, hpoint.X - 4, hpoint.Y - 10);
                            g.DrawLine(pen, hpoint.X + 14, hpoint.Y - 60, hpoint.X + 14, hpoint.Y - 20);
                            hpoint.X += step;
                        }
                        if (hpoint.X + step / 2 < 0 && i + 1 < DrawStr.Length)
                        {
                            step = 60;
                            hpoint.X += step;
                            hpoint.Y += 60;
                            DrawChar = "";
                            DrawChar += DrawStr[++i];
                            g.DrawRectangle(Pens.Turquoise, hpoint.X - 20, hpoint.Y - 20, 28, 40);
                            g.DrawRectangle(Pens.Turquoise, hpoint.X + 8, hpoint.Y - 20, 12, 40);
                            g.DrawString(DrawChar, font, Brushes.Teal, hpoint.X - 16, hpoint.Y - 10);
                            g.DrawLine(pen, hpoint.X - 14, hpoint.Y - 60, hpoint.X - 14, hpoint.Y - 20);
                            hpoint.X += step;
                        }
                    }
                    if (step > 0)
                    {
                        g.DrawLine(pen, hpoint.X - 46, hpoint.Y, hpoint.X - 20, hpoint.Y);
                        DrawChar = "null";
                        g.DrawString(DrawChar, font, Brushes.Teal, hpoint.X - 20, hpoint.Y - 10);
                    }
                    else
                    {
                        g.DrawLine(pen, hpoint.X + 46, hpoint.Y, hpoint.X + 20, hpoint.Y);
                        DrawChar = "null";
                        g.DrawString(DrawChar, font, Brushes.Teal, hpoint.X - 20, hpoint.Y - 10);
                    }
                    break;
                case DrawMode.Circular:
                    DrawChar += "_head";
                    g.DrawString(DrawChar, font, Brushes.Purple, hpoint.X - 5, hpoint.Y - 20);
                    hpoint.X += 100;
                    tpoint = hpoint;
                    for (int i = 0; i < DrawStr.Length; i++)
                    {
                        if (step > 0)
                        {
                            DrawChar = "";
                            DrawChar += DrawStr[i];
                            g.DrawLine(pen, hpoint.X - 46, hpoint.Y, hpoint.X - 20, hpoint.Y);
                            g.DrawRectangle(Pens.Orchid, hpoint.X - 20, hpoint.Y - 20, 28, 40);
                            g.DrawRectangle(Pens.Orchid, hpoint.X + 8, hpoint.Y - 20, 12, 40);
                            g.DrawString(DrawChar, font, Brushes.Purple, hpoint.X - 16, hpoint.Y - 10);
                            hpoint.X += step;
                        }
                        else
                        {
                            DrawChar = "";
                            DrawChar += DrawStr[i];
                            g.DrawLine(pen, hpoint.X + 46, hpoint.Y, hpoint.X + 20, hpoint.Y);
                            g.DrawRectangle(Pens.Orchid, hpoint.X - 20, hpoint.Y - 20, 12, 40);
                            g.DrawRectangle(Pens.Orchid, hpoint.X - 8, hpoint.Y - 20, 28, 40);
                            g.DrawString(DrawChar, font, Brushes.Purple, hpoint.X - 4, hpoint.Y - 10);
                            hpoint.X += step;
                        }
                        if (hpoint.X + step / 2 > Panel1.Width && i + 1 < DrawStr.Length)
                        {
                            step = -60;
                            hpoint.X += step;
                            hpoint.Y += 60;
                            DrawChar = "";
                            DrawChar += DrawStr[++i];
                            g.DrawRectangle(Pens.Orchid, hpoint.X - 20, hpoint.Y - 20, 12, 40);
                            g.DrawRectangle(Pens.Orchid, hpoint.X - 8, hpoint.Y - 20, 28, 40);
                            g.DrawString(DrawChar, font, Brushes.Purple, hpoint.X - 4, hpoint.Y - 10);
                            g.DrawLine(pen, hpoint.X + 14, hpoint.Y - 60, hpoint.X + 14, hpoint.Y - 20);
                            hpoint.X += step;
                        }
                        if (hpoint.X + step / 2 < 0 && i + 1 < DrawStr.Length)
                        {
                            step = 60;
                            hpoint.X += step;
                            hpoint.Y += 60;
                            DrawChar = "";
                            DrawChar += DrawStr[++i];
                            g.DrawRectangle(Pens.Orchid, hpoint.X - 20, hpoint.Y - 20, 28, 40);
                            g.DrawRectangle(Pens.Orchid, hpoint.X + 8, hpoint.Y - 20, 12, 40);
                            g.DrawString(DrawChar, font, Brushes.Purple, hpoint.X - 16, hpoint.Y - 10);
                            g.DrawLine(pen, hpoint.X - 14, hpoint.Y - 60, hpoint.X - 14, hpoint.Y - 20);
                            hpoint.X += step;
                        }
                    }
                    hpoint.X -= step;
                    if (step > 0)
                    {
                        
                        if (DrawStr.Length == 0)
                        {
                            g.DrawLine(pen, hpoint.X - 46, hpoint.Y, hpoint.X - 20, hpoint.Y);
                            g.DrawLine(pen, hpoint.X - 20, hpoint.Y, hpoint.X + 40, hpoint.Y);
                            hpoint.X += step;
                            DrawChar = "null";
                            g.DrawString(DrawChar, font, Brushes.Purple, hpoint.X - 20, hpoint.Y - 10);
                        }
                        else
                        {
                            g.DrawLine(pen, hpoint.X + 14, hpoint.Y, hpoint.X + 14, hpoint.Y + 30);
                            g.DrawLine(pen, hpoint.X + 14, hpoint.Y + 30, 30, hpoint.Y + 30);
                            g.DrawLine(pen, 30, hpoint.Y + 30, 30, tpoint.Y + 10);
                            g.DrawLine(pen, 30, tpoint.Y + 10, tpoint.X - 20, tpoint.Y + 10);
                        }
                    }
                    else
                    {
                        g.DrawLine(pen, hpoint.X - 14, hpoint.Y, 30, hpoint.Y);
                        g.DrawLine(pen, 30, hpoint.Y, 30, tpoint.Y + 10);
                        g.DrawLine(pen, 30, tpoint.Y + 10, tpoint.X - 20, tpoint.Y + 10);
                    }
                    break;
                case DrawMode.Double:
                    DrawChar += "_head";
                    g.DrawString(DrawChar, font, Brushes.DodgerBlue, hpoint.X - 5, hpoint.Y + 6);
                    hpoint.X += 100;
                    tpoint = hpoint;
                    for (int i = 0; i < DrawStr.Length; i++)
                    {
                        if (step > 0)
                        {
                            DrawChar = "";
                            DrawChar += DrawStr[i];
                            g.DrawLine(pen, hpoint.X - 46, hpoint.Y + 14, hpoint.X - 20, hpoint.Y + 14);
                            g.DrawLine(pen1, hpoint.X - 14, hpoint.Y - 14, hpoint.X - 40, hpoint.Y - 14);
                            g.DrawRectangle(Pens.DeepSkyBlue, hpoint.X - 20, hpoint.Y - 20, 40, 40);
                            g.DrawRectangle(Pens.DeepSkyBlue, hpoint.X - 20, hpoint.Y - 20, 12, 12);
                            g.DrawRectangle(Pens.DeepSkyBlue, hpoint.X + 8, hpoint.Y + 8, 12, 12);
                            g.DrawString(DrawChar, font, Brushes.DodgerBlue, hpoint.X - 16, hpoint.Y - 10);
                            hpoint.X += step;
                        }
                        else
                        {
                            DrawChar = "";
                            DrawChar += DrawStr[i];
                            g.DrawLine(pen, hpoint.X + 46, hpoint.Y + 14, hpoint.X + 20, hpoint.Y + 14);
                            g.DrawLine(pen1, hpoint.X + 14, hpoint.Y - 14, hpoint.X + 40, hpoint.Y - 14);
                            g.DrawRectangle(Pens.DeepSkyBlue, hpoint.X - 20, hpoint.Y - 20, 40, 40);
                            g.DrawRectangle(Pens.DeepSkyBlue, hpoint.X - 20, hpoint.Y + 8, 12, 12);
                            g.DrawRectangle(Pens.DeepSkyBlue, hpoint.X + 8, hpoint.Y - 20, 12, 12);
                            g.DrawString(DrawChar, font, Brushes.DodgerBlue, hpoint.X - 4, hpoint.Y - 10);
                            hpoint.X += step;
                        }
                        if (hpoint.X + step / 2 > Panel1.Width && i + 1 < DrawStr.Length)
                        {
                            step = -60;
                            hpoint.X += step;
                            hpoint.Y += 60;
                            DrawChar = "";
                            DrawChar += DrawStr[++i];
                            g.DrawRectangle(Pens.DeepSkyBlue, hpoint.X - 20, hpoint.Y - 20, 40, 40);
                            g.DrawRectangle(Pens.DeepSkyBlue, hpoint.X - 20, hpoint.Y + 8, 12, 12);
                            g.DrawRectangle(Pens.DeepSkyBlue, hpoint.X + 8, hpoint.Y - 20, 12, 12);
                            g.DrawString(DrawChar, font, Brushes.DodgerBlue, hpoint.X - 4, hpoint.Y - 10);
                            g.DrawLine(pen, hpoint.X + 12, hpoint.Y - 46, hpoint.X + 12, hpoint.Y - 20);
                            g.DrawLine(pen1, hpoint.X + 16, hpoint.Y - 14, hpoint.X + 16, hpoint.Y - 40);
                            hpoint.X += step;
                        }
                        if (hpoint.X + step / 2 < 0 && i + 1 < DrawStr.Length)
                        {
                            step = 60;
                            hpoint.X += step;
                            hpoint.Y += 60;
                            DrawChar = "";
                            DrawChar += DrawStr[++i];
                            g.DrawRectangle(Pens.DeepSkyBlue, hpoint.X - 20, hpoint.Y - 20, 40, 40);
                            g.DrawRectangle(Pens.DeepSkyBlue, hpoint.X - 20, hpoint.Y - 20, 12, 12);
                            g.DrawRectangle(Pens.DeepSkyBlue, hpoint.X + 8, hpoint.Y + 8, 12, 12);
                            g.DrawString(DrawChar, font, Brushes.DodgerBlue, hpoint.X - 16, hpoint.Y - 10);
                            g.DrawLine(pen, hpoint.X - 12, hpoint.Y - 46, hpoint.X - 12, hpoint.Y - 20);
                            g.DrawLine(pen1, hpoint.X - 16, hpoint.Y - 14, hpoint.X - 16, hpoint.Y - 40);
                            hpoint.X += step;
                        }
                    }
                    if (step > 0)
                    {
                        g.DrawLine(pen, hpoint.X - 46, hpoint.Y + 14, hpoint.X - 20, hpoint.Y + 14);
                        DrawChar = "null";
                        g.DrawString(DrawChar, font, Brushes.DodgerBlue, hpoint.X - 20, hpoint.Y + 6);
                    }
                    else
                    {
                        g.DrawLine(pen, hpoint.X + 46, hpoint.Y + 14, hpoint.X + 20, hpoint.Y + 14);
                        DrawChar = "null";
                        g.DrawString(DrawChar, font, Brushes.DodgerBlue, hpoint.X - 20, hpoint.Y + 6);
                    }
                    if (DrawStr.Length == 0) break;
                    g.DrawLine(pen1, tpoint.X - 14, tpoint.Y - 14, tpoint.X - 40, tpoint.Y - 14);
                    DrawChar = "null";
                    g.DrawString(DrawChar, font, Brushes.DodgerBlue, tpoint.X - 90, tpoint.Y - 20);
                    break;
                case DrawMode.None:
                    g.Clear(this.BackColor);
                    break;
                default: break;
            }
        }
    }
}
