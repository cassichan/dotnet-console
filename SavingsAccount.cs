public class SavingsAccount : BankAccount {
 public SavingsAccount(): base() {
        Balance = 200;
    }

//Allows to access amount in base class
    public SavingsAccount(decimal amount): base(amount) {
        
    }
}