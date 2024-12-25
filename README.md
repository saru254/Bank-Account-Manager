# Bank Account Manager

## Description
The **Bank Account Manager** is a simple console-based application that helps users manage their bank accounts. It demonstrates the principles of Object-Oriented Programming (OOP) such as encapsulation and abstraction. Users can:
- Check their account balance
- Deposit money
- Withdraw money with proper validations

## Features
- Secure handling of account data using encapsulation.
- Easy-to-use methods for depositing and withdrawing money.
- Validation to ensure deposits are positive and withdrawals are within the available balance.

## Getting Started

### Prerequisites
To run this program, you need:
- A C# compiler (e.g., Visual Studio, Visual Studio Code with .NET SDK installed).

### How to Run
1. Clone or download the repository.
2. Open the project in your C# IDE.
3. Build and run the project.
4. Follow the console prompts to test the Bank Account Manager functionalities.

## Usage
The program allows you to:
1. Initialize a bank account with an account number and initial balance.
2. Deposit money using the `Deposit` method.
3. Withdraw money using the `Withdraw` method.
4. Check the current balance using the `GetBalance` method.

### Example Output
```
Initial balance: 1000
Successfully deposited 500. New balance: 1500
Successfully withdrew 200. Remaining balance: 1300
Insufficient funds for this withdrawal.
Final balance: 1300
```

## Concepts Demonstrated
1. **Encapsulation**: The `accountNumber` and `balance` fields are private, and access is controlled via public methods.
2. **Abstraction**: The user interacts with high-level methods without worrying about internal implementation.

## Future Enhancements
- Add support for multiple account types (e.g., savings, current).
- Implement transaction history.
- Allow multiple accounts management.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

