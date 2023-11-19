namespace Interfaces
{
    public interface ITraerLista
    {
        public void AsignarLista<T>(List<T> lista);
        public event Action OnListaPedida;
    }
}
