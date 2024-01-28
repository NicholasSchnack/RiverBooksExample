﻿using FastEndpoints;

namespace RiverBooks.Books;

internal class DeleteBookEndpoint(IBookService bookService) :
    Endpoint<DeleteBookRequest, BookDto>
{
  private readonly IBookService _bookService = bookService;

  public override void Configure()
  {
    Delete("/books/{Id}");
    AllowAnonymous();
  }

  public override async Task HandleAsync(DeleteBookRequest request,
             CancellationToken cancellationToken = default)
  {
    await _bookService.DeleteBookAsync(request.Id);

    await SendNoContentAsync();
  }
}
