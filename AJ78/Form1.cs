using Spire.Barcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJ78
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_getClipboardImage_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                // IMG1 = new Bitmap(ms);//取出照片1

                Bitmap b = (Bitmap)Clipboard.GetImage();
                Bitmap bb = MakeGrayscale(b);
                // bb.Save("a.png");
                pictureBox1.Image = b;
                string[] data = BarcodeScanner.Scan(bb, BarCodeType.Code128);
                if (data.Length == 1)
                {
                    databaseDataSet.recovered.Rows.Add(null, DateTime.Now, data[0], null, null, null, imageToByte(b),null);
                }
                else if (data.Length > 1)
                {
                    List<string> li2 = new List<string>(data);
                    for (int i = 0; i < li2.Count; i++)  //外循环是循环的次数
                    {
                        for (int j = li2.Count - 1; j > i; j--)  //内循环是 外循环一次比较的次数
                        {

                            if (li2[i] == li2[j])
                            {
                                li2.RemoveAt(j);
                            }

                        }
                    }
                    foreach (var item in li2)
                    {
                        databaseDataSet.recovered.Rows.Add(null, DateTime.Now, item, null, null, null, imageToByte(b),null);
                    }
                }
                else
                {
                    MessageBox.Show("扫码不到单号，请手动输入！");
                }


            }
            else
            {
                pictureBox1.Image = null;
            }
             


        }
        public Bitmap MakeGrayscale(Bitmap original)
        {
            // You need to create a new bitmap with size the same as image original, 
            // then create a color matrix and convert a color image to grayscale with C#.
            Bitmap newBmp = new Bitmap(original.Width, original.Height);
            Graphics g = Graphics.FromImage(newBmp);
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                   new float[] {.3f, .3f, .3f, 0, 0},
                   new float[] {.59f, .59f, .59f, 0, 0},
                   new float[] {.11f, .11f, .11f, 0, 0},
                   new float[] {0, 0, 0, 1, 0},
                   new float[] {0, 0, 0, 0, 1}
               });
            ImageAttributes img = new ImageAttributes();
            img.SetColorMatrix(colorMatrix);
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, img);
            g.Dispose();
            return newBmp;
        }
        //将image转换成byte[]数据
        private byte[] imageToByte(System.Drawing.Image _image)
        {
            MemoryStream ms = new MemoryStream();
            _image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        //将byte[]数据转换成image
        private Image byteToImage(byte[] myByte)
        {
            MemoryStream ms = new MemoryStream(myByte);
            Image _Image = Image.FromStream(ms);
            return _Image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“databaseDataSet.recovered”中。您可以根据需要移动或移除它。
            this.recoveredTableAdapter.Fill(this.databaseDataSet.recovered);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowImage f2 = new ShowImage(pictureBox1.Image); // 开一个子窗口
            f2.Show(); // 
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            recoveredTableAdapter.Update(databaseDataSet);
        }

        private void button_get_Click(object sender, EventArgs e)
        {
            if (radioButton_all.Checked)
            {
                this.recoveredTableAdapter.Fill(this.databaseDataSet.recovered);
            }
            else if (radioButton_NotDone.Checked)
            {
                this.recoveredTableAdapter.FillByNotDone(this.databaseDataSet.recovered);
            }
            else if (radioButton_Done.Checked)
            {
                this.recoveredTableAdapter.FillByDone(this.databaseDataSet.recovered, dateTimePicker1.Value.AddDays(-7), dateTimePicker1.Value.AddDays(1));
            }
            else if (radioButton_Date.Checked)
            {
                this.recoveredTableAdapter.FillByDateTime(this.databaseDataSet.recovered, dateTimePicker1.Value, dateTimePicker1.Value.AddDays(1));
            }
            else if (radioButton_code.Checked)
            {
                if (textBox_code.Text.Length >0)
                {
                    this.recoveredTableAdapter.FillByCode(this.databaseDataSet.recovered,textBox_code.Text.Trim());
                }
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >-1)
            {
                try
                {
                    pictureBox1.Image = byteToImage((byte[])dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                }
                catch (Exception)
                {

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   

           
        }
    }
}
