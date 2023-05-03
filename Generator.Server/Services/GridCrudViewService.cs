﻿using Generator.Shared.Models.ComponentModels;
using Generator.Shared.Services;

namespace Generator.Server.Services;

public class GridCrudViewService : GenericServiceBase<GeneratorContext, GRID_CRUD_VIEW>, IGRidCrudViewService
{
    public GridCrudViewService(IServiceProvider provider) : base(provider)
    {
    }
}
