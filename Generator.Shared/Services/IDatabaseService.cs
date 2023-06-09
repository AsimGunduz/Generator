﻿using Generator.Shared.Models.ComponentModels;
using ProtoBuf.Grpc.Configuration;

namespace Generator.Shared.Services;

[Service]
public interface IDatabaseService : IGenericServiceBase<DATABASES>{}
