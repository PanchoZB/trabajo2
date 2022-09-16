namespace trabajo2.Models
{
    public class PromedioViewModel
    {
        private int promedio;

        public int Materia1 { get; set; }
        public int Materia2 { get; set; }
        public int Materia3 { get; set; }

        public int Promedio
        {
            get
            {
                return promedio = (Materia1 + Materia2 + Materia3) / 3;




            }
        }
        public string Frase
        {
            get
            {

                if (promedio <= 69) return "Alumno Reprobado";
                else return "Alumno Aprobado";
            }
        }
    }
}
