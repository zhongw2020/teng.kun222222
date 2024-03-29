// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类：可遵守如下规则进行扩展：
//      1.横向扩展：如需添加额外的属性，可新建文件“MatBasedataInputDto.cs”的分部类“public partial class MatBasedataInputDto”}添加属性
// </auto-generated>
//
//  <copyright file="MatBasedataInputDto.generated.cs" company="teng.kun">
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
using OSharp.Mapping;

using teng.kun.BaseModule.Entities;


namespace teng.kun.BaseModule.Dtos
{
    /// <summary>
    /// 输入DTO：物品基础数据信息
    /// </summary>
    [MapTo(typeof(MatBasedata))]
    [Description("物品基础数据信息")]
    public partial class MatBasedataInputDto : IInputDto<int>
    {
        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [DisplayName("编号")]
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 物品编码
        /// </summary>
        [DisplayName("物品编码"), Required]
        public string MatId { get; set; }

        /// <summary>
        /// 获取或设置 物品名称
        /// </summary>
        [DisplayName("物品名称"), Required]
        public string MatName { get; set; }

        /// <summary>
        /// 获取或设置 物品规格
        /// </summary>
        [DisplayName("物品规格"), Required]
        public string MatParameter { get; set; }

        /// <summary>
        /// 获取或设置 物品单位
        /// </summary>
        [DisplayName("物品单位"), Required]
        public string MatUnit { get; set; }

        /// <summary>
        /// 获取或设置 安全库存
        /// </summary>
        [DisplayName("安全库存")]
        public double SafeStock { get; set; }

        /// <summary>
        /// 获取或设置 当前库存
        /// </summary>
        [DisplayName("当前库存")]
        public double CurrStock { get; set; }

        /// <summary>
        /// 获取或设置 最大库存
        /// </summary>
        [DisplayName("最大库存")]
        public double MaxStock { get; set; }

        /// <summary>
        /// 获取或设置 备注
        /// </summary>
        [DisplayName("备注")]
        public string MatRemark { get; set; }

        /// <summary>
        /// 获取或设置 使用状态
        /// </summary>
        [DisplayName("使用状态")]
        public bool MatState { get; set; }

    }
}
