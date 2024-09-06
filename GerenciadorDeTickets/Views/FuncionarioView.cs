﻿using GerenciadorDeTickets.Models;
using GerenciadorDeTickets.Relatorios.WinForms;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets.Views
{
    public partial class FuncionarioView : Form, IFuncionarioView
    {
        DataTable dt = new DataTable();

        public FuncionarioView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tpFuncionarioDetalhes);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnBuscar.Click  += delegate 
            { 
                SearchEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Add(tpFuncionarioList);
                tabControl1.TabPages.Remove(tpFuncionarioDetalhes);
            };
            btnNovo.Click    += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpFuncionarioList);
                tabControl1.TabPages.Add(tpFuncionarioDetalhes);
                tpFuncionarioDetalhes.Text = "Adicionar Funcionario";
                
            };
            btnAlterar.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpFuncionarioList);
                tabControl1.TabPages.Add(tpFuncionarioDetalhes);
                tpFuncionarioDetalhes.Text = "Atualizar Funcionario";
            };
            btnSalvar.Click  += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tpFuncionarioDetalhes);
                    tabControl1.TabPages.Add(tpFuncionarioList);
                }

                MessageBox.Show(Message);
            };
            btnVoltar.Click += delegate
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpFuncionarioDetalhes);
                tabControl1.TabPages.Add(tpFuncionarioList);

            };
            btnFechar.Click  += delegate { this.Close(); };

        }

        private void Inicializar()
        {
            //dt = FuncionarioModel.GetDataTableFuncionarios();
            //dgvFuncionarios.DataSource = dt;
            //ConfigurarGridViewFuncionarios();
        }

        //     private void ConfigurarGridViewFuncionarios()
        //        {
        //            dgvFuncionarios.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
        //            dgvFuncionarios.DefaultCellStyle.Font = new Font("Arial", 8);
        //            dgvFuncionarios.RowHeadersWidth = 25;

        //            dgvFuncionarios.Columns["id"].HeaderText = "ID";
        //            dgvFuncionarios.Columns["id"].Width = 50;
        //            dgvFuncionarios.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvFuncionarios.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        //            dgvFuncionarios.Columns["nome"].HeaderText = "NOME";
        //            dgvFuncionarios.Columns["nome"].Width = 150;
        //            dgvFuncionarios.Columns["nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvFuncionarios.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        //            dgvFuncionarios.Columns["cpf"].HeaderText = "CPF";
        //            dgvFuncionarios.Columns["cpf"].Width = 120;
        //            dgvFuncionarios.Columns["cpf"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvFuncionarios.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        //            dgvFuncionarios.Columns["situacao"].HeaderText = "SITUAÇÃO";
        //            dgvFuncionarios.Columns["situacao"].Width = 100;
        //            dgvFuncionarios.Columns["situacao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvFuncionarios.Columns["situacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        //            dgvFuncionarios.Columns["data_alteracao"].HeaderText = "DATA ALTERAÇÃO";
        //            dgvFuncionarios.Columns["data_alteracao"].Width = 150;
        //            dgvFuncionarios.Columns["data_alteracao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvFuncionarios.Columns["data_alteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        //            dgvFuncionarios.Sort(dgvFuncionarios.Columns["Nome"], ListSortDirection.Ascending);

        //}       
        private DataTable GerarDadosRelatorioFuncionario()
        {
            var dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nome");
            dt.Columns.Add("cpf");
            dt.Columns.Add("situacao");
            dt.Columns.Add("alteracao");

            foreach (DataGridViewRow item in dgvFuncionarios.Rows)
            {
                dt.Rows.Add(item.Cells["id"].Value.ToString(), item.Cells["nome"].Value.ToString(), item.Cells["cpf"].Value.ToString(), item.Cells["situacao"].Value.ToString(), item.Cells["data_alteracao"].Value.ToString());
            }

            return dt;
        }

        public void SetFuncionarioBidingSource(BindingSource funcionarioDt)
        {
            dgvFuncionarios.DataSource = funcionarioDt;
        }
        public string FuncionarioId 
        {
            get { return lblId.Text; } 
            set { lblId.Text = value; } 
        }
        public string FuncionarioNome
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }
        public string FuncionarioCpf
        {
            get { return txtCpf.Text; }
            set { txtCpf.Text = value; }
        }
        public string FuncionarioSituacao
        {
            get { return cbSituacao.Text; }
            set { cbSituacao.Text = value; }
        }
        public string FuncionarioDataAlteracao
        {
            get { return lblData.Text; }
            set { lblData.Text = value; }
        }
        public string SearchValue
        {
            get { return txtBuscar.Text; }
            set { txtBuscar.Text = value; }
        }
        public bool IsEdit{ get; set;}
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }


        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private static FuncionarioView instance;
        public static FuncionarioView GetInstance(Form parentContainer)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new FuncionarioView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            
            return instance;
        }


    }
}