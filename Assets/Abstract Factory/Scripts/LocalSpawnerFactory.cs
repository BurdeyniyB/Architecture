using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace Assets.Abstract_Factory.Scripts
{
    public class LocalSpawnerFactory : ISpawnerFactory
    {

        public IUnit SpawnUnit()
        {
            var go = new GameObject("Unit (Local)");
            var unit = go.AddComponent<Unit>();

            return unit;
        }
        public IInteractableObject SpawnInteractableObject()
        {
            var go = new GameObject("Interactable Object (Local)");
            var io = go.AddComponent<InteractbleObject>();

            return io;
        }

        public IUnit SpawnPlayer()
        {
            var go = new GameObject("Unit (Local)");
            var unit = go.AddComponent<Unit>();
            
            go.GetComponent<Player>();
            return unit;
        }
    }
}
