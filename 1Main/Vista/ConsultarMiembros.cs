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
    public partial class ConsultarMiembros : Form
    {
        #region Singleton
        private static ConsultarMiembros instance;

        public static ConsultarMiembros Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new ConsultarMiembros();
                }
                return instance;
            }
        }
        #endregion

        private ConsultarMiembros()
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        
        private void activatePanels(RadioButton rbButton)
        {
            if (rbButton.Name == rbCedula.Name && rbButton.Checked == true)
            {
                panelCedula.Visible = true;
                panelApellidos.Visible = false;
                panelNombresYApellidos.Visible = false;
            }
            else if (rbButton.Name == rbApellidos.Name && rbButton.Checked == true)
            {
                panelApellidos.Visible = true;
                panelCedula.Visible = false;
                panelNombresYApellidos.Visible = false;
            }
            else if (rbButton.Name == rbNombresYApellidos.Name && rbButton.Checked == true)
            {
                panelNombresYApellidos.Visible = true;
                panelCedula.Visible = false;
                panelApellidos.Visible = false;
            }
        }

        private void panelCedulabBuscar_Click(object sender, EventArgs e)
        {

        }

        private void panelApellidosbBuscar_Click(object sender, EventArgs e)
        {

        }

        private void panelNombreYApellidosbBuscar_Click(object sender, EventArgs e)
        {

        }

        private void rbCedula_CheckedChanged(object sender, EventArgs e)
        {
            activatePanels(rbCedula);
        }

        private void rbApellidos_CheckedChanged(object sender, EventArgs e)
        {
            activatePanels(rbApellidos);
        }

        private void rbNombresYApellidos_CheckedChanged(object sender, EventArgs e)
        {
            activatePanels(rbNombresYApellidos);
        }
    }
}
