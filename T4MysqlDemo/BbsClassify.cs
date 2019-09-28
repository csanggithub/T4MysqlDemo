//-----------------------------------------------------------------------
// <copyright file=" BbsClassify.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: BbsClassify.cs
// * history : Created by T4 09/28/2019 16:14:43
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// BbsClassify Entity Model
    /// </summary>
    [Table("bbs_classify")]
    public class BbsClassify
    {
        /// <summary>
        /// 唯一编号 唯一编号
        /// </summary>
        [Key]
        public string Guid { get; set; }

        /// <summary>
        /// 分类名称 分类名称
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 英文名称 英文名称
        /// </summary>
        public string EnClassName { get; set; }

        /// <summary>
        /// 首字母
        /// </summary>
        public string FirstLetter { get; set; }

        /// <summary>
        /// 状态 状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 父级 父级
        /// </summary>
        public string ParentGuid { get; set; }

        /// <summary>
        /// 删除状态 删除状态
        /// </summary>
        public int IsDel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Summary { get; set; }

    }
}
