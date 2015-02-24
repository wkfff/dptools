//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2015-02-09 23:15:26 
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using DP.Data.OracleClient.Mapping;
using DP.Data.SqlClient.Mapping;
namespace VoiceMail.Entity
{
	
	/// <summary>
	/// 用户组表
	/// </summary>	
	[Serializable]
	[OracleTable(TableName = "UserGroup" , TableOrView = DP.Data.Common.TableType.Table, ConnectionStringKey = "SQLConnString_VoiceMail")]
    [SqlTable(TableName = "UserGroup" , TableOrView = DP.Data.Common.TableType.Table, ConnectionStringKey = "SQLConnString_VoiceMail")]
	public class UserGroupEntity 
	{
				/// <summary>
		/// 组编号
		/// </summary>		
				[OracleColumn(IsDbGenerated = true , IsPrimaryKey = true, ColumnDescription = "组编号", ColumnName = "GroupId")]
        [SqlColumn(IsDbGenerated = true , IsPrimaryKey = true, ColumnDescription = "组编号", ColumnName = "GroupId")]
				public long GroupId { get; set; }

				/// <summary>
		/// 组名称
		/// </summary>		
				[OracleColumn(ColumnDescription = "组名称", ColumnName = "GroupName")]
        [SqlColumn(ColumnDescription = "组名称", ColumnName = "GroupName")]		 
				public string GroupName { get; set; }

				/// <summary>
		/// 状态
		/// </summary>		
				[OracleColumn(ColumnDescription = "状态", ColumnName = "Status")]
        [SqlColumn(ColumnDescription = "状态", ColumnName = "Status")]		 
				public int Status { get; set; }

				/// <summary>
		/// 备注
		/// </summary>		
				[OracleColumn(ColumnDescription = "备注", ColumnName = "Remark")]
        [SqlColumn(ColumnDescription = "备注", ColumnName = "Remark")]		 
				public string Remark { get; set; }

				/// <summary>
		/// 最后更新时间
		/// </summary>		
				[OracleColumn(ColumnDescription = "最后更新时间", ColumnName = "LastUpdateTime")]
        [SqlColumn(ColumnDescription = "最后更新时间", ColumnName = "LastUpdateTime")]		 
				public DateTime? LastUpdateTime { get; set; }

				/// <summary>
		/// 最后更新人
		/// </summary>		
				[OracleColumn(ColumnDescription = "最后更新人", ColumnName = "LastUpdateUser")]
        [SqlColumn(ColumnDescription = "最后更新人", ColumnName = "LastUpdateUser")]		 
				public string LastUpdateUser { get; set; }

		 

	}
}
