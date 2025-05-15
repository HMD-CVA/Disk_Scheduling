using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DIsk_Scheduling
{
    public partial class Form1 : Form
    {
        private int Win_Width = 2000;
        private int Win_Height = 1200;
        private int HeadPosition = 0;

        private List<int> xData = new List<int> { 0, 14, 37, 53, 65, 67, 98, 122, 124, 183 };
        private List<int> requestQueue = new List<int>();
        private List<int> result = new List<int>();
        private List<int> paintQueue = new List<int>();

        Random random = new Random();
        private int randomA = 10;
        private int randomB = 200;

        private Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(Win_Width, Win_Height);

            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();

            groupBox1.MouseClick += panel_Graph_MouseClick;

            HeadValue.Minimum = xData.Min(); 
            HeadValue.Maximum = xData.Max();
            HeadPosition = (int)HeadValue.Value;
            HeadValue.Value = 0; // Need to change !!!!!!!!!!!!!

            paintQueue = xData;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_Time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            Invalidate();
        }

        void UserInput()
        {
            if (int.TryParse(txt_HeadValue.Text, out int value))
            {
                // Đảm bảo giá trị nằm trong khoảng cho phép của HeadValue
                value = Math.Max((int)HeadValue.Minimum, Math.Min((int)HeadValue.Maximum, value));
                HeadValue.Value = value;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the head position!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                requestQueue = txt_Input.Text.Split(',').Select(s => int.Parse(s.Trim())).ToList();
            }
            catch
            {
                MessageBox.Show("Invalid input! Please enter numbers separated by commas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            txt_SeekCnt.Clear();
            if (txt_Input.Text != string.Empty) UserInput();
            foreach (int i in requestQueue)
            {
                txt_SeekCnt.Text += i.ToString() + " ";
            }
            if (btn_FCFS.Checked)
            {
                FCFS();
            }
            if (btn_SSTF.Checked)
            {
                SSTF();
            }
            panel_Graph.Invalidate();
        }

        void resetAll()
        {
            btn_FCFS.Checked = false;   
            btn_Scan.Checked = false;
            btn_SSTF.Checked = false;
            btn_cscan.Checked = false;
            btn_clook.Checked = false;


            txt_Input.Clear();
            txt_SeekCnt.Clear();
            txt_HeadValue.Clear();
            requestQueue.Clear();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_FillRandom_Click(object sender, EventArgs e)
        {
            requestQueue.Clear();
            string s = string.Empty;
            int n = random.Next(randomA, randomB); n = 10;
            for (int i = 0; i < n; i++)
            {
                int rnd = random.Next(randomA, randomB);
                requestQueue.Add(rnd);
                s += rnd.ToString();
                if (i < n-1) s += ", ";
            }
            txt_Input.Clear();
            txt_Input.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_HeadValue.Text = string.Empty;
            txt_Input.Text = string.Empty;
        }

        private void panel_Graph_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickedPoint = e.Location;
            int x = clickedPoint.X;
            int y = clickedPoint.Y;

            MessageBox.Show($"Clicked at: X = {x}, Y = {y}");
        }
        void DrawArrowFilled(Graphics g, int x1, int y1, int x2, int y2, float arrowLength, float arrowAngle)
        {
            double angle = Math.Atan2(y2 - y1, x2 - x1);

            PointF arrowP1 = new PointF(
                x2 - arrowLength * (float)Math.Cos(angle - Math.PI / 180 * arrowAngle),
                y2 - arrowLength * (float)Math.Sin(angle - Math.PI / 180 * arrowAngle)
            );

            PointF arrowP2 = new PointF(
                x2 - arrowLength * (float)Math.Cos(angle + Math.PI / 180 * arrowAngle),
                y2 - arrowLength * (float)Math.Sin(angle + Math.PI / 180 * arrowAngle)
            );

            PointF[] triangle = new PointF[] { new PointF(x2, y2), arrowP1, arrowP2 };
            g.FillPolygon(Brushes.Red, triangle);
        }

        private void panel_Graph_Paint(object sender, PaintEventArgs e)
        {
            if (paintQueue.Count <= 0)
            {
                return;
            }

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);

            // Tính toán khoảng cách
            int panelWidth = panel_Graph.Width;
            int panelHeight = panel_Graph.Height;
            int marginLR = 50; // lề trái và phải
            int marginTB = 20; // lề trên và dưới
            int timelineLength = panelWidth - 2 * marginLR;

            int minValue = paintQueue.Min();
            int maxValue = paintQueue.Max();

            // Vẽ trục timeline
            int y = marginTB;
            g.DrawLine(pen, marginLR, y, panelWidth - marginLR, y);

            // Vẽ từng mốc trên timeline
            foreach (int value in paintQueue)
            {
                float percent = (float)(value - minValue) / (maxValue - minValue); // giá trị tương đối
                int x = marginLR + (int)(percent * timelineLength);

                // Vẽ tick
                using (Pen dashedPen = new Pen(Color.Blue, 2f)) // 4f hoặc 5f tùy độ dày bạn muốn
                {
                    dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    g.DrawLine(dashedPen, x, y - 10, x, y + 1000);
                }

                // Ghi nhãn
                string label = value.ToString();
                Font font = new Font("Segoe UI", 10);
                SizeF size = g.MeasureString(label, font);
                g.DrawString(label, font, Brushes.Black, x - size.Width / 2, y - 25);
            }

            int n = paintQueue.Count;
            int startY = marginTB;
            int endY = panel_Graph.Height - 50;
            int totalHeight = endY - startY;
            int segmentHeight = totalHeight / n;

            //Vẽ Yi
            //for (int i = 0; i <= n; i++)
            //{
            //    int Oy = startY + i * segmentHeight;
            //    g.DrawLine(Pens.Gray, 50, Oy, panel_Graph.Width, Oy); // vẽ vạch chia
            //    g.DrawString($"Y{i}", new Font("Segoe UI", 10), Brushes.Black, 10, Oy - 10);
            //}

            // Vẽ đường nối theo thứ tự trong result
            int yBase = marginTB;
            if (result.Count > 0)
            {
                int total = result.Count;
                int spacing = 50;

                int currentHead = 50; // hoặc HeadPosition nếu có

                List<int> xPoints = new List<int>();
                List<int> yPoints = new List<int>();

                // Tính sẵn các điểm (gồm điểm đầu - currentHead)
                for (int i = 0; i <= total; i++)
                {
                    int val = (i == 0) ? currentHead : result[i - 1];
                    float percent = (float)(val - minValue) / (maxValue - minValue);
                    int x = marginLR + (int)(percent * timelineLength);
                    y = yBase + i * spacing;

                    xPoints.Add(x);
                    yPoints.Add(y);
                }

                // Vẽ các đoạn nối với mũi tên
                for (int i = 0; i < total; i++)
                {
                    int x1 = xPoints[i];
                    int y1 = yPoints[i];
                    int x2 = xPoints[i + 1];
                    int y2 = yPoints[i + 1];

                    // Vẽ đoạn nối
                    using (Pen mainPen = new Pen(Color.Black, 3f))
                    {
                        g.DrawLine(mainPen, x1, y1, x2, y2);
                    }

                    // Vẽ đầu tròn
                    g.FillEllipse(Brushes.Black, x1 - 4, y1 - 4, 8, 8);
                    g.FillEllipse(Brushes.Black, x2 - 4, y2 - 4, 8, 8);

                    // Vẽ mũi tên tại cuối đoạn
                    DrawArrowFilled(g, x1, y1, x2, y2, 20, 30); // chiều dài & góc mũi tên
                }
            }
        }
        void FCFS()
        {
            int res = HeadPosition;
            var lists = xData.ToList();
            var tmp = xData.ToList();
            result = lists;
            paintQueue = xData;
        }
        void SSTF()
        {
            int res = HeadPosition;
            var lists = xData.ToList();
            var tmp = xData.ToList();
            while (lists.Count > 0) 
            {
                int removeE = int.MaxValue;
                foreach (int i in lists)
                {
                    if (removeE < Math.Abs(res - i))
                    {
                        removeE = Math.Abs(res - i);
                        res = i;
                    }
                }
                result.Add(res);
                lists.Remove(res);
            }
        }
        private void HeadValue_ValueChanged(object sender, EventArgs e)
        {
            int data = (int)HeadValue.Value;
            if (!xData.Contains(data))
            {
                xData.Add(data);
                panel_Graph.Invalidate();
            }
            //xData.Remove(data);

            //string s = string.Empty;
            //foreach (int value in xData)
            //{
            //    s += value.ToString() + " ";  
            //}
            //MessageBox.Show(s, "TB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            

            //var lists = xData.ToList();
            //lists.Remove(data);
            //xData = lists.ToArray(); // Nếu cần mảng trở lại

            //s = string.Empty;
            //foreach (int value in xData)
            //{
            //    s += value.ToString() + " ";
            //}
            //MessageBox.Show(s, "TB", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
