//-----------------------------------------------------------------------
// <copyright file=" CmsAdvclass.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: CmsAdvclass.cs
// * history : Created by T4 09/28/2019 16:14:43
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// CmsAdvclass Entity Model
    /// </summary>
    [Table("cms_advclass")]
    public class CmsAdvclass
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public string Guid { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public string ParentGuid { get; set; }

        /// <summary>
        /// 栏位名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 栏位类型
        /// </summary>
        public string Flag { get; set; }

        /// <summary>
        /// 宽度
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// 高度
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// 站点ID
        /// </summary>
        public string SiteGuid { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateDate { get; set; }

    }
}