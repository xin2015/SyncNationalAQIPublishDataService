using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Xin.Basic;

namespace SyncNationalAQIPublishDataService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SyncNationalAQIPublishDataService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 SyncNationalAQIPublishDataService.svc 或 SyncNationalAQIPublishDataService.svc.cs，然后开始调试。
    public class SyncNationalAQIPublishDataService : ISyncNationalAQIPublishDataService
    {
        public AQIDataPublishLive[] GetAQIDataPublishLive()
        {
            string tableName = "AQIDataPublishLive";
            return DataQuery.GetLive<AQIDataPublishLive>(tableName);
        }

        public AQIDataPublishLive[] GetAQIDataPublishHistory(DateTime beginTime, DateTime endTime)
        {
            string tableName = "AQIDataPublishHistory";
            return DataQuery.GetHistory<AQIDataPublishLive>(tableName, beginTime, endTime);
        }

        public CityAQIPublishLive[] GetCityAQIPublishLive()
        {
            string tableName = "CityAQIPublishLive";
            return DataQuery.GetLive<CityAQIPublishLive>(tableName);
        }

        public CityAQIPublishLive[] GetCityAQIPublishHistory(DateTime beginTime, DateTime endTime)
        {
            string tableName = "CityAQIPublishHistory";
            return DataQuery.GetHistory<CityAQIPublishLive>(tableName, beginTime, endTime);
        }

        public CityDayAQIPublishLive[] GetCityDayAQIPublishLive()
        {
            string tableName = "CityDayAQIPublishLive";
            return DataQuery.GetLive<CityDayAQIPublishLive>(tableName);
        }

        public CityDayAQIPublishLive[] GetCityDayAQIPublishHistory(DateTime beginTime, DateTime endTime)
        {
            string tableName = "CityDayAQIPublishHistory";
            return DataQuery.GetHistory<CityDayAQIPublishLive>(tableName, beginTime, endTime);
        }
    }
}
