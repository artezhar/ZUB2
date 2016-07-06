using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;
using Dapper;
using System.Reflection;
using System.Collections.Concurrent;
using System.Data;

namespace ZUB.Data
{
    public static class Mappings
    {
        private static ConcurrentDictionary<Type, Mapping> mps = new ConcurrentDictionary<Type, Mapping>();

        public static Mapping OfType(Type type) { return mps.ContainsKey(type) ? mps[type] : null; }

        public static void Add(Type type, Mapping mapping) { if (!mps.ContainsKey(type)) mps.GetOrAdd(type, mapping); }

        public static void Add(Type type, IDbConnection conn) { if (!mps.ContainsKey(type)) mps.GetOrAdd(type, Automap(type, conn)); }

        public static void AddOrReplace(Type type, Mapping mapping) { if (!mps.ContainsKey(type)) mps.GetOrAdd(type, mapping); else mps[type] = mapping; }

        private static Mapping Automap(Type type, IDbConnection dbc, bool matchCase = false)
        {
            Mapping map = new Mapping();
            var props = type.GetProperties();
            StringComparer sComp = matchCase ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase;
            var obj = dbc.Query<ts_row>($"select column_name, data_type, character_maximum_length from INFORMATION_SCHEMA.COLUMNS where table_name = '{type.Name}'");
            var obj_n = obj.Select(o => o.column_name);
            if (obj.Count() > 0)
            {
                foreach (string name in obj_n.Intersect(props.Select(p => p.Name), sComp))
                {
                    //map.Add(new MappingItem(props.Single(p => String.Compare(p.Name, name, !matchCase) == 0), type.Name, name));
                }
                /* foreach(string name in props.Select(p=>p.Name).Where(s=>!obj_n.Contains(s,sComp)))
                 {
                     var izz = dbc.Query<ts_row>($"select column_name, data_type, character_maximum_length from INFORMATION_SCHEMA.COLUMNS where table_name = '{name}'");
                     if(izz.Count()==1)
                     {
                         map.Add(new MappingItem(props.Single(p => String.Compare(p.Name, name, !matchCase) == 0),name,))
                     }
                 }*/
                return map;
            }
            else
                throw new NotImplementedException();
        }
    }



    

    

    


    internal class ts_row
    {
        public string column_name { get; set; }
        public string data_type { get; set; }
        public int character_maximum_length { get; set; }
    }
}
