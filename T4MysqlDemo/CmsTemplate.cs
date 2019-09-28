//-----------------------------------------------------------------------
// <copyright file=" CmsTemplate.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: CmsTemplate.cs
// * history : Created by T4 09/28/2019 16:14:43
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// CmsTemplate Entity Model
    /// </summary>
    [Table("cms_template")]
    public class CmsTemplate
    {
        /// <summary>
        /// 自动增长
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 模板地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate { get; set; }

    }
}
