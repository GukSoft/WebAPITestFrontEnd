using Microsoft.AspNetCore.Mvc;

namespace WebAPITest.Models
{
    //https://zukucode.com/2022/04/aspnet-webapi-file-upload.html
    public record FileCreateRequest(
    [FromForm(Name = "file")]
    IFormFile File);
}

