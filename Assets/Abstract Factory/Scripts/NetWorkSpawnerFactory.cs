using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Abstract_Factory.Scripts
{
    public class NetWorkSpawnerFactory : ISpawnerFactory
    {
        public IUnit SpawnUnit()
        {
            var go = new GameObject("Unit (NET)");
            var unit = go.AddComponent<Unit>();

            go.AddComponent<NetworkBehior>();
            return unit;
        }

        public IInteractableObject SpawnInteractableObject()
        {
            var go = new GameObject("Interactable Object (NET)");
            var io = go.AddComponent<InteractbleObject>();

            go.AddComponent<NetworkBehior>();
            return io;
        }

        public IUnit SpawnPlayer()
        {
            var go = new GameObject("Unit (NET)");
            var unit = go.AddComponent<Unit>();

            go.GetComponent<Player>();
            go.AddComponent<NetworkBehior>();
            return unit;
        }
    }
}
