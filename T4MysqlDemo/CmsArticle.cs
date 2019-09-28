//-----------------------------------------------------------------------
// <copyright file=" CmsArticle.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: CmsArticle.cs
// * history : Created by T4 09/28/2019 16:14:43
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// CmsArticle Entity Model
    /// </summary>
    [Table("cms_article")]
    public class CmsArticle
    {
        /// <summary>
        /// 自动增长
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 栏目ID
        /// </summary>
        public int ColumnId { get; set; }

        /// <summary>
        /// 0=新闻1=多图片
        /// </summary>
        public int Types { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 文章标题颜色
        /// </summary>
        public string TitleColor { get; set; }

        /// <summary>
        /// 文章副标题
        /// </summary>
        public string SubTitle { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 是否外链
        /// </summary>
        public bool IsLink { get; set; }

        /// <summary>
        /// 外部链接地址
        /// </summary>
        public string LinkUrl { get; set; }

        /// <summary>
        /// 文章标签
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 文章宣传图
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 文章缩略图
        /// </summary>
        public string ThumImg { get; set; }

        /// <summary>
        /// 视频链接地址
        /// </summary>
        public string VideoUrl { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsTop { get; set; }

        /// <summary>
        /// 是否热点
        /// </summary>
        public bool IsHot { get; set; }

        /// <summary>
        /// 是否滚动
        /// </summary>
        public bool IsScroll { get; set; }

        /// <summary>
        /// 是否幻灯
        /// </summary>
        public bool IsSlide { get; set; }

        /// <summary>
        /// 是否允许评论
        /// </summary>
        public bool IsComment { get; set; }

        /// <summary>
        /// 是否手机站显示
        /// </summary>
        public bool IsWap { get; set; }

        /// <summary>
        /// 是否在回收站
        /// </summary>
        public bool IsRecyc { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public bool Audit { get; set; }

        /// <summary>
        /// Seo关键字
        /// </summary>
        public string KeyWord { get; set; }

        /// <summary>
        /// 文章摘要
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 文章内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 点击量
        /// </summary>
        public int Hits { get; set; }

        /// <summary>
        /// 当日点击量
        /// </summary>
        public int DayHits { get; set; }

        /// <summary>
        /// 星期点击量
        /// </summary>
        public int WeedHits { get; set; }

        /// <summary>
        /// 月点击量
        /// </summary>
        public int MonthHits { get; set; }

        /// <summary>
        /// 最后点击时间
        /// </summary>
        public DateTime LastHitDate { get; set; }

        /// <summary>
        /// 编辑时间
        /// </summary>
        public DateTime EditDate { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate { get; set; }

        /// <summary>
        /// 删除到回收站时间
        /// </summary>
        public DateTime DelDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SiteGuid { get; set; }

    }
}
