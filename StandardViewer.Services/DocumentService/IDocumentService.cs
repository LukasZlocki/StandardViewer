using System.Collections.Generic;
using StandardViewer.Data.Models;

namespace StandardViewer.Services.DocumentService
{
    public interface IDocumentService
    {           
        // GET
        public Document GetDocumentByProductNumber(string productNumber);
        public List<Document> GetDocumentById(int id);
    }
}