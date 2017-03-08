using System.Threading.Tasks;

namespace Goova.Plexo
{
    public interface ICallback
    {
        Task<ClientResponse> Instrument(IntrumentCallback instrument);
    }
}
