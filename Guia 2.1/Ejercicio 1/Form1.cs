using Ejercicio_1.Models;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DepartamentoVehicular departamento = new DepartamentoVehicular();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form2 AGpersona = new Form2();
            if (AGpersona.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(AGpersona.tbDNI.Text);
                string nombre = AGpersona.tbNOMBRE.Text;

                Persona nueva = new Persona(dni, nombre);

                RegistroVehiculo agregado = departamento.RegistrarVehiculo(nueva);

                tbRegistrar.Text = agregado.VerDetalle();

            }
            else MessageBox.Show("Se cancelo la carga de nuevo vehiculo");




        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            for (int i =0;i<departamento.CantidadRegistros;i++)
            {
               RegistroVehiculo veh= departamento.VerRegistro(i);
               lbxListar.Items.Add(veh.VerDetalle()); 
            }



        }
    }
}
