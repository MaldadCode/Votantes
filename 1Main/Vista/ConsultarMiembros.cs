using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        #region Constructor
        private ConsultarMiembros()
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        #endregion

        #region Metodos Auxiliares
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

        private string[] DictValuesToList(Dictionary<string, string> dictionary)
        {
            var result = new string[dictionary.Count];

            for (int i = 0; i < dictionary.Count; i++)
            {
                result[i] = dictionary.Values.ToList()[i];
            }

            return result;
        }

        private string GetNumbersOfParams(int count)
        {
            var numbersOfParams = string.Empty;
            for (int i = 0; i < count; i++)
            {
                numbersOfParams += numbersOfParams.Length > 0 ?
                    "\n{/holder}".Replace("/holder", i.ToString()) :
                    "{/holder}".Replace("/holder", i.ToString());
            }

            return numbersOfParams;
        }
        #endregion

        #region Panel - Botones Buscar
        private void panelCedulabBuscar_Click(object sender, EventArgs e)
        {
            var cedulaRE = new Regex(@"\d{1,3}-\d{1,7}-\d");
            var validCedula = cedulaRE.Match(panelCedulamTbCedula.Text).Success;

            if (!validCedula)
            {
                MessageBox.Show("Cedula Invalida.");
                panelCedulamTbCedula.Focus();
            }
            else
            {
                MessageBox.Show("Buscando...");
            }
        }

        private void panelApellidosbBuscar_Click(object sender, EventArgs e)
        {
            switch (panelApellidostbPrimerApellido.Text.Length)
            {
                case 0:
                    MessageBox.Show("Primer Apellido no puede quedar Vacio.");
                    panelApellidostbPrimerApellido.Focus();
                    break;
                case 1:
                case 2:
                    MessageBox.Show("Primer Apellido debe contener minimo 3 Caracteres.");
                    panelApellidostbPrimerApellido.Focus();
                    break;
                default:
                    MessageBox.Show("Buscando...");
                    break;
            }
        }

        private void panelNombreYApellidosbBuscar_Click(object sender, EventArgs e)
        {
            var flag = true;
            string[] mList;
            var errors = new Dictionary<string, string>();

            if (panelNombresYApellidostbPrimerNombre.Text.Length < 1)
            {
                errors["primerNombre"] = "Primer Nombre no puede quedar Vacio.";
                flag = false;
            }
            else if (panelNombresYApellidostbPrimerNombre.Text.Length < 3)
            {
                errors["primerNombre"] = "Primer Nombre debe contener minimo 3 Caracteres.";
                flag = false;
            }

            if (panelNombresYApellidostbPrimerApellido.Text.Length < 1)
            {
                errors["primerApellido"] = "Primer Apellido no puede quedar Vacio.";
                flag = false;
            }
            else if (panelNombresYApellidostbPrimerApellido.Text.Length < 3)
            {
                errors["primerApellido"] = "Primer Apellido debe contener minimo 3 Caracteres.";
                flag = false;
            }

            if (flag)
            {
                MessageBox.Show("Buscando...");
            }
            else
            {
                MessageBox.Show(string.Format(GetNumbersOfParams(errors.Count), DictValuesToList(errors)));

                if (panelNombresYApellidostbPrimerNombre.Text.Length < 1 &&
                    panelNombresYApellidostbPrimerApellido.Text.Length < 1)
                {
                    panelNombresYApellidostbPrimerNombre.Focus();
                }
                else if (panelNombresYApellidostbPrimerNombre.Text.Length > 2)
                {
                    panelNombresYApellidostbPrimerApellido.Focus();
                }
                else if (panelNombresYApellidostbPrimerApellido.Text.Length > 2)
                {
                    panelNombresYApellidostbPrimerNombre.Focus();
                }
                else
                {
                    panelNombresYApellidostbPrimerNombre.Focus();
                }
            }
        }
        #endregion

        #region Habilitar RadioButtons
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
        #endregion

        #region Panel - Evento KeyPress de los Botones de 'Buscar'
        private void panelApellidostbPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int) Keys.Enter)
            {
                panelApellidosbBuscar.PerformClick();
            }
        }

        private void panelApellidostbSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int) Keys.Enter)
            {
                panelApellidosbBuscar.PerformClick();
            }
        }

        private void panelCedulamTbCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int) Keys.Enter)
            {
                panelCedulabBuscar.PerformClick();
            }
        }

        private void panelNombresYApellidostbPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int) Keys.Enter)
            {
                panelNombresYApellidosbBuscar.PerformClick();
            }
        }

        private void panelNombresYApellidostbPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                panelNombresYApellidosbBuscar.PerformClick();
            }
        }

        private void panelNombresYApellidostbSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                panelNombresYApellidosbBuscar.PerformClick();
            }
        }

        private void panelNombresYApellidostbSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                panelNombresYApellidosbBuscar.PerformClick();
            }
        }
        #endregion

        private void gbInfoBtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
