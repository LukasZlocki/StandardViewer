using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StandardViewer.Services.DocumentService;
using StandardViewer.Web.Models.DocumentVM;
using StandardViewer.Web.Serializer;

namespace StandardViewer.Web.Controllers
{
    [ApiController]
    public class DocumentController : Controller
    {
        private readonly ILogger<DocumentController> _logger;
        private readonly IDocumentService _documentService;

        public DocumentController(ILogger<DocumentController> logger, IDocumentService documentService)
        {
            _logger = logger;
            _documentService = documentService;
        }

        [HttpGet("document/document/{id}")]
        public ActionResult GetDocumentById(int id)
        {
            _logger.LogInformation("Get document by Id");
            var doc = _documentService.GetDocumentById(id);
            return View ("Standard");
        } 

        [HttpGet("documentProduct/{partNb}")]
        public ActionResult GetAllDocumentsByPartNumber(string partNb)
        {
            _logger.LogInformation("Get all documents by part number");
            var docsList = _documentService.GetDocumentsByProductNumber(partNb);
            return Ok(docsList);
        }

        [HttpGet("document/document")]
        public ActionResult GetAllDocuments()
        {
            _logger.LogInformation("Get All documents");
            var docsAll = _documentService.GetAllDocuments();
            var serviceViewModel = DocumentSerializer.SerializeToViewModel(docsAll); 

            //return Ok(docsAll);
            return View("Document", serviceViewModel);
        }


        [HttpGet("document/pdf")]
        public ActionResult ShowPdf()
        {
            string fileName = @"D:\Test\Lista3.pdf";
            //string path = Path.Combine(@"D:\Test\", fileName);you
            var fileBytes = System.IO.File.ReadAllBytes(fileName);
            return File(fileBytes, "application/pdf");

        }
        


    }
}