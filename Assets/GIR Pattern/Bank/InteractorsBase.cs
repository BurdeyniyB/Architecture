using System;
using System.Collections.Generic;

namespace Lessons.Architecture
{
    public class InteractorsBase
    {
        private Dictionary<Type, Interactor> _interactorsMap;

        public InteractorsBase() 
        {
           this._interactorsMap = new Dictionary<Type, Interactor>();
        }

        public void CreateAllInteractos()
        {
            this.CreateInteractor<BankInteractor>();
        }

        private void CreateInteractor<T>() where T : Interactor, new()
        {
            var interactor = new T();
            var type = typeof(T);
            this._interactorsMap[type] = interactor;
        }

        public void SendOnCreateToAllInteractor()
        {
            var allInteractors = this._interactorsMap.Values;
            foreach (var interactor in allInteractors)
            {
                interactor.OnCreate();
            }
        }    
        
        public void SendOnStartToAllInteractor()
        {
            var allInteractors = this._interactorsMap.Values;
            foreach (var interactor in allInteractors)
            {
                interactor.OnStart();
            }
        }

        public void IntializeAllInteractor()
        {
            var allInteractors = this._interactorsMap.Values;
            foreach (var interactor in allInteractors)
            {
                interactor.Initalize();
            }
        }

        public T GetInteractor<T>() where T : Interactor
        {
            var type = typeof(T);
            return (T)this._interactorsMap[type];
        }
    }

}

