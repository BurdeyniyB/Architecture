using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Pattern_Comand.Scripts
{
    internal class MoveDiagonal : MoveComand
    {
        private Vector3 _directionDiagonal = new Vector3(1f, -1f, 0f).normalized;
        public MoveDiagonal(Transform transform, float stepDistance = 1) : base(transform, stepDistance) { }

        public override void Execute()
        {
            transform.position += _directionDiagonal * stepDistance;
        }

        public override void Undo()
        {
            transform.position -= _directionDiagonal * stepDistance;
        }
    }
}
