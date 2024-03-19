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

        private void buttoòExtractMax_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewArray.RowCount = 1;
            dataGridViewArray.ColumnCount = 15;
            for (int i = 0; i < dataGridViewArray.ColumnCount; i++)
            {
                dataGridViewArray.Columns[i].Width = Convert.ToInt32(dataGridViewArray.Width / dataGridViewArray.ColumnCount - 0.2);

            }
            dataGridViewTree.RowCount = 4;
            dataGridViewTree.ColumnCount = 15;
            for (int i = 0; i < dataGridViewTree.ColumnCount; i++)
            {
                dataGridViewTree.Columns[i].Width = Convert.ToInt32(dataGridViewTree.Width / dataGridViewTree.ColumnCount - 0.2);
            }
            dataGridViewRezult.RowCount = 1;
            dataGridViewRezult.ColumnCount = 15;
            for (int i = 0; i < dataGridViewRezult.ColumnCount; i++)
            {
                dataGridViewRezult.Columns[i].Width = Convert.ToInt32(dataGridViewRezult.Width / dataGridViewRezult.ColumnCount - 0.2);
            }
        }
        void Print(int[] array)
        {
            int i = 0;
            int j = 3;
            int j1 = 1;
            int j2 = 0;
            int numOfIter = 0;
            while (i < array.Length)
            {
                while (array[i] == 0)
                {
                    i++;
                    if (i >= array.Length) { return; }
                }
                switch (numOfIter)
                {
                    case 0:
                        dataGridViewTree.Rows[0].Cells[7].Value = array[i];
                        break;
                    case <= 2:
                        dataGridViewTree.Rows[1].Cells[j].Value = array[i];
                        j += 8;
                        break;
                    case <= 6:
                        dataGridViewTree.Rows[2].Cells[j1].Value = array[i];
                        j1 += 4;
                        break;
                    case <= 14:
                        dataGridViewTree.Rows[3].Cells[j2].Value = array[i];
                        j2 += 2;
                        break;
                }
                i++;
                numOfIter++;
            }
        }

        void Add(int[] array,int index, int num)
        {
            array[index] = num;
            Up(array, index);
        }

        void Up(int[] array, int indexOfElement) 
        {
            int i = indexOfElement;

            while (array[i] > array[(i-1)/2])
            {
                int tmp = array[(i - 1) / 2];
                array[(i - 1) / 2] = array[i];
                array[i] = tmp;
                i=(i-1)/2;
            }
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
            Clear_Tab();
            int[] arr = new int[15];
            for(int i =0 ; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                Add(arr,i, rnd.Next(10, 99));
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                dataGridViewArray.Rows[0].Cells[i].Value = arr[i];
            }
            Print(arr);
        }

        private void buttonClearQueue_Click(object sender, EventArgs e)
        {
            Clear_Tab();
        }
    }
}
