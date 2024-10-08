﻿namespace GerenciadorDeTickets.Views
{
    partial class FuncionarioView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFuncionarioList = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.tpFuncionarioDetalhes = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTxtData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tpFuncionarioList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.tpFuncionarioDetalhes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tpFuncionarioList);
            this.tabControl1.Controls.Add(this.tpFuncionarioDetalhes);
            this.tabControl1.Location = new System.Drawing.Point(14, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 374);
            this.tabControl1.TabIndex = 0;
            // 
            // tpFuncionarioList
            // 
            this.tpFuncionarioList.Controls.Add(this.label4);
            this.tpFuncionarioList.Controls.Add(this.btnImprimir);
            this.tpFuncionarioList.Controls.Add(this.btnBuscar);
            this.tpFuncionarioList.Controls.Add(this.btnAlterar);
            this.tpFuncionarioList.Controls.Add(this.txtBuscar);
            this.tpFuncionarioList.Controls.Add(this.btnNovo);
            this.tpFuncionarioList.Controls.Add(this.dgvFuncionarios);
            this.tpFuncionarioList.Location = new System.Drawing.Point(4, 22);
            this.tpFuncionarioList.Name = "tpFuncionarioList";
            this.tpFuncionarioList.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionarioList.Size = new System.Drawing.Size(579, 348);
            this.tpFuncionarioList.TabIndex = 0;
            this.tpFuncionarioList.Text = "Listagem";
            this.tpFuncionarioList.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(-1, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Busca por NOME ou ID do funcionario";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(5, 313);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(64, 30);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(504, 22);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 30);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(436, 313);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(64, 30);
            this.btnAlterar.TabIndex = 2;
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
            this.txtBuscar.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(504, 313);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(64, 30);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(2, 57);
            this.dgvFuncionarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersWidth = 51;
            this.dgvFuncionarios.RowTemplate.Height = 24;
            this.dgvFuncionarios.Size = new System.Drawing.Size(567, 252);
            this.dgvFuncionarios.TabIndex = 11;
            // 
            // tpFuncionarioDetalhes
            // 
            this.tpFuncionarioDetalhes.Controls.Add(this.txtData);
            this.tpFuncionarioDetalhes.Controls.Add(this.btnCancelar);
            this.tpFuncionarioDetalhes.Controls.Add(this.cbSituacao);
            this.tpFuncionarioDetalhes.Controls.Add(this.btnSalvar);
            this.tpFuncionarioDetalhes.Controls.Add(this.txtCpf);
            this.tpFuncionarioDetalhes.Controls.Add(this.txtNome);
            this.tpFuncionarioDetalhes.Controls.Add(this.lblId);
            this.tpFuncionarioDetalhes.Controls.Add(this.label5);
            this.tpFuncionarioDetalhes.Controls.Add(this.lblTxtData);
            this.tpFuncionarioDetalhes.Controls.Add(this.label3);
            this.tpFuncionarioDetalhes.Controls.Add(this.label2);
            this.tpFuncionarioDetalhes.Controls.Add(this.lblNome);
            this.tpFuncionarioDetalhes.Location = new System.Drawing.Point(4, 22);
            this.tpFuncionarioDetalhes.Name = "tpFuncionarioDetalhes";
            this.tpFuncionarioDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionarioDetalhes.Size = new System.Drawing.Size(579, 348);
            this.tpFuncionarioDetalhes.TabIndex = 1;
            this.tpFuncionarioDetalhes.Text = "Detalhes";
            this.tpFuncionarioDetalhes.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(16, 250);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.ItemHeight = 13;
            this.cbSituacao.Location = new System.Drawing.Point(90, 161);
            this.cbSituacao.Margin = new System.Windows.Forms.Padding(2);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(92, 21);
            this.cbSituacao.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(341, 250);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 30);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(90, 116);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Multiline = true;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(314, 26);
            this.txtCpf.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 79);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.MaxLength = 255;
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Location = new System.Drawing.Point(90, 40);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(98, 26);
            this.lblId.TabIndex = 0;
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
            this.label5.TabIndex = 1;
            this.label5.Text = "ID";
            // 
            // lblTxtData
            // 
            this.lblTxtData.AutoSize = true;
            this.lblTxtData.Location = new System.Drawing.Point(13, 209);
            this.lblTxtData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTxtData.Name = "lblTxtData";
            this.lblTxtData.Size = new System.Drawing.Size(78, 13);
            this.lblTxtData.TabIndex = 10;
            this.lblTxtData.Text = "Data Alteracao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Situacao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(53, 91);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 39);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionarios";
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
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(90, 196);
            this.txtData.Margin = new System.Windows.Forms.Padding(2);
            this.txtData.MaxLength = 255;
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(92, 26);
            this.txtData.TabIndex = 11;
            // 
            // FuncionarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FuncionarioView";
            this.Text = "Funcionarios";
            this.tabControl1.ResumeLayout(false);
            this.tpFuncionarioList.ResumeLayout(false);
            this.tpFuncionarioList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.tpFuncionarioDetalhes.ResumeLayout(false);
            this.tpFuncionarioDetalhes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFuncionarioList;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TabPage tpFuncionarioDetalhes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTxtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtData;
    }
}