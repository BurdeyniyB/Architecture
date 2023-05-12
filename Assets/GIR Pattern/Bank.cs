using System;
using UnityEngine;

namespace Lessons.Architecture
{
    public static class Bank
    {
        public static event Action OnBankinitializedEvent;
        public static int Coins
        {
            get
            {
                CheckClass();
                return bankInteractor.Coins;
            }
        }

        public static bool IsInitialize { get;private set; }

        private static BankInteractor bankInteractor;

        public static void Initialilize(BankInteractor interactor)
        {
            bankInteractor = interactor;
            IsInitialize = true;

            OnBankinitializedEvent?.Invoke();
        }

        public static bool IsEnoughtCoins(int price)
        {
            CheckClass();
            return bankInteractor.IsEnoughtCoins(price);
        }

        public static void Add(GameObject sender, int countAddCoin)
        {
            CheckClass();
            bankInteractor.Add(sender, countAddCoin);
        }

        public static void Spend(GameObject sender, int countSpendCoin)
        {
            CheckClass();
            bankInteractor.Spend(sender, countSpendCoin);
        }

        private static void CheckClass()
        {
            if(!IsInitialize)
            {
                throw new Exception("Bank is not initialize");
            }
        }
    }
}