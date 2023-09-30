namespace Ejercicio01.CAI.CambieriLucas
{
    public partial class Ejercicio01 : Form
    {
        Ejercicio01Model model;
        public Ejercicio01()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            model = new Ejercicio01Model();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            model.DniIngresado = DniTextBox.Text;
            model.NombreIngresado = NombreTextBox.Text;
            model.ApellidoIngresado = ApellidoTextBox.Text;
            model.FechaNacimientoIngresada = FechaNacimientoDateTime.Value;

            string mensaje = model.Validar();
            MessageBox.Show(mensaje);
        }

        private void FechaNacimientoDateTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}