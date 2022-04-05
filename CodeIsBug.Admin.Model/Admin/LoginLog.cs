﻿using SqlSugar;

namespace CodeIsBug.Admin.Model.Admin
{
    /// <summary>
    /// 登录日志表
    ///</summary>
    [SugarTable("E_Sys_LoginLog")]
    public class LoginLog
    {
        /// <summary>
        /// 昵称 
        ///</summary>
        [SugarColumn(ColumnName = "NickName")]
        public string NickName { get; set; }
        /// <summary>
        /// IP地址 
        ///</summary>
        [SugarColumn(ColumnName = "IP")]
        public string IP { get; set; }
        /// <summary>
        /// 浏览器 
        ///</summary>
        [SugarColumn(ColumnName = "Browser")]
        public string Browser { get; set; }
        /// <summary>
        /// 系统 
        ///</summary>
        [SugarColumn(ColumnName = "OS")]
        public string OS { get; set; }
        /// <summary>
        /// 设备 
        ///</summary>
        [SugarColumn(ColumnName = "Device")]
        public string Device { get; set; }
        /// <summary>
        /// 浏览器信息 
        ///</summary>
        [SugarColumn(ColumnName = "BrowserInfo")]
        public string BrowserInfo { get; set; }
        /// <summary>
        /// 登录耗时 
        ///</summary>
        [SugarColumn(ColumnName = "ElapsedMilliseconds")]
        public int? ElapsedMilliseconds { get; set; }
        /// <summary>
        /// 登录结果 
        ///</summary>
        [SugarColumn(ColumnName = "Result")]
        public bool? Result { get; set; }
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
