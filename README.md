# Budget Calculator

## Overview

The Budget Calculator project is a .NET application designed to calculate the maximum budget for a specific ad within a total campaign budget, using the Goal Seek algorithm. The application allows users to determine how much budget can be allocated to a single ad while ensuring the total campaign budget remains within an approved amount.

## Features

- **Calculate Maximum Ad Budget**: Determine the maximum budget for a specific ad while keeping the total campaign budget within the approved amount.
- **Goal Seek Algorithm**: Utilizes a binary search method to find the optimal budget allocation.
- **Unit Testing**: Includes comprehensive unit tests to ensure the accuracy and reliability of the calculations.

## Technologies Used

- **.NET Core**: Framework for building the application.
- **xUnit**: Testing framework used for unit testing.
- **ASP.NET Core MVC**: Web framework for building the user interface.

## Project Structure

- **BudgetCalculator**: Main project containing the business logic and controllers.
  - `Services/BudgetService.cs`: Contains the `BudgetService` class with the Goal Seek algorithm.
  - `Controllers/BudgetController.cs`: Handles user input and interacts with the `BudgetService`.
  - `Views/Budget/Index.cshtml`: View for user interaction.
- **BudgetCalculator.Tests**: Test project containing unit tests for the `BudgetService`.
  - `BudgetServiceTests.cs`: Contains unit tests for the `GoalSeek` method.

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 6.0)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/), [Visual Studio Code](https://code.visualstudio.com/), or [JetBrains Rider](https://www.jetbrains.com/rider/)

### Setup

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/BudgetCalculator.git
   cd BudgetCalculator
   ```
Restore Dependencies

2. **Navigate to the project directory and restore the dependencies:**

bash
Copy code
dotnet restore
Build the Solution

3. **Build the solution to ensure everything is set up correctly:**

bash
dotnet build
Run the Application

4. **Start the application:**

bash
Copy code
dotnet run --project BudgetCalculator
Open a web browser and navigate to http://localhost:5000 to use the application.

### Usage
1. **Navigate to the Application**

2. **Open a web browser and go to http://localhost:5000.(or your setup localhost)**

3. **Input Data**

Total Budget (Z): Enter the approved total budget for the campaign.
Agency Fee Percentage (Y1): Enter the agency fee percentage.
Third-Party Tool Fee Percentage (Y2): Enter the third-party tool fee percentage.
Fixed Costs (HOURS): Enter the fixed costs for agency hours.
Budget for Other Ads: Enter the budget for other ads.
Submit

Click the "Calculate" button to determine the maximum budget for the specific ad.

Running Tests
To ensure the application is working correctly, run the unit tests:

Navigate to the Test Project

bash
cd BudgetCalculator.Tests
Run the Tests

bash
dotnet test
This will execute all the unit tests and display the results.

