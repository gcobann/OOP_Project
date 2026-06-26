using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Form1 : Form
    {
        // Global polygon object accessible by all buttons
        Polygon currentPolygon;

        // Timer to manage rotation animation
        Timer tmrRotate = new Timer();

        public Form1()
        {
            InitializeComponent();
            // Bind the timer tick to our custom method
            tmrRotate.Tick += TmrRotate_Tick;
        }

        private void DrawPolygonToCanvas()
        {
            Graphics g = picCanvas.CreateGraphics();
            g.Clear(Color.White); // Clear previous drawings

            if (currentPolygon == null || currentPolygon.Vertices == null) return;

            // Convert our custom ColorRGB to C#'s built-in Color
            Color polygonColor = Color.FromArgb(currentPolygon.Color.Red, currentPolygon.Color.Green, currentPolygon.Color.Blue);
            Pen drawPen = new Pen(polygonColor, 2);

            // Center the shape in the PictureBox
            Point[] screenPoints = new Point[currentPolygon.NumberOfEdges];
            int shiftX = picCanvas.Width / 2;
            int shiftY = picCanvas.Height / 2;
            int scaleFactor = 15; // Scale up the coordinates to make the shape visible

            for (int ae = 0; ae < currentPolygon.NumberOfEdges; ae++)
            {
                int x = (int)(currentPolygon.Vertices[ae].X * scaleFactor) + shiftX;
                // Y is multiplied by -1 because Windows Forms Y-axis goes downwards
                int y = (int)(-currentPolygon.Vertices[ae].Y * scaleFactor) + shiftY;
                screenPoints[ae] = new Point(x, y);
            }

            g.DrawPolygon(drawPen, screenPoints);
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            // Auto-draw if no shape exists yet
            if (currentPolygon == null)
            {
                btnReset.PerformClick();
                btnDraw.PerformClick();
            }

            // Toggle animation
            if (tmrRotate.Enabled == false)
            {
                int sure = trkSpin.Value;
                if (sure <= 0) sure = 1;

                tmrRotate.Interval = sure * 1000; // Convert seconds to milliseconds

                tmrRotate.Start();
                btnRotate.Text = "Stop";
            }
            else
            {
                tmrRotate.Stop();
                btnRotate.Text = "Rotate";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // Generate random values within the required ranges
            int rndX = rnd.Next(0, 4);
            int rndY = rnd.Next(0, 4);
            int rndLength = rnd.Next(3, 10);
            int rndEdgeCount = rnd.Next(3, 11);
            int rndAngle = rnd.Next(0, 360);

            int rndR = rnd.Next(0, 256);
            int rndG = rnd.Next(0, 256);
            int rndB = rnd.Next(0, 256);

            // Assign generated values to textboxes
            txtCenterX.Text = rndX.ToString();
            txtCenterY.Text = rndY.ToString();
            txtLength.Text = rndLength.ToString();
            txtEdge.Text = rndEdgeCount.ToString();
            txtAngle.Text = rndAngle.ToString();

            // Assign generated colors to trackbars
            trkRed.Value = rndR;
            trkGreen.Value = rndG;
            trkBlue.Value = rndB;

            // Stop rotation if it's currently running
            if (tmrRotate != null && tmrRotate.Enabled)
            {
                tmrRotate.Stop();
                btnRotate.Text = "Rotate";
            }

            // Clear memory and screen
            currentPolygon = null;
            Graphics g = picCanvas.CreateGraphics();
            g.Clear(Color.White);
        }

        private void trkSpin_Scroll(object sender, EventArgs e)
        {
            lblCurrentSpin.Text = trkSpin.Value.ToString();

            // Update timer speed dynamically if it's currently running
            if (tmrRotate.Enabled)
            {
                int sure = trkSpin.Value;
                if (sure <= 0) sure = 1;
                tmrRotate.Interval = sure * 1000;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
                int inputX = int.Parse(txtCenterX.Text);
                int inputY = int.Parse(txtCenterY.Text);
                int length = int.Parse(txtLength.Text);
                int edge = int.Parse(txtEdge.Text);

                currentPolygon = new Polygon(new Point2D(inputX, inputY), length);
                currentPolygon.NumberOfEdges = edge;

                currentPolygon.Color.Red = trkRed.Value;
                currentPolygon.Color.Green = trkGreen.Value;
                currentPolygon.Color.Blue = trkBlue.Value;

                currentPolygon.calculateEdgeCoordinates();

                DrawPolygonToCanvas();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentPolygon == null)
            {
                MessageBox.Show("Ekranda kaydedilecek bir şekil yok! Önce Draw butonuna basarak bir şekil çizin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Belgesi | *.txt";
            saveFileDialog.Title = "Şekli Kaydet";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save data as a comma-separated string
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine($"{currentPolygon.Center.X},{currentPolygon.Center.Y},{currentPolygon.Length},{currentPolygon.NumberOfEdges},{currentPolygon.Color.Red},{currentPolygon.Color.Green},{currentPolygon.Color.Blue}");
                }
                MessageBox.Show("Şekil başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Metin Belgesi | *.txt";
            openFileDialog.Title = "Şekil Yükle";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(openFileDialog.FileName))
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        // Split the saved string and assign values back to the UI
                        string[] data = line.Split(',');

                        txtCenterX.Text = data[0];
                        txtCenterY.Text = data[1];
                        txtLength.Text = data[2];
                        txtEdge.Text = data[3];

                        trkRed.Value = int.Parse(data[4]);
                        trkGreen.Value = int.Parse(data[5]);
                        trkBlue.Value = int.Parse(data[6]);

                        // Trigger draw manually to show the loaded shape
                        btnDraw_Click(null, null);
                    }
                }
                MessageBox.Show("Şekil dosyadan başarıyla yüklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TmrRotate_Tick(object sender, EventArgs e)
        {
            if (currentPolygon == null) return;

            int angle = int.Parse(txtAngle.Text);

            bool isCCW = chkCCW.Checked;

            currentPolygon.rotatePolygon(angle, isCCW);

            // Rotate and redraw
            DrawPolygonToCanvas();
        }
    }
}