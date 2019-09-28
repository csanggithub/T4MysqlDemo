//-----------------------------------------------------------------------
// <copyright file=" MemberGroup.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: MemberGroup.cs
// * history : Created by T4 09/28/2019 16:14:43
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// MemberGroup Entity Model
    /// </summary>
    [Table("member_group")]
    public class MemberGroup
    {
        /// <summary>
        /// 唯一编号 唯一编号
        /// </summary>
        [Key]
        public string Guid { get; set; }

        /// <summary>
        /// 等级 等级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 组名称 组名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 等级图片 等级图片
        /// </summary>
        public string Images { get; set; }

        /// <summary>
        /// 升级积分 升级积分
        /// </summary>
        public int UpPoint { get; set; }

        /// <summary>
        /// 升级金额 升级金额
        /// </summary>
        public decimal UpMoney { get; set; }

        /// <summary>
        /// 购物折扣 购物折扣
        /// </summary>
        public int DisCount { get; set; }

        /// <summary>
        /// 状态 状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDel { get; set; }

    }
}
