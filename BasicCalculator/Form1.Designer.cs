
namespace BasicCalculator
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Operand = new System.Windows.Forms.Label();
            this.Operand2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.TxtbOperand1 = new System.Windows.Forms.TextBox();
            this.TxtbSymbol = new System.Windows.Forms.TextBox();
            this.TxtbOperand2 = new System.Windows.Forms.TextBox();
            this.TxtbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand 1:";
            // 
            // Operand
            // 
            this.Operand.AutoSize = true;
            this.Operand.Location = new System.Drawing.Point(103, 116);
            this.Operand.Name = "Operand";
            this.Operand.Size = new System.Drawing.Size(71, 20);
            this.Operand.TabIndex = 1;
            this.Operand.Text = "Operand";
            // 
            // Operand2
            // 
            this.Operand2.AutoSize = true;
            this.Operand2.Location = new System.Drawing.Point(103, 173);
            this.Operand2.Name = "Operand2";
            this.Operand2.Size = new System.Drawing.Size(88, 20);
            this.Operand2.TabIndex = 2;
            this.Operand2.Text = "Operand 2:";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(103, 229);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(59, 20);
            this.result.TabIndex = 3;
            this.result.Text = "Result:";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(107, 291);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(87, 36);
            this.calc.TabIndex = 4;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(357, 291);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(87, 36);
            this.exit.TabIndex = 5;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // TxtbOperand1
            // 
            this.TxtbOperand1.Location = new System.Drawing.Point(288, 66);
            this.TxtbOperand1.Name = "TxtbOperand1";
            this.TxtbOperand1.Size = new System.Drawing.Size(156, 26);
            this.TxtbOperand1.TabIndex = 6;
            this.TxtbOperand1.Text = "first number";
            this.TxtbOperand1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtbOperand1_MouseClick);
            // 
            // TxtbSymbol
            // 
            this.TxtbSymbol.Location = new System.Drawing.Point(288, 116);
            this.TxtbSymbol.Name = "TxtbSymbol";
            this.TxtbSymbol.Size = new System.Drawing.Size(156, 26);
            this.TxtbSymbol.TabIndex = 7;
            this.TxtbSymbol.Text = "symbol";
            this.TxtbSymbol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtbSymbol_MouseClick);
            // 
            // TxtbOperand2
            // 
            this.TxtbOperand2.Location = new System.Drawing.Point(288, 173);
            this.TxtbOperand2.Name = "TxtbOperand2";
            this.TxtbOperand2.Size = new System.Drawing.Size(156, 26);
            this.TxtbOperand2.TabIndex = 9;
            this.TxtbOperand2.Text = "second number";
            this.TxtbOperand2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtbOperand2_MouseClick);
            // 
            // TxtbResult
            // 
            this.TxtbResult.Enabled = false;
            this.TxtbResult.Location = new System.Drawing.Point(288, 229);
            this.TxtbResult.Name = "TxtbResult";
            this.TxtbResult.Size = new System.Drawing.Size(156, 26);
            this.TxtbResult.TabIndex = 8;
            this.TxtbResult.Text = "results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 605);
            this.Controls.Add(this.TxtbOperand2);
            this.Controls.Add(this.TxtbResult);
            this.Controls.Add(this.TxtbSymbol);
            this.Controls.Add(this.TxtbOperand1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Operand2);
            this.Controls.Add(this.Operand);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Operand;
        private System.Windows.Forms.Label Operand2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox TxtbOperand1;
        private System.Windows.Forms.TextBox TxtbSymbol;
        private System.Windows.Forms.TextBox TxtbOperand2;
        private System.Windows.Forms.TextBox TxtbResult;
    }
}

