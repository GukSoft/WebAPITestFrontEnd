using Microsoft.AspNetCore.Mvc;
using WebAPITest.Models;
using WebAPITest.Modules;

namespace WebAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUpLoadController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> UpLoad([FromForm] FileCreateRequest request)
        {
            string filename = request.File.FileName;
            string filepath = "C:\\WWW\\WebAPI\\UpLoad";
            byte[] content = await request.File.GetBytesAsync();

            // ファイルを保存
            try
            {
                System.IO.File.WriteAllBytes(Path.Combine(filepath, filename), content);
            } catch (System.IO.IOException ex)
            {
                return BadRequest(ex.Message);
            }
            
            return Ok(filename);

        }
    }
}
