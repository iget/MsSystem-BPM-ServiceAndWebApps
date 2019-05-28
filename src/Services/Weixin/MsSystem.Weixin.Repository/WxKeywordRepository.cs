﻿using JadeFramework.Dapper;
using JadeFramework.Dapper.SqlGenerator;
using MsSystem.Weixin.IRepository;
using MsSystem.Weixin.Model;
using System.Data;

namespace MsSystem.Weixin.Repository
{
    public class WxKeywordRepository : DapperRepository<WxKeyword>, IWxKeywordRepository
    {
        public WxKeywordRepository(IDbConnection connection, SqlGeneratorConfig config) : base(connection, config)
        {
        }
    }
}
