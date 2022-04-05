using CodeIsBug.Admin.Model.Enums;
using SqlSugar;

namespace CodeIsBug.Admin.Model.Admin
{
    /// <summary>
    /// 权限表
    ///</summary>
    [SugarTable("E_Sys_Permission")]
    public class Permission
    {
        /// <summary>
        /// ParentId 
        ///</summary>
        [SugarColumn(ColumnName = "ParentId")]
        public Guid ParentId { get; set; }
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
        /// 权限名称 
        ///</summary>
        [SugarColumn(ColumnName = "Label")]
        public string Label { get; set; }
        /// <summary>
        /// 权限编码 
        ///</summary>
        [SugarColumn(ColumnName = "Code")]
        public string Code { get; set; }
        /// <summary>
        /// 权限类型 
        ///</summary>
        [SugarColumn(ColumnName = "Type")]
        public PermissionType? Type { get; set; }
        /// <summary>
        /// 菜单访问地址 
        ///</summary>
        [SugarColumn(ColumnName = "Path")]
        public string Path { get; set; }
        /// <summary>
        /// 图标 
        ///</summary>
        [SugarColumn(ColumnName = "Icon")]
        public string Icon { get; set; }
        /// <summary>
        /// 是否隐藏 
        ///</summary>
        [SugarColumn(ColumnName = "Hidden")]
        public bool Hidden { get; set; }
        /// <summary>
        /// 是否启用 
        ///</summary>
        [SugarColumn(ColumnName = "Enabled")]
        public bool Enabled { get; set; }
        /// <summary>
        /// 排序 
        ///</summary>
        [SugarColumn(ColumnName = "Sort")]
        public int? Sort { get; set; }
    }
}
