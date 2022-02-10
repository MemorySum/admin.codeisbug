namespace CodeIsBug.Admin.Model.Admin
{
    /// <summary>
    /// 用户角色
    /// </summary>
    public class UserRoleEntity
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public long UserId { get; set; }

        public UserEntity User { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        public long RoleId { get; set; }

        public RoleEntity Role { get; set; }
    }
}