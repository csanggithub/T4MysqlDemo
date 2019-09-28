//-----------------------------------------------------------------------
// <copyright file=" BbsQuestions.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: BbsQuestions.cs
// * history : Created by T4 09/28/2019 17:26:54
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    /// <summary>
    /// BbsQuestions Entity Model
    /// </summary>
    [Table("bbs_questions")]
    public partial class BbsQuestions
    {
        /// <summary>
        /// 唯一编号 唯一编号
        /// </summary>
        [Key]
        public string Guid { get; set; }

        /// <summary>
        /// 用户编号 用户编号
        /// </summary>
        public string UserGuid { get; set; }

        /// <summary>
        /// 问题标题 问题标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 英文标题，可以作为Url 英文标题，可以作为Url
        /// </summary>
        public string EnTitle { get; set; }

        /// <summary>
        /// 问题类型 问题类型
        /// </summary>
        public string Types { get; set; }

        /// <summary>
        /// 标签 标签
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 消耗积分 消耗积分
        /// </summary>
        public int Point { get; set; }

        /// <summary>
        /// 查看次数 查看次数
        /// </summary>
        public int LookSum { get; set; }

        /// <summary>
        /// 答案次数 答案次数
        /// </summary>
        public int AnswerSum { get; set; }

        /// <summary>
        /// 投票次数=赞 投票次数=赞
        /// </summary>
        public int Support { get; set; }

        /// <summary>
        /// 状态 1=未解决2=未回答3=已解决
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 热门状态 热门状态
        /// </summary>
        public bool IsRed { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public bool Audit { get; set; }

        /// <summary>
        /// 问题内容 问题内容
        /// </summary>
        public string Contents { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 发布时间 发布时间
        /// </summary>
        public DateTime AddTime { get; set; }

    }
}