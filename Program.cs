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
            listaEstudiantes.Add(new Estudiante(1, "Juan", "Calle 123", "123456789", "juan@example.com", "Profesor A", "Masculino", "Programaci�n Avanzada", "A", "Inform�tica"));
            listaEstudiantes.Add(new Estudiante(2, "Maria Gomez", "Avenida 456", "987654321", "maria@example.com", "Profesor B", "Femenino", "Dise�o Gr�fico", "B", "Artes y Dise�o"));

            // Mostrar los estudiantes en la lista
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                Console.WriteLine($"Matr�cula: {estudiante.Matricula}");
                Console.WriteLine($"Nombre: {estudiante.Nombre}");
                Console.WriteLine($"Direcci�n: {estudiante.Direccion}");
                Console.WriteLine($"Tel�fono: {estudiante.Telefono}");
                Console.WriteLine($"Email: {estudiante.Email}");
                Console.WriteLine($"Maestro Titular: {estudiante.Maestro_Titular}");
                Console.WriteLine($"G�nero: {estudiante.Genero}");
                Console.WriteLine($"Curso: {estudiante.Curso}");
                Console.WriteLine($"Secci�n: {estudiante.Seccion}");
                Console.WriteLine($"�rea T�cnica: {estudiante.Area_Tecnica}");
                Console.WriteLine();


               

            }

            
        }
    }

   
}