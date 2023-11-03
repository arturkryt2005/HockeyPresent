﻿using AntDesign;
using Bakasov.Client.Services;
using Bakasov.Core.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bakasov.Client.Pages;

/// <summary>
/// Class FetchData.
/// Implements the <see cref="Component
/// " />
/// </summary>
/// <seealso cref="ComponentBase" />
public partial class FetchData
{
    /// <summary>
    /// Gets or sets the product service.
    /// </summary>
    /// <value>The product service.</value>
    [Inject]
    private IProductService ProductService { get; set; } = null!;

    /// <summary>
    /// The table
    /// </summary>
    private ITable _table;

    /// <summary>
    /// Gets or sets the products.
    /// </summary>
    /// <value>The products.</value>
    private List<Product> Products { get; set; }

    /// <summary>
    /// The page index
    /// </summary>
    private int _pageIndex = 1;

    /// <summary>
    /// The page size
    /// </summary>
    private int _pageSize = 10;

    /// <summary>
    /// The total
    /// </summary>
    private const int _total = 0;

    /// <summary>
    /// The selected rows
    /// </summary>
    private IEnumerable<Product> _selectedRows;

    /// <summary>
    /// On initialized as an asynchronous operation.
    /// </summary>
    /// <returns>A Task representing the asynchronous operation.</returns>
    protected async Task OnInitializedAsync()
    {
        Products = await ProductService.GetProductsAsync();
    }

    /// <summary>
    /// Called when [change].
    /// </summary>
    private void OnChange()
    {

    }

    public partial class Insert
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

    }

    private Insert insert = new Insert();

    private void OnFinish(EditContext editContext)
    {
        Console.WriteLine("Success");
    }

    private void OnFinishFailed(EditContext editContext)
    {
        Console.WriteLine("Failed");
    }

}
