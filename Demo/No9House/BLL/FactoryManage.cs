
using DAL;
using System.Collections.Generic;

namespace BLL
{
    interface IUpData
    {
        int UpData();
    }

    /// <summary>
    /// 读取库基类
    /// </summary>
    public abstract class FactoryManage
    {
        protected string Table;
        protected List<string> Item;
        protected List<string> Values;
        public abstract FindProduct CreateT_SQLCmd();
    }

    /// <summary>
    /// 获取数据表
    /// </summary>
    public class GetTableFactoryManage : FactoryManage
    {
        public GetTableFactoryManage(string table)
        {
            this.Table = table;
        }

        public override FindProduct CreateT_SQLCmd()
        {
            return new GetTableServer(Table);
        }
    }

    /// <summary>
    /// 登录检测
    /// </summary>
    public class LogInCheckFactoryManage : FactoryManage
    {
        public LogInCheckFactoryManage(string table, List<string> items, List<string> values)
        {
            this.Table = table;
            this.Item = items;
            this.Values = values;
        }

        public override FindProduct CreateT_SQLCmd()
        {
            return new LogInCheckServer(Table, Item, Values);
        }
    }

    /// <summary>
    /// 修改数据
    /// </summary>
    public class AlterTableFactoryManage : FactoryManage
    {
        public override FindProduct CreateT_SQLCmd()
        {
            IAlterProduct alterProduct = new AlterTableServer();
            if (alterProduct.UpRowsCount() == 1)
                return new AlterTableServer();
            return null;
        }
    }

    /// <summary>
    /// 添加数据
    /// </summary>
    public class AddFieldFactoryManage : FactoryManage,IUpData
    {
        public AddFieldFactoryManage(string table, List<string> vlues)
        {
            this.Table = table;
            this.Values = vlues;
        }

        public int UpData()
        {
            IAlterProduct alterProduct = new AddFieldServer(Table,Values);
            return alterProduct.UpRowsCount();
        }

        public override FindProduct CreateT_SQLCmd()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// 删除数据
    /// </summary>
    public class DelFieldFactoryManage : FactoryManage
    {
        public override FindProduct CreateT_SQLCmd()
        {
            IAlterProduct alterProduct = new DelFieldServer();
            if (alterProduct.UpRowsCount() == 1)
                return new DelFieldServer();
            return null;
        }
    }

}
