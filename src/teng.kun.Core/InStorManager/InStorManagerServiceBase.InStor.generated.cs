// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类，可以遵守如下规则进行扩展：
//      1.横向扩展：如需给当前实体 InStor 添加方法，可新建文件“InStorManagerServiceBase.InStor.cs”的分部类“public abstract partial class InStorManagerServiceBase”添加功能
//      2.纵向扩展：如需要重写当前实体 InStor 的业务实现，可新建文件“InStorManagerService.InStor.cs”的分部类“public partial class InStorManagerService”对现有方法进行方法重写实现
// </auto-generated>
//
//  <copyright file="InStorManagerServiceBase.InStor.generated.cs" company="teng.kun">
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
using OSharp.Dependency;
using OSharp.Extensions;
using OSharp.Mapping;

using teng.kun.InStorManager.Dtos;
using teng.kun.InStorManager.Entities;


namespace teng.kun.InStorManager
{
    public abstract partial class InStorManagerServiceBase
    {
        /// <summary>
        /// 获取 入库信息查询数据集
        /// </summary>
        public IQueryable<InStor> InStors
        {
            get { return InStorRepository.QueryAsNoTracking(); }
        }

        /// <summary>
        /// 检查入库信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的入库信息编号</param>
        /// <returns>入库信息是否存在</returns>
        public virtual Task<bool> CheckInStorExists(Expression<Func<InStor, bool>> predicate, int id = default(int))
        {
            return InStorRepository.CheckExistsAsync(predicate, id);
        }
        
        /// <summary>
        /// 添加入库信息
        /// </summary>
        /// <param name="dtos">要添加的入库信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        public virtual Task<OperationResult> CreateInStors(params InStorInputDto[] dtos)
        {
            Check.Validate<InStorInputDto, int>(dtos, nameof(dtos));
            return InStorRepository.InsertAsync(dtos);
        }
        
        /// <summary>
        /// 更新入库信息
        /// </summary>
        /// <param name="dtos">包含更新信息的入库信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        public virtual Task<OperationResult> UpdateInStors(params InStorInputDto[] dtos)
        {
            Check.Validate<InStorInputDto, int>(dtos, nameof(dtos));
            return InStorRepository.UpdateAsync(dtos);
        }
        
        /// <summary>
        /// 删除入库信息
        /// </summary>
        /// <param name="ids">要删除的入库信息编号</param>
        /// <returns>业务操作结果</returns>
        public virtual Task<OperationResult> DeleteInStors(params int[] ids)
        {
            Check.NotNull(ids, nameof(ids));
            return InStorRepository.DeleteAsync(ids);
        }
    }
}
