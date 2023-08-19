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
        List<Tag> tagsSpecifiedTimePeriodSortByTime(DateTime start, DateTime end);
        [OperationContract]
        List<Tag> lastValueOfAITagsSortByTime();
        [OperationContract]
        List<Tag> lastValueOfDITagsSortByTime();

        [OperationContract]
        List<Tag>  tagValuesSpecificIdSortByValue(string tagId);





    }
}
