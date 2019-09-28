//-----------------------------------------------------------------------
// <copyright file=" SysCodetype.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: SysCodetype.cs
// * history : Created by T4 09/28/2019 17:26:54
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    /// <summary>
    /// SysCodetype Entity Model
    /// </summary>
    [Table("sys_codetype")]
    public partial class SysCodetype
    {
        /// <summary>
        /// 唯一标号Guid
        /// </summary>
        [Key]
        public string Guid { get; set; }

        /// <summary>
        /// 字典类型父级
        /// </summary>
        public string ParentGuid { get; set; }

        /// <summary>
        /// 深度
        /// </summary>
        public int Layer { get; set; }

        /// <summary>
        /// 字典类型名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 字典类型排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AddTime { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime EditTime { get; set; }

        /// <summary>
        /// 归属公司或站点
        /// </summary>
        public string SiteGuid { get; set; }

    }
}