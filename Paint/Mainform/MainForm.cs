using Paint.Mainform;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form
    {
        private Bitmap _bitmap;

        private Graphics _graphics;

        private bool _isPaint = false;

        private Point _pointX, _pointY;

        private Pen _pen = new Pen(Color.Black, 1f);

        private Pen _erase = new Pen(Color.White, 10f);

        private int _index;

        private float _startX, _startY, _endX, _endY, _X, _Y;

        private Color _newColor;

        private void MainForm_Load(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(mainPicture.Width, mainPicture.Height);

            _graphics = Graphics.FromImage(_bitmap);

            _graphics.Clear(Color.White);

            mainPicture.Image = _bitmap;
        }

        private void OnMainPictureMouseDown(object sender, MouseEventArgs e)
        {
            _isPaint = true;

            _pointY = e.Location;

            _startX = e.Location.X;

            _startY = e.Location.Y;
        }

        private void OnButtonCircleClick(object sender, EventArgs e)
        {
            _index = (int)Choice.Ellipse;

            ClickAndClear(sender);
        }
        /// <summary>
        /// Чистим цвет фона не активых кнопок тулстрипа и меняем цвет кнопки, на которую нажали
        /// </summary>
        /// <param name="sender"></param>
        private void ClickAndClear(object sender)
        {

            foreach (ToolStripButton itemButton in toolStrip1.Items.OfType<ToolStripButton>())
            {
                itemButton.BackColor = Color.WhiteSmoke;
            }

            if (sender != null)
            {
                (sender as ToolStripButton).BackColor = Color.PowderBlue;
            }
        }

        private void OnButtonRectangleClick(object sender, EventArgs e)
        {
            _index = (int)Choice.Rectangle;

            ClickAndClear(sender);
        }

        private void OnButtonLineClick(object sender, EventArgs e)
        {
            _index = (int)Choice.Line;

            ClickAndClear(sender);
        }

        private void OnPaintMainPicture(object sender, PaintEventArgs e)
        {
            Graphics _bufferGraphics = e.Graphics;

            if (_isPaint)
            {
                switch (_index)
                {
                    case (int)Choice.Ellipse:
                        _bufferGraphics.DrawEllipse(_pen, _startX, _startY, _endX, _endY);
                        break;

                    case (int)Choice.Rectangle:
                        _bufferGraphics.DrawRectangle(_pen, _startX, _startY, _endX, _endY);
                        break;

                    case (int)Choice.Line:
                        _bufferGraphics.DrawLine(_pen, _startX, _startY, _X, _Y);
                        break;
                }
            }
        }

        private void OnClickButtonClear(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);

            mainPicture.Image = _bitmap;

            _index = 0;

            ClickAndClear(null);
        }

        private void OnMainPictureMouseMove(object sender, MouseEventArgs e)
        {
            if (_isPaint)
            {
                _pointX = e.Location;

                switch (_index)
                {
                    case (int)Choice.Pensis:
                        _graphics.DrawLine(_pen, _pointX, _pointY);
                        break;

                    case (int)Choice.Erase:
                        _graphics.DrawLine(_erase, _pointX, _pointY);
                        break;

                }

                _pointY = _pointX;
            }

            mainPicture.Refresh();

            _X = e.X;

            _Y = e.Y;

            _endX = e.X - _startX;

            _endY = e.Y - _startY;
        }

        private void OnMouseClickColorBar(object sender, MouseEventArgs e)
        {
            Point point = SetPoint(colorBar, e.Location);

            currentColor.BackColor = ((Bitmap)colorBar.Image).GetPixel(point.X, point.Y);

            _newColor = currentColor.BackColor;

            _pen.Color = currentColor.BackColor;
        }

        private void OnColorBarMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point point = SetPoint(colorBar, e.Location);

                currentColor.BackColor = ((Bitmap)colorBar.Image).GetPixel(point.X, point.Y);

                _newColor = currentColor.BackColor;

                _pen.Color = currentColor.BackColor;
            }
        }

        private void OnScrollTrackBar1(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void OnTextChangedLabel1(object sender, EventArgs e)
        {
            _erase.Width = Int32.Parse(label1.Text);
        }

        private void OnBackColorChangedButtonErase(object sender, EventArgs e)
        {
            if (buttonErase.BackColor == Color.WhiteSmoke)
            {
                trackBar1.Visible = false;

                label1.Visible = false;
            }
            else
            {
                trackBar1.Visible = true;

                label1.Visible = true;
            }
        }

        private void OnMainPictureMouseUp(object sender, MouseEventArgs e)
        {
            _isPaint = false;

            _endX = _X - _startX;

            _endY = _Y - _startY;

            switch (_index)
            {
                case (int)Choice.Ellipse:
                    _graphics.DrawEllipse(_pen, _startX, _startY, _endX, _endY);
                    break;

                case (int)Choice.Rectangle:
                    _graphics.DrawRectangle(_pen, _startX, _startY, _endX, _endY);
                    break;

                case (int)Choice.Line:
                    _graphics.DrawLine(_pen, _startX, _startY, _X, _Y);
                    break;
            }
        }

        private void OnButtonPensilClick(object sender, EventArgs e)
        {
            _index = (int)Choice.Pensis;

            ClickAndClear(sender);
        }

        private void MouseClickMainPicture(object sender, MouseEventArgs e)
        {
            Point point = SetPoint((PictureBox)sender, e.Location);

            switch (_index)
            {

                case (int)Choice.Fill:

                    Fill(_bitmap, point.X, point.Y, _newColor);

                    break;

                case (int)Choice.Text:

                    if (e.Button == MouseButtons.Left)
                    {
                        SolidBrush sb = new SolidBrush(currentColor.BackColor);

                        FontFamily ff = new FontFamily("Arial");

                        _graphics.DrawString(textBox1.Text, new Font(ff, 10), sb, point);
                    }

                    break;
            }
        }

        private void OnClickButtonFill(object sender, EventArgs e)
        {
            _index = (int)Choice.Fill;

            ClickAndClear(sender);
        }

        private void OnClickButtonSave(object sender, EventArgs e)
        {
            var saveFiledialog = new SaveFileDialog();

            saveFiledialog.Filter = "JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|Все файлы|*.*";

            if (saveFiledialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = _bitmap.Clone(new Rectangle(0, 0, mainPicture.Width, mainPicture.Height), _bitmap.PixelFormat);

                bitmap.Save(saveFiledialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void OnClickButtonText(object sender, EventArgs e)
        {
            _index = (int)Choice.Text;

            ClickAndClear(sender);

        }

        private void OnClickSelectColor(object sender, EventArgs e)
        {
            colorSelection.ShowDialog();

            _newColor = colorSelection.Color;

            currentColor.BackColor = colorSelection.Color;

            _pen.Color = _newColor;
        }

        private void OnButtonTextChangedBackColor(object sender, EventArgs e)
        {
            textBox1.Clear();

            if (buttonText.BackColor == Color.WhiteSmoke)
            {
                textBox1.Visible = false;

                label2.Visible = false;
            }
            else
            {
                textBox1.Visible = true;

                label2.Visible = true;
            }
        }

        private void OnClickButtonLoadImage(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (File.Exists(openFileDialog1.FileName))
            {
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);

                Bitmap bitmap1 = new Bitmap(bitmap, mainPicture.Width, mainPicture.Height);

                _graphics = Graphics.FromImage(bitmap1);

                mainPicture.SizeMode = PictureBoxSizeMode.StretchImage;

                mainPicture.Image = bitmap1;
            }

            
        }

        private void OnButtonEraseClick(object sender, EventArgs e)
        {
            _index = (int)Choice.Erase;

            ClickAndClear(sender);

            _erase.Width = 1;

            label1.Text = _erase.Width.ToString();
        }

        private void OnButtonColorClick(object sender, EventArgs e)
        {
            colorSelection.ShowDialog();

            _newColor = colorSelection.Color;

            currentColor.BackColor = colorSelection.Color;

            _pen.Color = _newColor;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pointX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pointY = 1f * pictureBox.Image.Height / pictureBox.Height;

            return new Point((int)(point.X * pointX), (int)(point.Y * pointY));
        }

        private void Validate(Bitmap bitmap, Stack<Point> stackPoint, int x, int y, Color oldColor, Color newColor)
        {
            if (x > 0 && x < mainPicture.Width && y > 0 && y < mainPicture.Height)
            {
                Color color = bitmap.GetPixel(x, y);

                if (color == oldColor)
                {
                    stackPoint.Push(new Point(x, y));

                    bitmap.SetPixel(x, y, newColor);
                }
            }
        }

        private void Fill(Bitmap bitmap, int x, int y, Color newColor)
        {
            Color oldColor = bitmap.GetPixel(x, y);

            Stack<Point> pixel = new Stack<Point>();

            pixel.Push(new Point(x, y));

            bitmap.SetPixel(x, y, newColor);

            if (oldColor == newColor) return;

            while (pixel.Count > 0)
            {
                Point point = (Point)pixel.Pop();

                if (point.X > 0 && point.Y > 0 && point.X < bitmap.Width - 1 && point.Y < bitmap.Width - 1)
                {
                    Validate(bitmap, pixel, point.X - 1, point.Y, oldColor, newColor);
                    Validate(bitmap, pixel, point.X, point.Y - 1, oldColor, newColor);
                    Validate(bitmap, pixel, point.X + 1, point.Y, oldColor, newColor);
                    Validate(bitmap, pixel, point.X, point.Y + 1, oldColor, newColor);
                }
            }
        }
    }
}
