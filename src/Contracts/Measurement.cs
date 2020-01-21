using System;

namespace Contracts
{
    public class Measurement
    {
        public string ExportDataId { get; set; }
        public string ExportDataType { get; set; }
        public MeasurementExportData ExportData { get; set; }
        public string DeviceId { get; set; }
        public string Version { get; set; }
        public string SourceSystem { get; set; }
        public string SourceCustomerId { get; set; }
        public string MeteringPointId { get; set; }
    }

    public class MeasurementExportData
    {
        public DateTime MeasurementTime { get; set; }
        public DateTime RegistrationTime { get; set; }
        public string Register { get; set; }
        public int Interval { get; set; }
        public string ProductName { get; set; }

        public decimal Value { get; set; }
        public int Quality { get; set; }
    }
}
