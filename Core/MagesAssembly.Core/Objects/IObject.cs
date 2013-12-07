
using MagesAssembly.Core.Effects;
using MagesAssembly.Core.Players;
using System.Collections.Generic;

namespace MagesAssembly.Core.Objects
{
    public class MtgObject
    {

        public MtgObject()
        {
            this.ActiveEffects = new List<IEffect>();
            this.Name = new MtgAttribute<string>(this, "");
        }

        IPlayer Controller { get; set; }

        public MtgAttribute<string> Name { get; set; }

        public List<IEffect> ActiveEffects { get; private set; }
    }

    public class MtgAttribute<T>
    {
        public MtgAttribute(MtgObject owner, T original)
        {
            this.Owner = owner;
            this.Original = original;
        }

        public MtgObject Owner { get; private set; }

        public T Original { get; private set; }

        public T GetCurrent()
        {
            return default(T);
        }


    }
}
