namespace ProgramaEconomia
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
            this.cbbTipoDebito = new System.Windows.Forms.ComboBox();
            this.txtValorDebito = new System.Windows.Forms.TextBox();
            this.btnSalvarDebito = new System.Windows.Forms.Button();
            this.dttDebitos = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbbTipoCredito = new System.Windows.Forms.ComboBox();
            this.Debitar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarCredito = new System.Windows.Forms.Button();
            this.txtValorCredito = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dttDebitos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTipoDebito
            // 
            this.cbbTipoDebito.FormattingEnabled = true;
            this.cbbTipoDebito.Location = new System.Drawing.Point(88, 80);
            this.cbbTipoDebito.Name = "cbbTipoDebito";
            this.cbbTipoDebito.Size = new System.Drawing.Size(170, 21);
            this.cbbTipoDebito.TabIndex = 0;
            // 
            // txtValorDebito
            // 
            this.txtValorDebito.Location = new System.Drawing.Point(401, 80);
            this.txtValorDebito.Name = "txtValorDebito";
            this.txtValorDebito.Size = new System.Drawing.Size(100, 20);
            this.txtValorDebito.TabIndex = 1;
            // 
            // btnSalvarDebito
            // 
            this.btnSalvarDebito.Location = new System.Drawing.Point(638, 77);
            this.btnSalvarDebito.Name = "btnSalvarDebito";
            this.btnSalvarDebito.Size = new System.Drawing.Size(119, 23);
            this.btnSalvarDebito.TabIndex = 2;
            this.btnSalvarDebito.Text = "Salvar Débito";
            this.btnSalvarDebito.UseVisualStyleBackColor = true;
            this.btnSalvarDebito.Click += new System.EventHandler(this.btnSalvarDebito_Click);
            // 
            // dttDebitos
            // 
            this.dttDebitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dttDebitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Tipo,
            this.SubTipo,
            this.Descrição,
            this.Valor,
            this.Excluir});
            this.dttDebitos.Location = new System.Drawing.Point(17, 246);
            this.dttDebitos.Name = "dttDebitos";
            this.dttDebitos.Size = new System.Drawing.Size(717, 163);
            this.dttDebitos.TabIndex = 3;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // SubTipo
            // 
            this.SubTipo.HeaderText = "SubTipo";
            this.SubTipo.Name = "SubTipo";
            this.SubTipo.ReadOnly = true;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            // 
            // cbbTipoCredito
            // 
            this.cbbTipoCredito.FormattingEnabled = true;
            this.cbbTipoCredito.Location = new System.Drawing.Point(88, 122);
            this.cbbTipoCredito.Name = "cbbTipoCredito";
            this.cbbTipoCredito.Size = new System.Drawing.Size(170, 21);
            this.cbbTipoCredito.TabIndex = 4;
            // 
            // Debitar
            // 
            this.Debitar.AutoSize = true;
            this.Debitar.Location = new System.Drawing.Point(14, 88);
            this.Debitar.Name = "Debitar";
            this.Debitar.Size = new System.Drawing.Size(41, 13);
            this.Debitar.TabIndex = 5;
            this.Debitar.Text = "Debitar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Creditar";
            // 
            // btnSalvarCredito
            // 
            this.btnSalvarCredito.Location = new System.Drawing.Point(638, 124);
            this.btnSalvarCredito.Name = "btnSalvarCredito";
            this.btnSalvarCredito.Size = new System.Drawing.Size(119, 23);
            this.btnSalvarCredito.TabIndex = 7;
            this.btnSalvarCredito.Text = "Salvar Crédito";
            this.btnSalvarCredito.UseVisualStyleBackColor = true;
            this.btnSalvarCredito.Click += new System.EventHandler(this.btnSalvarCredito_Click);
            // 
            // txtValorCredito
            // 
            this.txtValorCredito.Location = new System.Drawing.Point(401, 126);
            this.txtValorCredito.Name = "txtValorCredito";
            this.txtValorCredito.Size = new System.Drawing.Size(100, 20);
            this.txtValorCredito.TabIndex = 8;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(88, 204);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(355, 20);
            this.txtDescricao.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrição";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(14, 174);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data";
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(88, 174);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(100, 20);
            this.mskData.TabIndex = 13;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Valor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtValorCredito);
            this.Controls.Add(this.btnSalvarCredito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Debitar);
            this.Controls.Add(this.cbbTipoCredito);
            this.Controls.Add(this.dttDebitos);
            this.Controls.Add(this.btnSalvarDebito);
            this.Controls.Add(this.txtValorDebito);
            this.Controls.Add(this.cbbTipoDebito);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dttDebitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTipoDebito;
        private System.Windows.Forms.TextBox txtValorDebito;
        private System.Windows.Forms.Button btnSalvarDebito;
        private System.Windows.Forms.DataGridView dttDebitos;
        private System.Windows.Forms.ComboBox cbbTipoCredito;
        private System.Windows.Forms.Label Debitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarCredito;
        private System.Windows.Forms.TextBox txtValorCredito;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

