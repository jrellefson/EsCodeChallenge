using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EsCodeChallenge.Models;
using EsCodeChallenge.ViewModels;

namespace EsCodeChallenge.Controllers
{
    public class SoftwareSearchController : Controller
    {
        public SoftwareSearchController() { }

        public ViewResult SoftwareSearchList(string searchString)
        {
            try
            {
                if (string.IsNullOrEmpty(searchString))
                {
                    return View();
                }

                var searchVersion = ConvertStringToVersion(searchString);

                var softwareList = new List<Software>();
                softwareList = SoftwareManager.GetAllSoftware().Where(p => ConvertStringToVersion(p.Version).CompareTo(searchVersion) > 0).ToList();

                return View(new SoftwareSearchViewModel
                {
                    SearchString = searchString,
                    SoftwareResults = softwareList
                });
            }
            catch (Exception)
            {
                return View();
            }
        }

        private static Version ConvertStringToVersion(string versionString)
        {
            char[] charactersToTrim = { ' ', '.' };
            versionString = versionString.Trim(charactersToTrim);
            if (versionString.Split('.').Length < 2)
            {
                versionString += ".0";
            }
            if (Version.TryParse(versionString, out Version version))
            {
                return version;
            }
            else
            {
                throw new Exception("Failed to convert string to Version.");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
