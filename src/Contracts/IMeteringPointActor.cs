using Dapr.Actors;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMeteringPointActor : IActor
    {
        Task ReceiveMeasurement(Measurement measurement);
    }
}
