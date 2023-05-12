using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Pattern_Comand.Scripts
{
    internal class MoveStraight : MoveComand
    {
        public MoveStraight(Transform transform, float stepDistance = 1) : base(transform, stepDistance) { }

        public override void Execute()
        {
            transform.position += Vector3.right * stepDistance;
        }

        public override void Undo()
        {
            transform.position -= Vector3.right * stepDistance;
        }
    }
}
