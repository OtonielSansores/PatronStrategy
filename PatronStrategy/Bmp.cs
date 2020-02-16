using PatronStrategy.Interfaces;

namespace PatronStrategy
{
    public class Bmp : IFormato
    {
        public string Guardar(string nombreImagen)
        {
            return string.Format("Se ha guardado la imagen {0}.BMP", nombreImagen);
        }
    }
}
