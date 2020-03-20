using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    /// <summary>
    /// 行数影响接口
    /// </summary>
    public interface IAlterProduct
    {
        int UpRowsCount();
    }

    /// <summary>
    /// 查询功能基类
    /// </summary>
     public abstract class FindProduct
    {
        protected string Table;
        protected List<string> Items;
        protected List<string> Value;
        protected string Type;
        protected DataSet MyDataSet;
        abstract public DataSet GetDataSet();
    }

    /// <summary>
    /// 获取数据表
    /// </summary>
    public class GetTableServer : FindProduct
    {
        public GetTableServer(string table)
        {
            Table = table;
        }

        public override DataSet GetDataSet()
        {
            try
            {
                MyDataSet = DbHelper.GetDataSet("SELECT * FROM "+Table);
                return MyDataSet;
            }
            catch
            {
                throw new Exception("wrong with selected");
            }
        }
    }

    /// <summary>
    /// 登录检测
    /// </summary>
    public class LogInCheckServer : FindProduct
    {
        public LogInCheckServer(string table , List<string> items,List<string> values )
        {
            Table = table;
            Items = items;
            Value = values;
        }

        public override DataSet GetDataSet()
        {
            try
            {
                MyDataSet = DbHelper.GetDataSet(String.Format("SELECT * FROM {0} WHERE {1}='{2}' AND {3}='{4}'", Table, Items[0], Value[0], Items[1], Value[1]));
                return MyDataSet;
            }
            catch
            {
                throw new Exception("Wrong with Checked");
            }
        }
    }

    /// <summary>
    /// 数据表内容修改功能
    /// </summary>
    public class AlterTableServer : FindProduct, IAlterProduct
    {

        public override DataSet GetDataSet()
        {
            throw new NotImplementedException();
        }

        public int UpRowsCount()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 数据表内容删除功能
    /// </summary>
    public class DelFieldServer : FindProduct, IAlterProduct
    {
        public override DataSet GetDataSet()
        {
            throw new NotImplementedException();
        }

        public int UpRowsCount()
        {
            throw new NotImplementedException();
        }
    }

/// <summary>
/// 数据表内容添加功能
/// </summary>
    public class AddFieldServer : FindProduct, IAlterProduct
    {
        public AddFieldServer(string table,List<string> valuesList)
        {
            Table = table;
            Value = valuesList;
        }
        public override DataSet GetDataSet()
        {
            throw new NotImplementedException();
        }

        public int UpRowsCount()
        {
            try
            {
                return DbHelper.GetUpData(String.Format("INSERT INTO {0}(user_id,user_pwd)VALUES('{1}','{2}')",Table,Value[0],Value[1]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
