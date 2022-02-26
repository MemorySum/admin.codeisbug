using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;

namespace CodeIsBug.Admin.Model.Admin
{
    /// <summary>
    /// 用户表
    ///</summary>
    [SugarTable("E_Sys_User")]
    public class User
    {
        /// <summary>
        /// 用户名 
        ///</summary>
        [SugarColumn(ColumnName = "UserName")]
        public string UserName { get; set; }
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
        /// 密码 
        ///</summary>
        [SugarColumn(ColumnName = "Password")]
        public string Password { get; set; }
        /// <summary>
        /// 昵称 
        ///</summary>
        [SugarColumn(ColumnName = "NickName")]
        public string NickName { get; set; }
        /// <summary>
        /// 头像 
        ///</summary>
        [SugarColumn(ColumnName = "Avatar")]
        public string Avatar { get; set; }
        /// <summary>
        /// 状态 
        ///</summary>
        [SugarColumn(ColumnName = "Status")]
        public int Status { get; set; }
        /// <summary>
        /// 备注 
        ///</summary>
        [SugarColumn(ColumnName = "Remark")]
        public string Remark { get; set; }
    }
}
