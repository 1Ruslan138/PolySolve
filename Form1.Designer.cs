namespace PolySolve
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
            this.groupBoxQuadratic = new System.Windows.Forms.GroupBox();
            this.labelQuadraticResult = new System.Windows.Forms.Label();
            this.buttonSolveQuadratic = new System.Windows.Forms.Button();
            this.textBoxCQuadratic = new System.Windows.Forms.TextBox();
            this.labelCQuadratic = new System.Windows.Forms.Label();
            this.textBoxBQuadratic = new System.Windows.Forms.TextBox();
            this.labelBQuadratic = new System.Windows.Forms.Label();
            this.textBoxAQuadratic = new System.Windows.Forms.TextBox();
            this.labelAQuadratic = new System.Windows.Forms.Label();
            this.labelQuadraticEquation = new System.Windows.Forms.Label();
            this.groupBoxCubic = new System.Windows.Forms.GroupBox();
            this.labelCubicEquation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCubicResult = new System.Windows.Forms.Label();
            this.buttonSolveCubic = new System.Windows.Forms.Button();
            this.textBoxDCubic = new System.Windows.Forms.TextBox();
            this.labelDCubic = new System.Windows.Forms.Label();
            this.textBoxCCubic = new System.Windows.Forms.TextBox();
            this.labelCCubic = new System.Windows.Forms.Label();
            this.textBoxBCubic = new System.Windows.Forms.TextBox();
            this.labelBCubic = new System.Windows.Forms.Label();
            this.textBoxACubic = new System.Windows.Forms.TextBox();
            this.labelACubic = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonClearQuadratic = new System.Windows.Forms.Button();
            this.buttonClearCubic = new System.Windows.Forms.Button();
            this.groupBoxQuadratic.SuspendLayout();
            this.groupBoxCubic.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxQuadratic
            // 
            this.groupBoxQuadratic.Controls.Add(this.buttonClearQuadratic);
            this.groupBoxQuadratic.Controls.Add(this.labelQuadraticResult);
            this.groupBoxQuadratic.Controls.Add(this.buttonSolveQuadratic);
            this.groupBoxQuadratic.Controls.Add(this.textBoxCQuadratic);
            this.groupBoxQuadratic.Controls.Add(this.labelCQuadratic);
            this.groupBoxQuadratic.Controls.Add(this.textBoxBQuadratic);
            this.groupBoxQuadratic.Controls.Add(this.labelBQuadratic);
            this.groupBoxQuadratic.Controls.Add(this.textBoxAQuadratic);
            this.groupBoxQuadratic.Controls.Add(this.labelAQuadratic);
            this.groupBoxQuadratic.Controls.Add(this.labelQuadraticEquation);
            this.groupBoxQuadratic.Location = new System.Drawing.Point(12, 12);
            this.groupBoxQuadratic.Name = "groupBoxQuadratic";
            this.groupBoxQuadratic.Size = new System.Drawing.Size(562, 180);
            this.groupBoxQuadratic.TabIndex = 0;
            this.groupBoxQuadratic.TabStop = false;
            this.groupBoxQuadratic.Text = "Квадратное уравнение";
            // 
            // labelQuadraticResult
            // 
            this.labelQuadraticResult.AutoSize = true;
            this.labelQuadraticResult.Location = new System.Drawing.Point(175, 85);
            this.labelQuadraticResult.Name = "labelQuadraticResult";
            this.labelQuadraticResult.Size = new System.Drawing.Size(0, 13);
            this.labelQuadraticResult.TabIndex = 8;
            // 
            // buttonSolveQuadratic
            // 
            this.buttonSolveQuadratic.Location = new System.Drawing.Point(18, 132);
            this.buttonSolveQuadratic.Name = "buttonSolveQuadratic";
            this.buttonSolveQuadratic.Size = new System.Drawing.Size(75, 23);
            this.buttonSolveQuadratic.TabIndex = 7;
            this.buttonSolveQuadratic.Text = "Решить";
            this.buttonSolveQuadratic.UseVisualStyleBackColor = true;
            this.buttonSolveQuadratic.Click += new System.EventHandler(this.buttonSolveQuadratic_Click);
            // 
            // textBoxCQuadratic
            // 
            this.textBoxCQuadratic.Location = new System.Drawing.Point(34, 100);
            this.textBoxCQuadratic.Name = "textBoxCQuadratic";
            this.textBoxCQuadratic.Size = new System.Drawing.Size(100, 20);
            this.textBoxCQuadratic.TabIndex = 6;
            // 
            // labelCQuadratic
            // 
            this.labelCQuadratic.AutoSize = true;
            this.labelCQuadratic.Location = new System.Drawing.Point(15, 103);
            this.labelCQuadratic.Name = "labelCQuadratic";
            this.labelCQuadratic.Size = new System.Drawing.Size(16, 13);
            this.labelCQuadratic.TabIndex = 5;
            this.labelCQuadratic.Text = "c:";
            // 
            // textBoxBQuadratic
            // 
            this.textBoxBQuadratic.Location = new System.Drawing.Point(34, 74);
            this.textBoxBQuadratic.Name = "textBoxBQuadratic";
            this.textBoxBQuadratic.Size = new System.Drawing.Size(100, 20);
            this.textBoxBQuadratic.TabIndex = 4;
            // 
            // labelBQuadratic
            // 
            this.labelBQuadratic.AutoSize = true;
            this.labelBQuadratic.Location = new System.Drawing.Point(15, 77);
            this.labelBQuadratic.Name = "labelBQuadratic";
            this.labelBQuadratic.Size = new System.Drawing.Size(16, 13);
            this.labelBQuadratic.TabIndex = 3;
            this.labelBQuadratic.Text = "b:";
            // 
            // textBoxAQuadratic
            // 
            this.textBoxAQuadratic.Location = new System.Drawing.Point(34, 48);
            this.textBoxAQuadratic.Name = "textBoxAQuadratic";
            this.textBoxAQuadratic.Size = new System.Drawing.Size(100, 20);
            this.textBoxAQuadratic.TabIndex = 2;
            // 
            // labelAQuadratic
            // 
            this.labelAQuadratic.AutoSize = true;
            this.labelAQuadratic.Location = new System.Drawing.Point(15, 51);
            this.labelAQuadratic.Name = "labelAQuadratic";
            this.labelAQuadratic.Size = new System.Drawing.Size(16, 13);
            this.labelAQuadratic.TabIndex = 1;
            this.labelAQuadratic.Text = "a:";
            // 
            // labelQuadraticEquation
            // 
            this.labelQuadraticEquation.AutoSize = true;
            this.labelQuadraticEquation.Location = new System.Drawing.Point(15, 25);
            this.labelQuadraticEquation.Name = "labelQuadraticEquation";
            this.labelQuadraticEquation.Size = new System.Drawing.Size(80, 13);
            this.labelQuadraticEquation.TabIndex = 0;
            this.labelQuadraticEquation.Text = "ax² + bx + c = 0";
            // 
            // groupBoxCubic
            // 
            this.groupBoxCubic.Controls.Add(this.buttonClearCubic);
            this.groupBoxCubic.Controls.Add(this.labelCubicEquation);
            this.groupBoxCubic.Controls.Add(this.label1);
            this.groupBoxCubic.Controls.Add(this.labelCubicResult);
            this.groupBoxCubic.Controls.Add(this.buttonSolveCubic);
            this.groupBoxCubic.Controls.Add(this.textBoxDCubic);
            this.groupBoxCubic.Controls.Add(this.labelDCubic);
            this.groupBoxCubic.Controls.Add(this.textBoxCCubic);
            this.groupBoxCubic.Controls.Add(this.labelCCubic);
            this.groupBoxCubic.Controls.Add(this.textBoxBCubic);
            this.groupBoxCubic.Controls.Add(this.labelBCubic);
            this.groupBoxCubic.Controls.Add(this.textBoxACubic);
            this.groupBoxCubic.Controls.Add(this.labelACubic);
            this.groupBoxCubic.Location = new System.Drawing.Point(12, 202);
            this.groupBoxCubic.Name = "groupBoxCubic";
            this.groupBoxCubic.Size = new System.Drawing.Size(562, 180);
            this.groupBoxCubic.TabIndex = 1;
            this.groupBoxCubic.TabStop = false;
            this.groupBoxCubic.Text = "Кубическое уравнение";
            // 
            // labelCubicEquation
            // 
            this.labelCubicEquation.AutoSize = true;
            this.labelCubicEquation.Location = new System.Drawing.Point(13, 20);
            this.labelCubicEquation.Name = "labelCubicEquation";
            this.labelCubicEquation.Size = new System.Drawing.Size(106, 13);
            this.labelCubicEquation.TabIndex = 13;
            this.labelCubicEquation.Text = "ax³ + bx² + cx + d = 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // labelCubicResult
            // 
            this.labelCubicResult.AutoSize = true;
            this.labelCubicResult.Location = new System.Drawing.Point(175, 85);
            this.labelCubicResult.Name = "labelCubicResult";
            this.labelCubicResult.Size = new System.Drawing.Size(0, 13);
            this.labelCubicResult.TabIndex = 9;
            // 
            // buttonSolveCubic
            // 
            this.buttonSolveCubic.Location = new System.Drawing.Point(16, 140);
            this.buttonSolveCubic.Name = "buttonSolveCubic";
            this.buttonSolveCubic.Size = new System.Drawing.Size(75, 23);
            this.buttonSolveCubic.TabIndex = 8;
            this.buttonSolveCubic.Text = "Решить";
            this.buttonSolveCubic.UseVisualStyleBackColor = true;
            this.buttonSolveCubic.Click += new System.EventHandler(this.buttonSolveCubic_Click);
            // 
            // textBoxDCubic
            // 
            this.textBoxDCubic.Location = new System.Drawing.Point(32, 114);
            this.textBoxDCubic.Name = "textBoxDCubic";
            this.textBoxDCubic.Size = new System.Drawing.Size(100, 20);
            this.textBoxDCubic.TabIndex = 7;
            // 
            // labelDCubic
            // 
            this.labelDCubic.AutoSize = true;
            this.labelDCubic.Location = new System.Drawing.Point(13, 117);
            this.labelDCubic.Name = "labelDCubic";
            this.labelDCubic.Size = new System.Drawing.Size(16, 13);
            this.labelDCubic.TabIndex = 6;
            this.labelDCubic.Text = "d:";
            // 
            // textBoxCCubic
            // 
            this.textBoxCCubic.Location = new System.Drawing.Point(32, 88);
            this.textBoxCCubic.Name = "textBoxCCubic";
            this.textBoxCCubic.Size = new System.Drawing.Size(100, 20);
            this.textBoxCCubic.TabIndex = 5;
            // 
            // labelCCubic
            // 
            this.labelCCubic.AutoSize = true;
            this.labelCCubic.Location = new System.Drawing.Point(13, 91);
            this.labelCCubic.Name = "labelCCubic";
            this.labelCCubic.Size = new System.Drawing.Size(16, 13);
            this.labelCCubic.TabIndex = 4;
            this.labelCCubic.Text = "c:";
            // 
            // textBoxBCubic
            // 
            this.textBoxBCubic.Location = new System.Drawing.Point(32, 62);
            this.textBoxBCubic.Name = "textBoxBCubic";
            this.textBoxBCubic.Size = new System.Drawing.Size(100, 20);
            this.textBoxBCubic.TabIndex = 3;
            // 
            // labelBCubic
            // 
            this.labelBCubic.AutoSize = true;
            this.labelBCubic.Location = new System.Drawing.Point(13, 65);
            this.labelBCubic.Name = "labelBCubic";
            this.labelBCubic.Size = new System.Drawing.Size(16, 13);
            this.labelBCubic.TabIndex = 2;
            this.labelBCubic.Text = "b:";
            // 
            // textBoxACubic
            // 
            this.textBoxACubic.Location = new System.Drawing.Point(32, 36);
            this.textBoxACubic.Name = "textBoxACubic";
            this.textBoxACubic.Size = new System.Drawing.Size(100, 20);
            this.textBoxACubic.TabIndex = 1;
            // 
            // labelACubic
            // 
            this.labelACubic.AutoSize = true;
            this.labelACubic.Location = new System.Drawing.Point(13, 39);
            this.labelACubic.Name = "labelACubic";
            this.labelACubic.Size = new System.Drawing.Size(16, 13);
            this.labelACubic.TabIndex = 0;
            this.labelACubic.Text = "a:";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(614, 359);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonClearQuadratic
            // 
            this.buttonClearQuadratic.Location = new System.Drawing.Point(99, 132);
            this.buttonClearQuadratic.Name = "buttonClearQuadratic";
            this.buttonClearQuadratic.Size = new System.Drawing.Size(75, 23);
            this.buttonClearQuadratic.TabIndex = 13;
            this.buttonClearQuadratic.Text = "Очистить";
            this.buttonClearQuadratic.UseVisualStyleBackColor = true;
            this.buttonClearQuadratic.Click += new System.EventHandler(this.buttonClearQuadratic_Click);
            // 
            // buttonClearCubic
            // 
            this.buttonClearCubic.Location = new System.Drawing.Point(97, 140);
            this.buttonClearCubic.Name = "buttonClearCubic";
            this.buttonClearCubic.Size = new System.Drawing.Size(75, 23);
            this.buttonClearCubic.TabIndex = 14;
            this.buttonClearCubic.Text = "Очистить";
            this.buttonClearCubic.UseVisualStyleBackColor = true;
            this.buttonClearCubic.Click += new System.EventHandler(this.buttonClearCubic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 394);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxCubic);
            this.Controls.Add(this.groupBoxQuadratic);
            this.Name = "Form1";
            this.Text = "PolySolve";
            this.groupBoxQuadratic.ResumeLayout(false);
            this.groupBoxQuadratic.PerformLayout();
            this.groupBoxCubic.ResumeLayout(false);
            this.groupBoxCubic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Квадратное уравнение

        private System.Windows.Forms.GroupBox groupBoxQuadratic;
        private System.Windows.Forms.Label labelQuadraticResult;
        private System.Windows.Forms.Button buttonSolveQuadratic;
        private System.Windows.Forms.TextBox textBoxCQuadratic;
        private System.Windows.Forms.Label labelCQuadratic;
        private System.Windows.Forms.TextBox textBoxBQuadratic;
        private System.Windows.Forms.Label labelBQuadratic;
        private System.Windows.Forms.TextBox textBoxAQuadratic;
        private System.Windows.Forms.Label labelAQuadratic;
        private System.Windows.Forms.Label labelQuadraticEquation;

        #endregion

        #region Кубическое уравнение

        private System.Windows.Forms.GroupBox groupBoxCubic;
        private System.Windows.Forms.Label labelCubicResult;
        private System.Windows.Forms.Button buttonSolveCubic;
        private System.Windows.Forms.TextBox textBoxDCubic;
        private System.Windows.Forms.Label labelDCubic;
        private System.Windows.Forms.TextBox textBoxCCubic;
        private System.Windows.Forms.Label labelCCubic;
        private System.Windows.Forms.TextBox textBoxBCubic;
        private System.Windows.Forms.Label labelBCubic;
        private System.Windows.Forms.TextBox textBoxACubic;
        private System.Windows.Forms.Label labelACubic;

        #endregion

        private System.Windows.Forms.Label labelCubicEquation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonClearQuadratic;
        private System.Windows.Forms.Button buttonClearCubic;
    }
}