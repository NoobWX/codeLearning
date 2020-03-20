using System.Collections.Generic;

namespace BLL
{
    /// <summary>
    /// 将参数集合
    /// </summary>
    public abstract class Otapa
    {
        private int? type_ = null; 
        public List<object> ParamSet = new List<object>();//装箱拆箱不是明智的做法,之后重新设计

        /// <summary>
        /// select * from table where items1=values1 and items2=values2 
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="items">列名</param>
        /// <param name="values">值</param>
        public Otapa(string table, List<string> items, List<string> values)
        {
            ParamSet.AddRange(new List<object> { table, items, values });
        }

        /// <summary>
        /// 获取数据表模板
        /// </summary>
        /// <param name="values"></param>
        public Otapa(string values)
        {
            ParamSet.Add(values);
        }

        /// <summary>
        /// 先使用select * from table where items1=values1 and items2=values2
        /// 然后对数据与type进行比对
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="items">列名</param>
        /// <param name="values">值</param>
        /// <param name="type">检测内容</param>
        public Otapa(string table, List<string> items, List<string> values, int type)
        {
            ParamSet.AddRange(new List<object> { table, items, values, type });
        }

        /// <summary>
        /// 注册模板
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="values">数值</param>
        // public Otapa(string table, List<string> values)
        // {
        //     ParamSet.AddRange(new List<object>() { table, values[0],values[1] });
        // }

        public Otapa(string table,string valuesID, string valuesPsw)
        {
            ParamSet.AddRange(new List<object>(){table,valuesID,valuesPsw});
        }
    }
}
