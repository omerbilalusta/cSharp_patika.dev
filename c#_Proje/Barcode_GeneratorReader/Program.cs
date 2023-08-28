using IronBarCode;
using System;
using System.Linq;

namespace BarcodeProgram
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Barcode haline getirilmesini istediğiniz metni giriniz.");
            GeneratedBarcode qrCode = createQR(Console.ReadLine());
            readQR(qrCode);

        }
        
        static GeneratedBarcode createQR(string value){
            QRCodeLogo qRCodeLogo = new QRCodeLogo("patika.dev_logo.png");
            GeneratedBarcode qrCode =  QRCodeWriter.CreateQrCodeWithLogo(value,qRCodeLogo);
            qrCode.ResizeTo(500,500).SetMargins(10);
            qrCode.SaveAsPng("qrCode.png");
            return qrCode;
        }
        static void readQR(GeneratedBarcode qrCode){
            var resultOfQrCode = BarcodeReader.Read("qrCode.png").First();
            if(qrCode.BinaryValue.SequenceEqual(resultOfQrCode.BinaryValue)){
                Console.WriteLine(resultOfQrCode.Text);
            }
            else
                Console.WriteLine("Bozulmuş data.");
        }
    }
}