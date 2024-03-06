using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_practico_ra2_su_nombr3
{
    public class Estudiante:Form1
    {


        // Campos de la clase Estudiante
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Maestro_Titular { get; set; }
        public string Genero { get; set; }
        public string Curso { get; set; }
        public string Seccion { get; set; }
        public string Area_Tecnica { get; set; }


        // Constructor
        public Estudiante(int Matricula, string Nombre, string Direccion, string Telefono, string Email, string Maestro_Titular, string Genero, string Curso, string Seccion, string Area_Tecnica)
        {
            Matricula = Matricula;
            Nombre = Nombre;
            Direccion = Direccion;
            Telefono = Telefono;
            Email = Email;
            Maestro_Titular = Maestro_Titular;
            Genero = Genero;
            Curso = Curso;
            Seccion = Seccion;
            Area_Tecnica = Area_Tecnica;





        }
    }

  
    
        
            }
        
    






    
