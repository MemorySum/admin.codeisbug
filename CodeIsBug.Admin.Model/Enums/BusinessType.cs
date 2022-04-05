﻿namespace CodeIsBug.Admin.Model.Enums
{
    /**
     * 业务操作类型
     * 0=其它,1=新增,2=修改,3=删除,4=授权,5=导出,6=导入
     * @author zrry
     */
    public enum BusinessType
    {
        /**
     * 其它
     */
        OTHER = 0,

        /**
         * 新增
         */
        INSERT = 1,

        /**
         * 修改
         */
        UPDATE = 2,

        /**
         * 删除
         */
        DELETE = 3,

        /**
         * 授权
         */
        GRANT = 4,

        /**
         * 导出
         */
        EXPORT = 5,

        /**
         * 导入
         */
        IMPORT = 6
    }
}
