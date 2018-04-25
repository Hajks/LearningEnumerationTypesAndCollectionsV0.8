using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEnumerationTypesAndCollectionsV0._8
{
    public enum SortCriteria
    {
        ValueThenType,
        TypeThenValue,
    }
    class CardComparer : IComparer<Card>
    {
        public SortCriteria SortBy = SortCriteria.ValueThenType;
        public int Compare(Card x, Card y)
        {
            if (SortBy == SortCriteria.ValueThenType)
                if (x.Value > y.Value)
                    return 1;
                else if (x.Value < y.Value)
                    return -1;
                else
                    if (x.Type > y.Type)
                        return 1;
                    else if (x.Type < y.Type)
                        return -1;
                    else
                        return 0;
            else
                if (x.Type > y.Type)
                    return 1;
                else if (x.Type < y.Type)
                    return -1;
                if (x.Value > y.Value)
                    return 1;
                else if (x.Value < y.Value)
                    return -1;
                else
                    return 0;
        }
    }
}
