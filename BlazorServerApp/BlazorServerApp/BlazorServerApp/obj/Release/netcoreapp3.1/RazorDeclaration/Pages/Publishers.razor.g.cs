#pragma checksum "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\Publishers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbb5218004d894448d4281ca19b4a7ab0a47425c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\Publishers.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\Publishers.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\Publishers.razor"
using BlazorServerApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\Publishers.razor"
           [Authorize( Roles = "Publisher", Policy="SeniorEmployee")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/publishers")]
    public partial class Publishers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\Publishers.razor"
       

    public Publisher publisher { get; set; }
    public List<Publisher> publisherList { get; set; }
    public string[] Cities { get; set; }
    ElementReference publisherNameTextBox;

    public bool IsVisible { get; set; }
    public bool Result { get; set; }
    public string RecordName { get; set; }

    protected override void OnInitialized()
    {
        publisher = new Publisher();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
            await LoadPublishers();

        await base.OnAfterRenderAsync(firstRender);
    }

    private async Task LoadPublishers()
    {
        publisherList = await bookStoresService.GetAllAsync("publishers/");

        StateHasChanged();
    }

    private async Task SavePublisher()
    {
        if (publisher.PubId == 0)
            await bookStoresService.SaveAsync("publishers/", publisher);
        else
            await bookStoresService.UpdateAsync("publishers/", publisher.PubId, publisher);

        await LoadPublishers();

        Result = true;
        IsVisible = true;

        var publisherName = publisher.PublisherName;

        RecordName = publisherName;

        publisher = new Publisher();

        //await JSRuntime.InvokeVoidAsync("saveMessage", firstName, lastName);
        await JSRuntime.InvokeVoidAsync("setFocusOnElement", publisherNameTextBox);
    }

    private async Task DeletePublisher(int pubId)
    {
        await bookStoresService.DeleteAsync("publishers/", pubId);

        await LoadPublishers();

        //throw new Exception("DeleteAuthor");
    }

    private void EditPublisher(Publisher argPublisher)
    {
        publisher = argPublisher;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookStoresService<Publisher> bookStoresService { get; set; }
    }
}
#pragma warning restore 1591
