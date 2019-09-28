//-----------------------------------------------------------------------
// <copyright file=" CmsImgtype.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: CmsImgtype.cs
// * history : Created by T4 09/28/2019 16:14:43
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// CmsImgtype Entity Model
    /// </summary>
    [Table("cms_imgtype")]
    public class CmsImgtype
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public string Guid { get; set; }

        /// <summary>
        /// 一级菜单
        /// </summary>
        public string ParentGuid { get; set; }

        /// <summary>
        /// 图片类型分类 0=本地 1=云端
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AddDate { get; set; }

    }
}
