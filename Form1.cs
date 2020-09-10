using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HammingCodes
{
    public partial class Form1 : Form
    {
        private int rows = 4;
        private int cols = 4;
        private Queue<int> data = new Queue<int>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = cols;
            Enumerable.Range(0,rows - 1).ToList().ForEach(x => dataGridView1.Rows.Add(new DataGridViewRow()));
        }

        private void HamTheDataButton_Click(object sender, EventArgs e)
        {
            if (!DataMaskedTextBox.MaskFull) return;
            data.Clear();
            DataMaskedTextBox.Text.Split('-').ToList().Select(x => int.Parse(x)).ToList().ForEach(x => data.Enqueue(x));

            Ham4x4 ham = new Ham4x4(data.ToArray());
            int[,] gridData = ham.CreateGrid();
            for (int row = 0; row < gridData.GetLength(0); row++)
            {
                for (int col = 0; col < gridData.GetLength(1); col++)
                {
                    dataGridView1.Rows[row].Cells[col].Value = gridData[row, col];
                }
            }
        }
    }
}
