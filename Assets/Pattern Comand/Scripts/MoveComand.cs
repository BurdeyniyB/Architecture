using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Pattern_Comand.Scripts
{
    public abstract class MoveComand
    {
        protected Transform transform;
        protected float stepDistance;

        public MoveComand(Transform transform, float stepDistance = 1)
        {
            this.transform = transform;
            this.stepDistance = stepDistance;
        }

        public abstract void Execute();
        public abstract void Undo();
    }
}
