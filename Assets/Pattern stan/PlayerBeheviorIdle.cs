using UnityEngine;

namespace Assets.Scripts.Pattern_stan
{
    public class PlayerBeheviorIdle : IPlayerBehavior
    {
        public void Enter()
        {
            Debug.Log("Enter Idle behavior");
        }

        public void Exit()
        {
            Debug.Log("Exit Idle behavior");
        }

        public void Update()
        {
            Debug.Log("Update Idle behavior");
        }
    }
}
