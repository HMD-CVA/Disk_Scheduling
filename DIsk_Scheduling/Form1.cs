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

        private List<int> requestQueue = new List<int>();
        private List<int> result = new List<int>();

        private int[] xData = { 0, 14, 37, 53, 65, 67, 98, 122, 124, 183 };

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

            HeadPosition = 60;

            HeadValue.Minimum = xData.Min(); 
            HeadValue.Maximum = xData.Max();
            HeadPosition = (int)HeadValue.Value;
            HeadValue.Value = HeadPosition;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_Time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            Invalidate();
        }

        void UserInput()
        {
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
            txt_Input.Text = string.Empty;
        }

        private void panel_Graph_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickedPoint = e.Location;
            int x = clickedPoint.X;
            int y = clickedPoint.Y;

            MessageBox.Show($"Clicked at: X = {x}, Y = {y}");
        }

        private void panel_Graph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);

            // Tính toán khoảng cách
            int panelWidth = panel_Graph.Width;
            int panelHeight = panel_Graph.Height;
            int marginLR = 50; // lề trái và phải
            int marginTB = 20; // lề trên và dưới
            int timelineLength = panelWidth - 2 * marginLR;

            int minValue = xData.Min();
            int maxValue = xData.Max();

            // Vẽ trục timeline
            int y = marginTB;
            g.DrawLine(pen, marginLR, y, panelWidth - marginLR, y);

            // Vẽ từng mốc trên timeline
            foreach (int value in xData)
            {
                float percent = (float)(value - minValue) / (maxValue - minValue); // giá trị tương đối
                int x = marginLR + (int)(percent * timelineLength);

                // Vẽ tick
                g.DrawLine(Pens.Blue, x, y - 10, x, y + 1000);

                // Ghi nhãn
                string label = value.ToString();
                Font font = new Font("Segoe UI", 10);
                SizeF size = g.MeasureString(label, font);
                g.DrawString(label, font, Brushes.Black, x - size.Width / 2, y - 25);
            }

            int n = xData.Length;
            int startY = marginTB;
            int endY = panel_Graph.Height - 50;
            int totalHeight = endY - startY;
            int segmentHeight = totalHeight / n;

            for (int i = 0; i <= n; i++)
            {
                int Oy = startY + i * segmentHeight;
                g.DrawLine(Pens.Gray, 50, Oy, panel_Graph.Width - 50, Oy); // vẽ vạch chia
                g.DrawString($"Y{i}", new Font("Segoe UI", 10), Brushes.Black, 10, Oy - 10);
            }

            // Vẽ đường nối theo thứ tự trong result
            int yBase = marginTB;
            if (result.Count > 0)
            {
                int total = result.Count;
                int yStart = yBase + 50;
                int spacing = 50;

                int currentHead = HeadPosition;
                for (int i = 0; i < total; i++)
                {
                    int from = (i == 0) ? currentHead : result[i - 1];
                    int to = result[i];

                    float percentFrom = (float)(from - minValue) / (maxValue - minValue);
                    float percentTo = (float)(to - minValue) / (maxValue - minValue);

                    int x1 = marginLR + (int)(percentFrom * timelineLength);
                    int x2 = marginLR + (int)(percentTo * timelineLength);
                    y = yStart + i * spacing;

                    g.DrawLine(Pens.Red, x1, y, x2, y);
                    g.FillEllipse(Brushes.Red, x1 - 4, y - 4, 8, 8);
                    g.FillEllipse(Brushes.Red, x2 - 4, y - 4, 8, 8);

                    g.DrawString($"{from} → {to}", new Font("Segoe UI", 10), Brushes.DarkGreen, (x1 + x2) / 2, y - 20);
                }
            }
        }
        void FCFS()
        {
            int res = HeadPosition;
            var lists = xData.ToList();
            var tmp = xData.ToList();
            result = lists;
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
                var list = xData.ToList();
                list.Add(data);
                xData = list.ToArray(); // Nếu cần mảng trở lại
            }

            string s = string.Empty;
            foreach (int value in xData)
            {
                s += value.ToString() + " ";  
            }
            MessageBox.Show(s, "TB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            panel_Graph.Invalidate();

            var lists = xData.ToList();
            lists.Remove(data);
            xData = lists.ToArray(); // Nếu cần mảng trở lại

            s = string.Empty;
            foreach (int value in xData)
            {
                s += value.ToString() + " ";
            }
            MessageBox.Show(s, "TB", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
