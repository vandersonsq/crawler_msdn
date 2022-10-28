
namespace ConsultaMSDN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exibição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Postagem,
            this.Exibição,
            this.Resposta,
            this.Link});
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(907, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 300;
            // 
            // Postagem
            // 
            this.Postagem.HeaderText = "Postagem";
            this.Postagem.Name = "Postagem";
            this.Postagem.Width = 150;
            // 
            // Exibição
            // 
            this.Exibição.HeaderText = "Exibição";
            this.Exibição.Name = "Exibição";
            // 
            // Resposta
            // 
            this.Resposta.HeaderText = "Resposta";
            this.Resposta.Name = "Resposta";
            this.Resposta.Width = 80;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.Width = 250;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(12, 12);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(118, 39);
            this.btAtualizar.TabIndex = 1;
            this.btAtualizar.Text = "Atualizar Lista";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 511);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Consulta MSDN C#";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exibição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.Button btAtualizar;
    }
}

