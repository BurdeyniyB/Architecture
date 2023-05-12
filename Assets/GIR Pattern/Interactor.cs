namespace Lessons.Architecture
{
    public abstract class Interactor
    {
        public virtual void OnCreate() { }
        public virtual void Initalize() { }
        public virtual void OnStart() { }
    }

}
