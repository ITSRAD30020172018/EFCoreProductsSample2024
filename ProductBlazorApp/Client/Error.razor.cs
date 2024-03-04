using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBlazorApp.Pages
{
    

    public partial class Error
    {
        [Parameter]
        public string Message { get; set; }

    }
}
