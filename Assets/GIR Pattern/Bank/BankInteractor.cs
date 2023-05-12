using UnityEngine;

namespace Lessons.Architecture
{
    public class BankInteractor : Interactor
    {
        private BankRepository repository;
        public int Coins => this.repository.Coins;

        public BankInteractor() { }
        public override void Initalize()
        {
            Bank.Initialilize(this);
        }
        public override void OnCreate()
        {
            base.OnCreate();
            this.repository = ArchitectureTester.ReposyrorysBase.GetRepository<BankRepository>();
        }

        public bool IsEnoughtCoins(int price)
        {
            return this.Coins >= price;
        }

        public void Add(GameObject sender, int countAddCoin)
        {
            this.repository.Coins += countAddCoin;
            this.repository.Save();
        }

        public void Spend(GameObject sender, int countSpendCoin) 
        {
            this.repository.Coins -= countSpendCoin;
            this.repository.Save();
        }
    }

}
