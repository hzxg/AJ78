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
    public partial class ChooseCode : Form
    {
        public List<string> code
;        public ChooseCode(List<string> str)
        {
            code = str;
            InitializeComponent();
        }
        public event childclose choosecodeone;
        private void ChooseCode_Load(object sender, EventArgs e)
        {
            this.Top = MousePosition.Y -120;
            this.Left = MousePosition.X - 150;
            foreach (var item in code)
            {
                dataGridView1.Rows.Add(item);
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >-1)
            {
                 
                choosecodeone((string)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
