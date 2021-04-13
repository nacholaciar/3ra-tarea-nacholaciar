﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miapp_2
{
    public partial class AltaPersona : Form
    {
        public AltaPersona()
        {
            InitializeComponent();
        }

        private void AltaPersona_Load(object sender, EventArgs e)
        {
            txtCantidadH.Enabled = false;

            cbCarrera.Items.Add("Ing. En Sistemas de Informacion");
            cbCarrera.Items.Add("Ing. Mecanica");
            cbCarrera.Items.Add("Ing. Quimica");

            cbTDocumento.Items.Add("DNI");
            cbTDocumento.Items.Add("Pasaporte");
            cbTDocumento.Items.Add("Librete universitaria");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void lblDocumento_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ckHijo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHijo.Checked)
            {
                txtCantidadH.Enabled = true;
            }
            else
            {
                txtCantidadH.Enabled = false;
            }
        }

        private void lblCantidadH_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarPersona_Click(object sender, EventArgs e)
        {
            string resultado = "";

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nacimiento = mskNacimiento.Text;
            string sexo = "";
            if (rdMasculino.Checked)
            {
                sexo = "Masculino";
            }
            if (rdFemenino.Checked)
            {
                sexo = "Femenino";
            }
            if (rdOtro.Checked)
            {
                sexo = "Otro";
            }

            string tipoDucmento = cbTDocumento.GetItemText(cbTDocumento.SelectedItem);
            string nroDocumento = maskDNI.Text;
            string calle = lblCalle.Text;
            string nroCasa = lblNroCasa.Text;

            string soltero = "";
            string casado = "";
            string hijos = "";
            string cantidadHijos = "";

            if (ckSoltero.Checked)
            {
                soltero = "Soltero";
            }
            else
            {
                soltero = "No es soltero";
            }

            if(ckCasado.Checked == true)
            {
                casado = "Casado";
            }
            else
            {
                casado = "No es casado";
            }

            if (ckHijo.Checked)
            {
                hijos = "Si tiene hijos";
                // txtCantidadH.Enabled = true;

            }
            else
            {
                hijos = "no tiene hijos";
            }

            cantidadHijos = txtCantidadH.Text;

            string carrera = cbCarrera.GetItemText(cbCarrera.SelectedItem);
            MessageBox.Show(nombre + " " + apellido + " " + sexo + " " + tipoDucmento + " " + nroDocumento);
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCmapos();
        }

        private void LimpiarCmapos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            mskNacimiento.Text = "";
            rdMasculino.Checked = true;
            maskDNI.Text = "";
            txtCalle.Text = "";
            txtNroCasa.Text = "";
            ckSoltero.Checked = false;
            ckCasado.Checked = false;
            ckHijo.Checked = false;

        }
    }
}
