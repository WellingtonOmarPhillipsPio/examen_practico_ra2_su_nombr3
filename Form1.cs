namespace examen_practico_ra2_su_nombr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            dgv_informacion.Rows.Add(txt_Matricula.Text, txt_Nombre.Text, txt_Direccion.Text,
                txt_Telefono.Text, cbo_Genero.Text, txt_Email.Text, cbo_Curso.Text, cbo_Seccion.Text, cbo_Area_Tecnica.Text, txt_Maestro_Titular.Text);





            txt_Matricula.Clear();
            txt_Nombre.Clear();
            txt_Direccion.Clear();
            txt_Telefono.Clear();

            txt_Email.Clear();


            txt_Maestro_Titular.Clear();




        }
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {


            btn_Agregar.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Limpiar.Enabled = true;
            btn_Salir.Enabled = true;
            btn_Guardar.Enabled = true;
            btn_Nuevo.Enabled = false;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btn_Agregar.Enabled = false;
            btn_Eliminar.Enabled = true;
            btn_Limpiar.Enabled = false;
            btn_Salir.Enabled = false;
            btn_Guardar.Enabled = false;

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_Nuevo.Enabled = true;
            btn_Agregar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Limpiar.Enabled = true;
            btn_Salir.Enabled = true;
            btn_Guardar.Enabled = false;
         

            DialogResult resultado = dlg_guardar.ShowDialog();

            // Verificar si el usuario presionó el botón Guardar
            if (resultado == DialogResult.OK)
            {

                string ruta_archivo = dlg_guardar.FileName;
                string crea_texto = ruta_archivo;


                using (StreamWriter archivo = File.CreateText(ruta_archivo))
                {
                 
                    foreach (DataGridViewRow fila in dgv_informacion.Rows)
                    {
                        // Obtiene los valores de las celdas 
                        string valorColumna1 = fila.Cells[0].Value?.ToString() ?? "Matricula|";
                        string valorColumna2 = fila.Cells[1].Value?.ToString() ?? "Nombre|";
                        string valorColumna6 = fila.Cells[6].Value?.ToString() ?? "Curso|";
                        string valorColumna7 = fila.Cells[7].Value?.ToString() ?? "Seccion|";
                        string valorColumna8 = fila.Cells[8].Value?.ToString() ?? "Area_Tecnica|";




                        // Escribe los valores en el archivo de texto
                        archivo.WriteLine

                            ($"{valorColumna1},     " +
                            $"{valorColumna2},"      +
                            $"{valorColumna6},"      +
                            $"{valorColumna7},"      +
                            $"{valorColumna8},");


                    }
                }
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {



            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea salir de esta aplicacion?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            


            dgv_informacion.Rows.Clear();


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int fila;


            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar este registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (respuesta == DialogResult.Yes)
            {
                fila = dgv_informacion.CurrentRow.Index;
                dgv_informacion.Rows.RemoveAt(fila);
            }
        }

      
    }
}







