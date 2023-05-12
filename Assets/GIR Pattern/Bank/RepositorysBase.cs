using System;
using System.Collections.Generic;

namespace Lessons.Architecture
{
    public class RepositorysBase
    {
        private Dictionary<Type, Repository> _repositoryMap;

        public RepositorysBase()
        {
            this._repositoryMap = new Dictionary<Type, Repository>();
        }

        public void CreateAllRepository()
        {
            this.CreateRepository<BankRepository>();
        }

        private void CreateRepository<T>() where T : Repository, new()
        {
            var interactor = new T();
            var type = typeof(T);
            this._repositoryMap[type] = interactor;
        }

        public void SendOnCreateToAllRepository()
        {
            var allRepositorys = this._repositoryMap.Values;
            foreach (var repository in allRepositorys)
            {
                repository.OnCreate();
            }
        }

        public void SendOnStartToAllRepository()
        {
            var allRepositorys = this._repositoryMap.Values;
            foreach (var interactor in allRepositorys)
            {
                interactor.OnStart();
            }
        }

        public void IntializeAllRepository()
        {
            var allRepositorys = this._repositoryMap.Values;
            foreach (var interactor in allRepositorys)
            {
                interactor.Initalize();
            }
        }

        public T GetRepository<T>() where T : Repository
        {
            var type = typeof(T);
            return (T)this._repositoryMap[type];
        }
    }
}
