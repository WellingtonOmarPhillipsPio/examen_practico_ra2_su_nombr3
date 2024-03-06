namespace examen_practico_ra2_su_nombr3
{
    public static class Program
    {



        
    static void Main(string[] args)
        {
        https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            // Crear lista de estudiantes
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            // Agregar estudiantes a la lista
            listaEstudiantes.Add(new Estudiante(1, "Juan", "Calle 123", "123456789", "juan@example.com", "Profesor A", "Masculino", "Programación Avanzada", "A", "Informática"));
            listaEstudiantes.Add(new Estudiante(2, "Maria Gomez", "Avenida 456", "987654321", "maria@example.com", "Profesor B", "Femenino", "Diseño Gráfico", "B", "Artes y Diseño"));

            // Mostrar los estudiantes en la lista
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                Console.WriteLine($"Matrícula: {estudiante.Matricula}");
                Console.WriteLine($"Nombre: {estudiante.Nombre}");
                Console.WriteLine($"Dirección: {estudiante.Direccion}");
                Console.WriteLine($"Teléfono: {estudiante.Telefono}");
                Console.WriteLine($"Email: {estudiante.Email}");
                Console.WriteLine($"Maestro Titular: {estudiante.Maestro_Titular}");
                Console.WriteLine($"Género: {estudiante.Genero}");
                Console.WriteLine($"Curso: {estudiante.Curso}");
                Console.WriteLine($"Sección: {estudiante.Seccion}");
                Console.WriteLine($"Área Técnica: {estudiante.Area_Tecnica}");
                Console.WriteLine();


               

            }

            
        }
    }

   
}