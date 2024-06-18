namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.firstValueBox = new System.Windows.Forms.RichTextBox();
            this.secondValueBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.Mult = new System.Windows.Forms.RadioButton();
            this.Div = new System.Windows.Forms.RadioButton();
            this.Sub = new System.Windows.Forms.RadioButton();
            this.Add = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro número";
            // 
            // firstValueBox
            // 
            this.firstValueBox.Location = new System.Drawing.Point(323, 75);
            this.firstValueBox.Name = "firstValueBox";
            this.firstValueBox.Size = new System.Drawing.Size(137, 24);
            this.firstValueBox.TabIndex = 1;
            this.firstValueBox.Text = "";
            // 
            // secondValueBox
            // 
            this.secondValueBox.Location = new System.Drawing.Point(323, 105);
            this.secondValueBox.Name = "secondValueBox";
            this.secondValueBox.Size = new System.Drawing.Size(137, 24);
            this.secondValueBox.TabIndex = 3;
            this.secondValueBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segundo número";
            // 
            // radioGroup
            // 
            this.radioGroup.Controls.Add(this.Mult);
            this.radioGroup.Controls.Add(this.Div);
            this.radioGroup.Controls.Add(this.Sub);
            this.radioGroup.Controls.Add(this.Add);
            this.radioGroup.Location = new System.Drawing.Point(238, 135);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(222, 76);
            this.radioGroup.TabIndex = 5;
            this.radioGroup.TabStop = false;
            this.radioGroup.Text = "Operação";
            // 
            // Mult
            // 
            this.Mult.AutoSize = true;
            this.Mult.Location = new System.Drawing.Point(113, 22);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(87, 17);
            this.Mult.TabIndex = 3;
            this.Mult.TabStop = true;
            this.Mult.Text = "Multiplicação";
            this.Mult.UseVisualStyleBackColor = true;
            // 
            // Div
            // 
            this.Div.AutoSize = true;
            this.Div.Location = new System.Drawing.Point(113, 45);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(60, 17);
            this.Div.TabIndex = 2;
            this.Div.TabStop = true;
            this.Div.Text = "Divisão";
            this.Div.UseVisualStyleBackColor = true;
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Location = new System.Drawing.Point(22, 45);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(74, 17);
            this.Sub.TabIndex = 1;
            this.Sub.TabStop = true;
            this.Sub.Text = "Subtração";
            this.Sub.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Location = new System.Drawing.Point(22, 22);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(58, 17);
            this.Add.TabIndex = 0;
            this.Add.TabStop = true;
            this.Add.Text = "Adição";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(304, 275);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(156, 24);
            this.resultBox.TabIndex = 9;
            this.resultBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioGroup);
            this.Controls.Add(this.secondValueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstValueBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox firstValueBox;
        private System.Windows.Forms.RichTextBox secondValueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.RadioButton Mult;
        private System.Windows.Forms.RadioButton Div;
        private System.Windows.Forms.RadioButton Sub;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Label label3;
    }
}

