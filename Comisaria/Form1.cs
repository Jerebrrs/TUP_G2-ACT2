using Comisaria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Comisaria.Models.Comisaria nuevaComisaria = new Comisaria.Models.Comisaria();

        private void btnCrearComi_Click(object sender, EventArgs e)
        {

            Policia pol1 = new Policia(37550129, "Juan", 123);
            Policia pol2 = new Policia(3936919, "Ana", 456);
            if (nuevaComisaria.AsignarPolicia(pol1) == true && nuevaComisaria.AsignarPolicia(pol2) == true)
            {
                MessageBox.Show("Se creo la comisaria.");
            }
            else
            {
                MessageBox.Show("No se creo la comisaria.");
            }
            btnCrearComi.Text = $"Comisarias (1)";
            cbAgentes.Items.Clear();
            foreach (var agente in nuevaComisaria.agentes)
            {
                cbAgentes.Items.Add(agente.NumeroPlaca.ToString());
            }
        }
        private void cbAgentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbPlaca_Click(object sender, EventArgs e)
        {

        }

        private void lbDesde_Click(object sender, EventArgs e)
        {

        }

        private void btnAsigGuardias_Click(object sender, EventArgs e)
        {
            int placaAgente = Convert.ToInt32(cbAgentes.Text);


            if (nuevaComisaria.VerAgente(placaAgente) != null)
            {
                int guard = Convert.ToInt32(domUpNroGuardia.Text);
                int hi = Convert.ToInt32(doUpHInicio.Text);
                int mi = Convert.ToInt32(doUpduacionMin.Text);
                int durMinu = Convert.ToInt32(doUpduacionMin.Text);
                nuevaComisaria.AsignarGuardia(guard, hi, mi, durMinu, placaAgente);

            }

            btnAsigGuardias.Text = $"Asignar Guardia ({nuevaComisaria.guardias.Count} creadas)";

            domUpNroGuardia.Text = "";
            doUpHInicio.Text = "";
            doUpduacionMin.Text = "";
            cbAgentes.SelectedIndex = -1;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
