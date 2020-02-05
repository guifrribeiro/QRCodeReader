using System.Threading.Tasks;
using ZXing.Mobile;

namespace QRCodeReader.Services
{
    public class QRCodeReaderService : IQRCodeReaderService
    {
        public async Task<string> ReaderAsync()
        {
            var optionsCustom = new MobileBarcodeScanningOptions()
            {
                //UseFrontCameraIfAvailable = true;
            };

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Aproxime a câmera do código de barras",
                BottomText = "Toque na tela para focar"
            };

            var scanResults = await scanner.Scan(optionsCustom);

            return (scanResults != null) ? scanResults.Text : string.Empty;
        }
    }
}