using Microsoft.AspNetCore.Mvc;
using BookServer.BLL.Services.Interfaces;
using BookServer.API.Mappers;
using BLLModels = BookServer.BLL.Models;
using BookServer.API.Models;

namespace BookServer.API.Controllers;

[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;
    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet("Get")]
    public ActionResult Get(int start, int end)
    {
        try
        {
            IEnumerable<BLLModels.Book> books = string.IsNullOrEmpty(HttpContext.Request.QueryString.ToString())
                ? _bookService.GetAll()
                : _bookService.GetRange(start - 1, end - 1);

            IEnumerable<Book> result = books.Select(x => x.ToViewModel());

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
