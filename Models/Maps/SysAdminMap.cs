//-----------------------------------------------------------------------
// <copyright file=" SysAdminMap.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: SysAdminMap.cs
// * history : Created by T4 09/28/2019 17:26:34
// </copyright>
//-----------------------------------------------------------------------
using Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace Models.Maps
{
    /// <summary>
    /// SysAdminMap
    /// </summary>
    public partial class SysAdminMap : EntityTypeConfiguration<SysAdmin>
    {
        public SysAdminMap()
        {
            this.HasKey(p => p.Guid);
        }
    }
}
