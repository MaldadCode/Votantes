using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Main.Vista
{
    public partial class MainWindow: Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void consultarMiembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarMiembros win = ConsultarMiembros.Instance;

            win.ShowDialog();
        }
    }
}
