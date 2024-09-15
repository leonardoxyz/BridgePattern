using BridgePattern.Interfaces;

namespace BridgePattern.Classes
{
    public class PdfFormat : IFileFormat
    {
        public void Save(string content)
        {
            Console.WriteLine($"Salvando o documento em formato PDF: {content}");
        }
    }
}
