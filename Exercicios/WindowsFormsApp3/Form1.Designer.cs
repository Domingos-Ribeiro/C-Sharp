namespace WindowsFormsApp3
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
            this.lstUtilizadores = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmdAdicionar = new System.Windows.Forms.Button();
            this.cmdRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSuspensos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Selec_um = new System.Windows.Forms.Button();
            this.btn_Selec_todos = new System.Windows.Forms.Button();
            this.btn_Voltar_todos = new System.Windows.Forms.Button();
            this.btn_Voltar_um = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_suspensos = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ativos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUtilizadores
            // 
            this.lstUtilizadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUtilizadores.FormattingEnabled = true;
            this.lstUtilizadores.ItemHeight = 31;
            this.lstUtilizadores.Location = new System.Drawing.Point(25, 162);
            this.lstUtilizadores.Name = "lstUtilizadores";
            this.lstUtilizadores.Size = new System.Drawing.Size(205, 345);
            this.lstUtilizadores.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 20);
            this.txtNome.TabIndex = 2;
            // 
            // cmdAdicionar
            // 
            this.cmdAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdicionar.Location = new System.Drawing.Point(125, 58);
            this.cmdAdicionar.Name = "cmdAdicionar";
            this.cmdAdicionar.Size = new System.Drawing.Size(168, 36);
            this.cmdAdicionar.TabIndex = 3;
            this.cmdAdicionar.Text = "Adicionar";
            this.cmdAdicionar.UseVisualStyleBackColor = true;
            this.cmdAdicionar.Click += new System.EventHandler(this.cmdAdicionar_Click);
            // 
            // cmdRemover
            // 
            this.cmdRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemover.Location = new System.Drawing.Point(25, 523);
            this.cmdRemover.Name = "cmdRemover";
            this.cmdRemover.Size = new System.Drawing.Size(205, 32);
            this.cmdRemover.TabIndex = 4;
            this.cmdRemover.Text = "Remover";
            this.cmdRemover.UseVisualStyleBackColor = true;
            this.cmdRemover.Click += new System.EventHandler(this.cmdRemover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Utilizadores do Sistema";
            // 
            // lstSuspensos
            // 
            this.lstSuspensos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSuspensos.FormattingEnabled = true;
            this.lstSuspensos.ItemHeight = 31;
            this.lstSuspensos.Location = new System.Drawing.Point(340, 162);
            this.lstSuspensos.Name = "lstSuspensos";
            this.lstSuspensos.Size = new System.Drawing.Size(202, 345);
            this.lstSuspensos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Utilizadores Suspensos";
            // 
            // btn_Selec_um
            // 
            this.btn_Selec_um.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Selec_um.Location = new System.Drawing.Point(14, 83);
            this.btn_Selec_um.Name = "btn_Selec_um";
            this.btn_Selec_um.Size = new System.Drawing.Size(42, 25);
            this.btn_Selec_um.TabIndex = 9;
            this.btn_Selec_um.Text = ">";
            this.btn_Selec_um.UseVisualStyleBackColor = true;
            this.btn_Selec_um.Click += new System.EventHandler(this.btn_Selec_um_Click);
            // 
            // btn_Selec_todos
            // 
            this.btn_Selec_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Selec_todos.Location = new System.Drawing.Point(14, 114);
            this.btn_Selec_todos.Name = "btn_Selec_todos";
            this.btn_Selec_todos.Size = new System.Drawing.Size(42, 29);
            this.btn_Selec_todos.TabIndex = 10;
            this.btn_Selec_todos.Text = ">>";
            this.btn_Selec_todos.UseVisualStyleBackColor = true;
            this.btn_Selec_todos.Click += new System.EventHandler(this.btn_Selec_todos_Click);
            // 
            // btn_Voltar_todos
            // 
            this.btn_Voltar_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar_todos.Location = new System.Drawing.Point(14, 232);
            this.btn_Voltar_todos.Name = "btn_Voltar_todos";
            this.btn_Voltar_todos.Size = new System.Drawing.Size(42, 25);
            this.btn_Voltar_todos.TabIndex = 11;
            this.btn_Voltar_todos.Text = "<<";
            this.btn_Voltar_todos.UseVisualStyleBackColor = true;
            this.btn_Voltar_todos.Click += new System.EventHandler(this.btn_Voltar_todos_Click);
            // 
            // btn_Voltar_um
            // 
            this.btn_Voltar_um.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar_um.Location = new System.Drawing.Point(14, 201);
            this.btn_Voltar_um.Name = "btn_Voltar_um";
            this.btn_Voltar_um.Size = new System.Drawing.Size(42, 25);
            this.btn_Voltar_um.TabIndex = 12;
            this.btn_Voltar_um.Text = "<";
            this.btn_Voltar_um.UseVisualStyleBackColor = true;
            this.btn_Voltar_um.Click += new System.EventHandler(this.btn_Voltar_um_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "TOTAIS";
            // 
            // txt_suspensos
            // 
            this.txt_suspensos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suspensos.Location = new System.Drawing.Point(22, 207);
            this.txt_suspensos.Name = "txt_suspensos";
            this.txt_suspensos.Size = new System.Drawing.Size(155, 23);
            this.txt_suspensos.TabIndex = 14;
            this.txt_suspensos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(22, 281);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(155, 23);
            this.txt_total.TabIndex = 15;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Utilizadores Suspensos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Utilizadores Ativos";
            // 
            // txt_ativos
            // 
            this.txt_ativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ativos.Location = new System.Drawing.Point(22, 133);
            this.txt_ativos.Name = "txt_ativos";
            this.txt_ativos.Size = new System.Drawing.Size(155, 23);
            this.txt_ativos.TabIndex = 18;
            this.txt_ativos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Voltar_um);
            this.panel1.Controls.Add(this.btn_Selec_um);
            this.panel1.Controls.Add(this.btn_Selec_todos);
            this.panel1.Controls.Add(this.btn_Voltar_todos);
            this.panel1.Location = new System.Drawing.Point(249, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 345);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.cmdAdicionar);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 100);
            this.panel2.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(this.txt_ativos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_suspensos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(558, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 345);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSuspensos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdRemover);
            this.Controls.Add(this.lstUtilizadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domingos Ribeiro - Validação de Utilizadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstUtilizadores;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button cmdAdicionar;
        private System.Windows.Forms.Button cmdRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSuspensos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Selec_um;
        private System.Windows.Forms.Button btn_Selec_todos;
        private System.Windows.Forms.Button btn_Voltar_todos;
        private System.Windows.Forms.Button btn_Voltar_um;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_suspensos;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ativos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

