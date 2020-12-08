namespace CalculadoraDeBhaskara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btCalcular = new System.Windows.Forms.Button();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbX1 = new System.Windows.Forms.Label();
            this.lbX2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAjuda = new System.Windows.Forms.Label();
            this.rbR = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(30, 164);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 0;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(30, 87);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 1;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(177, 87);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 2;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(319, 87);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(100, 20);
            this.tbC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "C";
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.Location = new System.Drawing.Point(174, 169);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(26, 13);
            this.lbX1.TabIndex = 7;
            this.lbX1.Text = "X1: ";
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.Location = new System.Drawing.Point(174, 210);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(26, 13);
            this.lbX2.TabIndex = 8;
            this.lbX2.Text = "X2: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 39);
            this.label6.TabIndex = 9;
            this.label6.Text = "ENTRE COM OS VALORES \'A\', \'B\' E \'C\'\r\n                  DA FORMA \r\n            AX²" +
    " + BX + C = 0";
            // 
            // lbAjuda
            // 
            this.lbAjuda.AutoSize = true;
            this.lbAjuda.Location = new System.Drawing.Point(390, 9);
            this.lbAjuda.Name = "lbAjuda";
            this.lbAjuda.Size = new System.Drawing.Size(44, 13);
            this.lbAjuda.TabIndex = 10;
            this.lbAjuda.Text = "SOBRE";
            this.lbAjuda.Click += new System.EventHandler(this.lbAjuda_Click);
            // 
            // rbR
            // 
            this.rbR.AutoSize = true;
            this.rbR.Location = new System.Drawing.Point(319, 124);
            this.rbR.Name = "rbR";
            this.rbR.Size = new System.Drawing.Size(35, 17);
            this.rbR.TabIndex = 11;
            this.rbR.TabStop = true;
            this.rbR.Text = "|R";
            this.rbR.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(319, 147);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(34, 17);
            this.rbC.TabIndex = 12;
            this.rbC.TabStop = true;
            this.rbC.Text = "|C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 247);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbR);
            this.Controls.Add(this.lbAjuda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbX2);
            this.Controls.Add(this.lbX1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.btCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CALCULADORA DE BHASKARA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbAjuda;
        private System.Windows.Forms.RadioButton rbR;
        private System.Windows.Forms.RadioButton rbC;
    }
}

