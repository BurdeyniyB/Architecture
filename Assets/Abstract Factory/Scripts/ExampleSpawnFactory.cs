using System.Diagnostics;
using UnityEngine;
using UnityEngine.Networking.Types;
using Debug = UnityEngine.Debug;

namespace Assets.Abstract_Factory.Scripts
{
    public class ExampleSpawnFactory : MonoBehaviour
    {
        private ISpawnerFactory _spawnerFactory;

        private void Start()
        {
            SetModeLocal();
        }


        public void SetLocalMode()
        {
            SetModeLocal();
        }

        public void SetNetworkMode()
        {
            SetModeNetwork();
        }

        public void SpawnUnit()
        {
            _spawnerFactory.SpawnUnit();
        }

        public void SpawnInteractableObject()
        {
            _spawnerFactory.SpawnInteractableObject();
        }

        public void SpawnPlayer()
        {
            _spawnerFactory.SpawnPlayer();
        }


        private void SetModeLocal()
        {
            _spawnerFactory = new LocalSpawnerFactory();

            Debug.Log("Local mode");
        }

        private void SetModeNetwork()
        {
            _spawnerFactory = new NetWorkSpawnerFactory();

            Debug.Log("Network mode");
        }
    }
}
