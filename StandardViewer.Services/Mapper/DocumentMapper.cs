using System.Collections.Generic;
using System.Linq;
using StandardViewer.Data.Models;
using StandardViewer.Services.Dtos;

namespace StandardViewer.Services.Mapper
{
    public static class DocumentMapper
    {
        // serialize Document to Document Read DTO
        public static DocumentReadDTO SerializeDocumentToDocumentDto(Document document)
        {
            return new DocumentReadDTO 
            {
                ProductNumber  = document.ProductNumber,
                DocumentName = document.DocumentName
            };
        }

        public static List<DocumentReadDTO> SerializeDocumentListToDocumentDtoList(IEnumerable<Document> documents)
        {
            return documents.Select (document => new DocumentReadDTO {
                ProductNumber  = document.ProductNumber,
                DocumentName = document.DocumentName

            }).ToList();  
        }

        
    }
}