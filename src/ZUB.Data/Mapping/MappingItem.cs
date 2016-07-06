using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZUB.Data
{
    public class MappingItem
    {
        //public PropertyInfo Property { get; set; }// Надо ли?
        public string PropertyName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public MappingItemType MappingType { get; set; }

        /*public MappingItem(PropertyInfo pi, string tn, string cn)
        {
            Property = pi;
            TableName = tn;
            ColumnName = cn;
        }*/

        public MappingItem(string pn, string tn, string cn, MappingItemType mt = MappingItemType.FIELD)
        {
            TableName = tn;
            ColumnName = cn;
            PropertyName = pn;
            MappingType = mt;
        }
    }

    public enum MappingItemType
    {
        FIELD, TABLE
    }
}
