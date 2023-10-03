﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaPatrick
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Tela = new Form1();
            Tela.Show();
            this.Hide();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Serviços Tela = new Serviços();
            Tela.Show();
            this.Hide();
        }

        private void btnConsultarAgendamento_Click(object sender, EventArgs e)
        {
            ConsultarAgendamento Tela = new ConsultarAgendamento();
            Tela.Show();
            this.Hide();
        }
    }
}