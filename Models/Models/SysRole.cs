//-----------------------------------------------------------------------
// <copyright file=" SysRole.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: SysRole.cs
// * history : Created by T4 09/28/2019 17:26:54
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    /// <summary>
    /// SysRole Entity Model
    /// </summary>
    [Table("sys_role")]
    public partial class SysRole
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public string Guid { get; set; }

        /// <summary>
        /// 部门Guid
        /// </summary>
        public string DepartmentGuid { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 归属于角色组
        /// </summary>
        public string DepartmentGroup { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        public string Codes { get; set; }

        /// <summary>
        /// 是否为超级管理员
        /// </summary>
        public bool IsSystem { get; set; }

        /// <summary>
        /// 部门描述
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime EditTime { get; set; }

    }
}
