using System;
using System.Collections.Generic;
using EsCodeChallenge.Models;
using Microsoft.AspNetCore.Mvc;

namespace EsCodeChallenge.ViewModels
{
    public class SoftwareSearchViewModel
    {
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public List<Software> SoftwareResults { get; set; }
    }
}
