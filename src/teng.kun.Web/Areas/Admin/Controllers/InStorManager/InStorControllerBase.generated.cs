// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类，可以遵守如下规则进行扩展：
//      1.横向扩展：如需给当前控制器添加API，请在控制器类型 InStorController.cs 进行添加
//      2.纵向扩展：如需要重写当前控制器的API实现，请在控制器类型 InStorController.cs 进行继承重写
// </auto-generated>
//
//  <copyright file="InStorBase.generated.cs" company="teng.kun">
//      teng.kun
//  </copyright>
//  <site>http://teng.kun</site>
//  <last-editor>teng.kun</last-editor>
// -----------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using OSharp.AspNetCore.Mvc;
using OSharp.AspNetCore.Mvc.Filters;
using OSharp.AspNetCore.UI;
using OSharp.Caching;
using OSharp.Authorization.Functions;
using OSharp.Authorization.Modules;
using OSharp.Data;
using OSharp.Entity;
using OSharp.Filter;
using OSharp.Security;

using teng.kun.InStorManager;
using teng.kun.InStorManager.Dtos;
using teng.kun.InStorManager.Entities;


namespace teng.kun.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// 管理控制器基类: 入库信息
    /// </summary>
    [ModuleInfo(Position = "InStorManager", PositionName = "入库管理模块")]
    [Description("管理-入库信息")]
    public abstract class InStorControllerBase : AdminApiController
    {
        /// <summary>
        /// 初始化一个<see cref="InStorController"/>类型的新实例
        /// </summary>
        protected InStorControllerBase(IInStorManagerContract inStorManagerContract,
            IFilterService filterService)
        {
            InStorManagerContract = inStorManagerContract;
            FilterService = filterService;
        }

        /// <summary>
        /// 获取或设置 数据过滤服务对象
        /// </summary>
        protected IFilterService FilterService { get; }

        /// <summary>
        /// 获取或设置 入库管理模块业务契约对象
        /// </summary>
        protected IInStorManagerContract InStorManagerContract { get; }
        
        /// <summary>
        /// 读取入库列表信息
        /// </summary>
        /// <param name="request">页请求信息</param>
        /// <returns>入库列表分页信息</returns>
        [HttpPost]
        [ModuleInfo]
        [Description("读取")]
        public virtual PageData<InStorOutputDto> Read(PageRequest request)
        {
            Check.NotNull(request, nameof(request));

            Expression<Func<InStor, bool>> predicate = FilterService.GetExpression<InStor>(request.FilterGroup);
            var page = InStorManagerContract.InStors.ToPage<InStor, InStorOutputDto>(predicate, request.PageCondition);

            return page.ToPageData();
        }
        
        /// <summary>
        /// 新增入库信息
        /// </summary>
        /// <param name="dtos">入库信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [DependOnFunction("Read")]
        [ServiceFilter(typeof(UnitOfWorkAttribute))]
        [Description("新增")]
        public virtual async Task<AjaxResult> Create(InStorInputDto[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await InStorManagerContract.CreateInStors(dtos);
            return result.ToAjaxResult();
        }
        
        /// <summary>
        /// 更新入库信息
        /// </summary>
        /// <param name="dtos">入库信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [DependOnFunction("Read")]
        [ServiceFilter(typeof(UnitOfWorkAttribute))]
        [Description("更新")]
        public virtual async Task<AjaxResult> Update(InStorInputDto[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await InStorManagerContract.UpdateInStors(dtos);
            return result.ToAjaxResult();
        }

        /// <summary>
        /// 更新入库信息
        /// </summary>
        /// <param name="dtos">入库信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [DependOnFunction("Read")]
        [ServiceFilter(typeof(UnitOfWorkAttribute))]
        [Description("入库作废")]
        public virtual async Task<AjaxResult> UpdateAbolish(InStorInputDto[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await InStorManagerContract.UpdateInStors(dtos);
            return result.ToAjaxResult();
        }
        /// <summary>
        /// 更新入库信息
        /// </summary>Recoil
        /// <param name="dtos">入库信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [DependOnFunction("Read")]
        [ServiceFilter(typeof(UnitOfWorkAttribute))]
        [Description("入库结算")]
        public virtual async Task<AjaxResult> UpdateClose(InStorInputDto[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await InStorManagerContract.UpdateInStors(dtos);
            return result.ToAjaxResult();
        }
        /// <summary>
        /// 更新入库信息
        /// </summary>
        /// <param name="dtos">入库信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [DependOnFunction("Read")]
        [ServiceFilter(typeof(UnitOfWorkAttribute))]
        [Description("入库反冲")]
        public virtual async Task<AjaxResult> UpdateRecoil(InStorInputDto[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await InStorManagerContract.UpdateInStors(dtos);
            return result.ToAjaxResult();
        }
        /// <summary>
        /// 更新入库信息
        /// </summary>
        /// <param name="dtos">入库信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [DependOnFunction("Read")]
        [ServiceFilter(typeof(UnitOfWorkAttribute))]
        [Description("入库审核")]
        public virtual async Task<AjaxResult> UpdateVerify(InStorInputDto[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await InStorManagerContract.UpdateInStors(dtos);
            return result.ToAjaxResult();
        }
        /// <summary>
        /// 删除入库信息
        /// </summary>
        /// <param name="ids">入库信息编号</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [DependOnFunction("Read")]
        [ServiceFilter(typeof(UnitOfWorkAttribute))]
        [Description("删除")]
        public virtual async Task<AjaxResult> Delete(int[] ids)
        {
            Check.NotNull(ids, nameof(ids));
            OperationResult result = await InStorManagerContract.DeleteInStors(ids);
            return result.ToAjaxResult();
        }
    }
}
