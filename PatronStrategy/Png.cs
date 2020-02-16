using PatronStrategy.Interfaces;

namespace PatronStrategy
{
    public class Png : IFormato
    {
        public string Guardar(string nombreImagen)
        {
            return string.Format("Se ha guardado la imagen {0}.PNG", nombreImagen);
        }
    }
}
