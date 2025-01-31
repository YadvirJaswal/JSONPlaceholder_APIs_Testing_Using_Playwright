# JSONPlaceholder API Testing with Playwright and C#

This repository contains automated test cases for testing the JSONPlaceholder APIs using Playwright in **C#** with **xUnit**. It covers a variety of HTTP requests such as GET, POST, PUT, and DELETE for JSONPlaceholder, a free online REST API for testing and prototyping.

---

## Features

- Automated API tests for:
  - Fetching all posts
  - Fetching a specific post by ID
  - Creating a new post
  - Updating an existing post
  - Deleting a post
- Validations include:
  - HTTP status codes
  - Response data matching expected values
  - Data integrity through deserialization

---   

## Prerequisites

Before running the tests, ensure you have the following installed:

- [.NET 6 or later](https://dotnet.microsoft.com/download)
- [Playwright for .NET](https://playwright.dev/dotnet)
- JSONPlaceholder API (no setup required)

--- 

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/YadvirJaswal/JSONPlaceholder_APIs_Testing_Using_Playwright.git
   cd JSONPlaceholder_APIs_Testing_Using_Playwright

---

## Test Cases Included

- **Get All Posts** -
   Validates that the API returns a list of posts and checks the response status and structure.

- **Get Post by ID** -
    Tests the retrieval of a specific post using its ID and validates the returned data.

- **Create Post** -
    Sends a POST request to create a new post and verifies the response status and body content.

- **Update Post** -
    Updates an existing post using a PUT request and validates the updated data.

- **Delete Post** -
    Sends a DELETE request to remove a specific post and validates the response and status code.
---

## Key Techonologies

- **Playwright**: For API automation and testing.
- **xUnit**: A lightweight and extensible test framework for .NET.
- **C#**: The programming language used to write the tests.

---




