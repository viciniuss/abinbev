using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Events
{
    public class SaleRegisteredEvent
    {
        private static readonly List<Action<object>> Handlers = new();

        public static void Register(Action<object> callback)
        {
            Handlers.Add(callback);
        }

        public static void Raise(object @event)
        {
            foreach (var handler in Handlers)
            {
                handler(@event);
            }
        }
    }
}
