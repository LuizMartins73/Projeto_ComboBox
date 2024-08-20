namespace Projeto_ComboBox
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
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboLista
            // 
            this.cboLista.AccessibleName = "cboLista";
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Items.AddRange(new object[] {
            "3",
            "1",
            "4",
            "1",
            "5",
            "9",
            "2",
            "6",
            "5",
            "3",
            "5",
            "8",
            "9",
            "7",
            "9",
            "3",
            "2",
            "3",
            "8",
            "46",
            "26"});
            this.cboLista.Location = new System.Drawing.Point(103, 212);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(427, 21);
            this.cboLista.TabIndex = 0;
            this.cboLista.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(103, 27);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(376, 20);
            this.txtTexto.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inserir no Combo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 55);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ordenar o Combo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 78);
            this.button3.TabIndex = 6;
            this.button3.Text = "Remover o Combo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Qtd de itens:";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblQtde.Location = new System.Drawing.Point(140, 365);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(17, 18);
            this.lblQtde.TabIndex = 8;
            this.lblQtde.Text = "0";
            this.lblQtde.Click += new System.EventHandler(this.label4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(213, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 55);
            this.button4.TabIndex = 9;
            this.button4.Text = "Exibir dados do Combo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Índice do Combo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Texto do Combo: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 527);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(376, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 570);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(376, 20);
            this.textBox3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 687);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

