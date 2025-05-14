using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private List<int> requestQueue = new List<int>();
        private List<int> sequence = new List<int>();

        private int[] xData = { 0, 14, 37, 53, 65, 67, 98, 122, 124, 183 };

        Random random = new Random();
        private int randomA = 10;
        private int randomB = 200;

        private Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(Win_Width, Win_Height);

            timer.Interval = 1; // mili giây (1000ms = 1 giây)
            timer.Tick += Timer_Tick;
            timer.Start(); // Bắt đầu đếm thời gian

            ChartInput(0, 200, 0, 20);

            groupBox1.MouseClick += panel_Graph_MouseClick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_Time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            Invalidate();
        }

        void ChartInput(int StartOx, int EndOx, int StartOy, int EndOy)
        {
            
            for (int i = 0; i < 10; i++)
            {
                int x = xData[i];
                CustomLabel label = new CustomLabel();
                label.FromPosition = i * 200/10;
                label.ToPosition = label.FromPosition + 200/10;
                label.Text = x.ToString();
                
            }
        }

        void UserInput()
        {
            try
            {
                requestQueue = txt_Input.Text.Split(',').Select(s => int.Parse(s.Trim())).ToList();

                //sequence.Clear();
                //sequence.Add(startTrack);
                //sequence.AddRange(requestQueue);
            }
            catch
            {
                MessageBox.Show("Invalid input! Please enter numbers separated by commas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (txt_Input.Text != string.Empty) UserInput();
            foreach (int i in requestQueue)
            {
                txt_SeekCnt.Text += i.ToString() + " ";
            }
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
            Point startPosition = new Point (panel_Graph.Location.X, panel_Graph.Location.Y);
        }
    }
}
