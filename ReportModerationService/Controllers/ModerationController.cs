// === ASP.NET Core Web API: ReportModerationService ===
// ModerationController.cs

using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ReportModerationService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModerationController : ControllerBase
    {
        private static readonly string WordsFilePath = "badwords.txt";
        private static HashSet<string> BadWords;

        static ModerationController()
        {
            if (System.IO.File.Exists(WordsFilePath))
            {
                BadWords = System.IO.File.ReadAllLines(WordsFilePath)
                                .Where(line => !string.IsNullOrWhiteSpace(line))
                                .Select(line => line.Trim().ToLower())
                                .ToHashSet();
            }
            else
            {
                BadWords = new HashSet<string>();
            }
        }
       
        [HttpPost("analyze")]
        public IActionResult AnalyzeText([FromBody] ModerationRequest request)
        {
            if (request?.Text == null)
                return BadRequest("Invalid input");

            var words = request.Text.ToLower().Split(' ', '.', ',', '!', '?', '\\', '/', ':', ';');
            bool containsBadWord = words.Any(word => BadWords.Contains(word));

            return Ok(new { result = containsBadWord ? "Warning" : "OK" });
        }
    }

    public class ModerationRequest
    {
        public string Text { get; set; }
    }
}
