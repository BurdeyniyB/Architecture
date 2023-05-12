namespace Lessons.Architecture
{
    public abstract class Repository
    {
        public virtual void OnCreate() { }
        public virtual void Initalize() { }
        public virtual void OnStart() { }
        public abstract void Save();
    }

}
