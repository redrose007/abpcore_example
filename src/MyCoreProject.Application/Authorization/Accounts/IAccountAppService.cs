﻿using System.Threading.Tasks;
using Abp.Application.Services;
using MyCoreProject.Authorization.Accounts.Dto;

namespace MyCoreProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
