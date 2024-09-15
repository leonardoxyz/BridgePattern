using BridgePattern.Abstraction;
using BridgePattern.Classes;
using BridgePattern.Interfaces;
using BridgePattern.RefinedAbstraction;

// Criando um relatório em formato PDF
IFileFormat pdfFormat = new PdfFormat();
Document report = new Report(pdfFormat, "Análise Financeira 2024");
report.Save();

// Criando um currículo em formato Word
IFileFormat wordFormat = new WordFormat();
Document resume = new Resume(wordFormat, "Leo - DEV & QA");
resume.Save();
