﻿using Generator.Components.Extensions;
using Generator.Components.Interfaces;
using Generator.Shared.Extensions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using MudBlazor;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Generator.Components.Components;

public class GenTextField : MudTextField<object>, IGenTextField
{
    public Type DataType { get; set; }

    public object GetDefaultValue => DataType.GetDefaultValue();

    [CascadingParameter(Name = nameof(ParentComponent))]
    public GenGrid ParentComponent { get; set; }

    [Parameter, EditorBrowsable(EditorBrowsableState.Never)]
    public object Model { get; set; }

    [Parameter]
    [EditorRequired]
    public string BindingField { get; set; }

    [Parameter]
    [Range(1, 12, ErrorMessage = "Column width must be between 1 and 12")]
    public int Width { get; set; }

    [Parameter]
    public int Order { get; set; }

    [Parameter]
    public bool VisibleOnEdit { get; set; } = true;

    [Parameter]
    public bool VisibleOnGrid { get; set; } = true;

    [Parameter]
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

    //Gridin basinda cagirdigimiz icin buraya duser, tabi model null oldugu icin renderlemiyoruz
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        if (Model is not null && ParentComponent is not null)
        {
            base.BuildRenderTree(builder);
        }
    }

    protected override Task OnInitializedAsync()
    {
        if (InputType == InputType.Date)
        {
            Converter = _dateConverter;
            Culture = CultureInfo.GetCultureInfo("en-US");
            Format = "yyyy-MM-dd";
            DataType = typeof(DateTime);
        }
        else
        {
            Converter = _stringConverter;
            DataType = typeof(string);
        }

        ParentComponent?.AddChildComponent(this);

        return Task.CompletedTask;
    }

    private Converter<object> _stringConverter = new()
    {
        SetFunc = value => value?.ToString(),
        GetFunc = text => text?.ToString()
    };

    private Converter<object> _dateConverter = new()
    {
        SetFunc = value => Convert.ToDateTime(value).ToString("yyyy-MM-dd"),
        GetFunc = text =>
        {
            DateTime.TryParse(text, out var dataToReturn);
            return dataToReturn;
        }
    };

    [EditorBrowsable(EditorBrowsableState.Never)]
    public new string Text => Model.GetPropertyValue(BindingField).ToString();

    public void OnValueChanged(object value)
    {
        Model.SetPropertyValue(BindingField, value);
    }

    public RenderFragment RenderAsComponent(object model, bool ignoreLabels = false) => (builder) =>
    {
        Model = model;

        ValueChanged = EventCallback.Factory.Create<object>(this, OnValueChanged);

        var loValue = model.GetPropertyValue(BindingField);

        builder.RenderComponent(new RenderParameters<GenTextField>(this, model, ignoreLabels), (nameof(Value), loValue));
    };

    public RenderFragment RenderAsGridComponent(object model) => (builder) =>
    {
        var data = model.GetPropertyValue(BindingField);

        if (data is DateTime dt)
        {
            data = dt.ToString(Format);
        }

        RenderExtensions.RenderGrid(builder, data);
    };
}






