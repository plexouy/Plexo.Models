using System;
using System.ServiceModel;
using System.Threading;

namespace Plexo.Helpers
{
    public class OperationContextSynchronizationContext : SynchronizationContext
    {
        private readonly OperationContext context;

        public OperationContextSynchronizationContext(IClientChannel channel) : this(new OperationContext(channel))
        {
        }

        public OperationContextSynchronizationContext(OperationContext context)
        {
            OperationContext.Current = context;
            this.context = context;
        }

        public override void Post(SendOrPostCallback d, object state)
        {
            OperationContext.Current = context;
            d(state);
        }
    }

    public static class OperationContextSynchronizationContextExt
    {
        public static void SyncContext(this IClientChannel client, Action a)
        {
            var currentSynchronizationContext = SynchronizationContext.Current;
            try
            {
                SynchronizationContext.SetSynchronizationContext(new OperationContextSynchronizationContext(client));
                a();
            }
            finally
            {
                SynchronizationContext.SetSynchronizationContext(currentSynchronizationContext);
            }
        }

        public static T SyncContext<T>(this IClientChannel client, Func<T> a)
        {
            var currentSynchronizationContext = SynchronizationContext.Current;
            try
            {
                SynchronizationContext.SetSynchronizationContext(new OperationContextSynchronizationContext(client));
                return a();
            }
            finally
            {
                SynchronizationContext.SetSynchronizationContext(currentSynchronizationContext);
            }
        }
    }
}