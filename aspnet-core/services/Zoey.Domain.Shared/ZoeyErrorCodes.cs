﻿namespace Zoey;

public static class ZoeyErrorCodes
{
    //Add your business exception error codes here...
}

public static class IdentityErrorCodes
{
    //Add your business exception error codes here...
    /// <summary>
    /// 无法变更静态声明类型
    /// </summary>
    public const string StaticClaimTypeChange = "Volo.Abp.Identity:020005";
    /// <summary>
    /// 无法删除静态声明类型
    /// </summary>
    public const string StaticClaimTypeDeletion = "Volo.Abp.Identity:020006";
    /// <summary>
    /// 手机号码已被使用
    /// </summary>
    public const string DuplicatePhoneNumber = "Volo.Abp.Identity:020007";
    /// <summary>
    /// 你不能修改你的手机绑定信息
    /// </summary>
    public const string UsersCanNotChangePhoneNumber = "Volo.Abp.Identity:020008";
    /// <summary>
    /// 你不能修改你的邮件绑定信息
    /// </summary>
    public const string UsersCanNotChangeEmailAddress = "Volo.Abp.Identity:020009";
}