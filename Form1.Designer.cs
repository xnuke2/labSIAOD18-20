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
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewElement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChangePiorityOld).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChangePiorityNew).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonCreateQueue
            // 
            buttonCreateQueue.Location = new Point(3, 13);
            buttonCreateQueue.Name = "buttonCreateQueue";
            buttonCreateQueue.Size = new Size(192, 29);
            buttonCreateQueue.TabIndex = 0;
            buttonCreateQueue.Text = "Создать очередь";
            buttonCreateQueue.UseVisualStyleBackColor = true;
            // 
            // buttonClearQueue
            // 
            buttonClearQueue.Location = new Point(239, 13);
            buttonClearQueue.Name = "buttonClearQueue";
            buttonClearQueue.Size = new Size(192, 29);
            buttonClearQueue.TabIndex = 1;
            buttonClearQueue.Text = "Очистить очередь";
            buttonClearQueue.UseVisualStyleBackColor = true;
            // 
            // buttoтExtractMax
            // 
            buttoтExtractMax.Location = new Point(463, 13);
            buttoтExtractMax.Name = "buttoтExtractMax";
            buttoтExtractMax.Size = new Size(192, 29);
            buttoтExtractMax.TabIndex = 2;
            buttoтExtractMax.Text = "Извлечь наибольший";
            buttoтExtractMax.UseVisualStyleBackColor = true;
            buttoтExtractMax.Click += buttoтExtractMax_Click;
            // 
            // buttonPasteNew
            // 
            buttonPasteNew.Location = new Point(3, 61);
            buttonPasteNew.Name = "buttonPasteNew";
            buttonPasteNew.Size = new Size(192, 29);
            buttonPasteNew.TabIndex = 3;
            buttonPasteNew.Text = "Вставить новый";
            buttonPasteNew.UseVisualStyleBackColor = true;
            // 
            // buttonChangePriority
            // 
            buttonChangePriority.Location = new Point(315, 61);
            buttonChangePriority.Name = "buttonChangePriority";
            buttonChangePriority.Size = new Size(192, 29);
            buttonChangePriority.TabIndex = 4;
            buttonChangePriority.Text = "Изменить приоритет";
            buttonChangePriority.UseVisualStyleBackColor = true;
            // 
            // numericUpDownNewElement
            // 
            numericUpDownNewElement.Location = new Point(201, 63);
            numericUpDownNewElement.Name = "numericUpDownNewElement";
            numericUpDownNewElement.Size = new Size(75, 27);
            numericUpDownNewElement.TabIndex = 5;
            // 
            // numericUpDownChangePiorityOld
            // 
            numericUpDownChangePiorityOld.Location = new Point(548, 63);
            numericUpDownChangePiorityOld.Name = "numericUpDownChangePiorityOld";
            numericUpDownChangePiorityOld.Size = new Size(75, 27);
            numericUpDownChangePiorityOld.TabIndex = 6;
            // 
            // numericUpDownChangePiorityNew
            // 
            numericUpDownChangePiorityNew.Location = new Point(661, 63);
            numericUpDownChangePiorityNew.Name = "numericUpDownChangePiorityNew";
            numericUpDownChangePiorityNew.Size = new Size(75, 27);
            numericUpDownChangePiorityNew.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 65);
            label1.Name = "label1";
            label1.Size = new Size(16, 20);
            label1.TabIndex = 8;
            label1.Text = "c";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(629, 65);
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 114);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 306);
            panel2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(271, 9);
            label3.Name = "label3";
            label3.Size = new Size(236, 20);
            label3.TabIndex = 0;
            label3.Text = "Представление в виде массива";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15 });
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.Size = new Size(770, 32);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 50;
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 50;
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 50;
            // 
            // Column8
            // 
            Column8.HeaderText = "Column8";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 50;
            // 
            // Column9
            // 
            Column9.HeaderText = "Column9";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 50;
            // 
            // Column10
            // 
            Column10.HeaderText = "Column10";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 50;
            // 
            // Column11
            // 
            Column11.HeaderText = "Column11";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 50;
            // 
            // Column12
            // 
            Column12.HeaderText = "Column12";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 50;
            // 
            // Column13
            // 
            Column13.HeaderText = "Column13";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Width = 50;
            // 
            // Column14
            // 
            Column14.HeaderText = "Column14";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.Width = 50;
            // 
            // Column15
            // 
            Column15.HeaderText = "Column15";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.Width = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewElement).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChangePiorityOld).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChangePiorityNew).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
    }
}
