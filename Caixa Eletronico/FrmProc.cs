﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caixa_Eletronico.Classes;

namespace Caixa_Eletronico
{
    public partial class FrmProc : Form
    {
        bool pode_N;//mudar
        bool pode_T;//mudar
        Singleton s;//mudar
        private string tipo;//mudar

        public FrmProc()//mudar
        {
            s = Singleton.Instance;
        }
        public FrmProc(string tipo) : this()//mudar
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void FrmProc_Load(object sender, EventArgs e)//mudar
        {
            LblOpcao.Text = tipo;
            if (tipo == "Transferência")
            {
                TxtConta.Visible = true;
                label2.Visible = true;
            }
        }
        private void BtnEnviar_Click(object sender, EventArgs e)//mudar
        {
            if (tipo == "Saque")
            {
                double valor = (double)NumValor.Value;
                if (s.conta_logada.Sacar(valor))
                {
                    MessageBox.Show("Saque realizado!");
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente...");
                }
            }
            if (tipo == "Depósito")
            {
                double valor = (double)NumValor.Value;
                s.conta_logada.Depositar(valor);
                MessageBox.Show("Depósito realizado!");
            }
            if (tipo == "Transferência")
            {
                double valor = (double)NumValor.Value;
                Conta destino = s.BuscarConta(TxtConta.Text);
                if (destino != null)
                {
                    if (s.conta_logada.Transferir(destino, valor))
                    {
                        MessageBox.Show("Transferência realizada!");
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente...!");
                    }
                }
                else
                {
                    MessageBox.Show("Conta destino não existe!");
                }
            }
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Hide();
        }
        private void numValor_ValueChanged(object sender, EventArgs e)//mudar
        {
            if (tipo != "Transferência")
            {
                if (NumValor.Value != 0)
                {
                    BtnEnviar.Enabled = true;
                }
                else
                {
                    BtnEnviar.Enabled = false;
                }
            }
            else
            {
                if (NumValor.Value != 0)
                {
                    pode_N = true;
                    CheckEnableBtFazer();
                }
                else
                {
                    pode_N = false;
                    CheckEnableBtFazer();
                }
            }
        }

        private void txtConta_TextChanged(object sender, EventArgs e)//mudar
        {
            if (TxtConta.Text != "")
            {
                pode_T = true;
                CheckEnableBtFazer();
            }
            else
            {
                BtnEnviar.Enabled = false;
            }
        }
        private void CheckEnableBtFazer()//mudar
        {
            if (tipo == "Transferência")
            {
                BtnEnviar.Enabled = pode_N && pode_T;
            }
        }

    }
}