namespace CodeIsBug.Admin.Common.Helper
{
    /// <summary>
    ///     统一返回结果
    /// </summary>
    public class Result
    {
        #region 字段定义
        /// <summary>
        ///     状态码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        ///     返回消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     对象
        /// </summary>
        public object Object { get; set; }

        /// <summary>
        ///     扩展对象
        /// </summary>
        public object ExtendObject { get; set; }

        public int Total { get; set; }
        #endregion

        #region 扩展方法封装
        /// <summary>
        ///     自定义成功消息
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static Result Success(string msg)
        {
            return new()
            {
                Code = 1,
                Message = msg
            };
        }

        /// <summary>
        ///     success
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Result Success(dynamic data)
        {
            return new()
            {
                Code = 1,
                Message = "Success",
                Object = data,
                ExtendObject = null,
                Total = 0
            };
        }

        /// <summary>
        ///     自定义消息和data
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Result Success(string msg, dynamic data)
        {
            return new()
            {
                Code = 1,
                Message = msg,
                Object = data,
                Total = 0,
                ExtendObject = null
            };
        }

        /// <summary>
        ///     自定义data或者扩展属性
        /// </summary>
        /// <param name="data"></param>
        /// <param name="extendData"></param>
        /// <returns></returns>
        public static Result Success(dynamic data, dynamic extendData)
        {
            return new()
            {
                Code = 1,
                Message = "Success",
                Object = data,
                ExtendObject = extendData,
                Total = 0
            };
        }

        /// <summary>
        ///     自定义消息、data、扩展属性
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="data"></param>
        /// <param name="extendData"></param>
        /// <returns></returns>
        public static Result Success(string msg, dynamic data, dynamic extendData)
        {
            return new()
            {
                Code = 1,
                Message = msg,
                Object = data,
                ExtendObject = extendData,
                Total = 0
            };
        }

        /// <summary>
        ///     错误消息
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static Result Error(string msg)
        {
            return new()
            {
                Code = 500,
                Message = msg,
                Object = null,
                ExtendObject = null,
                Total = 0
            };
        }

        /// <summary>
        ///     错误消息
        /// </summary>
        /// <param name="code"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static Result Error(int code, string msg)
        {
            return new()
            {
                Code = code,
                Message = msg,
                Object = null,
                ExtendObject = null,
                Total = 0
            };
        }

        /// <summary>
        ///     自定义错误消息
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static Result Failed(string msg)
        {
            return new()
            {
                Code = 0,
                Message = msg,
                Total = 0,
                Object = null,
                ExtendObject = null
            };
        }

        /// <summary>
        ///     自定义错误码和消息
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Result Failed(string msg, int code)
        {
            return new()
            {
                Code = code,
                Message = msg,
                Total = 0,
                Object = null,
                ExtendObject = null
            };
        }
        #endregion
    }
}