using MagesAssembly.Core.EventSystem;

namespace MagesAssembly.Core.Effects
{
    /// <summary>
    /// Called when an specified event happens.
    /// </summary>
    public interface IEffect
    {

        //INFO: We should be careful when we extend this interface. 
        //      It might not be what we want, because it's currently just an event handler.

        void Resolve(IEvent @event);
    }
}
