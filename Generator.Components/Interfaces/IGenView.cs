﻿using Generator.Components.Args;
using Generator.Components.Enums;
using Microsoft.AspNetCore.Components;

namespace Generator.Components.Interfaces;

public interface IGenView<TModel> : IGenCompRenderer where TModel:new()
{
    public string Title { get; set; }

    public ViewState ViewState { get; set; }

    public EditMode EditMode { get; set; }

    public TModel OriginalEditItem { get; set; }

    public TModel SelectedItem { get; internal set; }

   

    public EventCallback<IGenView<TModel>> Load { get; set; }

    public List<IGenComponent> Components { get; set; }

    public TComponent GetComponent<TComponent>(string bindingField) where TComponent : IGenComponent;
}