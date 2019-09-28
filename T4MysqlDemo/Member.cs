//-----------------------------------------------------------------------
// <copyright file=" Member.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Member.cs
// * history : Created by T4 09/28/2019 16:14:43
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// Member Entity Model
    /// </summary>
    [Table("member")]
    public class Member
    {
        /// <summary>
        /// 唯一编号 唯一编号
        /// </summary>
        [Key]
        public string Guid { get; set; }

        /// <summary>
        /// 等级 等级
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// 登录账号 登录账号
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 登录密码 登录密码
        /// </summary>
        public string LoginPwd { get; set; }

        /// <summary>
        /// 真实姓名 真实姓名
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 手机号码 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 邮箱 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 签名 签名
        /// </summary>
        public string Autograph { get; set; }

        /// <summary>
        /// 头像 头像
        /// </summary>
        public string HeadPic { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// 积分 积分
        /// </summary>
        public int Point { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDel { get; set; }

        /// <summary>
        /// 状态 状态
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// 登录时间 登录时间
        /// </summary>
        public DateTime LoginTime { get; set; }

        /// <summary>
        /// 登录次数 登录次数
        /// </summary>
        public int LoginSum { get; set; }

        /// <summary>
        /// 注册时间 注册时间
        /// </summary>
        public DateTime RegTime { get; set; }

    }
}
