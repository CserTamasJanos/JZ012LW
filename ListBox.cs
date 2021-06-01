using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feladatok12
{
    public partial class ListBox : Form
    {
        private int SelectedIndex
        { 
            get
            {
                if (listBox1.Items.Count > 0)
                {
                    return listBox1.SelectedIndex;
                }
                else return -1;
            }
        }

        public ListBox()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBoxNewText.Text);
            textBoxNewText.Text = string.Empty;
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            if(SelectedIndex > -1)
            {
                listBox1.Items.RemoveAt(SelectedIndex);
            }
        }
    }
}
