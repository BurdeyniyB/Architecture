using UnityEngine;

namespace Assets.Scripts.Pattern_stan
{
    internal class PlayerBehaviorAggressive : IPlayerBehavior
    {
        public void Enter()
        {
            Debug.Log("Enter Aggressive behavior");
        }

        public void Exit()
        {
            Debug.Log("Exit Aggressive behavior");
        }

        public void Update()
        {
            Debug.Log("Update Aggressive behavior");
        }
    }
}
