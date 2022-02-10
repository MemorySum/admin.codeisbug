namespace CodeIsBug.Admin.Model.Admin
{
    /// <summary>
    /// 操作日志
    /// </summary>
    public class OprationLogEntity
    {
        /// <summary>
        /// 接口名称
        /// </summary>
        public string ApiLabel { get; set; }

        /// <summary>
        /// 接口地址
        /// </summary>
        public string ApiPath { get; set; }

        /// <summary>
        /// 接口提交方法
        /// </summary>
        public string ApiMethod { get; set; }

        /// <summary>
        /// 操作参数
        /// </summary>
        public string Params { get; set; }
    }
}