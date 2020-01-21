using Contracts;
using Dapr.Actors;
using Dapr.Actors.Runtime;
using System;
using System.Threading.Tasks;

namespace Actors
{
    public class MeteringPointActor : Actor, IMeteringPointActor, IRemindable
    {
        public MeteringPointActor(ActorService service, ActorId id) : base(service, id)
        { }

        public Task ReceiveMeasurement(Measurement measurement)
        {
            Console.WriteLine($"Recieved measurent for {measurement.MeteringPointId}. Actor ID is {Id}");
            return Task.CompletedTask;
        }

        public Task ReceiveReminderAsync(string reminderName, byte[] state, TimeSpan dueTime, TimeSpan period)
        {
            throw new NotImplementedException();
        }
    }
}
