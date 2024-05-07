# Library Management API

This project is a RESTful API for managing a library system. It provides endpoints to manage resources such as books, authors, and publishers.

## Installation

1. Clone the repository:
git clone https://github.com/tgbaozkn/library-management-api.git

2. Navigate to the project directory:
cd library-management-api

3. Install dependencies:
dotnet restore

4. Update the database:
dotnet ef database update

## Usage

### Endpoints

- **GET /api/books**: Get all books.
- **GET /api/books/{id}**: Get a specific book by its ID.
- **POST /api/books**: Create a new book.
- **PUT /api/books/{id}**: Update an existing book.
- **DELETE /api/books/{id}**: Delete a book.

Similar endpoints are available for authors and publishers.

### Example

To create a new book, send a POST request to `/api/books` with the following JSON payload:

```json
{
"title": "Sample Book",
"authorId": 1,
"publisherId": 1
}
Error Handling
If a request is invalid or missing required parameters, a 400 Bad Request response is returned.
If a resource is not found, a 404 Not Found response is returned.
If there is a server error, a 500 Internal Server Error response is returned.
Development
To contribute to this project, follow these steps:

Fork the repository.
Create a new branch (git checkout -b feature/my-new-feature).
Make your changes.
Commit your changes (git commit -am 'Add new feature').
Push to the branch (git push origin feature/my-new-feature).
Create a new Pull Request.