using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJ78
{
    public partial class ShowImage : Form
    {
        public Image simg;
        public ShowImage(Image img)
        {
            simg = img;
            InitializeComponent();
        }

        private void ShowImage_Load(object sender, EventArgs e)
        {
           
            this.Width = (simg.Width+10)/2;
            this.Height = (simg.Height+10)/2;
            pictureBox1.Image = simg;
        }
    }
}
