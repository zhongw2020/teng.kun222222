// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类，可以遵守如下规则进行扩展：
//      1.横向扩展：如需给当前控制器添加API，请在控制器类型 Test09Controller.cs 进行添加
//      2.纵向扩展：如需要重写当前控制器的API实现，请在控制器类型 Test09Controller.cs 进行继承重写
// </auto-generated>
//
//  <copyright file="Test09Base.generated.cs" company="teng.kun">
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

using teng.kun.OutStorManager;
using teng.kun.OutStorManager.Dtos;
using teng.kun.OutStorManager.Entities;


namespace teng.kun.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// 管理控制器基类: test09信息
    /// </summary>
    [ModuleInfo(Position = "OutStorManager", PositionName = "出库管理模块")]
    [Description("管理-test09信息")]
    public abstract class Test09ControllerBase : AdminApiController
    {
        /// <summary>
        /// 初始化一个<see cref="Test09Controller"/>类型的新实例
        /// </summary>
        protected Test09ControllerBase(IOutStorManagerContract outStorManagerContract,
            IFilterService filterService)
        {
            OutStorManagerContract = outStorManagerContract;
            FilterService = filterService;
        }

        /// <summary>
        /// 获取或设置 数据过滤服务对象
        /// </summary>
        protected IFilterService FilterService { get; }

        /// <summary>
        /// 获取或设置 出库管理模块业务契约对象
        /// </summary>
        protected IOutStorManagerContract OutStorManagerContract { get; }
        
        /// <summary>
        /// 读取test09列表信息
        /// </summary>
        /// <param name="request">页请求信息</param>
        /// <returns>test09列表分页信息</returns>
        [HttpPost]
        [ModuleInfo]
        [Description("读取")]
        public virtual PageData<Test09OutputDto> Read(PageRequest request)
        {
            Check.NotNull(request, nameof(request));

            Expression<Func<Test09, bool>> predicate = FilterService.GetExpression<Test09>(request.FilterGroup);
            var page = OutStorManagerContract.Test09s.ToPage<Test09, Test09OutputDto>(predicate, request.PageCondition);

            return page.ToPageData();
        }
        
        /// <summary>
        /// 新增test09信息
        /// </summary>
        /// <param name="dtos">test09信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [DependOnFunction("Read")]
        [ServiceFilter(typeof(UnitOfWorkAttribute))]
        [Description("新增")]
        public virtual async Task<AjaxResult> Create(Test09InputDto[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await OutStorManagerContract.CreateTest09s(dtos);
            return result.ToAjaxResult();
        }
        
        /// <summary>
        /// 更新test09信息
        /// </summary>
        /// <param name="dtos">test09信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [DependOnFunction("Read")]
        [ServiceFilter(typeof(UnitOfWorkAttribute))]
        [Description("更新")]
        public virtual async Task<AjaxResult> Update(Test09InputDto[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await OutStorManagerContract.UpdateTest09s(dtos);
            return result.ToAjaxResult();
        }
        
        /// <summary>
        /// 删除test09信息
        /// </summary>
        /// <param name="ids">test09信息编号</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [DependOnFunction("Read")]
        [ServiceFilter(typeof(UnitOfWorkAttribute))]
        [Description("删除")]
        public virtual async Task<AjaxResult> Delete(int[] ids)
        {
            Check.NotNull(ids, nameof(ids));
            OperationResult result = await OutStorManagerContract.DeleteTest09s(ids);
            return result.ToAjaxResult();
        }
    }
}
