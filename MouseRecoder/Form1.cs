using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseRecoder
{
    public partial class Form1 : Form
    {
        long _leftClickCount = 0;
        long leftClickCount {
            get {
                return _leftClickCount;
            }
            set {
                _leftClickCount = value;
                label_leftClick_display.Text = _leftClickCount.ToString();
            }
        }
        long _rightClickCount = 0;
        long rightClickCount {
            get {
                return _rightClickCount;
            }
            set {
                _rightClickCount = value;
                label_rightClick_display.Text = _rightClickCount.ToString();
            }
        }
        long _middleClickCount = 0;
        long middleClickCount {
            get {
                return _middleClickCount;
            }
            set {
                _middleClickCount = value;
                label_middleClick_display.Text = _middleClickCount.ToString();
            }
        }
        Image image;
        Point prevPos = Point.Empty;
        Graphics graphics;
        Pen pen;

        public Form1()
        {
            InitializeComponent();
            this.Opacity = (double)trackBar1.Value / trackBar1.Maximum;
            MouseHook mh = new MouseHook();
            //mh.MouseDown += MouseDownEvent;
            //mh.MouseUp += MouseUpEvent;
            mh.MouseMove += MouseMoveEvent;
            mh.Click += MouseClickEvent;
            mh.Start();
            image = new Bitmap(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
            pictureBox1.Image = image;
            graphics = Graphics.FromImage(image);
            graphics.Clear(Color.White); //使用白色填充整张图片, 即白色背景上画黑色的线
            pen = new Pen(Color.Black, 1);
        }

        private void MouseClickEvent(object sender, EventArgs e)
        {
            MouseEventArgs args = e as MouseEventArgs;
            switch(args.Button) {
                case MouseButtons.Left:
                    leftClickCount++;
                    graphics.FillEllipse(Brushes.Red, args.Location.X, args.Location.Y, 3, 3);
                    break;
                case MouseButtons.Right:
                    rightClickCount++;
                    graphics.FillEllipse(Brushes.Green, args.Location.X, args.Location.Y, 3, 3);
                    break;
                case MouseButtons.Middle:
                    middleClickCount++;
                    graphics.FillEllipse(Brushes.Blue, args.Location.X, args.Location.Y, 3, 3);
                    break;
                default:
                    break;
            }
        }

        public void MouseDownEvent(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Button.ToString() + "按下");
        }

        public void MouseUpEvent(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Button.ToString() + "抬起");
            switch(e.Button) {
                case MouseButtons.Left:
                    leftClickCount++;
                    break;
                case MouseButtons.Right:
                    rightClickCount++;
                    break;
                case MouseButtons.Middle:
                    middleClickCount++;
                    break;
                default:
                    break;
            }
        }

        public void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            mousePos.Text = string.Format("X: {0}, Y: {1}", e.X, e.Y);
            if(Point.Empty == prevPos) {
                prevPos = e.Location;
                return;
            }
            if(e.Location == prevPos) {
                return;
            }
            graphics.DrawLine(pen, prevPos.X, prevPos.Y, e.Location.X, e.Location.Y);
            pictureBox1.Refresh();
            prevPos = e.Location;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = (double)trackBar1.Value / trackBar1.Maximum;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string str = string.Format("\\mouse_path_{0}_{1}_{2}_{3}{4}{5}{6}.png", System.DateTime.Now.Year, System.DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
            image.Save(Application.StartupPath + str);
        }
    }
}
