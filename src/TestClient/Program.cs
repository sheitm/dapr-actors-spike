using Contracts;
using Dapr.Actors.Client;
using System;
using System.Threading.Tasks;

namespace TestClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Environment.SetEnvironmentVariable("DAPR_HTTP_PORT", "61282");

            var mpt = "707057500052051495";
            var m = new Measurement 
            {
                ExportDataId = "7359992890750580-5-10-637145064000000000",
                ExportDataType = "Measurement",
                DeviceId = "7359992890750580",
                Version = "2.0",
                SourceSystem = "Aidon Linkware",
                SourceCustomerId = "194a5fc8-509e-4f94-aa4b-23c629b76062",
                MeteringPointId = mpt,
                ExportData = new MeasurementExportData
                {
                    MeasurementTime = new DateTime(2020, 1, 13, 10, 0, 0),
                    RegistrationTime = new DateTime(2020, 1, 13, 10, 37, 31),
                    Register = "ActivePlus",
                    Interval = 15,
                    ProductName = "000005 Aplus 15 min ES1",
                    Value = 3649.514M,
                    Quality = 0
                }
            };

            var proxy = ActorProxy.Create<IMeteringPointActor>(new Dapr.Actors.ActorId(mpt), "MeteringPointActor");
            await proxy.ReceiveMeasurement(m);

        }
    }
}
