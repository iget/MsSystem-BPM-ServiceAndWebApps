﻿using JadeFramework.Core.Domain.Entities;
using MsSystem.OA.Model;
using MsSystem.OA.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MsSystem.OA.IService
{
    public interface IOaMessageService
    {
        Task<Page<OaMessage>> GetPageAsync(int pageIndex, int pageSize);
        Task<MessageShowDTO> GetByIdAsync(long id);
        Task<bool> InsertAsync(MessageShowDTO model);
        Task<bool> UpdateAsync(MessageShowDTO model);
        Task<bool> DeleteAsync(MessageDeleteDTO dto);
        Task<List<OaMessage>> EnableMessageAsync(List<long> ids);
        Task<Page<OaMessageMyList>> MyListAsync(OaMessageMyListSearch search);
        Task<OaMessageMyListDetail> MyListDetailAsync(long id, long userid);
    }
}
