using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ScadaCore
{
    [ServiceContract]
    public interface IReportManager
    {
        [OperationContract]
        List<Alarm> alarmsSpecifiedTimePeriodSortByPriority(DateTime start, DateTime end);

        [OperationContract]
        List<Alarm> alarmsSpecifiedTimePeriodSortByTime(DateTime start, DateTime end);
        [OperationContract]
        List<Alarm> alarmsSpecifiedPrioritySortByTime(string priority);
        [OperationContract]
        List<Log> tagsSpecifiedTimePeriodSortByTime(DateTime start, DateTime end);
        [OperationContract]
        List<Log> lastValueOfAITagsSortByTime();
        [OperationContract]
        List<Log> lastValueOfDITagsSortByTime();

        [OperationContract]
        List<Log>  tagValuesSpecificIdSortByValue(string tagId);






    }
}
