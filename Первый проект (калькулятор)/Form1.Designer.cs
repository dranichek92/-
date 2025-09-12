namespace Первый_проект__калькулятор_
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonEq = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Калькулятор";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(127, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Число 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(127, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Число 2:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 196);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(528, 20);
            this.textBox2.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdd.Location = new System.Drawing.Point(203, 128);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 62);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSub.Location = new System.Drawing.Point(337, 128);
            this.buttonSub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(126, 62);
            this.buttonSub.TabIndex = 6;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMul.Location = new System.Drawing.Point(471, 128);
            this.buttonMul.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(126, 62);
            this.buttonMul.TabIndex = 7;
            this.buttonMul.Text = "x";
            this.buttonMul.UseVisualStyleBackColor = false;
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDiv.Location = new System.Drawing.Point(605, 128);
            this.buttonDiv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(126, 62);
            this.buttonDiv.TabIndex = 8;
            this.buttonDiv.Text = ":";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonEq
            // 
            this.buttonEq.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEq.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEq.Location = new System.Drawing.Point(403, 222);
            this.buttonEq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEq.Name = "buttonEq";
            this.buttonEq.Size = new System.Drawing.Size(126, 41);
            this.buttonEq.TabIndex = 9;
            this.buttonEq.Text = "=";
            this.buttonEq.UseVisualStyleBackColor = false;
            this.buttonEq.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(337, 269);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ответ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 558);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonEq);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.buttonMul_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonEq;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}

