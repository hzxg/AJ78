﻿using Spire.Barcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJ78
{
    public delegate void childclose(string str);

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DoubleBufferedDataGirdView(true);

        }

        public Bitmap b;
        TreeNode rtn;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“databaseDataSet.Select_stockNum”中。您可以根据需要移动或移除它。
            this.select_stockNumTableAdapter.Fill(this.databaseDataSet.Select_stockNum);
            // TODO: 这行代码将数据加载到表“databaseDataSet.stockNum”中。您可以根据需要移动或移除它。
            this.stockNumTableAdapter.Fill(this.databaseDataSet.stockNum);
            // TODO: 这行代码将数据加载到表“databaseDataSet.recovered”中。您可以根据需要移动或移除它。
            this.recoveredTableAdapter.FillByNotDone(this.databaseDataSet.recovered);

            dateTimePicker1.Value = DateTime.Now;



        }

        private void button_getClipboardImage_Click(object sender, EventArgs e)
        {
            DataRefresh();
            if (Clipboard.ContainsImage())
            {
                // IMG1 = new Bitmap(ms);//取出照片1

                b = (Bitmap)Clipboard.GetImage();
                Bitmap bb = MakeGrayscale(b);
                // bb.Save("a.png");
                pictureBox1.Image = b;
                string[] data = BarcodeScanner.Scan(bb, BarCodeType.Code128);
                if (data.Length == 1)
                {
                    ChooseCode(data[0]);


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
                    ChooseCode f2 = new ChooseCode(li2); // 开一个子窗口
                    f2.choosecodeone += new childclose(ChooseCode);
                    f2.Show(); // 


                }
                else
                {
                    MessageBox.Show("扫码不到单号，请手动输入！");
                }


            }
            else
            {
                pictureBox1.Image = null;
                b = null;
            }



        }
        public bool Checksame(string str)
        {
            if (recoveredTableAdapter.GetDataByCode(str).Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void ChooseCode(string str)
        {
            // OutputLine(str +"关闭");
            // databaseDataSet.recovered.Rows.Add(null, DateTime.Now, str, null, null, null, imageToByte(b), null);


            if (Checksame(str))
            {
                MessageBox.Show("这个单号已存在");
                this.recoveredTableAdapter.FillByCode(this.databaseDataSet.recovered, str);
                databaseDataSet.recovered.Rows[0][6] = imageToByte(b);
                DataRefresh();


            }
            else
            {
                databaseDataSet.recovered.Rows.Add(null, DateTime.Now, str, null, null, null, imageToByte(b), null);
                DataRefresh();
            }
        }
        public void DataRefresh()
        {
            dataGridView1.EndEdit();
            recoveredTableAdapter.Update(databaseDataSet);
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ShowImage f2 = new ShowImage(pictureBox1.Image); // 开一个子窗口
                f2.Show(); // 
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            DataRefresh();
        }

        private void button_get_Click(object sender, EventArgs e)
        {
            DataRefresh();
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

            dataGridView1.Refresh();
            dataGridView1.Refresh();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
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


        private void button_SCode_Click(object sender, EventArgs e)
        {
            DataRefresh();
            if (textBox_code.Text.Length > 0)
            {
                this.recoveredTableAdapter.FillByCode(this.databaseDataSet.recovered, textBox_code.Text.Trim());
            }
        }

        private void button_SDate_Click(object sender, EventArgs e)
        {
            this.recoveredTableAdapter.FillByDateTime(this.databaseDataSet.recovered, dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button_add_Click(object sender, EventArgs e)
        {
            DataRefresh();
            databaseDataSet.recovered.Rows.Add(null, DateTime.Now, textBox_code.Text, null, null, null, null, null);
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //显示在HeaderCell上
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow r = this.dataGridView1.Rows[i];
                r.HeaderCell.Value = string.Format("{0}", i + 1);
            }
            this.dataGridView1.Refresh();
        }

        private void button_stockNum_Save_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            stockNumTableAdapter.Update(databaseDataSet);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text != "")
            {
                
            }
            this.select_stockNumTableAdapter.Fill(this.databaseDataSet.Select_stockNum);
            // TODO: 这行代码将数据加载到表“databaseDataSet.stockNum”中。您可以根据需要移动或移除它。
            this.stockNumTableAdapter.Fill(this.databaseDataSet.stockNum);
            // TODO: 这行代码将数据加载到表“databaseDataSet.recovered”中。您可以根据需要移动或移除它。
            this.recoveredTableAdapter.FillByNotDone(this.databaseDataSet.recovered);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtn.Text);
             
        }
        private void Output(string msg)
        {
            textBoxOutput.AppendText(msg);
            textBoxOutput.SelectionStart = textBoxOutput.Text.Length;
            textBoxOutput.ScrollToCaret();
            textBoxOutput.Refresh();
        }
        private void OutputLine(string msg)
        {
            Output(msg + "\r\n");
        }
        public int oi1, oi2, oi3;
        public void ClearNode(TreeNode tn)
        {
            foreach (TreeNode item in tn.Nodes)
            {
                if (item.Nodes.Count > 0)
                {
                    item.Text = Ignorecount(item.Text.Trim());
                    ClearNode(item);
                }
            }
        }
        public TreeNode tnt;
        public void sumToPnode(TreeNode tn)
        {
            TreeNode Ptn = tn.Parent;

                    oi1 = 0;
                    oi2 = 0;
                    oi3 = 0;
            foreach (TreeNode item in Ptn.Nodes)
            {
                string str = item.Text.Replace(item.Text.Substring(0, item.Text.IndexOf("[")), "");
                str = str.Replace("]", "");
                str = str.Replace("[", "");
                string[] values2 = str.ToString().Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                oi1 = oi1 + int.Parse(values2[0]);
                oi2 = oi2 + int.Parse(values2[1]);
                oi3 = oi3 + int.Parse(values2[2]);

                Ptn.Text = Ignorecount(Ptn.Text) + " [" + oi1 + "/" + oi2 + "/" + oi3 + "]";

            } 

        }
        public void SumNode(TreeNode tn)
        {

            foreach (TreeNode item in tn.Nodes)
            {
                if (item.Text.Contains(" [") == false)
                {
                    foreach (TreeNode item2 in item.Nodes)
                    {
                        if (item2.Text.Contains("[") ==true)
                        {
                            sumToPnode(item2);
                             
                        }
                        else
                        {
                            SumNode(item);
                        }

                    }
                }

            }
        }
        public void CaddNodes()
        {
            DataTable dtCopy = databaseDataSet.stockNum.Copy();

            DataView dv = databaseDataSet.stockNum.DefaultView;
            dv.Sort = "商家编码";
            dtCopy = dv.ToTable();
            DataTable dt = dtCopy;
            //TreeNode rtn = new TreeNode("ROOT");
            //treeView1.Nodes.Add(rtn);
            rtn = new TreeNode("ROOT [占用库存/可用库存/总库存]");

            foreach (DataRow dr in dt.Rows)
            {
                string[] values = dr[1].ToString().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                TreeNode tnt = rtn;
                for (int i = 0; i < values.Length; i++)
                {

                    TreeNode tntt = CFindNode(tnt, values[i]);
                    if (tntt == null)
                    {

                        tnt.Nodes.Add(values[i] + " [" + (int)dr[2] + "/" + (int)dr[3] + "/" + (int)dr[4] + "]");


                        tnt = CFindNode(tnt, values[i]);

                    }
                    else

                    {
                        tnt = tntt;

                    }


                }

            }
        }
        private TreeNode CFindNode(TreeNode tnp, string str)
        {
            if (tnp == null)
            {
                return null;
            }
            if (Ignorecount(tnp.Text) == str)
            {
                return tnp;
            }
            TreeNode tnT = null;
            foreach (TreeNode tn in tnp.Nodes)
            {
                tnT = CFindNode(tn, str);
                if (tnT != null)
                {
                    break;
                }

            }
            return tnT;
        } 
        public string Ignorecount(string str)
        {
            if (str.Contains("["))
            {
                return str.Substring(0, str.IndexOf("[") - 1);
            }
            else
            {
                return str;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CaddNodes();
            ClearNode(rtn);
            SumNode(rtn);
            //sumToPnode(rtn.Nodes[0]);
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(rtn);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            databaseDataSet.stockNum.Rows.Add(null, "AJ001-M", 1, 1, 1);
            databaseDataSet.stockNum.Rows.Add(null, "AJ001-L", 10, 10, 10);
            databaseDataSet.stockNum.Rows.Add(null, "AJ002-白-M", 100, 100, 100);
            databaseDataSet.stockNum.Rows.Add(null, "AJ002-白-L", 1000, 1000, 1000);
            databaseDataSet.stockNum.Rows.Add(null, "AJ002-白-XL", 10000, 10000, 10000);
            databaseDataSet.stockNum.Rows.Add(null, "AJ002-黑-M", 100000, 100000, 100000);
            databaseDataSet.stockNum.Rows.Add(null, "AJ002-黑-L", 1000000, 1000000, 1000000);
            databaseDataSet.stockNum.Rows.Add(null, "AJ002-黑-XL", 10000000, 10000000, 10000000);
            databaseDataSet.stockNum.Rows.Add(null, "AJ003-M", 100000000, 100000000, 100000000);
            databaseDataSet.stockNum.Rows.Add(null, "AJ004-L", 1000000000, 1000000000, 1000000000);

            stockNumTableAdapter.Update(databaseDataSet);
        }

        private void button_sumUsable_Click(object sender, EventArgs e)
        {
            sumUsable();
        }
        public void sumUsable()
        {
            foreach (DataRow dr in databaseDataSet.stockNum)
            {
                dr[3] = (int)dr[4] - (int)dr[2];
            }
        }

        public class CustomDGVComboBoxCell : DataGridViewComboBoxCell
        {
            public override void InitializeEditingControl(int rowIndex, object initialFormattedValue,
                DataGridViewCellStyle dataGridViewCellStyle)
            {
                base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

                ComboBox comboBox = (ComboBox)base.DataGridView.EditingControl;
                if (comboBox != null)
                {
                    comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                    comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;

                }
            }

            protected override object GetFormattedValue(object value, int rowIndex,
                 ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter,
                 TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
            {
                return base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
            }

        }

        public class CustomDGVComboBoxColumn : DataGridViewComboBoxColumn
        {
            public CustomDGVComboBoxColumn()
            {
                CustomDGVComboBoxCell obj = new CustomDGVComboBoxCell();
                this.CellTemplate = obj;
            }
        }

    }
    public static class DoubleBufferDataGridView
    {
        /// <summary>
        /// 双缓冲，解决闪烁问题
        /// </summary>
        public static void DoubleBufferedDataGirdView(this DataGridView dgv, bool flag)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, flag, null);
        }
    }
}