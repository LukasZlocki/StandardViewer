using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StandardViewer.Services.DocumentService;

namespace StandardViewer.Web.Controllers
{
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly ILogger<DocumentController> _logger;
        private readonly IDocumentService _documentService;

        public DocumentController(ILogger<DocumentController> logger, IDocumentService documentService)
        {
            _logger = logger;
            _documentService = documentService;
        }

        [HttpGet("api/document/{id}")]
        public ActionResult GetDocumentById(int id)
        {
            _logger.LogInformation("Get document by Id");
            var doc = _documentService.GetDocumentById(id);
            return Ok (doc);
        } 

        [HttpGet("api/document")]
        public ActionResult GetAllDocumentsByPartNumber(string partNb)
        {
            _logger.LogInformation("Get all documents by part number");
            var docsList = _documentService.GetDocumentsByProductNumber(partNb);
            return Ok(docsList);
        }

        [HttpGet("api/document")]
        public ActionResult GetAllDocuments()
        {
            _logger.LogInformation("Get All documents");
            var docsAll = _documentService.GetAllDocuments();
            return Ok(docsAll);
        }

    }
}