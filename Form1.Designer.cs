namespace labSIAOD18_20
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCreateQueue = new Button();
            buttonClearQueue = new Button();
            buttoтExtractMax = new Button();
            buttonPasteNew = new Button();
            buttonChangePriority = new Button();
            numericUpDownNewElement = new NumericUpDown();
            numericUpDownChangePiorityOld = new NumericUpDown();
            numericUpDownChangePiorityNew = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            labelError = new Label();
            buttonExit = new Button();
            dataGridViewRezult = new DataGridView();
            label5 = new Label();
            dataGridViewTree = new DataGridView();
            label4 = new Label();
            dataGridViewArray = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewElement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChangePiorityOld).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChangePiorityNew).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRezult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArray).BeginInit();
            SuspendLayout();
            // 
            // buttonCreateQueue
            // 
            buttonCreateQueue.Location = new Point(26, 13);
            buttonCreateQueue.Name = "buttonCreateQueue";
            buttonCreateQueue.Size = new Size(192, 29);
            buttonCreateQueue.TabIndex = 0;
            buttonCreateQueue.Text = "Создать очередь";
            buttonCreateQueue.UseVisualStyleBackColor = true;
            buttonCreateQueue.Click += buttonCreateQueue_Click;
            // 
            // buttonClearQueue
            // 
            buttonClearQueue.Location = new Point(328, 13);
            buttonClearQueue.Name = "buttonClearQueue";
            buttonClearQueue.Size = new Size(192, 29);
            buttonClearQueue.TabIndex = 1;
            buttonClearQueue.Text = "Очистить очередь";
            buttonClearQueue.UseVisualStyleBackColor = true;
            buttonClearQueue.Click += buttonClearQueue_Click;
            // 
            // buttoтExtractMax
            // 
            buttoтExtractMax.Location = new Point(629, 13);
            buttoтExtractMax.Name = "buttoтExtractMax";
            buttoтExtractMax.Size = new Size(192, 29);
            buttoтExtractMax.TabIndex = 2;
            buttoтExtractMax.Text = "Извлечь наибольший";
            buttoтExtractMax.UseVisualStyleBackColor = true;
            buttoтExtractMax.Click += buttoтExtractMax_Click;
            // 
            // buttonPasteNew
            // 
            buttonPasteNew.Location = new Point(26, 64);
            buttonPasteNew.Name = "buttonPasteNew";
            buttonPasteNew.Size = new Size(192, 29);
            buttonPasteNew.TabIndex = 3;
            buttonPasteNew.Text = "Вставить новый";
            buttonPasteNew.UseVisualStyleBackColor = true;
            buttonPasteNew.Click += buttonPasteNew_Click;
            // 
            // buttonChangePriority
            // 
            buttonChangePriority.Location = new Point(407, 67);
            buttonChangePriority.Name = "buttonChangePriority";
            buttonChangePriority.Size = new Size(192, 29);
            buttonChangePriority.TabIndex = 4;
            buttonChangePriority.Text = "Изменить приоритет";
            buttonChangePriority.UseVisualStyleBackColor = true;
            buttonChangePriority.Click += buttonChangePriority_Click;
            // 
            // numericUpDownNewElement
            // 
            numericUpDownNewElement.Location = new Point(224, 65);
            numericUpDownNewElement.Name = "numericUpDownNewElement";
            numericUpDownNewElement.Size = new Size(75, 27);
            numericUpDownNewElement.TabIndex = 5;
            // 
            // numericUpDownChangePiorityOld
            // 
            numericUpDownChangePiorityOld.Location = new Point(629, 67);
            numericUpDownChangePiorityOld.Name = "numericUpDownChangePiorityOld";
            numericUpDownChangePiorityOld.Size = new Size(75, 27);
            numericUpDownChangePiorityOld.TabIndex = 6;
            // 
            // numericUpDownChangePiorityNew
            // 
            numericUpDownChangePiorityNew.Location = new Point(741, 67);
            numericUpDownChangePiorityNew.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownChangePiorityNew.Name = "numericUpDownChangePiorityNew";
            numericUpDownChangePiorityNew.Size = new Size(75, 27);
            numericUpDownChangePiorityNew.TabIndex = 7;
            numericUpDownChangePiorityNew.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(606, 69);
            label1.Name = "label1";
            label1.Size = new Size(16, 20);
            label1.TabIndex = 8;
            label1.Text = "c";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(709, 69);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 9;
            label2.Text = "на";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(buttonCreateQueue);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonClearQueue);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttoтExtractMax);
            panel1.Controls.Add(numericUpDownChangePiorityNew);
            panel1.Controls.Add(buttonPasteNew);
            panel1.Controls.Add(numericUpDownChangePiorityOld);
            panel1.Controls.Add(buttonChangePriority);
            panel1.Controls.Add(numericUpDownNewElement);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 115);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(labelError);
            panel2.Controls.Add(buttonExit);
            panel2.Controls.Add(dataGridViewRezult);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dataGridViewTree);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dataGridViewArray);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(11, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(870, 372);
            panel2.TabIndex = 11;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(577, 81);
            labelError.Name = "labelError";
            labelError.Size = new Size(50, 20);
            labelError.TabIndex = 10;
            labelError.Text = "label6";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(729, 317);
            buttonExit.Margin = new Padding(3, 4, 3, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(136, 49);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // dataGridViewRezult
            // 
            dataGridViewRezult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRezult.ColumnHeadersVisible = false;
            dataGridViewRezult.Location = new Point(5, 279);
            dataGridViewRezult.Name = "dataGridViewRezult";
            dataGridViewRezult.RowHeadersVisible = false;
            dataGridViewRezult.RowHeadersWidth = 50;
            dataGridViewRezult.Size = new Size(861, 32);
            dataGridViewRezult.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(360, 256);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 4;
            label5.Text = "Результат выборки";
            // 
            // dataGridViewTree
            // 
            dataGridViewTree.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTree.ColumnHeadersVisible = false;
            dataGridViewTree.Location = new Point(3, 116);
            dataGridViewTree.Name = "dataGridViewTree";
            dataGridViewTree.RowHeadersVisible = false;
            dataGridViewTree.RowHeadersWidth = 50;
            dataGridViewTree.Size = new Size(862, 137);
            dataGridViewTree.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(318, 81);
            label4.Name = "label4";
            label4.Size = new Size(227, 20);
            label4.TabIndex = 2;
            label4.Text = "Представление в виде дерева";
            // 
            // dataGridViewArray
            // 
            dataGridViewArray.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArray.ColumnHeadersVisible = false;
            dataGridViewArray.Location = new Point(3, 32);
            dataGridViewArray.Name = "dataGridViewArray";
            dataGridViewArray.RowHeadersVisible = false;
            dataGridViewArray.RowHeadersWidth = 50;
            dataGridViewArray.Size = new Size(862, 32);
            dataGridViewArray.TabIndex = 1;
            dataGridViewArray.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(318, 9);
            label3.Name = "label3";
            label3.Size = new Size(236, 20);
            label3.TabIndex = 0;
            label3.Text = "Представление в виде массива";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 507);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Лабораторная работа 18-20 Хмыренков";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewElement).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChangePiorityOld).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChangePiorityNew).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRezult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTree).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArray).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCreateQueue;
        private Button buttonClearQueue;
        private Button buttoтExtractMax;
        private Button buttonPasteNew;
        private Button buttonChangePriority;
        private NumericUpDown numericUpDownNewElement;
        private NumericUpDown numericUpDownChangePiorityOld;
        private NumericUpDown numericUpDownChangePiorityNew;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewArray;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewTree;
        private DataGridView dataGridViewRezult;
        private Label label5;
        private Button buttonExit;
        private Label labelError;
    }
}
