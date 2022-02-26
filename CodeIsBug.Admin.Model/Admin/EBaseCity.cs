using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;

namespace CodeIsBug.Admin.Model.Admin
{
    /// <summary>
    /// 省市信息表
    ///</summary>
    [SugarTable("E_Base_City")]
    public class EBaseCity
    {
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "ID", IsPrimaryKey = true)]
        public Guid ID { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "PID")]
        public Guid? PID { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Level")]
        public int? Level { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Name")]
        public string Name { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Pinyin_Prefix")]
        public string PinyinPrefix { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Pinyin")]
        public string Pinyin { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "FullId")]
        public Guid? FullId { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "FullName")]
        public string FullName { get; set; }
    }
}
