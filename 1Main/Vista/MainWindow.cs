﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1Main.Controlador;

namespace _1Main.Vista
{
    public partial class MainWindow: Form
    {
        public MainWindow()
        {
            InitializeComponent();

//            var queryResult = new VotantesDbController();
//            MessageBox.Show(queryResult.MigrationDB());

            BackgroundImage = null;
        }

        private void consultarMiembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var win = ConsultarMiembros.Instance;

            win.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "¿Seguro que quieres salir?";
            const string caption = "Salir";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
