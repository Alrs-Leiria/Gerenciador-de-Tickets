namespace GerenciadorDeTickets.Views
{
    partial class RelatorioView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAgrupar = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.cbTodos = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFuncionarioId = new System.Windows.Forms.TextBox();
            this.txtFuncionairoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTotalQuantidadeTickets = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.lblTotalQuantidadeTickets);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbAgrupar);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.dgvRelatorio);
            this.panel2.Controls.Add(this.dtInicial);
            this.panel2.Controls.Add(this.dtFinal);
            this.panel2.Controls.Add(this.cbTodos);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFuncionarioId);
            this.panel2.Controls.Add(this.txtFuncionairoNome);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnGerar);
            this.panel2.Location = new System.Drawing.Point(14, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 367);
            this.panel2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Quantidade total de tickets no periodo: ";
            // 
            // cbAgrupar
            // 
            this.cbAgrupar.AutoSize = true;
            this.cbAgrupar.Location = new System.Drawing.Point(325, 137);
            this.cbAgrupar.Name = "cbAgrupar";
            this.cbAgrupar.Size = new System.Drawing.Size(63, 17);
            this.cbAgrupar.TabIndex = 50;
            this.cbAgrupar.Text = "Agrupar";
            this.cbAgrupar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(491, 114);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 29);
            this.btnImprimir.TabIndex = 49;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.AllowUserToAddRows = false;
            this.dgvRelatorio.AllowUserToDeleteRows = false;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Location = new System.Drawing.Point(40, 168);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.ReadOnly = true;
            this.dgvRelatorio.Size = new System.Drawing.Size(526, 179);
            this.dgvRelatorio.TabIndex = 48;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(40, 48);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(120, 20);
            this.dtInicial.TabIndex = 47;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(190, 48);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(120, 20);
            this.dtFinal.TabIndex = 46;
            // 
            // cbTodos
            // 
            this.cbTodos.AutoSize = true;
            this.cbTodos.Location = new System.Drawing.Point(325, 114);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(56, 17);
            this.cbTodos.TabIndex = 45;
            this.cbTodos.Text = "Todos";
            this.cbTodos.UseVisualStyleBackColor = true;
            this.cbTodos.CheckedChanged += new System.EventHandler(this.cbTodos_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Funcionario";
            // 
            // txtFuncionarioId
            // 
            this.txtFuncionarioId.Location = new System.Drawing.Point(40, 114);
            this.txtFuncionarioId.Margin = new System.Windows.Forms.Padding(2);
            this.txtFuncionarioId.MaxLength = 255;
            this.txtFuncionarioId.Multiline = true;
            this.txtFuncionarioId.Name = "txtFuncionarioId";
            this.txtFuncionarioId.Size = new System.Drawing.Size(41, 26);
            this.txtFuncionarioId.TabIndex = 43;
            this.txtFuncionarioId.Text = "0";
            // 
            // txtFuncionairoNome
            // 
            this.txtFuncionairoNome.Enabled = false;
            this.txtFuncionairoNome.Location = new System.Drawing.Point(85, 114);
            this.txtFuncionairoNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtFuncionairoNome.MaxLength = 255;
            this.txtFuncionairoNome.Multiline = true;
            this.txtFuncionairoNome.Name = "txtFuncionairoNome";
            this.txtFuncionairoNome.Size = new System.Drawing.Size(225, 26);
            this.txtFuncionairoNome.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Periodo";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(410, 114);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 29);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 39);
            this.panel1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total de tickets por funcionário";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFechar.Location = new System.Drawing.Point(533, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 30);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // lblTotalQuantidadeTickets
            // 
            this.lblTotalQuantidadeTickets.AutoSize = true;
            this.lblTotalQuantidadeTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantidadeTickets.Location = new System.Drawing.Point(236, 350);
            this.lblTotalQuantidadeTickets.Name = "lblTotalQuantidadeTickets";
            this.lblTotalQuantidadeTickets.Size = new System.Drawing.Size(14, 17);
            this.lblTotalQuantidadeTickets.TabIndex = 52;
            this.lblTotalQuantidadeTickets.Text = "-";
            // 
            // RelatorioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "RelatorioView";
            this.Text = "RelatorioView";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtFuncionarioId;
        private System.Windows.Forms.TextBox txtFuncionairoNome;
        private System.Windows.Forms.CheckBox cbTodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.CheckBox cbAgrupar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalQuantidadeTickets;
    }
}