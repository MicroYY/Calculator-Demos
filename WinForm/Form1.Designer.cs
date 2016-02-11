namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.num0 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(90, 225);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(60, 20);
            this.num0.TabIndex = 1;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.equation);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(165, 225);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(60, 20);
            this.dot.TabIndex = 2;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.equation);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(240, 225);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(60, 20);
            this.calc.TabIndex = 3;
            this.calc.Text = "=";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(15, 185);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(60, 20);
            this.num1.TabIndex = 4;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.equation);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(90, 185);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(60, 20);
            this.num2.TabIndex = 5;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.equation);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(165, 185);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(60, 20);
            this.num3.TabIndex = 6;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.equation);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(240, 185);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(60, 20);
            this.divide.TabIndex = 7;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.equation);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(15, 145);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(60, 20);
            this.num4.TabIndex = 8;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.equation);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(90, 145);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(60, 20);
            this.num5.TabIndex = 9;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.equation);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(165, 145);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(60, 20);
            this.num6.TabIndex = 10;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.equation);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(240, 145);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(60, 20);
            this.multiply.TabIndex = 11;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.equation);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(15, 105);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(60, 20);
            this.num7.TabIndex = 12;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.equation);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(90, 105);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(60, 20);
            this.num8.TabIndex = 13;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.equation);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(165, 105);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(60, 20);
            this.num9.TabIndex = 14;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.equation);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(240, 105);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 20);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.equation);
            // 
            // pow
            // 
            this.pow.Location = new System.Drawing.Point(15, 65);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(60, 20);
            this.pow.TabIndex = 16;
            this.pow.Text = "^";
            this.pow.UseVisualStyleBackColor = true;
            this.pow.Click += new System.EventHandler(this.equation);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(90, 65);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 20);
            this.clear.TabIndex = 17;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(165, 65);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(60, 20);
            this.delete.TabIndex = 18;
            this.delete.Text = "<--";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(240, 65);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 20);
            this.plus.TabIndex = 19;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.equation);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(15, 225);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(25, 20);
            this.left.TabIndex = 20;
            this.left.Text = "(";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.equation);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(50, 225);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(25, 20);
            this.right.TabIndex = 21;
            this.right.Text = ")";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.equation);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result.Location = new System.Drawing.Point(236, 28);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(19, 20);
            this.result.TabIndex = 22;
            this.result.Text = "0";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(50, 28);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 21);
            this.input.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.input);
            this.Controls.Add(this.result);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.num0);
            this.Name = "Form1";
            this.Text = "计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox input;
    }
}

