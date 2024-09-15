using BridgePattern.Interfaces;

namespace BridgePattern.Abstraction
{
    public abstract class Document
    {
        protected IFileFormat _fileFormat;

        public Document(IFileFormat fileFormat)
        {
            _fileFormat = fileFormat;
        }

        public abstract void Save();
    }
}