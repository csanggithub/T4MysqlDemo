//-----------------------------------------------------------------------
// <copyright file=" SysAdmin.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: SysAdmin.cs
// * history : Created by T4 09/28/2019 16:14:43
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// SysAdmin Entity Model
    /// </summary>
    [Table("sys_admin")]
    public class SysAdmin
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        [Key]
        public string Guid { get; set; }

        /// <summary>
        /// 角色标识
        /// </summary>
        public string RoleGuid { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 部门标识
        /// </summary>
        public string DepartmentGuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DepartmentGuidList { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get; set; }

        /// <summary>
        /// 真是姓名
        /// </summary>
        public string TrueName { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string HeadPic { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate { get; set; }

        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime LoginDate { get; set; }

        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime UpLoginDate { get; set; }

    }
}