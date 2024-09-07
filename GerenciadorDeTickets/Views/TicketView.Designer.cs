﻿namespace GerenciadorDeTickets.Views
{
    partial class TicketView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTicketList = new System.Windows.Forms.TabPage();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.tpTicketDetalhes = new System.Windows.Forms.TabPage();
            this.nupQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.txtFuncionairoNome = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTxtData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtFuncionarioId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpTicketList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.tpTicketDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(105, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 39);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tickets";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(554, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 30);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tpTicketList);
            this.tabControl1.Controls.Add(this.tpTicketDetalhes);
            this.tabControl1.Location = new System.Drawing.Point(105, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 374);
            this.tabControl1.TabIndex = 19;
            // 
            // tpTicketList
            // 
            this.tpTicketList.Controls.Add(this.btnImprimir);
            this.tpTicketList.Controls.Add(this.btnBuscar);
            this.tpTicketList.Controls.Add(this.btnAlterar);
            this.tpTicketList.Controls.Add(this.txtBuscar);
            this.tpTicketList.Controls.Add(this.btnNovo);
            this.tpTicketList.Controls.Add(this.dgvTickets);
            this.tpTicketList.Location = new System.Drawing.Point(4, 22);
            this.tpTicketList.Name = "tpTicketList";
            this.tpTicketList.Padding = new System.Windows.Forms.Padding(3);
            this.tpTicketList.Size = new System.Drawing.Size(583, 348);
            this.tpTicketList.TabIndex = 0;
            this.tpTicketList.Text = "Listagem";
            this.tpTicketList.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(5, 313);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(64, 30);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(504, 22);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 30);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(436, 313);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(64, 30);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(2, 22);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(499, 31);
            this.txtBuscar.TabIndex = 13;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(504, 313);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(64, 30);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Location = new System.Drawing.Point(2, 57);
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.RowHeadersWidth = 51;
            this.dgvTickets.RowTemplate.Height = 24;
            this.dgvTickets.Size = new System.Drawing.Size(567, 252);
            this.dgvTickets.TabIndex = 11;
            // 
            // tpTicketDetalhes
            // 
            this.tpTicketDetalhes.Controls.Add(this.txtFuncionarioId);
            this.tpTicketDetalhes.Controls.Add(this.nupQuantidade);
            this.tpTicketDetalhes.Controls.Add(this.btnBuscarFuncionario);
            this.tpTicketDetalhes.Controls.Add(this.btnCancelar);
            this.tpTicketDetalhes.Controls.Add(this.cbSituacao);
            this.tpTicketDetalhes.Controls.Add(this.btnSalvar);
            this.tpTicketDetalhes.Controls.Add(this.lblData);
            this.tpTicketDetalhes.Controls.Add(this.txtFuncionairoNome);
            this.tpTicketDetalhes.Controls.Add(this.lblId);
            this.tpTicketDetalhes.Controls.Add(this.label5);
            this.tpTicketDetalhes.Controls.Add(this.lblTxtData);
            this.tpTicketDetalhes.Controls.Add(this.label3);
            this.tpTicketDetalhes.Controls.Add(this.label2);
            this.tpTicketDetalhes.Controls.Add(this.lblNome);
            this.tpTicketDetalhes.Location = new System.Drawing.Point(4, 22);
            this.tpTicketDetalhes.Name = "tpTicketDetalhes";
            this.tpTicketDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tpTicketDetalhes.Size = new System.Drawing.Size(583, 348);
            this.tpTicketDetalhes.TabIndex = 1;
            this.tpTicketDetalhes.Text = "Detalhes";
            this.tpTicketDetalhes.UseVisualStyleBackColor = true;
            // 
            // nupQuantidade
            // 
            this.nupQuantidade.Location = new System.Drawing.Point(90, 122);
            this.nupQuantidade.Name = "nupQuantidade";
            this.nupQuantidade.Size = new System.Drawing.Size(98, 20);
            this.nupQuantidade.TabIndex = 40;
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(410, 79);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(44, 26);
            this.btnBuscarFuncionario.TabIndex = 39;
            this.btnBuscarFuncionario.Text = "...";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(16, 250);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 30);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(90, 161);
            this.cbSituacao.Margin = new System.Windows.Forms.Padding(2);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(98, 21);
            this.cbSituacao.TabIndex = 37;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(341, 250);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 30);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            this.lblData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblData.Location = new System.Drawing.Point(90, 197);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(98, 26);
            this.lblData.TabIndex = 34;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFuncionairoNome
            // 
            this.txtFuncionairoNome.Location = new System.Drawing.Point(135, 79);
            this.txtFuncionairoNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtFuncionairoNome.MaxLength = 255;
            this.txtFuncionairoNome.Multiline = true;
            this.txtFuncionairoNome.Name = "txtFuncionairoNome";
            this.txtFuncionairoNome.Size = new System.Drawing.Size(270, 26);
            this.txtFuncionairoNome.TabIndex = 32;
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Location = new System.Drawing.Point(90, 40);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(98, 26);
            this.lblId.TabIndex = 31;
            this.lblId.Text = "0";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "ID";
            // 
            // lblTxtData
            // 
            this.lblTxtData.AutoSize = true;
            this.lblTxtData.Location = new System.Drawing.Point(13, 209);
            this.lblTxtData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTxtData.Name = "lblTxtData";
            this.lblTxtData.Size = new System.Drawing.Size(78, 13);
            this.lblTxtData.TabIndex = 29;
            this.lblTxtData.Text = "Data Alteracao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Situacao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Quantidade";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 92);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 13);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Funcionario";
            // 
            // txtFuncionarioId
            // 
            this.txtFuncionarioId.Location = new System.Drawing.Point(90, 79);
            this.txtFuncionarioId.Margin = new System.Windows.Forms.Padding(2);
            this.txtFuncionarioId.MaxLength = 255;
            this.txtFuncionarioId.Multiline = true;
            this.txtFuncionarioId.Name = "txtFuncionarioId";
            this.txtFuncionarioId.Size = new System.Drawing.Size(41, 26);
            this.txtFuncionarioId.TabIndex = 41;
            // 
            // TicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "TicketView";
            this.Text = "TicketView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpTicketList.ResumeLayout(false);
            this.tpTicketList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.tpTicketDetalhes.ResumeLayout(false);
            this.tpTicketDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTicketList;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.TabPage tpTicketDetalhes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtFuncionairoNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTxtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnBuscarFuncionario;
        private System.Windows.Forms.NumericUpDown nupQuantidade;
        private System.Windows.Forms.TextBox txtFuncionarioId;
    }
}