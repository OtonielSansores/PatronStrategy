using PatronStrategy.Interfaces;

namespace PatronStrategy
{
    public class Jpge : IFormato
    {
        public string Guardar(string nombreImagen)
        {
            return string.Format("Se ha guardado la imagen {0}.JPGE", nombreImagen);
        }
    }
}
