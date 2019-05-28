﻿using JadeFramework.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MsSystem.WF.IService
{
    /// <summary>
    /// TODO 服务之间调用待优化
    /// </summary>
    public interface IConfigService
    {
        Task<List<ZTree>> GetRoleTreesAsync(List<long> ids);
        Task<List<ZTree>> GetUserTreeAsync(List<long> ids);

        /// <summary>
        /// 根据角色ID获取用户ID
        /// </summary>
        /// <param name="roleids"></param>
        /// <returns></returns>
        Task<List<long>> GetUserIdsByRoleIdsAsync(List<long> roleids);
    }
}
