namespace WinFormTasks
{
    partial class FormCalculate
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
            this.labelTask1 = new System.Windows.Forms.Label();
            this.textBoxNTask1 = new System.Windows.Forms.TextBox();
            this.buttonSolveTask1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNTask1 = new System.Windows.Forms.Label();
            this.labelTask1Result = new System.Windows.Forms.Label();
            this.labelTask2Result = new System.Windows.Forms.Label();
            this.labelNTask2 = new System.Windows.Forms.Label();
            this.buttonSoiveTask2 = new System.Windows.Forms.Button();
            this.textBoxNTask2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTask1
            // 
            this.labelTask1.AutoSize = true;
            this.labelTask1.Location = new System.Drawing.Point(17, 27);
            this.labelTask1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTask1.Name = "labelTask1";
            this.labelTask1.Size = new System.Drawing.Size(506, 17);
            this.labelTask1.TabIndex = 0;
            this.labelTask1.Text = "(Task_1)Дано ціле число n (n > 0). Знайти суму 1 + 1/2 + 1/3 + ... + 1 / n.";
            // 
            // textBoxNTask1
            // 
            this.textBoxNTask1.Location = new System.Drawing.Point(54, 60);
            this.textBoxNTask1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNTask1.Name = "textBoxNTask1";
            this.textBoxNTask1.Size = new System.Drawing.Size(148, 25);
            this.textBoxNTask1.TabIndex = 1;
            // 
            // buttonSolveTask1
            // 
            this.buttonSolveTask1.Location = new System.Drawing.Point(223, 60);
            this.buttonSolveTask1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSolveTask1.Name = "buttonSolveTask1";
            this.buttonSolveTask1.Size = new System.Drawing.Size(112, 30);
            this.buttonSolveTask1.TabIndex = 2;
            this.buttonSolveTask1.Text = "Solve";
            this.buttonSolveTask1.UseVisualStyleBackColor = true;
            this.buttonSolveTask1.Click += new System.EventHandler(this.buttonSolveTask1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // labelNTask1
            // 
            this.labelNTask1.AutoSize = true;
            this.labelNTask1.Location = new System.Drawing.Point(17, 60);
            this.labelNTask1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNTask1.Name = "labelNTask1";
            this.labelNTask1.Size = new System.Drawing.Size(29, 17);
            this.labelNTask1.TabIndex = 4;
            this.labelNTask1.Text = "n =";
            // 
            // labelTask1Result
            // 
            this.labelTask1Result.AutoSize = true;
            this.labelTask1Result.Location = new System.Drawing.Point(369, 63);
            this.labelTask1Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTask1Result.Name = "labelTask1Result";
            this.labelTask1Result.Size = new System.Drawing.Size(0, 17);
            this.labelTask1Result.TabIndex = 5;
            // 
            // labelTask2Result
            // 
            this.labelTask2Result.AutoSize = true;
            this.labelTask2Result.Location = new System.Drawing.Point(386, 187);
            this.labelTask2Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTask2Result.Name = "labelTask2Result";
            this.labelTask2Result.Size = new System.Drawing.Size(0, 17);
            this.labelTask2Result.TabIndex = 10;
            // 
            // labelNTask2
            // 
            this.labelNTask2.AutoSize = true;
            this.labelNTask2.Location = new System.Drawing.Point(17, 203);
            this.labelNTask2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNTask2.Name = "labelNTask2";
            this.labelNTask2.Size = new System.Drawing.Size(29, 17);
            this.labelNTask2.TabIndex = 9;
            this.labelNTask2.Text = "n =";
            // 
            // buttonSoiveTask2
            // 
            this.buttonSoiveTask2.Location = new System.Drawing.Point(223, 180);
            this.buttonSoiveTask2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSoiveTask2.Name = "buttonSoiveTask2";
            this.buttonSoiveTask2.Size = new System.Drawing.Size(112, 30);
            this.buttonSoiveTask2.TabIndex = 8;
            this.buttonSoiveTask2.Text = "Solve";
            this.buttonSoiveTask2.UseVisualStyleBackColor = true;
            this.buttonSoiveTask2.Click += new System.EventHandler(this.buttonSoiveTask2_Click);
            // 
            // textBoxNTask2
            // 
            this.textBoxNTask2.Location = new System.Drawing.Point(54, 203);
            this.textBoxNTask2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNTask2.Name = "textBoxNTask2";
            this.textBoxNTask2.Size = new System.Drawing.Size(148, 25);
            this.textBoxNTask2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(552, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "(Task_2)Дано дробове число a і ціле число n (n > 0). Обчислити a в степені n.";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(17, 170);
            this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(28, 17);
            this.labelA.TabIndex = 12;
            this.labelA.Text = "a =";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(54, 170);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(148, 25);
            this.textBoxA.TabIndex = 11;
            // 
            // FormCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 285);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelTask2Result);
            this.Controls.Add(this.labelNTask2);
            this.Controls.Add(this.buttonSoiveTask2);
            this.Controls.Add(this.textBoxNTask2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTask1Result);
            this.Controls.Add(this.labelNTask1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSolveTask1);
            this.Controls.Add(this.textBoxNTask1);
            this.Controls.Add(this.labelTask1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCalculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTask1;
        private System.Windows.Forms.TextBox textBoxNTask1;
        private System.Windows.Forms.Button buttonSolveTask1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNTask1;
        private System.Windows.Forms.Label labelTask1Result;
        private System.Windows.Forms.Label labelTask2Result;
        private System.Windows.Forms.Label labelNTask2;
        private System.Windows.Forms.Button buttonSoiveTask2;
        private System.Windows.Forms.TextBox textBoxNTask2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxA;
    }
}

