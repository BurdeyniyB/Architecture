using UnityEngine;

namespace Assets.Scripts.Pattern_stan
{
    internal class PlayerBehaviorActive : IPlayerBehavior
    {
        public void Enter()
        {
            Debug.Log("Enter Active behavior");
        }

        public void Exit()
        {
            Debug.Log("Exit Active behavior");
        }

        public void Update()
        {
            Debug.Log("Update Active behavior");
        }
    }
}
