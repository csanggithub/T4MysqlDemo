//-----------------------------------------------------------------------
// <copyright file=" CmsAdvlist.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: CmsAdvlist.cs
// * history : Created by T4 09/28/2019 17:26:54
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    /// <summary>
    /// CmsAdvlist Entity Model
    /// </summary>
    [Table("cms_advlist")]
    public partial class CmsAdvlist
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public string Guid { get; set; }

        /// <summary>
        /// 栏目ID
        /// </summary>
        public string ClassGuid { get; set; }

        /// <summary>
        /// 广告位名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 广告位类型
        /// </summary>
        public int Types { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        public string LinkUrl { get; set; }

        /// <summary>
        /// 链接描述
        /// </summary>
        public string LinkSummary { get; set; }

        /// <summary>
        /// 打开窗口类型
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// 广告位说明
        /// </summary>
        public string AdvCode { get; set; }

        /// <summary>
        /// 是否启用时间显示
        /// </summary>
        public bool IsTimeLimit { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 点击量
        /// </summary>
        public int Hits { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// 广告位说明
        /// </summary>
        public string Summary { get; set; }

    }
}
