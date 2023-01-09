﻿using System;
using Generator.Examples.Shared;
using Microsoft.EntityFrameworkCore;
using ProtoBuf.Grpc;

namespace Generator.Services.Services
{
	public class UserService:IUserService
	{
        public TestContext Db { get; set; }

        public UserService(IServiceProvider provider)
		{
            Db = provider.GetService<TestContext>();
        }

        public async ValueTask<USER> CreateAsync(RESPONSE_REQUEST<USER> request, CallContext context = default)
        {
            Db.USER.Add(request.Data);

            await Db.SaveChangesAsync();

            return request.Data;
        }

        public async ValueTask<List<USER>> ReadAsync(CallContext context = default)
        {
            return await Db.USER.AsNoTracking().ToListAsync();
        }

        public async ValueTask<USER> UpdateAsync(RESPONSE_REQUEST<USER> request, CallContext context = default)
        {
            Db.USER.Update(request.Data);

            await Db.SaveChangesAsync();

            return request.Data;
        }

        public async ValueTask<USER> DeleteAsync(RESPONSE_REQUEST<USER> request, CallContext context = default)
        {
            Db.USER.Remove(request.Data);

            await Db.SaveChangesAsync();

            return request.Data;
        }
    }
}

