﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._1n
{
    class CCircle : Base
    {




        private int Radius;

        private SolidBrush brush = new SolidBrush(Color.Gray);

        private int x;
        private int y;
        protected bool marked = false;


        public CCircle(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.Radius = 100;
            this.Name = "Circle";
            
            
        }

        public CCircle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.Radius = r;
            this.Name = "Circle";

        }
        public override SolidBrush GetBrush()
        { return brush; }

        public override int  returnX()
        {
            return this.x;
        }
        public override int returnY()
        {
            return this.y;
        }
        public override void draw(Graphics gr)
        {
            
            gr.FillEllipse(GetBrush(), this.x - Radius / 2, this.y - Radius / 2, Radius, Radius);
            if (marked == true)
                gr.DrawEllipse(Pens.Orange, this.x - Radius / 2, this.y - Radius / 2, Radius, Radius);
           
            
        }
        public override void mark()
        {
            marked = true;
        }
        public override void unmark()
        {
            marked = false;
        }
        public override bool is_marked()
        {
            if (marked == true) return true;
            else return false;
        }
        public override void setColor(Color color)
        {
            brush.Color = color;
        }
        public override bool touched(int x, int y)
        {
            if (x >= this.x - Radius / 2 && x <= this.x + Radius / 2 && y >= this.y - Radius / 2 && y <= this.y + Radius / 2)
                return true;
            else return false;

        }
        public override void move(int x, int y, int width, int height)
        {
            int chx = this.x + x;
            int chy = this.y + y;
            if (chx - Radius / 2 > 0 && chx + Radius / 2 < width && chy - Radius / 2 > 0 && chy + Radius / 2 < height) 
            { 
            if (chx > 200 || chy > 200)
            {
               this.x += x;
               this.y += y;
            }
           }
        }

        public override void changeSize(int num)
        {
            if(num == 1)
            {
                this.Radius += 10;
            }
            else if( num == -1)
            {
                this.Radius -= 10;
            }
        }
        public override void save(StreamWriter st)
        {
            st.Write("Circle\n");
            st.Write("Radius = " + this.Radius.ToString() + "\n");
            st.Write("The X is " + this.x + "\n");
            st.Write("The Y is " + this.y + "\n");
            st.Write("The Color is " + this.brush.Color + "\n");

        }
        public override void load(StreamReader st)
        {
            
           int radius_s = Int32.Parse(st.ReadLine().Substring(9).Trim());
            this.Radius = radius_s;
           int x_s = Int32.Parse(st.ReadLine().Substring(9).Trim()); ;
            this.x = x_s;
            int y_s = Int32.Parse(st.ReadLine().Substring(9).Trim()); ;
            this.y = y_s;
            string color_s = (st.ReadLine().Substring(20).Trim());
            /*MessageBox.Show(color_s);*/ //Color [  Gray]

            switch (color_s)
            {
                case "Blue]":
                    brush.Color = Color.Blue;
                    break;
                case "Green]":
                    brush.Color = Color.Green;
                    break;
                case "Pink]":
                    brush.Color = Color.Pink;
                    break;
                case "Gold]":
                    brush.Color = Color.Gold;
                    break;


            }


        }
        public override void drawArr(Graphics g, int a_x, int a_y)
        {
           /* MessageBox.Show("Hello");*/
            Pen p = new Pen(Brushes.GreenYellow, 3);
            p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, this.x, this.y, a_x, a_y);
            
        }

    }
}
