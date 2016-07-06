using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZUB.Data
{
    public class Mapping : List<MappingItem>
    {
        public Type EntityType { get; set; }
        public string BaseTableName
        {
            get
            {
                if (String.IsNullOrWhiteSpace(btable))
                    return EntityType?.Name;
                return btable;
            }
            set
            {
                btable = value;
            }
        }
        private string btable;
    }
}
