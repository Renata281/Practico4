namespace Formulario4
{
    public partial class Formulario4 : Form
    {
        public Formulario4()
        {
            InitializeComponent();
        }

        private void bGenFucion_Click(object sender, EventArgs e)
        {
            //limpiar el ListBox antes de agregar nuevos resultados
            lbxListNros.Items.Clear();

            //validacion de campos vacios
            if(string.IsNullOrEmpty(tDesde.Text) || string.IsNullOrEmpty(tHasta.Text)){
                MessageBox.Show("Debe completar todos los campos", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // salir del metodo si hay campos vacios
            }

            //validacion de que los campos sean numeros
            int valorDesde;
            int valorHasta;

            // Usar TryParse para validar que los campos contengan nros enteros
            bool esNumeroDesde = int.TryParse(tDesde.Text, out valorDesde);
            bool esNumeroHAsta = int.TryParse(tHasta.Text, out valorHasta);

            if(!esNumeroDesde || !esNumeroHAsta)
            {
                MessageBox.Show("Solo se permiten números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //sale del metodo si no son nros
            }
            //validacion de que el valor "desde" sea menor que el valor "hasta"
            if(valorDesde > valorHasta)
            {
                MessageBox.Show("El valor de inicio no puede ser mayor que el valor final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //validacion de que el valor "desde" sea mayor o igual a 0
            if(valorDesde < 0)
            {
                MessageBox.Show("El valor de inicio no puede ser menor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Bucle para agregar los numeros al ListBox
            for(int i = valorDesde; i <= valorHasta; i++)
            {
                lbxListNros.Items.Add(i);
            }
        }
    }
}
