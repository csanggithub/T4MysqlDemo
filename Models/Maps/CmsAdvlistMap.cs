//-----------------------------------------------------------------------
// <copyright file=" CmsAdvlistMap.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: CmsAdvlistMap.cs
// * history : Created by T4 09/28/2019 17:26:34
// </copyright>
//-----------------------------------------------------------------------
using Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace Models.Maps
{
    /// <summary>
    /// CmsAdvlistMap
    /// </summary>
    public partial class CmsAdvlistMap : EntityTypeConfiguration<CmsAdvlist>
    {
        public CmsAdvlistMap()
        {
            this.HasKey(p => p.Guid);
        }
    }
}
