using System;
using System.Collections.Generic;

interface IAccount {
    void Deposit(double amount);
    void Withdraw(double amount);
    double CalculateInterest(int months);
}

abstract class Account : IAccount {
    public Customer Customer { get; set; }
    public double Balance { get; set; }
    public double InterestRate { get; set; }

    public abstract double CalculateInterest(int months);

    public void Deposit(double amount) {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C} into account #{this.GetHashCode()}");
    }

    public void Withdraw(double amount) {
        if (Balance >= amount) {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C} from account #{this.GetHashCode()}");
        } else {
            Console.WriteLine($"Insufficient funds in account #{this.GetHashCode()}");
        }
    }
}

class DepositAccount : Account {
    public override double CalculateInterest(int months) {
        if (Balance >= 1000) {
            return months * InterestRate;
        } else {
            return 0;
        }
    }
}

class LoanAccount : Account {
    public override double CalculateInterest(int months) {
        if (Customer is Individual) {
            if (months <= 3) {
                return 0;
            }
        } else {
            if (months <= 2) {
                return 0;
            }
        }
        return months * InterestRate;
    }
}

class MortgageAccount : Account {
    public override double CalculateInterest(int months) {
        if (Customer is Individual) {
            if (months <= 6) {
                return 0;
            }
        } else {
            if (months <= 12) {
                return months * InterestRate / 2;
            }
        }
        return months * InterestRate;
    }
}

abstract class Customer {
    public string Name { get; set; }
}

class Individual : Customer {
}

class Company : Customer {
}

class Bank {
    public List<IAccount> Accounts { get; set; }

    public Bank() {
        Accounts = new List<IAccount>();
    }

    public void AddAccount(IAccount account) {
        Accounts.Add(account);
    }

    public void CalculateInterest(int months) {
        foreach (IAccount account in Accounts) {
            double interest = account.CalculateInterest(months);
            account.Deposit(interest);
        }
    }
}

class Program {
    static void Main(string[] args) {
        Bank bank = new Bank();

        Individual vignesh = new Individual { Name = "Vignesh" };
        DepositAccount vigneshDeposit = new DepositAccount { Customer = vignesh, Balance = 5000, InterestRate = 0.01 };
        LoanAccount vigneshLoan = new LoanAccount { Customer = vignesh, Balance = 10000, InterestRate = 0.02 };
        MortgageAccount vigneshMortgage = new MortgageAccount { Customer = vignesh, Balance = 200000, InterestRate = 0.03 };

        bank.AddAccount(vigneshDeposit);
        bank.AddAccount(vigneshLoan);
        bank.AddAccount(vigneshMortgage);

        Company sachin = new Company { Name = "Sachin" };
        DepositAccount sachinDeposit = new DepositAccount { Customer = sachin, Balance = 25000, InterestRate = 0.005 };
        LoanAccount sachinLoan = new LoanAccount { Customer = sachin, Balance = 50000, InterestRate = 0.01 };
        MortgageAccount sachinMortgage = new MortgageAccount { Customer = sachin, Balance = 1000000, InterestRate = 0.015 };

        bank.AddAccount(sachinDeposit);
        bank.AddAccount(sachinLoan);
        bank.AddAccount(sachinMortgage);
        Console.WriteLine(sachinMortgage.CalculateInterest(12));


    }
}
