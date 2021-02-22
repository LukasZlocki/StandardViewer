using System.Collections.Generic;
using StandardViewer.Services.Dtos;

namespace StandardViewer.Services.DocumentService
{
    public interface IDocumentService
    {           
        // GET
        public List<DocumentReadDTO> GetDocumentsByProductNumber(string productNumber);
        // GET
        public DocumentReadDTO GetDocumentById(int id);
        // GET
        public List<DocumentReadDTO> GetAllDocuments();
    }
}