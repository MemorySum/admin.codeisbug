using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;

namespace CodeIsBug.Admin.Model.Admin
{
    /// <summary>
    /// 用户角色对照表
    ///</summary>
    [SugarTable("E_Sys_UserRoleMap")]
    public class UserRoleMap
    {
        /// <summary>
        /// 1 
        ///</summary>
        [SugarColumn(ColumnName = "UserId")]
        public Guid UserId { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "RoleId")]
        public Guid RoleId { get; set; }
        /// <summary>
        /// 主键 
        ///</summary>
        [SugarColumn(ColumnName = "Id", IsPrimaryKey = true)]
        public Guid Id { get; set; }
        /// <summary>
        /// 创建人guid 
        ///</summary>
        [SugarColumn(ColumnName = "CreateUserId")]
        public Guid CreateUserId { get; set; }
        /// <summary>
        /// 创建时间 
        ///</summary>
        [SugarColumn(ColumnName = "CreateTime")]
        public DateTime CreateTime { get; set; }
    }
}
