// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类，可以遵守如下规则进行扩展：
//      1. 横向扩展：如需给当前模块添加方法接口，可新建文件“IOutStorManagerContract.cs”的分部接口“public partial interface IOutStorManagerContract”添加方法，并添加相应新的分部基类 abstract partial class OutStorManagerServiceBase 实现新方法
// </auto-generated>
//
//  <copyright file="IOutStorManagerContract.generated.cs" company="teng.kun">
//      teng.kun
//  </copyright>
//  <site>http://teng.kun</site>
//  <last-editor>teng.kun</last-editor>
// -----------------------------------------------------------------------

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using OSharp.Data;
using OSharp.Extensions;

using teng.kun.OutStorManager.Dtos;
using teng.kun.OutStorManager.Entities;


namespace teng.kun.OutStorManager
{
    /// <summary>
    /// 业务契约接口：出库管理模块
    /// </summary>
    public partial interface IOutStorManagerContract
    {
        #region 出库信息业务

        /// <summary>
        /// 获取 出库信息查询数据集
        /// </summary>
        IQueryable<OutStor> OutStors { get; }

        /// <summary>
        /// 检查出库信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的出库信息编号</param>
        /// <returns>出库信息是否存在</returns>
        Task<bool> CheckOutStorExists(Expression<Func<OutStor, bool>> predicate, int id = default(int));
        
        /// <summary>
        /// 添加出库信息信息
        /// </summary>
        /// <param name="dtos">要添加的出库信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> CreateOutStors(params OutStorInputDto[] dtos);
            
        /// <summary>
        /// 更新出库信息信息
        /// </summary>
        /// <param name="dtos">包含更新信息的出库信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> UpdateOutStors(params OutStorInputDto[] dtos);
            
        /// <summary>
        /// 删除出库信息信息
        /// </summary>
        /// <param name="ids">要删除的出库信息编号</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> DeleteOutStors(params int[] ids);
        

        #endregion
        
        #region test09信息业务

        /// <summary>
        /// 获取 test09信息查询数据集
        /// </summary>
        IQueryable<Test09> Test09s { get; }

        /// <summary>
        /// 检查test09信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的test09信息编号</param>
        /// <returns>test09信息是否存在</returns>
        Task<bool> CheckTest09Exists(Expression<Func<Test09, bool>> predicate, int id = default(int));
        
        /// <summary>
        /// 添加test09信息信息
        /// </summary>
        /// <param name="dtos">要添加的test09信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> CreateTest09s(params Test09InputDto[] dtos);
            
        /// <summary>
        /// 更新test09信息信息
        /// </summary>
        /// <param name="dtos">包含更新信息的test09信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> UpdateTest09s(params Test09InputDto[] dtos);
            
        /// <summary>
        /// 删除test09信息信息
        /// </summary>
        /// <param name="ids">要删除的test09信息编号</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> DeleteTest09s(params int[] ids);
        

        #endregion
        
    }
}