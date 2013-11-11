using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
 
namespace PetriDishWin
{
    public partial class PetriDishForm : Form
    {
        public Bitmap bmp;
        public Bitmap membmp;
        public Graphics graphics;
        public System.Windows.Forms.Timer UpdateTimer;
        public GridController theController;
        public StatsManager stats; 
        delegate void PixelFunc(int x, int y, Color color);
 
        private void Init()
        {
            if (graphics != null) graphics.Dispose();
            if (bmp != null) bmp.Dispose();
            petriDishImage.Image = null; 
            bmp = new Bitmap(petriDishImage.Width, petriDishImage.Height);
            membmp = new Bitmap(petriDishImage.Width, petriDishImage.Height);
            petriDishImage.Image = bmp;
            graphics = petriDishImage.CreateGraphics();
            
        }
        public PetriDishForm()
        {
            theController = new GridController(300, 5);
            stats = new StatsManager();
            InitializeComponent();
        }
 
        private void SetPixel(int x, int y, Color color)
        {
            lock (membmp)
            {
                membmp.SetPixel(x, y, color);
            }
        }
 
        private void Render(Object state)
        {
            int[] coords;
            var length = theController.gameGrid.grid.GetLength(0);
            PixelFunc pixelFunc = new PixelFunc(SetPixel);
            var position = 0;
            foreach (var microbe in theController.gameGrid.grid)
            {
                if (microbe != null)
                {
                    coords = GetCoords(position, length);
                    SetPixel(coords[0], coords[1], microbe.rgbColour);
                }
                position++;
            }
        }
        private int[] GetCoords(int position, int length)
        {
            int row = position / length;
            int col = position % length;
            int[] coords = new int[]{row,col};
            return coords;
        }
 
        public void startButton_Click(object sender, EventArgs e)
        {
                cycle();
        }

        private void cycle()
        {
            Init();
            if (UpdateTimer == null)
            {
                UpdateTimer = new System.Windows.Forms.Timer();
                UpdateTimer.Interval = 150;
                UpdateTimer.Tick += new EventHandler(Timer_Tick);
                UpdateTimer.Start();
            }
        }

        private void Timer_Tick(Object sender, EventArgs e)
        {
            theController.GridCycle();
            UpdateLabels();
            lock (membmp)
            {
                graphics.DrawImageUnscaled(membmp, 0, 0);
            }
            WaitCallback wc = new System.Threading.WaitCallback(Render);
            ThreadPool.QueueUserWorkItem(wc);
        }

        private void PetriDishForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            graphics.Dispose();
            bmp.Dispose();
            membmp.Dispose();
        }

        private void UpdateLabels()
        {
            stats.AnalyseGrid(theController.gameGrid.grid);

            MicrobeID.Text = stats.topDog.microbeId.ToString();
            MicrobeID.ForeColor = stats.topDog.rgbColour;
            MicrobeCount.Text = stats.topDogCount.ToString();
            MutateStrength.Text = stats.topDog.mutateStrength.ToString();
            MutateResistance.Text = stats.topDog.mutateResistance.ToString();
            SpreadChance.Text = stats.topDog.spreadChance.ToString();
            ConsumeStrength.Text = stats.topDog.consumeStrength.ToString();
            ConsumeResistance.Text = stats.topDog.consumeResistance.ToString();
        }
    }
}