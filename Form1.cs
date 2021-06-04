using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Timers;
using System.Threading.Tasks;


namespace Fractals
{
    public partial class MainForm : Form
    {

        private Mandelbrot mandelbrot;
        int sizeChange=1;
        int color_choice;
        private bool handler_enabled=true;
        private bool increase = true;
        public MainForm()
        {
            InitializeComponent();
            tbSizeCnange_Scroll(null, null);
            saveBitmapDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            //pSwitchCircle.BackColor = Color.FromArgb(0, 0, 0, 0);
            DrawFractal();
        }
        private void DrawFractal()
        {
            if (handler_enabled)
            {
                mandelbrot = new Mandelbrot(pbMain.ClientSize, (double)udAnchorX.Value, (double)udAnchorY.Value, (double)udWidth.Value, (double)udHeigth.Value, (int)udIterations.Value, color_choice);
                pbMain.Invalidate();
            }
        }

        private void bDraw_MouseClick(object sender, MouseEventArgs e)
        {
            DrawFractal();
        }

        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            if (mandelbrot != null)
                e.Graphics.DrawImage(mandelbrot.bmp, 0, 0);
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            DrawFractal();
        }

        private void tbSizeCnange_Scroll(object sender, EventArgs e)
        {
            sizeChange = (int)Math.Pow(2,tbSizeCnange.Value);
            lbSizeChange.Text = sizeChange.ToString()+ "x";
        }

        private void pbMain_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void SetUpDown (NumericUpDown ud, decimal value)
        {
            try
            {
                ud.Value = value;
            }
            catch (ArgumentOutOfRangeException)
            {
                if (value> ud.Maximum)
                    ud.Value = ud.Maximum;
                else
                    ud.Value = ud.Minimum;
            }
        }
        private void pbMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            handler_enabled = false;
            decimal scale;
            decimal centerX = udWidth.Value / pbMain.ClientSize.Width * e.X + udAnchorX.Value;
            decimal centerY = udHeigth.Value / pbMain.ClientSize.Height * e.Y + udAnchorY.Value;
            if (increase)
            {
                scale = 1 /(decimal)sizeChange;
            }
            else
            {
                scale = sizeChange;
            }
            SetUpDown(udWidth, udWidth.Value * scale);
            SetUpDown(udHeigth, udHeigth.Value * scale);
            SetUpDown(udAnchorX, centerX - (udWidth.Value / 2));
            SetUpDown(udAnchorY, centerY - (udHeigth.Value / 2));


            handler_enabled = true;
            DrawFractal();
        }

        private void buttonSave_MouseClick(object sender, MouseEventArgs e)
        {
            if ((saveBitmapDialog.ShowDialog() == DialogResult.OK) && (mandelbrot != null))
            {
                ImageFormat format;
                switch (saveBitmapDialog.FilterIndex)
                {
                    case 1:
                        format = ImageFormat.Bmp;
                        break;
                    case 2:
                        format = ImageFormat.Jpeg;
                        break;
                    default:
                        format = ImageFormat.Jpeg;
                        break;
                }
                mandelbrot.bmp.Save(saveBitmapDialog.FileName,format);
            }
        }

        private void btUp_MouseClick(object sender, MouseEventArgs e)
        {
            SetUpDown(udAnchorY, udAnchorY.Value - udHeigth.Value / 10);
            DrawFractal();
        }

        private void btDown_MouseClick(object sender, MouseEventArgs e)
        {
            SetUpDown(udAnchorY, udAnchorY.Value + udHeigth.Value / 10) ;

            DrawFractal();
        }

        private void btRight_MouseClick(object sender, MouseEventArgs e)
        {
            SetUpDown(udAnchorX, udAnchorX.Value + udWidth.Value / 10);

            DrawFractal();
        }

        private void btLeft_MouseClick(object sender, MouseEventArgs e)
        {
            SetUpDown(udAnchorX, udAnchorX.Value - udWidth.Value / 10);

            DrawFractal();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                color_choice = Int32.Parse((sender as Control).Tag.ToString());
            DrawFractal();
        }

        async void bIncrease_MouseClick(object sender, MouseEventArgs e)
        {
            int speed = 10;
            increase=!increase;
            if (increase)
            {
                for (int i = 0; i < 19; i++)
                {
                    //Task.Delay(10).GetAwaiter().GetResult();
                    await Task.Delay(speed);
                    pSwitchCircle.Location = new Point((pSwitchCircle.Location.X) - 1, (pSwitchCircle.Location.Y));
                    
                    
                }
                gbSize.Text = "Кратность увеличения:";
            }
            else
            {
                for (int i = 0; i < 19; i++)
                {
                    //Task.Delay(10).GetAwaiter().GetResult();
                    await Task.Delay(speed);
                    pSwitchCircle.Location = new Point((pSwitchCircle.Location.X) + 1, (pSwitchCircle.Location.Y));
                }
                gbSize.Text = "Кратность уменьшения:";
            }
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            tipUpdown.SetToolTip(sender as Control, (sender as NumericUpDown).Value.ToString());
            DrawFractal();
        }
    }
}
