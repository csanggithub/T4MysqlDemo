//-----------------------------------------------------------------------
// <copyright file=" CmsMessageServices.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: CmsMessageServices.cs
// * history : Created by T4 09/28/2019 22:25:13
// </copyright>
//-----------------------------------------------------------------------
using IRepository;
using IServices;
using Models.Models;
using Services.Base;

namespace Services
{
    /// <summary>
    /// CmsMessageServices
    /// </summary>
    public partial class CmsMessageServices : BaseServices<CmsMessage>, ICmsMessageServices
    {
        ICmsMessageRepository dal;

        public CmsMessageServices(ICmsMessageRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
    }
}
