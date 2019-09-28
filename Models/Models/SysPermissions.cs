//-----------------------------------------------------------------------
// <copyright file=" SysPermissions.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: SysPermissions.cs
// * history : Created by T4 09/28/2019 17:26:54
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    /// <summary>
    /// SysPermissions Entity Model
    /// </summary>
    [Table("sys_permissions")]
    public partial class SysPermissions
    {
        /// <summary>
        /// 角色Guid
        /// </summary>
        public string RoleGuid { get; set; }

        /// <summary>
        /// 管理员ID
        /// </summary>
        public string AdminGuid { get; set; }

        /// <summary>
        /// 菜单Guid
        /// </summary>
        public string MenuGuid { get; set; }

        /// <summary>
        /// 角色-菜单-权限按钮Json
        /// </summary>
        public string BtnFunJson { get; set; }

        /// <summary>
        /// 授权类型1=角色-菜单 2=用户-角色 3=角色-菜单-按钮功能
        /// </summary>
        public int Types { get; set; }

    }
}