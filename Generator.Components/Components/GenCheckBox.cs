﻿using Microsoft.AspNetCore.Components;
using Generator.Components.Enums;
using MudBlazor;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Generator.Components.Interfaces;

namespace Generator.Components.Components;

public class GenCheckBox : MudCheckBox<object>, IGenCheckBox
{
    [Parameter]
    [EditorRequired()]
    public string BindingField { get; set; }


    [Parameter, AllowNull]
    [Range(1, 12, ErrorMessage = "Column width must be between 1 and 12")]
    public int Width { get; set; }

    [Parameter, AllowNull]
    public int Order { get; set; }

    [Parameter, AllowNull]
    public bool VisibleOnEdit { get; set; } = true;

    [Parameter, AllowNull]
    public bool VisibleOnGrid { get; set; } = true;

    [Parameter, AllowNull]
    public bool EnabledOnEdit { get; set; } = true;

    [Parameter]
    public int xs { get; set; }

    [Parameter]
    public int sm { get; set; }

    [Parameter]
    public int md { get; set; }

    [Parameter]
    public int lg { get; set; }

    [Parameter]
    public int xl { get; set; }

    [Parameter]
    public int xxl { get; set; }

    

    public RenderFragment Render(object Model,  ComponentType componentType, params (string key, object value)[] AdditionalParameters)
    {
        throw new NotImplementedException();
    }
}





