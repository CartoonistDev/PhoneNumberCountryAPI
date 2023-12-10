# PhoneNumberCountryAPI

PhoneNumberCountryAPI is a RESTful Web API that provides information about the country and country details based on a given phone number.

## Table of Contents

- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
  - [Installation](#installation)
  - [Configuration](#configuration)
- [Usage](#usage)
- [Endpoints](#endpoints)
- [Response Format](#response-format)
- [Error Handling](#error-handling)
- [Contributing](#contributing)

## Prerequisites

Before you begin, ensure you have met the following requirements:

- [ ] [.NET SDK](https://dotnet.microsoft.com/download/dotnet)
- [ ] [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (or your preferred code editor)
- [ ] [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [ ] [In-Memory Database](https://docs.microsoft.com/en-us/ef/core/providers/in-memory/?tabs=dotnet-core-cli)

## Getting Started

### Installation

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/CartoonistDev/PhoneNumberCountryAPI.git

2. Open the project in your preferred code editor.

## Configuration

1. Configure your database connection in `appsettings.json`:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "YourConnectionStringHere"
     }
   }

Replace "YourConnectionStringHere" with your actual database connection string.

1. Ensure you have the necessary NuGet packages installed, including Entity Framework Core and In-Memory Database.

2. Build and run the project.

## Usage

To use the PhoneNumberCountryAPI, follow these steps:

1. Make GET requests to the provided API endpoints, passing a phone number as a parameter.

2. The API will return information about the country and its details based on the phone number's country code.

## Endpoints

- `GET /api/phonenumber/{phoneNumber}`

   Retrieves information about the country and its details based on the provided phone number.

## Response Format

The API response is in JSON format and follows this structure:

	```json
	{
	  "number": "2348033432323",
	  "country": {
		"countryCode": "234",
		"name": "Nigeria",
		"countryIso": "NG",
		"countryDetails": [
		  {
			"operator": "Airtel Nigeria",
			"operatorCode": "ANG"
		  },
		  {
			"operator": "MTN Nigeria",
			"operatorCode": "MTN NG"
		  },
		  {
			"operator": "9Mobile Nigeria",
			"operatorCode": "ETN"
		  },
		  {
			"operator": "Globacom Nigeria",
			"operatorCode": "GLO NG"
		  }
		]
	  }
	}
	
## Error Handling

- If the provided phone number is empty or invalid, the API will respond with a `400 Bad Request` status code.

- If the requested country information is not found, the API will respond with a `404 Not Found` status code.

- For unexpected errors or exceptions, the API will respond with a `500 Internal Server Error` status code, including an error description and code.

## Contributing

Contributions are welcome! Feel free to open an issue or submit a pull request for any improvements or bug fixes.

