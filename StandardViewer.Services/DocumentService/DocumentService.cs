using System.Collections.Generic;
using System.Linq;
using StandardViewer.Data.Models;

namespace StandardViewer.Services.DocumentService
{
    public class DocumentService : IDocumentService
    {
        readonly ViewerDbContext _db;

        public DocumentService(ViewerDbContext db)
        {
            _db = db;
        }

        public List<Document> GetAllDocuments()
        {
            var dbResult = _db.Documents.ToList();
            return dbResult; 
        }

        // GET
        public Document GetDocumentById(int id)
        {
            var dbResult = _db.Documents.Find(id);
            return dbResult;
        }

        // GET 
        public List<Document> GetDocumentsByProductNumber(string productNumber)
        {
            var dbResult = _db.Documents.Where(nb => nb.ProductNumber == productNumber).ToList();
            return dbResult; 
        }



    }
}