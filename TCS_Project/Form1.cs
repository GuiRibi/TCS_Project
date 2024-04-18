using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Windows.Graphics.Display;

namespace TCS_Project
{
    public partial class Form1 : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 1;
        }

        private void tableLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back && e.KeyChar != '\u0003' || e.KeyChar == ',' && textBox1.Text.Contains(","))
            {
                string clipboardText = Clipboard.GetText();

                bool isNumeric = double.TryParse(clipboardText, out double doubleValue) || long.TryParse(clipboardText, out long longValue);

                if (isNumeric && e.KeyChar == '\u0016')
                {
                    if (textBox1.Text.Contains(",") && clipboardText.Contains(","))
                    {
                        e.Handled = true;
                        MessageBox.Show(textBox1.Text + clipboardText + " is not a valid number.", "Exception: invalid number", MessageBoxButtons.OK);
                    }
                    else
                        return;
                }
                if (!isNumeric && e.KeyChar == '\u0016')
                {
                    e.Handled = true;
                    MessageBox.Show(textBox1.Text + clipboardText + " is not a valid number.", "Exception: invalid number", MessageBoxButtons.OK);
                }
                else
                    e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back && e.KeyChar != '\u0003' || e.KeyChar == ',' && textBox2.Text.Contains(","))
            {
                string clipboardText = Clipboard.GetText();

                bool isNumeric = double.TryParse(clipboardText, out double doubleValue) || long.TryParse(clipboardText, out long longValue);

                if (isNumeric && e.KeyChar == '\u0016')
                {
                    if (textBox2.Text.Contains(",") && clipboardText.Contains(","))
                    {
                        e.Handled = true;
                        MessageBox.Show(textBox2.Text + clipboardText + " is not a valid number.", "Exception: invalid number", MessageBoxButtons.OK);
                    }
                    else
                        return;
                }
                if (!isNumeric && e.KeyChar == '\u0016')
                {
                    e.Handled = true;
                    MessageBox.Show(textBox2.Text + clipboardText + " is not a valid number.", "Exception: invalid number", MessageBoxButtons.OK);
                }
                else
                    e.Handled = true;

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back && e.KeyChar != '\u0003' || e.KeyChar == ',' && textBox3.Text.Contains(","))
            {
                string clipboardText = Clipboard.GetText();

                bool isNumeric = double.TryParse(clipboardText, out double doubleValue) || long.TryParse(clipboardText, out long longValue);

                if (isNumeric && e.KeyChar == '\u0016')
                {
                    if (textBox3.Text.Contains(",") && clipboardText.Contains(","))
                    {
                        e.Handled = true;
                        MessageBox.Show(textBox3.Text + clipboardText + " is not a valid number.", "Exception: invalid number", MessageBoxButtons.OK);
                    }
                    else
                        return;
                }
                if (!isNumeric && e.KeyChar == '\u0016')
                {
                    e.Handled = true;
                    MessageBox.Show(textBox3.Text + clipboardText + " is not a valid number.", "Exception: invalid number", MessageBoxButtons.OK);
                }
                else
                    e.Handled = true;

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back && e.KeyChar != '\u0003' || e.KeyChar == ',' && textBox4.Text.Contains(","))
            {
                string clipboardText = Clipboard.GetText();

                bool isNumeric = double.TryParse(clipboardText, out double doubleValue) || long.TryParse(clipboardText, out long longValue);

                if (isNumeric && e.KeyChar == '\u0016')
                {
                    if (textBox4.Text.Contains(",") && clipboardText.Contains(","))
                    {
                        e.Handled = true;
                        MessageBox.Show(textBox4.Text + clipboardText + " is not a valid number.", "Exception: invalid number", MessageBoxButtons.OK);
                    }
                    else
                        return;
                }
                if (!isNumeric && e.KeyChar == '\u0016')
                {
                    e.Handled = true;
                    MessageBox.Show(textBox4.Text + clipboardText + " is not a valid number.", "Exception: invalid number", MessageBoxButtons.OK);
                }
                else
                    e.Handled = true;

            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back && e.KeyChar != '\u0003' || e.KeyChar == ',' && textBox5.Text.Contains(","))
            {
                string clipboardText = Clipboard.GetText();

                bool isNumeric = double.TryParse(clipboardText, out double doubleValue) || long.TryParse(clipboardText, out long longValue);

                if (isNumeric && e.KeyChar == '\u0016')
                {
                    if (textBox5.Text.Contains(",") && clipboardText.Contains(","))
                    {
                        e.Handled = true;
                        MessageBox.Show(textBox5.Text + clipboardText + " is not a valid number.", "Exception: invalid number", MessageBoxButtons.OK);
                    }
                    else
                        return;
                }
                if (!isNumeric && e.KeyChar == '\u0016')
                {
                    e.Handled = true;
                    MessageBox.Show(textBox5.Text + clipboardText + " is not a valid number.", "Exception: invalid number", MessageBoxButtons.OK);
                }
                else
                    e.Handled = true;

            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private Bitmap Graph(PointF[] pointV, PointF[] pointI, double U, double I, double Z, double A)
        {
            Bitmap bpm = new Bitmap(pictureBoxGraph.Width, pictureBoxGraph.Height);
            Graphics g = Graphics.FromImage(bpm);

            g.FillRectangle(Brushes.White, 0, 0, pictureBoxGraph.Width, pictureBoxGraph.Height);
            g.DrawLine(new Pen(Color.Black, 2), 0, pictureBoxGraph.Height / 2, pictureBoxGraph.Width, pictureBoxGraph.Height / 2);
            g.DrawLines(new Pen(Color.Green, 2), pointV);
            g.DrawLines(new Pen(Color.Red, 2), pointI);

            g.DrawString("U = " + U.ToString("0.0#") + "V", new Font("Segoe UI", 7), new SolidBrush(Color.Green), 2, 2);
            g.DrawString("I = " + I.ToString("0.0#") + "A", new Font("Segoe UI", 7), new SolidBrush(Color.Red), 2, pictureBoxGraph.Height - 20);

            return bpm;
        }

        private PointF[] Points_I(double angle, double frequency, double ratio)
        {
            double Period = 1 / frequency;
            int resolution = pictureBoxGraph.Width * 2;
            int pic_height = pictureBoxGraph.Height;
            PointF[] pts = new PointF[resolution];
            Parallel.For(0, resolution, i =>
            {
                double t = Period * (float)i;
                double y_value = -Math.Sin((2 * Math.PI) * ((float)i / resolution) + angle) * ratio;
                double y_coordinate = y_value * (pic_height / 2 - 10) + pic_height / 2;
                pts[i] = new PointF((float)i / 2, (float)y_coordinate);

            });
            return pts;
        }

        private PointF[] Points_U(double frequency, double ratio)
        {
            double Period = 1 / frequency;
            int resolution = pictureBoxGraph.Width * 2;
            int pic_height = pictureBoxGraph.Height;
            PointF[] pts = new PointF[resolution];
            Parallel.For(0, resolution, i =>
            {
                double t = Period * (float)i;
                double y_value = -Math.Sin((2 * Math.PI) * ((float)i / resolution)) * ratio;
                double y_coordinate = y_value * (pic_height / 2 - 10) + pic_height / 2;
                pts[i] = new PointF((float)i / 2, (float)y_coordinate);
            });
            return pts;
        }

        private double Angle(double R, double C, double L, double f)
        {
            double angular_vel = 2 * Math.PI * f;
            double XL = angular_vel * L;
            double XC = 1 / (angular_vel * C);
            return (Math.Atan((XL - XC) / R));
        }

        private double Impedance(double R, double C, double L, double f)
        {
            double angular_vel = 2 * Math.PI * f;
            double XL = angular_vel * L;
            double XC = 1 / (angular_vel * C);
            return (Math.Sqrt(R * R + (XL - XC) * (XL - XC)));
        }

        private double Current(double U, double Z)
        {
            return (U / Z);
        }

        private double[] Ratio(double U, double I)
        {
            double ratio;
            if (U > I) 
            {
                ratio = I / U;
                return new double[] {1, ratio };
            }
            else
            {
                ratio = U / I;
                return new double[] {ratio, 1 };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double R = double.Parse(textBox1.Text) * Math.Pow(10, comboBox1.SelectedIndex * 3 -3);
                double L = double.Parse(textBox2.Text) * Math.Pow(10, - comboBox2.SelectedIndex * 3);
                double C = double.Parse(textBox3.Text) * Math.Pow(10, - comboBox3.SelectedIndex * 3);
                double f = double.Parse(textBox4.Text) * Math.Pow(10, comboBox4.SelectedIndex * 3);
                double U = double.Parse(textBox5.Text) * Math.Pow(10, - comboBox5.SelectedIndex * 3 + 3);

                double A = Angle(R, C, L, f);
                double Z = Impedance(R, C, L, f);
                double I = Current(U, Z);

                double[] ratio = Ratio(U, I);

                PointF[] List_U = Points_U(f, ratio[0]);
                PointF[] List_I = Points_I(A, f, ratio[1]);

                pictureBoxGraph.Image = Graph(List_U, List_I, U, I, Z, A);

                labelResults.Text = "φ = " + (A * 180 / Math.PI).ToString("0.0##") + "º; Z = " + Z.ToString("0.0##") + "Ω";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception: invalid operation", MessageBoxButtons.OK);
            }
        }
    }
}
