//-----------------------------------------------------------------------
// <copyright file=" WxMaterial.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: WxMaterial.cs
// * history : Created by T4 09/28/2019 16:14:43
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// WxMaterial Entity Model
    /// </summary>
    [Table("wx_material")]
    public class WxMaterial
    {
        /// <summary>
        /// 自动增长
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 所属公众号ID
        /// </summary>
        public int WxId { get; set; }

        /// <summary>
        /// 类型，1=图文  2=连接
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 保存位置  1=本地 2=服务器
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string Img { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 连接
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 内容Json
        /// </summary>
        public string TestJson { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate { get; set; }

    }
}
