using System.Threading.Tasks;

namespace QRCodeReader.Services
{
    public interface IQRCodeReaderService
    {
        Task<string> ReaderAsync();
    }
}