using MagesAssembly.Core.EventSystem;
using System;

namespace MagesAssembly.Core.Effects
{
    internal class ActionEffect<T> : IEffect where T : IEvent
    {
        private readonly Action<T> _action;

        public ActionEffect(Action<T> action)
        {
            this._action = action;
        }

        public void Resolve(EventSystem.IEvent @event)
        {
            this._action((T)@event);
        }
    }
}
