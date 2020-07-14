using Examples.Web.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Examples.Web.Client.Pages
{
    public partial class FluentValidationExample : ComponentBase
    {
        [Inject]
        private HttpClient Http { get; set; }
        private RegisterUserRequest request = new RegisterUserRequest();

        async Task Save()
        {
            await Http.PostAsJsonAsync("api/user", request);
        }
    }
}
