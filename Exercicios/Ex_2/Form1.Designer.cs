namespace ex_2
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
            this.pnl_cima = new System.Windows.Forms.Panel();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_Adiciona = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.pnl_meio = new System.Windows.Forms.Panel();
            this.pnl_baixo = new System.Windows.Forms.Panel();
            this.lst_1 = new System.Windows.Forms.ListBox();
            this.pnl_cima.SuspendLayout();
            this.pnl_meio.SuspendLayout();
            this.pnl_baixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // pnl_cima
            // 
            this.pnl_cima.Controls.Add(this.btn_Adiciona);
            this.pnl_cima.Controls.Add(this.txt_Nome);
            this.pnl_cima.Controls.Add(this.label1);
            this.pnl_cima.Location = new System.Drawing.Point(12, 12);
            this.pnl_cima.Name = "pnl_cima";
            this.pnl_cima.Size = new System.Drawing.Size(410, 82);
            this.pnl_cima.TabIndex = 1;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(19, 21);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(372, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // btn_Adiciona
            // 
            this.btn_Adiciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adiciona.Location = new System.Drawing.Point(277, 47);
            this.btn_Adiciona.Name = "btn_Adiciona";
            this.btn_Adiciona.Size = new System.Drawing.Size(114, 32);
            this.btn_Adiciona.TabIndex = 2;
            this.btn_Adiciona.Text = "Adicionar";
            this.btn_Adiciona.UseVisualStyleBackColor = true;
            this.btn_Adiciona.Click += new System.EventHandler(this.btn_Adiciona_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(277, 9);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(114, 35);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Remover";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // pnl_meio
            // 
            this.pnl_meio.Controls.Add(this.lst_1);
            this.pnl_meio.Location = new System.Drawing.Point(12, 100);
            this.pnl_meio.Name = "pnl_meio";
            this.pnl_meio.Size = new System.Drawing.Size(410, 519);
            this.pnl_meio.TabIndex = 3;
            // 
            // pnl_baixo
            // 
            this.pnl_baixo.Controls.Add(this.btn_Remove);
            this.pnl_baixo.Location = new System.Drawing.Point(12, 625);
            this.pnl_baixo.Name = "pnl_baixo";
            this.pnl_baixo.Size = new System.Drawing.Size(410, 54);
            this.pnl_baixo.TabIndex = 4;
            // 
            // lst_1
            // 
            this.lst_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_1.FormattingEnabled = true;
            this.lst_1.ItemHeight = 31;
            this.lst_1.Location = new System.Drawing.Point(19, 13);
            this.lst_1.Name = "lst_1";
            this.lst_1.Size = new System.Drawing.Size(372, 500);
            this.lst_1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 689);
            this.Controls.Add(this.pnl_baixo);
            this.Controls.Add(this.pnl_meio);
            this.Controls.Add(this.pnl_cima);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Utilizadores válidos";
            this.pnl_cima.ResumeLayout(false);
            this.pnl_cima.PerformLayout();
            this.pnl_meio.ResumeLayout(false);
            this.pnl_baixo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_cima;
        private System.Windows.Forms.Button btn_Adiciona;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Panel pnl_meio;
        private System.Windows.Forms.Panel pnl_baixo;
        private System.Windows.Forms.ListBox lst_1;
    }
}

