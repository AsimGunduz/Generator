﻿using Generator.Shared.Models.ComponentModels;
using ProtoBuf.Grpc.Configuration;

namespace Generator.Shared.Services;

[Service]
public interface IGridsMService : IGenericServiceBase<GRIDS_M> { }
