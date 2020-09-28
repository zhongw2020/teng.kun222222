// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类，可以遵守如下规则进行扩展：
//      1. 横向扩展：如需给当前模块添加方法接口，可新建文件“IBaseModuleContract.cs”的分部接口“public partial interface IBaseModuleContract”添加方法，并添加相应新的分部基类 abstract partial class BaseModuleServiceBase 实现新方法
// </auto-generated>
//
//  <copyright file="IBaseModuleContract.generated.cs" company="teng.kun">
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

using teng.kun.BaseModule.Dtos;
using teng.kun.BaseModule.Entities;


namespace teng.kun.BaseModule
{
    /// <summary>
    /// 业务契约接口：模块
    /// </summary>
    public partial interface IBaseModuleContract
    {
        #region 员工基础数据信息业务

        /// <summary>
        /// 获取 员工基础数据信息查询数据集
        /// </summary>
        IQueryable<EmpBasedata> EmpBasedatas { get; }

        /// <summary>
        /// 检查员工基础数据信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的员工基础数据信息编号</param>
        /// <returns>员工基础数据信息是否存在</returns>
        Task<bool> CheckEmpBasedataExists(Expression<Func<EmpBasedata, bool>> predicate, int id = default(int));
        
        /// <summary>
        /// 添加员工基础数据信息信息
        /// </summary>
        /// <param name="dtos">要添加的员工基础数据信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> CreateEmpBasedatas(params EmpBasedataInputDto[] dtos);
            
        /// <summary>
        /// 更新员工基础数据信息信息
        /// </summary>
        /// <param name="dtos">包含更新信息的员工基础数据信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> UpdateEmpBasedatas(params EmpBasedataInputDto[] dtos);
            
        /// <summary>
        /// 删除员工基础数据信息信息
        /// </summary>
        /// <param name="ids">要删除的员工基础数据信息编号</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> DeleteEmpBasedatas(params int[] ids);


        #endregion

        #region 客户基础数据信息业务

        /// <summary>
        /// 获取 客户基础数据信息查询数据集
        /// </summary>
        IQueryable<CusBasedata> CusBasedatas { get; }

        /// <summary>
        /// 检查客户基础数据信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的客户基础数据信息编号</param>
        /// <returns>客户基础数据信息是否存在</returns>
        Task<bool> CheckCusBasedataExists(Expression<Func<CusBasedata, bool>> predicate, int id = default(int));

        /// <summary>
        /// 添加客户基础数据信息信息
        /// </summary>
        /// <param name="dtos">要添加的客户基础数据信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> CreateCusBasedatas(params CusBasedataInputDto[] dtos);

        /// <summary>
        /// 更新客户基础数据信息信息
        /// </summary>
        /// <param name="dtos">包含更新信息的客户基础数据信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> UpdateCusBasedatas(params CusBasedataInputDto[] dtos);

        /// <summary>
        /// 删除客户基础数据信息信息
        /// </summary>
        /// <param name="ids">要删除的客户基础数据信息编号</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> DeleteCusBasedatas(params int[] ids);


        #endregion

        #region 供应商基础数据信息业务

        /// <summary>
        /// 获取 供应商基础数据信息查询数据集
        /// </summary>
        IQueryable<SupBasedata> SupBasedatas { get; }

        /// <summary>
        /// 检查供应商基础数据信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的供应商基础数据信息编号</param>
        /// <returns>供应商基础数据信息是否存在</returns>
        Task<bool> CheckSupBasedataExists(Expression<Func<SupBasedata, bool>> predicate, int id = default(int));

        /// <summary>
        /// 添加供应商基础数据信息信息
        /// </summary>
        /// <param name="dtos">要添加的供应商基础数据信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> CreateSupBasedatas(params SupBasedataInputDto[] dtos);

        /// <summary>
        /// 更新供应商基础数据信息信息
        /// </summary>
        /// <param name="dtos">包含更新信息的供应商基础数据信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> UpdateSupBasedatas(params SupBasedataInputDto[] dtos);

        /// <summary>
        /// 删除供应商基础数据信息信息
        /// </summary>
        /// <param name="ids">要删除的供应商基础数据信息编号</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> DeleteSupBasedatas(params int[] ids);


        #endregion

        #region 物品基础数据信息业务

        /// <summary>
        /// 获取 物品基础数据信息查询数据集
        /// </summary>
        IQueryable<MatBasedata> MatBasedatas { get; }

        /// <summary>
        /// 检查物品基础数据信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的物品基础数据信息编号</param>
        /// <returns>物品基础数据信息是否存在</returns>
        Task<bool> CheckMatBasedataExists(Expression<Func<MatBasedata, bool>> predicate, int id = default(int));

        /// <summary>
        /// 添加物品基础数据信息信息
        /// </summary>
        /// <param name="dtos">要添加的物品基础数据信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> CreateMatBasedatas(params MatBasedataInputDto[] dtos);

        /// <summary>
        /// 更新物品基础数据信息信息
        /// </summary>
        /// <param name="dtos">包含更新信息的物品基础数据信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> UpdateMatBasedatas(params MatBasedataInputDto[] dtos);

        /// <summary>
        /// 删除物品基础数据信息信息
        /// </summary>
        /// <param name="ids">要删除的物品基础数据信息编号</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> DeleteMatBasedatas(params int[] ids);


        #endregion

    }
}