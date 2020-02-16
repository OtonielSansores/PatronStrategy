using PatronStrategy.Interfaces;

namespace PatronStrategy.Context
{
    public class Context
    {
        private IFormato _formato;
        public Context(IFormato formato)
        {
            _formato = formato;
        }

        public string GuardarImagen(string nombreImgen)
        {
            return _formato.Guardar(nombreImgen);
        }


    }
}
