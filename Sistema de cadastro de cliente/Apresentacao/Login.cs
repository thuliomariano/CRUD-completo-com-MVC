﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_cadastro_de_cliente.Apresentacao;

namespace Sistema_de_cadastro_de_cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text == "admin") && (txtSenha.Text == "123"))
            {
                Registros registros = new Registros();
                registros.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tente novamente", "Usuario ou senha está incorreto!");
            }
        }
    }
}