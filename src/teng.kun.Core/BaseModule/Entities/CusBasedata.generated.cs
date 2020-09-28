//------------------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类：可遵守如下规则进行扩展：
//      1.横向扩展：如需添加额外的属性，可新建文件“CusBasedata.cs”的分部类“public partial class CusBasedata”}添加属性
// </auto-generated>
//
//  <copyright file="CusBasedata.generated.cs" company="teng.kun">
//      teng.kun
//  </copyright>
//  <site>http://teng.kun</site>
//  <last-editor>teng.kun</last-editor>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using OSharp.Entity;


namespace teng.kun.BaseModule.Entities
{
    /// <summary>
    /// 实体类：客户基础数据信息
    /// </summary>
    [Description("客户基础数据信息")]
    [TableNamePrefix("BaseModule")]
    public partial class CusBasedata : EntityBase<int>, ICreatedTime
    {
        /// <summary>
        /// 获取或设置 客户编码
        /// </summary>
        [DisplayName("客户编码"), Required]
        public string CusId { get; set; }

        /// <summary>
        /// 获取或设置 名称
        /// </summary>
        [DisplayName("名称"), Required]
        public string CusName { get; set; }

        /// <summary>
        /// 获取或设置 联系方式
        /// </summary>
        [DisplayName("联系方式")]
        public string CusPhone { get; set; }

        /// <summary>
        /// 获取或设置 合作开始时间
        /// </summary>
        [DisplayName("合作开始时间")]
        public DateTime CusComStartTime { get; set; }

        /// <summary>
        /// 获取或设置 合作结束时间
        /// </summary>
        [DisplayName("合作结束时间")]
        public DateTime CusComEndTime { get; set; }

        /// <summary>
        /// 获取或设置 合作状态
        /// </summary>
        [DisplayName("合作状态")]
        public bool CusState { get; set; }

        /// <summary>
        /// 获取或设置 备注
        /// </summary>
        [DisplayName("备注")]
        public string CusRemark { get; set; }

        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreatedTime { get; set; }

    }
}

