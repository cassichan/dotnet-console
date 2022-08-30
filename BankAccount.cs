
public class BankAccount {

    public string AccountNumber {get;set;}

    public decimal Balance {get;set;} = 0;
    // can state explicitly balance starts at 0

    //create constructors
    public BankAccount() {
        AccountNumber = "";
        Balance = 100;
        // decimal.Zero;
    }

    public BankAccount(decimal newBalance) {
        AccountNumber = "";
        Balance = newBalance;
    }

    //Methods
    public void MakeDeposit(decimal amount) {
        //exception
        if (amount <= 0) {
            throw new Exception("Doh!");
        }
        Balance += amount;
    }

    public decimal MakeDepositGetBalance(decimal amount) {
        MakeDeposit(amount);
        return Balance;
    }

}