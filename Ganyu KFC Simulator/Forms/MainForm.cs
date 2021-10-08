using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Numerics;

namespace Ganyu_KFC_Simulator.Forms
{
    public partial class MainForm : Form
    {
        Image chimken;
        Image ganyu;
        Image ganyubig;
        Image bucket;
        Image flower;

        PictureBox[] boxes;

        bool[] touched = { false, false, false };
        bool[] flying = { false, false, false };
        int score = 0;
        int[] scores = { 1, 10, 223 };

        float[] gravity = { 0, 0, 0 };

        Point[] corigin;

        Vector2[] direction;
        Point[] lastPosition;

        public MainForm()
        {
            InitializeComponent();
            direction = new Vector2[3];
            lastPosition = new Point[3];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<string> names = assembly.GetManifestResourceNames().ToList();

            chimken = Image.FromStream(assembly.GetManifestResourceStream(names.Find(new Predicate<string>(val => val.Contains("a.png")))));
            ganyu = Image.FromStream(assembly.GetManifestResourceStream(names.Find(new Predicate<string>(val => val.Contains("b.png")))));
            ganyubig = Image.FromStream(assembly.GetManifestResourceStream(names.Find(new Predicate<string>(val => val.Contains("ganyuBIG.png")))));
            bucket = Image.FromStream(assembly.GetManifestResourceStream(names.Find(new Predicate<string>(val => val.Contains("c.png")))));
            flower = Image.FromStream(assembly.GetManifestResourceStream(names.Find(new Predicate<string>(val => val.Contains("d.png")))));

            chickenbox.Image = chimken;
            ganyubox.Image = ganyu;
            chickenbucketbox.Image = bucket;
            flowerbox.Image = flower;

            chickenbucketbox.Visible = false;
            flowerbox.Visible = false;

            boxes = new PictureBox[] {chickenbox, chickenbucketbox, flowerbox };

            corigin = new Point[] { chickenbox.Location, chickenbucketbox.Location, flowerbox.Location };

            timer.Enabled = true;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            scorelabel.Text = $"Score: {score}";
            if (score == 69)
                scorelabel.Text = "haha 69 sex nnumber lol";
            if (score >= 10) boxes[1].Visible = true;
            if (score >= 100) boxes[2].Visible = true;
            if (score >= 999)
            {
                foreach (Control i in Controls)
                {
                    i.Visible = false;
                }
                this.BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = ganyubig;
                timer.Enabled = false;
            }
            for (int i = 0; i < flying.Length; i++)
            {
                if (flying[i])
                {
                    gravity[i] += 0.295f;
                    boxes[i].Location = 
                        new Point(
                            (int)(boxes[i].Location.X + Math.Ceiling(direction[i].X)), 
                            (int)(boxes[i].Location.Y + Math.Ceiling(direction[i].Y) + gravity[i])
                        );
                    if (direction[i].X == 0 && direction[i].Y == 0)
                    {
                        flying[i] = false;
                        touched[i] = false;
                        gravity[i] = 0;
                    }
                    if (ganyubox.Bounds.IntersectsWith(boxes[i].Bounds))
                    {
                        score += scores[i];
                        boxes[i].Location = corigin[i];
                        touched[i] = false;
                        flying[i] = false;
                        gravity[i] = 0;
                    }
                    if (!boxes[i].Bounds.IntersectsWith(ClientRectangle))
                    {
                        boxes[i].Location = corigin[i];
                        touched[i] = false;
                        flying[i] = false;
                        gravity[i] = 0;
                    }
                    return;
                }
                Point Location = new Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);
                direction[i] = new Vector2(Location.X - lastPosition[i].X, Location.Y - lastPosition[i].Y);
                direction[i] /= 5;
                if (touched[i] && !flying[i]) boxes[i].Location = new Point(Location.X - boxes[i].Width / 2, Location.Y - boxes[i].Height / 2);

                lastPosition[i] = Location;
            }
        }

        private void chickenbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!touched[0] && !flying[0]) touched[0] = true;
        }

        private void chickenbox_MouseUp(object sender, MouseEventArgs e)
        {
            if (touched[0] && !flying[0]) flying[0] = true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                score += 10;
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            corigin[0] = chickenbox.Location;
            corigin[1] = chickenbucketbox.Location;
            corigin[2] = flowerbox.Location;
        }

        private void flowerbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!touched[2] && !flying[2]) touched[2] = true;
        }

        private void flowerbox_MouseUp(object sender, MouseEventArgs e)
        {
            if (touched[2] && !flying[2]) flying[2] = true;
        }

        private void chickenbucketbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!touched[1] && !flying[1]) touched[1] = true;
        }

        private void chickenbucketbox_MouseUp(object sender, MouseEventArgs e)
        {
            if (touched[1] && !flying[1]) flying[1] = true;
        }
    }
}
