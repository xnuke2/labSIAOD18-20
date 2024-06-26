using System;

namespace labSIAOD18_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private const int length = 15;
        int[] arr = new int[length];
        int size = 0;
        int[] arrRezult = new int[length];
        int sizeRezult = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
            dataGridViewArray.RowCount = 1;
            dataGridViewArray.ColumnCount = length;
            for (int i = 0; i < dataGridViewArray.ColumnCount; i++)
            {
                dataGridViewArray.Columns[i].Width = Convert.ToInt32(dataGridViewArray.Width / dataGridViewArray.ColumnCount - 0.2);

            }
            dataGridViewTree.RowCount = 4;
            dataGridViewTree.ColumnCount = length;
            for (int i = 0; i < dataGridViewTree.ColumnCount; i++)
            {
                dataGridViewTree.Columns[i].Width = Convert.ToInt32(dataGridViewTree.Width / dataGridViewTree.ColumnCount - 0.2);
            }
            dataGridViewRezult.RowCount = 1;
            dataGridViewRezult.ColumnCount = length;
            for (int i = 0; i < dataGridViewRezult.ColumnCount; i++)
            {
                dataGridViewRezult.Columns[i].Width = Convert.ToInt32(dataGridViewRezult.Width / dataGridViewRezult.ColumnCount - 0.2);
            }
        }
        void Print()
        {
            printTree();
            for (int i1 = 0; i1 < arr.Length; i1++)
            {
                if (arr[i1]!=0) dataGridViewArray.Rows[0].Cells[i1].Value = arr[i1];
            }
            for (int i1 = 0; i1 < arrRezult.Length; i1++)
            {
                if (arrRezult[i1] != 0)
                {
                    dataGridViewRezult.Rows[0].Cells[i1].Value = arrRezult[i1];
                }
                else break;
                

            }
        }
        void printTree()
        {
            int i = 0;
            int j2 = 0;
            int numOfIter = 0;
            int tmp;
            while (i < arr.Length)
            {
                while (arr[i] == 0)
                {
                    i++;
                    if (i >= arr.Length) { return; }
                }
                switch (i)
                {
                    case 0:
                        dataGridViewTree.Rows[0].Cells[7].Value = arr[i];
                        break;
                    case <= 2:
                        tmp = 3 + (i - 1) * 8;
                        dataGridViewTree.Rows[1].Cells[tmp].Value = arr[i];
                        break;
                    case <= 6:
                        tmp = 1 + (i - 3) * 4;
                        dataGridViewTree.Rows[2].Cells[tmp].Value = arr[i];
                        break;
                    case <= 14:
                        tmp = (i - 7) * 2;
                        dataGridViewTree.Rows[3].Cells[tmp].Value = arr[i];
                        break;
                }
                i++;
                numOfIter++;
            }
        }
        void Add(int index, int num)
        {
            arr[index] = num;
            Up( index);
            size++;
        }

        void Up(int indexOfElement)
        {
            int i = indexOfElement;

            while (arr[i] > arr[(i - 1) / 2])
            {
                int tmp = arr[(i - 1) / 2];
                arr[(i - 1) / 2] = arr[i];
                arr[i] = tmp;
                i = (i - 1) / 2;
            }
        }
        void ClearArrays()
        {
            for (int i = 0; i < size; i++)
            {
                arr[i] = 0;
            }
            size = 0;
            for (int i = 0; i < sizeRezult; i++)
            {
                arrRezult[i] = 0;
            }
            sizeRezult = 0;
        }
        void Clear_Tab()
        {
            for (int i = 0; i < dataGridViewArray.Rows[0].Cells.Count; i++)
            {
                dataGridViewArray.Rows[0].Cells[i].Value = "";
            }
            for (int j = 0; j < dataGridViewTree.Rows.Count; j++)
                for (int i = 0; i < dataGridViewTree.Rows[0].Cells.Count; i++)
                    dataGridViewTree.Rows[j].Cells[i].Value = "";
            for (int i = 0; i < dataGridViewRezult.Rows[0].Cells.Count; i++)
            {
                dataGridViewRezult.Rows[0].Cells[i].Value = "";
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreateQueue_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            Clear_Tab();
            ClearArrays();
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                Add(i, rnd.Next(10, 99));
            }
            Print();
        }

        private void buttonClearQueue_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            ClearArrays();
            Clear_Tab();
        }
        private void butto�ExtractMax_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            if (size == 0) 
            { 
                labelError.Visible = true;
                labelError.Text = "������ ����";
                return;
            }
            if (sizeRezult == length)
            {
                labelError.Visible = true;
                labelError.Text = "������-��������� �����";
                return;
            }
            
            arrRezult[sizeRezult] = arr[0];
            sizeRezult++;
            Delete(0);
            Clear_Tab() ;
            Print();
        }

        int Delete(int i)
        {
            arr[i] = arr[size-1];
            arr[size - 1] = 0;
            Down(i);
            size--;
            return i;
        }
        private void Down(int index)
        {
            while (2 * index + 1 <= length)
            {
                
                int j = 2 * index + 1;
                if (j < arr.Length && arr[j] < arr[j + 1]) j++;
                if ((arr[index] >= arr[j])) break;
                    (arr[index], arr[j]) = (arr[j], arr[index]);
                index = j;
            }
        }
        private void buttonChangePriority_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            if(size==0) 
            { 
                labelError.Visible = true;
                labelError.Text = "������ ����";
                return;
            }
            int oldNum = Convert.ToInt32(numericUpDownChangePiorityOld.Value);
            int newNum = Convert.ToInt32(numericUpDownChangePiorityNew.Value);
            for (int i = 0; i < length; i++) 
            {
                if (arr[i] ==oldNum)
                {
                    arr[i] = newNum;
                    if (oldNum > newNum)
                        Down(i);
                    else 
                        Up(i);

                    Clear_Tab();
                    Print();
                    return;
                }
            }
            
            labelError.Visible = true;
            labelError.Text = "������� �� ������";
            return;
        }

        private void buttonPasteNew_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            if (size == length)
            {
                labelError.Visible = true;
                labelError.Text = "������ �����";
                return;
            }
            Add(size,Convert.ToInt32( numericUpDownNewElement.Value));
            Clear_Tab();
            Print();
        }
    }
}
