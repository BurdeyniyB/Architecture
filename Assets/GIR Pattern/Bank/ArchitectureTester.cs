using System;
using System.Collections;
using UnityEngine;

namespace Lessons.Architecture
{
    public class ArchitectureTester : MonoBehaviour
    {

        public static InteractorsBase InteractorsBase;
        public static RepositorysBase ReposyrorysBase;

        private void Start()
        {
            this.StartCoroutine(this.StartGameRoutine());
        }

        private IEnumerator StartGameRoutine()
        {
            InteractorsBase = new InteractorsBase();
            ReposyrorysBase = new RepositorysBase();

            InteractorsBase.CreateAllInteractos();
            ReposyrorysBase.CreateAllRepository();
            yield return null;

            InteractorsBase.SendOnCreateToAllInteractor();
            ReposyrorysBase.SendOnCreateToAllRepository();
            yield return null;

            InteractorsBase.IntializeAllInteractor();
            ReposyrorysBase.IntializeAllRepository();
            yield return null;

            InteractorsBase.SendOnCreateToAllInteractor();
            ReposyrorysBase.SendOnStartToAllRepository();

            Debug.Log($"In bank: {Bank.Coins}");
        }

        public void AddCoin()
        {
            Bank.Add(this.gameObject, 5);
            Debug.Log($"Coins add: {5} in bank {Bank.Coins}");
        }

        public void SpendCoin()
        {
            Bank.Spend(this.gameObject, 10);
            Debug.Log($"Coins spend: {10} in bank {Bank.Coins}");
        }

        private void CheckInitize()
        {

        }
    }

}

