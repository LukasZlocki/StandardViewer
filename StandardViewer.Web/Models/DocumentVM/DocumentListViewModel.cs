using System.Collections.Generic;
using StandardViewer.Services.Dtos;

namespace StandardViewer.Web.Models.DocumentVM
{
    public class DocumentListViewModel
    {
        public IEnumerable<DocumentReadDTO> DocumentsList {get; set;}
    }
}