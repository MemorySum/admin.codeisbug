using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;

namespace CodeIsBug.Admin.Model.Admin
{
    /// <summary>
    /// 角色表
    ///</summary>
    [SugarTable("E_Sys_Role")]
    public class Role
    {
        /// <summary>
        /// 角色名称 
        ///</summary>
        [SugarColumn(ColumnName = "Name")]
        public string Name { get; set; }
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
        /// <summary>
        /// 是否删除 
        ///</summary>
        [SugarColumn(ColumnName = "IsDelete")]
        public bool IsDelete { get; set; }
        /// <summary>
        /// 最后修改人ID 
        ///</summary>
        [SugarColumn(ColumnName = "LastModifyUserId")]
        public Guid? LastModifyUserId { get; set; }
        /// <summary>
        /// 最后修改时间 
        ///</summary>
        [SugarColumn(ColumnName = "LastModifyTime")]
        public DateTime? LastModifyTime { get; set; }
        /// <summary>
        /// 角色代码 
        ///</summary>
        [SugarColumn(ColumnName = "Code")]
        public string Code { get; set; }
        /// <summary>
        /// 角色描述 
        ///</summary>
        [SugarColumn(ColumnName = "Description")]
        public string Description { get; set; }
        /// <summary>
        /// 是否启用 
        ///</summary>
        [SugarColumn(ColumnName = "Enabled")]
        public int? Enabled { get; set; }
        /// <summary>
        /// 排序 
        ///</summary>
        [SugarColumn(ColumnName = "Sort")]
        public int? Sort { get; set; }
    }
}
