using BridgePattern.Abstraction;
using BridgePattern.Interfaces;

namespace BridgePattern.RefinedAbstraction
{
    public class Report : Document
    {
        private string _content;

        public Report(IFileFormat fileFormat, string content) : base(fileFormat)
        {
            _content = content;
        }

        public override void Save()
        {
            _fileFormat.Save($"Relatório: {_content}");
        }
    }

    public class Resume : Document
    {
        private string _content;

        public Resume(IFileFormat fileFormat, string content) : base(fileFormat)
        {
            _content = content;
        }

        public override void Save()
        {
            _fileFormat.Save($"Currículo: {_content}");
        }
    }
}