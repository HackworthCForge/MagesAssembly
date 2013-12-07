using MagesAssembly.Common;
using MagesAssembly.Core.Effects;
using System;
using System.Collections.Concurrent;

namespace MagesAssembly.Core.EventSystem
{
    public class EventManager
    {
        public static EventManager Instance
        {
            get { return Singleton<EventManager>.Value; }
        }

        private ConcurrentDictionary<Type, ConcurrentBag<IEffect>> _registeredEffects = new ConcurrentDictionary<Type, ConcurrentBag<IEffect>>();

        public bool Publish(IEvent @event)
        {
            bool foundRegisteredEffects = false;
            bool eventIsCanceled = false;

            Type eventType = @event.GetType();
            while (eventType != null && eventIsCanceled == false)
            {
                ConcurrentBag<IEffect> registeredEffects = this._registeredEffects.GetOrAdd(eventType, new ConcurrentBag<IEffect>());
                foreach (IEffect effect in registeredEffects)
                {
                    effect.Resolve(@event);

                    foundRegisteredEffects = true;

                    if (@event.Canceled)
                    {
                        eventIsCanceled = true;
                        break;
                    }
                }

                eventType = eventType.BaseType;

                if (typeof(IEvent).IsAssignableFrom(eventType) == false)
                    break;
            }

            return foundRegisteredEffects;
        }

        public void Subscribe<T>(IEffect subscriber) where T : IEvent
        {
            ConcurrentBag<IEffect> effects = this._registeredEffects.GetOrAdd(typeof(T), new ConcurrentBag<IEffect>());
            effects.Add(subscriber);
        }

        public void Subscribe<T>(Action<T> subscriber) where T : IEvent
        {
            this.Subscribe<T>(new ActionEffect<T>(subscriber));
        }
    }
}
