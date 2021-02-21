using System.Collections.Generic;
using StandardViewer.Data.Models;

namespace StandardViewer.Services.DocumentService
{
    public interface IDocumentService
    {           
        // GET
        public List<Document> GetDocumentsByProductNumber(string productNumber);
        // GET
        public Document GetDocumentById(int id);
        // GET
        public List<Document> GetAllDocuments();
    }
}