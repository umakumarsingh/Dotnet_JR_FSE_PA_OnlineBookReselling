using Microsoft.AspNetCore.Mvc;
using OnlineBookReselling.BusinessLayer.Interfaces;
using OnlineBookReselling.DataLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookReselling.BusinessLayer.Services.ViewModels
{
    public class TopMenuViewComponent : ViewComponent
    {
        private readonly IBookResellingServices _bookResellingServices;

        /// <summary>
        /// Show the list of salon services on Menu Bar
        /// </summary>
        /// <param name="bookResellingServices"></param>
        public TopMenuViewComponent(IBookResellingServices bookResellingServices)
        {
            _bookResellingServices = bookResellingServices;
        }
        /// <summary>
        /// Invoke method as async while displaying menu bar.
        /// </summary>
        /// <returns></returns>
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _bookResellingServices.BookTypeList();
            return await Task.FromResult((IViewComponentResult)View("Default", model));
        }
    }
}
