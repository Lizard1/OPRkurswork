namespace KursWorkOPR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataForGenerations = new System.Windows.Forms.DataGridView();
            this.Generation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nosob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X1X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBestPerson = new System.Windows.Forms.DataGridView();
            this.textBoxForP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Npoints = new System.Windows.Forms.NumericUpDown();
            this.numGenerations = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chanceOfMutate = new System.Windows.Forms.NumericUpDown();
            this.X1Rest1 = new System.Windows.Forms.NumericUpDown();
            this.X2Rest1 = new System.Windows.Forms.NumericUpDown();
            this.X1Rest2 = new System.Windows.Forms.NumericUpDown();
            this.X2Rest2 = new System.Windows.Forms.NumericUpDown();
            this.Restrictions = new System.Windows.Forms.Label();
            this.X1ord = new System.Windows.Forms.Label();
            this.X2ord = new System.Windows.Forms.Label();
            this.textBoxForFunction = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.butPointGener = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxForCrossing = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownIterationsCount = new System.Windows.Forms.NumericUpDown();
            this.GenerationB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chanceOfMutateB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chanceOfCrossing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodDrop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBestPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Npoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chanceOfMutate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Rest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Rest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Rest2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Rest2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterationsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(745, 497);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataForGenerations
            // 
            this.dataForGenerations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataForGenerations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Generation,
            this.Number,
            this.Nosob,
            this.X1,
            this.X2,
            this.X1X2,
            this.Function});
            this.dataForGenerations.Location = new System.Drawing.Point(-5, 515);
            this.dataForGenerations.Name = "dataForGenerations";
            this.dataForGenerations.Size = new System.Drawing.Size(487, 214);
            this.dataForGenerations.TabIndex = 1;
            // 
            // Generation
            // 
            this.Generation.HeaderText = "Поколение";
            this.Generation.Name = "Generation";
            this.Generation.Width = 70;
            // 
            // Number
            // 
            this.Number.FillWeight = 20F;
            this.Number.HeaderText = "N";
            this.Number.Name = "Number";
            this.Number.Width = 40;
            // 
            // Nosob
            // 
            this.Nosob.HeaderText = "Nosob";
            this.Nosob.Name = "Nosob";
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.Name = "X1";
            this.X1.Width = 50;
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.Name = "X2";
            this.X2.Width = 50;
            // 
            // X1X2
            // 
            this.X1X2.HeaderText = "X1X2";
            this.X1X2.Name = "X1X2";
            this.X1X2.Width = 150;
            // 
            // Function
            // 
            this.Function.HeaderText = "Ф.Присп.";
            this.Function.Name = "Function";
            this.Function.Width = 80;
            // 
            // dataGridViewBestPerson
            // 
            this.dataGridViewBestPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBestPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GenerationB,
            this.chanceOfMutateB,
            this.chanceOfCrossing,
            this.functionCount,
            this.methodDrop,
            this.Value});
            this.dataGridViewBestPerson.Location = new System.Drawing.Point(513, 515);
            this.dataGridViewBestPerson.Name = "dataGridViewBestPerson";
            this.dataGridViewBestPerson.Size = new System.Drawing.Size(540, 214);
            this.dataGridViewBestPerson.TabIndex = 1;
            // 
            // textBoxForP
            // 
            this.textBoxForP.Location = new System.Drawing.Point(921, 128);
            this.textBoxForP.Name = "textBoxForP";
            this.textBoxForP.Size = new System.Drawing.Size(100, 20);
            this.textBoxForP.TabIndex = 5;
            this.textBoxForP.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество начальных точек (N): ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Npoints
            // 
            this.Npoints.Location = new System.Drawing.Point(946, 100);
            this.Npoints.Name = "Npoints";
            this.Npoints.Size = new System.Drawing.Size(74, 20);
            this.Npoints.TabIndex = 7;
            this.Npoints.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numGenerations
            // 
            this.numGenerations.AutoSize = true;
            this.numGenerations.Location = new System.Drawing.Point(764, 128);
            this.numGenerations.Name = "numGenerations";
            this.numGenerations.Size = new System.Drawing.Size(88, 13);
            this.numGenerations.TabIndex = 8;
            this.numGenerations.Text = "Поколения  (P): ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(764, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Вероятность мутации (M):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // chanceOfMutate
            // 
            this.chanceOfMutate.Location = new System.Drawing.Point(921, 157);
            this.chanceOfMutate.Name = "chanceOfMutate";
            this.chanceOfMutate.Size = new System.Drawing.Size(100, 20);
            this.chanceOfMutate.TabIndex = 16;
            this.chanceOfMutate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // X1Rest1
            // 
            this.X1Rest1.Location = new System.Drawing.Point(768, 26);
            this.X1Rest1.Name = "X1Rest1";
            this.X1Rest1.Size = new System.Drawing.Size(86, 20);
            this.X1Rest1.TabIndex = 18;
            this.X1Rest1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // X2Rest1
            // 
            this.X2Rest1.Location = new System.Drawing.Point(768, 52);
            this.X2Rest1.Name = "X2Rest1";
            this.X2Rest1.Size = new System.Drawing.Size(86, 20);
            this.X2Rest1.TabIndex = 19;
            this.X2Rest1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // X1Rest2
            // 
            this.X1Rest2.Location = new System.Drawing.Point(898, 26);
            this.X1Rest2.Name = "X1Rest2";
            this.X1Rest2.Size = new System.Drawing.Size(85, 20);
            this.X1Rest2.TabIndex = 18;
            this.X1Rest2.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // X2Rest2
            // 
            this.X2Rest2.Location = new System.Drawing.Point(898, 52);
            this.X2Rest2.Name = "X2Rest2";
            this.X2Rest2.Size = new System.Drawing.Size(85, 20);
            this.X2Rest2.TabIndex = 19;
            this.X2Rest2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Restrictions
            // 
            this.Restrictions.AutoSize = true;
            this.Restrictions.Location = new System.Drawing.Point(763, 10);
            this.Restrictions.Name = "Restrictions";
            this.Restrictions.Size = new System.Drawing.Size(79, 13);
            this.Restrictions.TabIndex = 20;
            this.Restrictions.Text = "Ограничения: ";
            // 
            // X1ord
            // 
            this.X1ord.AutoSize = true;
            this.X1ord.Location = new System.Drawing.Point(860, 28);
            this.X1ord.Name = "X1ord";
            this.X1ord.Size = new System.Drawing.Size(32, 13);
            this.X1ord.TabIndex = 21;
            this.X1ord.Text = ": X1 :";
            // 
            // X2ord
            // 
            this.X2ord.AutoSize = true;
            this.X2ord.Location = new System.Drawing.Point(860, 55);
            this.X2ord.Name = "X2ord";
            this.X2ord.Size = new System.Drawing.Size(32, 13);
            this.X2ord.TabIndex = 22;
            this.X2ord.Text = ": X2 :";
            // 
            // textBoxForFunction
            // 
            this.textBoxForFunction.Location = new System.Drawing.Point(891, 274);
            this.textBoxForFunction.Name = "textBoxForFunction";
            this.textBoxForFunction.Size = new System.Drawing.Size(132, 20);
            this.textBoxForFunction.TabIndex = 23;
            this.textBoxForFunction.Text = "(10*((x-y)+1)^2)/(x+y)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(765, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Введите функцию: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(891, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Отобрать точки рандомного наброса\r\n\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butPointGener
            // 
            this.butPointGener.Location = new System.Drawing.Point(768, 212);
            this.butPointGener.Name = "butPointGener";
            this.butPointGener.Size = new System.Drawing.Size(117, 23);
            this.butPointGener.TabIndex = 29;
            this.butPointGener.Text = "Случайный наброс";
            this.butPointGener.UseVisualStyleBackColor = true;
            this.butPointGener.Click += new System.EventHandler(this.butPointGener_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(768, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Наброс сеткой";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(765, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Коэффициент скрещивания: ";
            // 
            // textBoxForCrossing
            // 
            this.textBoxForCrossing.Location = new System.Drawing.Point(921, 183);
            this.textBoxForCrossing.Name = "textBoxForCrossing";
            this.textBoxForCrossing.Size = new System.Drawing.Size(102, 20);
            this.textBoxForCrossing.TabIndex = 36;
            this.textBoxForCrossing.Text = "4";
            this.textBoxForCrossing.TextChanged += new System.EventHandler(this.textBoxForCrossing_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(891, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "Отобрать точки в сетке";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1098, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "Шаг";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1039, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "УОС :";
            // 
            // numericUpDownIterationsCount
            // 
            this.numericUpDownIterationsCount.Location = new System.Drawing.Point(1081, 100);
            this.numericUpDownIterationsCount.Name = "numericUpDownIterationsCount";
            this.numericUpDownIterationsCount.Size = new System.Drawing.Size(72, 20);
            this.numericUpDownIterationsCount.TabIndex = 40;
            this.numericUpDownIterationsCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // GenerationB
            // 
            this.GenerationB.HeaderText = "Поколение";
            this.GenerationB.Name = "GenerationB";
            // 
            // chanceOfMutateB
            // 
            this.chanceOfMutateB.HeaderText = "Вероятность мутации";
            this.chanceOfMutateB.Name = "chanceOfMutateB";
            // 
            // chanceOfCrossing
            // 
            this.chanceOfCrossing.HeaderText = "Коэффициент скрещивания";
            this.chanceOfCrossing.Name = "chanceOfCrossing";
            // 
            // functionCount
            // 
            this.functionCount.HeaderText = "Функция приспособленности";
            this.functionCount.MinimumWidth = 10;
            this.functionCount.Name = "functionCount";
            // 
            // methodDrop
            // 
            this.methodDrop.HeaderText = "Метод наброса";
            this.methodDrop.Name = "methodDrop";
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение функции";
            this.Value.Name = "Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 741);
            this.Controls.Add(this.numericUpDownIterationsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxForCrossing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butPointGener);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxForFunction);
            this.Controls.Add(this.X2ord);
            this.Controls.Add(this.X1ord);
            this.Controls.Add(this.Restrictions);
            this.Controls.Add(this.X2Rest2);
            this.Controls.Add(this.X2Rest1);
            this.Controls.Add(this.X1Rest2);
            this.Controls.Add(this.X1Rest1);
            this.Controls.Add(this.chanceOfMutate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numGenerations);
            this.Controls.Add(this.Npoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxForP);
            this.Controls.Add(this.dataGridViewBestPerson);
            this.Controls.Add(this.dataForGenerations);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBestPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Npoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chanceOfMutate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Rest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Rest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Rest2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Rest2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterationsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBestPerson;
        private System.Windows.Forms.TextBox textBoxForP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numGenerations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown X1Rest1;
        private System.Windows.Forms.NumericUpDown X2Rest1;
        private System.Windows.Forms.NumericUpDown X1Rest2;
        private System.Windows.Forms.NumericUpDown X2Rest2;
        private System.Windows.Forms.Label Restrictions;
        private System.Windows.Forms.Label X1ord;
        private System.Windows.Forms.Label X2ord;
        private System.Windows.Forms.TextBox textBoxForFunction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butPointGener;
        private System.Windows.Forms.DataGridViewTextBoxColumn Generation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nosob;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Function;
        public System.Windows.Forms.NumericUpDown Npoints;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataForGenerations;
        public System.Windows.Forms.NumericUpDown chanceOfMutate;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxForCrossing;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownIterationsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenerationB;
        private System.Windows.Forms.DataGridViewTextBoxColumn chanceOfMutateB;
        private System.Windows.Forms.DataGridViewTextBoxColumn chanceOfCrossing;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodDrop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}

