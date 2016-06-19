using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SyncNationalAQIPublishDataService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ISyncNationalAQIPublishDataService”。
    [ServiceContract]
    public interface ISyncNationalAQIPublishDataService
    {
        [OperationContract]
        AQIDataPublishLive[] GetAQIDataPublishLive();

        [OperationContract]
        AQIDataPublishLive[] GetAQIDataPublishHistory(DateTime beginTime, DateTime endTime);


        [OperationContract]
        CityAQIPublishLive[] GetCityAQIPublishLive();

        [OperationContract]
        CityAQIPublishLive[] GetCityAQIPublishHistory(DateTime beginTime, DateTime endTime);


        [OperationContract]
        CityDayAQIPublishLive[] GetCityDayAQIPublishLive();

        [OperationContract]
        CityDayAQIPublishLive[] GetCityDayAQIPublishHistory(DateTime beginTime, DateTime endTime);
    }


    // 使用下面示例中说明的数据约定将复合类型添加到服务操作。
    [DataContract]
    public class AQIDataPublishLive
    {
        [DataMember]
        public string Area { get; set; }

        [DataMember]
        public string StationCode { get; set; }

        [DataMember]
        public string PositionName { get; set; }

        [DataMember]
        public DateTime TimePoint { get; set; }

        [DataMember]
        public string SO2 { get; set; }

        [DataMember]
        public string SO2_24h { get; set; }
        [DataMember]
        public string NO2 { get; set; }

        [DataMember]
        public string NO2_24h { get; set; }
        [DataMember]
        public string PM10 { get; set; }

        [DataMember]
        public string PM10_24h { get; set; }
        [DataMember]
        public string CO { get; set; }

        [DataMember]
        public string CO_24h { get; set; }
        [DataMember]
        public string O3 { get; set; }

        [DataMember]
        public string O3_24h { get; set; }
        [DataMember]
        public string O3_8h { get; set; }

        [DataMember]
        public string O3_8h_24h { get; set; }
        [DataMember]
        public string PM2_5 { get; set; }

        [DataMember]
        public string PM2_5_24h { get; set; }

        [DataMember]
        public string AQI { get; set; }

        [DataMember]
        public string PrimaryPollutant { get; set; }

        [DataMember]
        public string Quality { get; set; }

        [DataMember]
        public string Unheathful { get; set; }

        [DataMember]
        public string Measure { get; set; }

        [DataMember]
        public string Longitude { get; set; }

        [DataMember]
        public string Latitude { get; set; }
    }

    [DataContract]
    public class CityAQIPublishLive
    {
        [DataMember]
        public string Area { get; set; }

        [DataMember]
        public string CityCode { get; set; }

        [DataMember]
        public DateTime TimePoint { get; set; }

        [DataMember]
        public string SO2 { get; set; }
        [DataMember]
        public string NO2 { get; set; }
        [DataMember]
        public string PM10 { get; set; }
        [DataMember]
        public string CO { get; set; }
        [DataMember]
        public string O3 { get; set; }
        [DataMember]
        public string PM2_5 { get; set; }

        [DataMember]
        public string AQI { get; set; }

        [DataMember]
        public string PrimaryPollutant { get; set; }

        [DataMember]
        public string Quality { get; set; }

        [DataMember]
        public string Unheathful { get; set; }

        [DataMember]
        public string Measure { get; set; }
    }

    [DataContract]
    public class CityDayAQIPublishLive
    {
        [DataMember]
        public string Area { get; set; }

        [DataMember]
        public string CityCode { get; set; }

        [DataMember]
        public DateTime TimePoint { get; set; }

        [DataMember]
        public string SO2_24h { get; set; }

        [DataMember]
        public string NO2_24h { get; set; }

        [DataMember]
        public string PM10_24h { get; set; }

        [DataMember]
        public string CO_24h { get; set; }

        [DataMember]
        public string O3_8h_24h { get; set; }

        [DataMember]
        public string PM2_5_24h { get; set; }

        [DataMember]
        public string AQI { get; set; }

        [DataMember]
        public string PrimaryPollutant { get; set; }

        [DataMember]
        public string Quality { get; set; }

        [DataMember]
        public string Unheathful { get; set; }

        [DataMember]
        public string Measure { get; set; }
    }
}
