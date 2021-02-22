using System.Collections.Generic;
using System.Linq;
using StandardViewer.Data.Models;
using StandardViewer.Services.Dtos;
using StandardViewer.Services.Mapper;

namespace StandardViewer.Services.DocumentService
{
    public class DocumentService : IDocumentService
    {
        readonly ViewerDbContext _db;

        public DocumentService(ViewerDbContext db)
        {
            _db = db;
        }

        public List<DocumentReadDTO> GetAllDocuments()
        {
            // extracting data list from db
            var dbResult = _db.Documents.ToList();
            // serialize data list from core model to DTO list
            var service = DocumentMapper.SerializeDocumentListToDocumentDtoList(dbResult);
            return service; 
        }

        // GET
        public DocumentReadDTO GetDocumentById(int id)
        {
            // extracting data from db
            var dbResult = _db.Documents.Find(id);
            // serialize data from core model to DTO
            var service = DocumentMapper.SerializeDocumentToDocumentDto(dbResult); 
            return service;
        }

        // GET 
        public List<DocumentReadDTO> GetDocumentsByProductNumber(string productNumber)
        {
            var dbResult = _db.Documents.Where(nb => nb.ProductNumber == productNumber).ToList();
            var service = DocumentMapper.SerializeDocumentListToDocumentDtoList(dbResult);
            return service;
        }



    }
}