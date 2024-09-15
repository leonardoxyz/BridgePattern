using BridgePattern.Interfaces;

namespace BridgePattern.Classes
{
    public class WordFormat : IFileFormat
    {
        public void Save(string content)
        {
            Console.WriteLine($"Salvando o documento em formato Word: {content}");
        }
    }
}