﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NeutralNews.Pages
{
  public class SocialModel : PageModel
  {
    public string Message { get; set; }

    public void OnGet()
    {
      Message = "Your application description page.";
    }
  }
}
