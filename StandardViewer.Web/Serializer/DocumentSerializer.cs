using System.Collections.Generic;
using StandardViewer.Services.Dtos;
using StandardViewer.Web.Models.DocumentVM;

namespace StandardViewer.Web.Serializer
{
    public class DocumentSerializer
    {

        public static DocumentListViewModel SerializeToViewModel (List<DocumentReadDTO> documentDTO)
        {   
            return new DocumentListViewModel{
                DocumentsList = documentDTO
            };

        }
        
    }
}