using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZUB.Data
{
    public class MappingBuilder
    {
        private Mapping _mapping = new Mapping();

        public Mapping Build(bool autoMap = true)
        {
            if (autoMap)
                foreach (var prop in _mapping.EntityType.GetProperties().Where(p => !_mapping.Select(m => m.PropertyName).Contains(p.Name)))
                {
                    _mapping.Add(new MappingItem(prop.Name, _mapping.BaseTableName, prop.Name));
                }
            return _mapping;
        }

        public MappingBuilder Type(Type type)
        {
            _mapping.EntityType = type;
            return this;
        }

        public MappingBuilder SetMainTable(string table_name)
        {
            return this;
        }

        public MappingBuilder MapPropertyToColumn(string prop, string tn, string cn)
        {
            _mapping.Add(new MappingItem(prop, tn, cn));
            return this;
        }

        public MappingBuilder MapPropertyToTable(string prop, string tn, string cn = "ID")
        {
            _mapping.Add(new MappingItem(prop, tn, cn, MappingItemType.TABLE));
            return this;
        }

    }
}
