using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5Jumat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxKiri_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            if (comboBoxMode.SelectedIndex == 0)
            {
                listBoxKiri.Items.Add(textBoxInput.Text);
                textBoxInput.Text = "";
                textBoxInput.Focus();
            }
            else if (comboBoxMode.SelectedIndex == 1)
            {
                if (listBoxKiri.Items.Count == 1)
                {
                    int counter = listBoxKiri.SelectedIndex;
                    listBoxKiri.Items.RemoveAt(counter);
                    listBoxKiri.Items.Insert(counter, textBoxInput.Text);
                }
            }
            else
            {
                MessageBox.Show("Mode Belum Dipilih");
            }
        }

        private void checkBoxBlock_CheckedChanged(object sender, EventArgs e)
        {            
                buttonKKanan.Enabled = false;
                buttonKanan.Enabled = false;
                buttonKKiri.Enabled = false;
                buttonKiri.Enabled = false;
                buttonHapus.Enabled = false;            
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            for (int i = listBoxKiri.SelectedIndices.Count -1; i>= 0; i--)
            {
                listBoxKiri.Items.RemoveAt(listBoxKiri.SelectedIndices[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxKiri.SelectionMode = SelectionMode.MultiSimple;
            listBoxKanan.SelectionMode = SelectionMode.MultiSimple;
        }

        private void buttonKKanan_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxKiri.Items)
            {
                listBoxKanan.Items.Add(item.ToString());
            }
            listBoxKiri.Items.Clear();
        }

        private void buttonKanan_Click(object sender, EventArgs e)
        {
            if (listBoxKiri.SelectedItem != null)
            {
                while (listBoxKiri.SelectedItems.Count == 1)
                {
                    listBoxKanan.Items.Add(listBoxKiri.SelectedItem);
                    listBoxKiri.Items.Remove(listBoxKiri.SelectedItem);
                }
            }
        }

        private void buttonKiri_Click(object sender, EventArgs e)
        {
            if (listBoxKanan.SelectedItem != null)
            {
                while (listBoxKanan.SelectedItems.Count == 1)
                {
                    listBoxKiri.Items.Add(listBoxKanan.SelectedItem);
                    listBoxKanan.Items.Remove(listBoxKanan.SelectedItem);
                }
            }
        }

        private void buttonKKiri_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxKanan.Items)
            {
                listBoxKiri.Items.Add(item.ToString());
            }
            listBoxKanan.Items.Clear();
        }
    }
}
