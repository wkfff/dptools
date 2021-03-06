﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace DP.Data.Common
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public class Query
    {
        public Query()
        {

        }

        #region 变量

        /// <summary>
        /// 
        /// </summary>
        private List<string> _selectFields = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        private List<Condition> _conditions = new List<Condition>();

        /// <summary>
        /// 
        /// </summary>
        private List<SortOrder> _orders = new List<SortOrder>();

        /// <summary>
        /// 
        /// </summary>
        private int _startRecordIndex = 0;

        /// <summary>
        /// 
        /// </summary>
        private int _pageSize = -1;

        /// <summary>
        /// 
        /// </summary>
        private string _partitionName = "";

        /// <summary>
        /// 
        /// </summary>
        private bool _isPaging = false;

        /// <summary>
        /// 
        /// </summary>
        private string _tableName = "";

        /// <summary>
        /// 查询条件 Sql语句
        /// </summary>
        private string _conditionString = "";
        /// <summary>
        /// 查询条件DB参数
        /// </summary>
        private List<DbParameter> _dbParameters = new List<DbParameter>();

       

      

      
	    #endregion

        #region 属性
        /// <summary>
        /// 查询条件DB参数
        /// </summary>
        public List<DbParameter> DbParameters
        {
            get { return _dbParameters; }
            set { _dbParameters = value; }
        }
    
        /// <summary>
        /// 查询条件 Sql语句
        /// </summary>
        public string ConditionString
        {
            get { return _conditionString; }
            set { _conditionString = value; }
        }


        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        /// <remarks></remarks>
        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is paging.
        /// </summary>
        /// <value><c>true</c> if this instance is paging; otherwise, <c>false</c>.</value>
        /// <remarks></remarks>
        public bool IsPaging
        {
            get { return _isPaging; }
            set { _isPaging = value; }
        }

        /// <summary>
        /// Gets or sets the name of the partition.
        /// </summary>
        /// <value>The name of the partition.</value>
        /// <remarks></remarks>
        public string PartitionName
        {
            get { return _partitionName; }
            set { _partitionName = value; }
        }

        /// <summary>
        /// Gets or sets the size of the page.
        /// </summary>
        /// <value>The size of the page.</value>
        /// <remarks></remarks>
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }


        /// <summary>
        /// Gets or sets the start index of the record.
        /// </summary>
        /// <value>The start index of the record.</value>
        /// <remarks></remarks>
        public int StartRecordIndex
        {
            get { return _startRecordIndex; }
            set { _startRecordIndex = value; }
        }


        /// <summary>
        /// Gets or sets the orders.
        /// </summary>
        /// <value>The orders.</value>
        /// <remarks></remarks>
        public List<SortOrder> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Gets or sets the conditions.
        /// </summary>
        /// <value>The conditions.</value>
        /// <remarks></remarks>
        public List<Condition> Conditions
        {
            get { return _conditions; }
            set { _conditions = value; }
        }

        /// <summary>
        /// Gets or sets the select fields.
        /// </summary>
        /// <value>The select fields.</value>
        /// <remarks></remarks>
        public List<string> SelectFields
        {
            get { return _selectFields; }
            set { _selectFields = value; }
        } 
        #endregion



    }
}
