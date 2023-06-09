﻿using Generator.Shared.Models.ComponentModels;
using Generator.Shared.Services;

namespace Generator.Server.Services;

public class GridsMService : GenericServiceBase<GeneratorContext, GRIDS_M>, IGridsMService
{
    public GridsMService(IServiceProvider provider) : base(provider)
    {
    }
}
