using MagesAssembly.Core.Objects;

namespace MagesAssembly.Core.EventSystem
{
    public interface IEvent
    {
        MtgObject Source { get; }

        bool Canceled { get; set; }

        IEvent OriginalEvent { get; set; }

    }
}
