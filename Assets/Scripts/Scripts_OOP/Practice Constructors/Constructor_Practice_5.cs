using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor_Practice_5 : MonoBehaviour
{
    class BankAccount
    {
        private int accountNumber;
        private int balanceCash;
        private string typeofAccount;
        private int withdrawCash;
        private int depositCash;

        public BankAccount(int accountNumber, int balanceCash, int withdrawCash, string typeAccount)
        {
            this.accountNumber = accountNumber;
            this.balanceCash = balanceCash;
            this.typeofAccount = typeAccount;
            this.withdrawCash = withdrawCash;
        }

        public BankAccount(int accountNumber, int balanceCash, string typeAccount, int depositCash)
        {
            this.accountNumber = accountNumber;
            this.balanceCash = balanceCash;
            this.typeofAccount = typeAccount;
            this.depositCash = depositCash;
        }

        public void BankWithdraw()
        {
            int currentCash = 0 + balanceCash;
            int moneyLeft = currentCash - withdrawCash;

            if (currentCash > withdrawCash)
            {
                Debug.Log("Your bank account number of " + accountNumber + " type " + typeofAccount + " has a balance of " + moneyLeft);
            }
            else if (withdrawCash < currentCash)
            {
                Debug.Log("You do not have enough cash ");
            }
        }

        public void BankDeposit()
        {
            int currentCash = 0 + balanceCash;
            currentCash += depositCash;

            Debug.Log("Your bank account number of " + accountNumber + " type " + typeofAccount + " has a balance of " + currentCash); 
        }
    }
    private void Start()
    {
        BankAccount myAccountDeposit = new BankAccount(50, 500, " new ", 1000);
        BankAccount myAccountWithdraw = new BankAccount(50, 200, 100, " new ");
        myAccountDeposit.BankDeposit();
        myAccountWithdraw.BankWithdraw();
    }
}
