using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Abstract_Factory.Scripts
{
    public interface ISpawnerFactory
    {
        IUnit SpawnUnit();
        IInteractableObject SpawnInteractableObject();
        IUnit SpawnPlayer();
    }
}
