﻿using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace Generator.Examples.Shared;

[Service]
public interface IOrdersMService
{
    public ValueTask<ORDERS_M> CreateAsync(RESPONSE_REQUEST<ORDERS_M> request,CallContext context = default);

    public ValueTask<List<ORDERS_M>> ReadAsync(RESPONSE_REQUEST<int> request ,CallContext context = default);

    public ValueTask<ORDERS_M> UpdateAsync(RESPONSE_REQUEST<ORDERS_M> request,CallContext context = default);

    public ValueTask<ORDERS_M> DeleteAsync(RESPONSE_REQUEST<ORDERS_M> request,CallContext context = default);

}
