using DAL;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BLL
{
    /// <summary>
    /// 数据处理类,对工厂提取出的数据进行处理
    /// </summary>
    public class MidWareManage : Otapa
    {
        public delegate bool Checkdele(MidWareManage midWare);//登录检测
        public delegate DataTable GetTabledele(MidWareManage table);//获取数据表
        public delegate bool CheckType(MidWareManage midWare);//特值检测
        public delegate bool CheckRepeatUser(MidWareManage midWare);//用户注册用户名重复查询
        public delegate bool AddField(MidWareManage midWare);//值插入
        public MidWareManage(string table, string userid, string userpwd) : base(table, userid, userpwd)
        { }
        public MidWareManage(string table, List<string> items, List<string> values) : base(table, items, values)
        {
        }
        public MidWareManage(string table, List<string> items, List<string> values, int type) : base(table, items, values, type)
        {
        }
        public MidWareManage(string table) : base(table)
        {
        }
        public GetTabledele gettable = midware =>
        {
            FindProduct findProduct = new GetTableFactoryManage((string)midware.ParamSet[0]).CreateT_SQLCmd();
            return findProduct != null ? findProduct.GetDataSet().Tables[0] : null;

        };
        public Checkdele checkdele = midWare =>
        {
            FindProduct findProduct = new LogInCheckFactoryManage((string)midWare.ParamSet[0], (List<string>)midWare.ParamSet[1], (List<string>)midWare.ParamSet[2]).CreateT_SQLCmd();
            return findProduct != null && (findProduct.GetDataSet().Tables[0].Rows.Count == 1);
        };
        public CheckType getType = midWare =>
        {
            FindProduct findProduct = new LogInCheckFactoryManage((string)midWare.ParamSet[0], (List<string>)midWare.ParamSet[1], (List<string>)midWare.ParamSet[2]).CreateT_SQLCmd();
            return findProduct != null && (findProduct.GetDataSet().Tables[0].Rows[0][2].ToString() == midWare.ParamSet[3].ToString());
        };
        public AddField addfield = midware =>
        {
            var temp = midware.ParamSet[1];


            AddFieldFactoryManage addFieldFactoryManage = new AddFieldFactoryManage(midware.ParamSet[0].ToString(),
                new List<string>() { midware.ParamSet[1].ToString(), midware.ParamSet[2].ToString() });//将对象组拆箱后转成字符泛型列表进行测试,value是对象类型的泛型列表
            return addFieldFactoryManage.UpData() == 1;
        };
        public CheckRepeatUser checkrepectuser = midware =>
        {
            var function = new GetTableFactoryManage((string)midware.ParamSet[0]).CreateT_SQLCmd();
            var Tables = function.GetDataSet().Tables[0];
            IEnumerable<DataRow> rows =
                from p in Tables.AsEnumerable()
                where midware != null && p.Field<string>("user_id") == midware.ParamSet[1].ToString()
                select p;
            return !rows.Any();
        };
    }
}
