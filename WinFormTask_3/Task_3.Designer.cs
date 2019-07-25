namespace WinFormTask_3
{
    partial class Task_3
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTask1Result = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelTask1 = new System.Windows.Forms.Label();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.labelSumnegativeNumb = new System.Windows.Forms.Label();
            this.labelMaxNumb = new System.Windows.Forms.Label();
            this.labelSumIndexes = new System.Windows.Forms.Label();
            this.labelvariablecoun = new System.Windows.Forms.Label();
            this.labelsumMax_Min = new System.Windows.Forms.Label();
            this.labelIntengerQuantity = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTask1Result
            // 
            this.labelTask1Result.AutoSize = true;
            this.labelTask1Result.Location = new System.Drawing.Point(909, 177);
            this.labelTask1Result.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTask1Result.Name = "labelTask1Result";
            this.labelTask1Result.Size = new System.Drawing.Size(0, 17);
            this.labelTask1Result.TabIndex = 10;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(26, 62);
            this.labelN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(29, 17);
            this.labelN.TabIndex = 9;
            this.labelN.Text = "n =";
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(605, 59);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(168, 25);
            this.buttonSolve.TabIndex = 8;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(67, 59);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(145, 25);
            this.textBoxN.TabIndex = 7;
            // 
            // labelTask1
            // 
            this.labelTask1.AutoSize = true;
            this.labelTask1.Location = new System.Drawing.Point(15, 18);
            this.labelTask1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTask1.Name = "labelTask1";
            this.labelTask1.Size = new System.Drawing.Size(622, 17);
            this.labelTask1.TabIndex = 6;
            this.labelTask1.Text = "(Task_3) В одновимірному масиві, що складається з N елементів, визначити і вивест" +
    "и:";
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(18, 101);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(755, 71);
            this.dataGridViewTable.TabIndex = 11;
            // 
            // labelSumnegativeNumb
            // 
            this.labelSumnegativeNumb.AutoSize = true;
            this.labelSumnegativeNumb.Location = new System.Drawing.Point(20, 191);
            this.labelSumnegativeNumb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSumnegativeNumb.Name = "labelSumnegativeNumb";
            this.labelSumnegativeNumb.Size = new System.Drawing.Size(0, 17);
            this.labelSumnegativeNumb.TabIndex = 12;
            // 
            // labelMaxNumb
            // 
            this.labelMaxNumb.AutoSize = true;
            this.labelMaxNumb.Location = new System.Drawing.Point(20, 217);
            this.labelMaxNumb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMaxNumb.Name = "labelMaxNumb";
            this.labelMaxNumb.Size = new System.Drawing.Size(0, 17);
            this.labelMaxNumb.TabIndex = 13;
            // 
            // labelSumIndexes
            // 
            this.labelSumIndexes.AutoSize = true;
            this.labelSumIndexes.Location = new System.Drawing.Point(20, 244);
            this.labelSumIndexes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSumIndexes.Name = "labelSumIndexes";
            this.labelSumIndexes.Size = new System.Drawing.Size(0, 17);
            this.labelSumIndexes.TabIndex = 14;
            // 
            // labelvariablecoun
            // 
            this.labelvariablecoun.AutoSize = true;
            this.labelvariablecoun.Location = new System.Drawing.Point(388, 244);
            this.labelvariablecoun.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelvariablecoun.Name = "labelvariablecoun";
            this.labelvariablecoun.Size = new System.Drawing.Size(0, 17);
            this.labelvariablecoun.TabIndex = 17;
            // 
            // labelsumMax_Min
            // 
            this.labelsumMax_Min.AutoSize = true;
            this.labelsumMax_Min.Location = new System.Drawing.Point(388, 217);
            this.labelsumMax_Min.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelsumMax_Min.Name = "labelsumMax_Min";
            this.labelsumMax_Min.Size = new System.Drawing.Size(0, 17);
            this.labelsumMax_Min.TabIndex = 16;
            // 
            // labelIntengerQuantity
            // 
            this.labelIntengerQuantity.AutoSize = true;
            this.labelIntengerQuantity.Location = new System.Drawing.Point(388, 191);
            this.labelIntengerQuantity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIntengerQuantity.Name = "labelIntengerQuantity";
            this.labelIntengerQuantity.Size = new System.Drawing.Size(0, 17);
            this.labelIntengerQuantity.TabIndex = 15;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(429, 59);
            this.buttonRandom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(168, 25);
            this.buttonRandom.TabIndex = 18;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(249, 59);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(168, 25);
            this.buttonOK.TabIndex = 19;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Task_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 309);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.labelvariablecoun);
            this.Controls.Add(this.labelsumMax_Min);
            this.Controls.Add(this.labelIntengerQuantity);
            this.Controls.Add(this.labelSumIndexes);
            this.Controls.Add(this.labelMaxNumb);
            this.Controls.Add(this.labelSumnegativeNumb);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.labelTask1Result);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelTask1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task_3";
            this.Text = "Task-3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTask1Result;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelTask1;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Label labelSumnegativeNumb;
        private System.Windows.Forms.Label labelMaxNumb;
        private System.Windows.Forms.Label labelSumIndexes;
        private System.Windows.Forms.Label labelvariablecoun;
        private System.Windows.Forms.Label labelsumMax_Min;
        private System.Windows.Forms.Label labelIntengerQuantity;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonOK;
    }
}

