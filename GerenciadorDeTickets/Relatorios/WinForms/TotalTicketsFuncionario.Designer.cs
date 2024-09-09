namespace GerenciadorDeTickets.Relatorios.WinForms
{
    partial class TotalTicketsFuncionario
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
            this.rvTotalTickets = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvTotalTickets
            // 
            this.rvTotalTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvTotalTickets.LocalReport.ReportEmbeddedResource = "GerenciadorDeTickets.Relatorios.ReportViewer.TotalTickets.rdlc";
            this.rvTotalTickets.Location = new System.Drawing.Point(0, 0);
            this.rvTotalTickets.Name = "rvTotalTickets";
            this.rvTotalTickets.ServerReport.BearerToken = null;
            this.rvTotalTickets.Size = new System.Drawing.Size(800, 450);
            this.rvTotalTickets.TabIndex = 0;
            // 
            // TotalTicketsFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvTotalTickets);
            this.Name = "TotalTicketsFuncionario";
            this.Text = "Total de Tickets";
            this.Load += new System.EventHandler(this.TotalTicketsByFuncionario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvTotalTickets;
    }
}