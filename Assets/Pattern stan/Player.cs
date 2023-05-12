using Assets.Scripts.Pattern_stan;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Pattern_stan
{
    public class Player : MonoBehaviour
    {
        private Dictionary<Type, IPlayerBehavior> _beheviorMap;
        private IPlayerBehavior _beheviorCurrent;

        private void Start()
        {
            this.InitBehavior();
            this.SetBehaviorByDefault();
        }

        private void InitBehavior()
        {
            this._beheviorMap = new Dictionary<Type, IPlayerBehavior>();

            this._beheviorMap[typeof(PlayerBehaviorActive)] = new PlayerBehaviorActive();
            this._beheviorMap[typeof(PlayerBehaviorAggressive)] = new PlayerBehaviorAggressive();
            this._beheviorMap[typeof(PlayerBeheviorIdle)] = new PlayerBeheviorIdle();

        }

        private void SetBehavior(IPlayerBehavior newBehavior)
        {
            if(this._beheviorCurrent != null)
                this._beheviorCurrent.Exit();

            this._beheviorCurrent = newBehavior;
            this._beheviorCurrent.Enter();
        }

        private void SetBehaviorByDefault()
        {
            SetBehaviorIdle();
        }

        private IPlayerBehavior GetBehavior<T>() where T : IPlayerBehavior
        {
            var type = typeof(T);
            return this._beheviorMap[type];
        }

        private void Update()
        {
            if (this._beheviorCurrent != null)
                this._beheviorCurrent.Update();
        }

        public void SetBehaviorIdle()
        {
            var behavior = this.GetBehavior<PlayerBeheviorIdle>();
            this.SetBehavior(behavior);
        }        

        public void SetBehaviorActive()
        {
            var behavior = this.GetBehavior<PlayerBehaviorActive>();
            this.SetBehavior(behavior);
        }  
        
        public void SetBehaviorAggressive()
        {
            var behavior = this.GetBehavior<PlayerBehaviorAggressive>();
            this.SetBehavior(behavior);
        }
    }

}
