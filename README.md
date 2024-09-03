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

## Original Formula

```
Z = X + Y1 * X + Y2 * (X1 + X2 + ... + Xi) + HOURS
```

The formula used to calculate the total campaign budget `Z` is:
Where:

- `X` is the total ad spend.
- `Y1` is the agency fee percentage.
- `Y2` is the third-party tool fee percentage.
- `X1`, `X2`, `Xi` are the budgets for individual ads.
- `HOURS` is the fixed cost for agency hours.

In the context of the application:

- `X` is split into `X_target` (budget for the specific ad) and `OtherAdsBudget` (budget for other ads).
- `Y1` and `Y2` are percentages that apply to `X` and the sum of all ad budgets, respectively.
- `HOURS` remains a fixed cost.

Find more details at original prompt [here.](https://gist.githubusercontent.com/stasyess/3993a26c58b26ed36300ca4ed359eb06/raw/e02e2503226009f87e8ffecd846dbb1dc8b523e7/Assignment.txt)

## Algorithm

To find the maximum budget for the specific ad, we use a **binary search** algorithm. This approach is used to iteratively adjust the budget for the specific ad until the total budget `Z` does not exceed the approved amount.

### Binary Search Method

1. **Initialize Variables**: Set the initial low and high bounds for the binary search range.
2. **Calculate Midpoint**: Compute the midpoint of the current range.
3. **Calculate Total Cost**: Using the midpoint value, compute the total cost using the formula.
4. **Adjust Range**: If the total cost is less than the approved budget `Z`, adjust the low bound. Otherwise, adjust the high bound.
5. **Repeat**: Continue adjusting the range until the difference between the high and low bounds is within a specified tolerance.

## Project Structure

- **BudgetCalculator**: Main project containing the business logic and controllers.
  - `Services/BudgetService.cs`: Contains the `BudgetService` class with the Goal Seek algorithm.
  - `Controllers/BudgetController.cs`: Handles user input and interacts with the `BudgetService`.
  - `Views/Budget/Index.cshtml`: View for user interaction.
- **BudgetCalculator.Tests**: Test project containing unit tests for the `BudgetService`.
  - `BudgetServiceTests.cs`: Contains unit tests for the `GoalSeek` method.

# Access the Application
<img width="1398" alt="Screenshot 2024-09-03 at 16 07 21" src="https://github.com/user-attachments/assets/2b3d9498-ff68-42eb-a717-426bc2c3fd58">

## Web App URL

This application is deployed to Azure App Service, which provides a scalable and managed environment for hosting web applications.
To access the deployed application, follow these steps:
**Go to [BudgetCalculatorJu](https://budgetcalculatorju.azurewebsites.net/)**

## Or Clone to Your Local

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 6.0)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/), [Visual Studio Code](https://code.visualstudio.com/), or [JetBrains Rider](https://www.jetbrains.com/rider/)

### Setup

1. **Clone the Repository**

   ```bash
   git clone https://github.com/c20chin/BudgetCalculator.git
   cd BudgetCalculator
   ```

2. **Navigate to the project directory and restore the dependencies:**

   ```bash
   dotnet restore
   ```

3. **Build the solution to ensure everything is set up correctly:**

   ```bash
   dotnet build
   ```

4. **Run the application:**

   ```bash
   dotnet run --project BudgetCalculator
   ```

5. **Open a web browser and navigate to http://localhost:5000 to use the application.**

### Usage

1. **Navigate to the Application**

2. **Open a web browser and go to http://localhost:5000.(or your setup localhost)**

3. **Input Data**

- **Total Budget (Z)**: Enter the approved total budget for the campaign.
- **Agency Fee Percentage (Y1)**: Enter the agency fee percentage.
- **Third-Party Tool Fee Percentage (Y2)**: Enter the third-party tool fee percentage.
- **Fixed Costs (HOURS)**: Enter the fixed costs for agency hours.
- **Budget for Other Ads**: Enter the budget for other ads.

4. **Submit**
   Click the "Calculate" button to determine the maximum budget for the specific ad.

## Running Tests

To ensure the application is working correctly, run the unit tests:

1. **Navigate to the Test Project**

```bash
cd BudgetCalculator.Tests
```

2. **Run the Tests**

```bash
dotnet test
```

This will execute all the unit tests and display the results.
