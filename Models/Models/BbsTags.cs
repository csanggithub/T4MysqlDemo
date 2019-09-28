//-----------------------------------------------------------------------
// <copyright file=" BbsTags.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: BbsTags.cs
// * history : Created by T4 09/28/2019 17:26:54
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    /// <summary>
    /// BbsTags Entity Model
    /// </summary>
    [Table("bbs_tags")]
    public partial class BbsTags
    {
        /// <summary>
        /// 唯一编号 唯一编号
        /// </summary>
        [Key]
        public string Guid { get; set; }

        /// <summary>
        /// 标签名称 标签名称
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// 英文名称 英文名称
        /// </summary>
        public string EnTagName { get; set; }

        /// <summary>
        /// 首字母
        /// </summary>
        public string FirstLetter { get; set; }

        /// <summary>
        /// 状态 状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 删除状态 删除状态
        /// </summary>
        public int IsDel { get; set; }

        /// <summary>
        /// 描述 描述
        /// </summary>
        public string Summary { get; set; }

    }
}