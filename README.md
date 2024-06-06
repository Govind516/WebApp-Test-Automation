# WebApplication Test Automation

This project contains automated tests for the WebApplication project using Selenium WebDriver and NUnit.

## Table of Contents
  - [Preview](#preview)
  - [Technologies Used](#technologies-used)
  - [Setup](#setup)
  - [Installation](#installation)
  - [Usage](#usage)
  - [Test Included](#tests-included)

## Preview

https://github.com/Govind516/WebApp-Test-Automation/assets/102366719/4c054d7a-3902-4f82-b8d2-ac2f3c2f8762

## Technologies Used

- C#
- ASP .NET Framework
- NUnit
- Selenium WebDriver

## Setup

1. Clone this repository.
2. Navigate to the WebApplication directory.
3. Open the solution in Visual Studio or your preferred IDE.
4. Ensure that the WebApplication project is running on http://localhost:5175.
5. Navigate to the WebAppTest directory.
6. Run the tests using NUnit or your preferred test runner.

## Installation

1. Install .NET SDK:
   ```sh
   https://dotnet.microsoft.com/en-us/download
   
2. Clone the repository:
   ```sh
   git clone https://github.com/Govind516/WebApp-Test-Automation.git

3. Navigate to the WebAppTests directory:
   ```sh
   cd WebAppTests

4. Install the Dependencies
   ```sh
   dotnet add package NUnit
   dotnet add package NUnit3TestAdapter
   dotnet add package Microsoft.NET.Test.Sdk
   dotnet add package Selenium.WebDriver
   dotnet add package Selenium.WebDriver.ChromeDriver

## Usage

1. Start the development server:
   ```sh
   cd WebApplication
   dotnet run

2. Open your browser and visit `http://localhost:5175` to see the website in action

3. Perform the Test:
    ```sh
   cd WebAppTests
   dotnet test
    
![image](https://github.com/Govind516/WebApp-Test-Automation/assets/102366719/6eb3986e-82a7-491b-b492-3713c3e24650)

## Tests Included

- Verify that the web page loads successfully.
- Enter the name, email, and phone in the input fields and submit the form.
- Submit the form with all fiels filled.
- Verify that the welcome message is displayed correctly with the entered name.
- Simulate a delay of 3 seconds and verify the welcome message.
- Perform the for test without entering optional fields.
