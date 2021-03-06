﻿using Grand.Framework.Components;
using Grand.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Grand.Web.Components
{
    public class CustomerNavigationViewComponent : BaseViewComponent
    {
        private readonly ICustomerViewModelService _customerViewModelService;

        public CustomerNavigationViewComponent(ICustomerViewModelService customerViewModelService)
        {
            this._customerViewModelService = customerViewModelService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int selectedTabId = 0)
        {
            var model = await Task.Run(() => _customerViewModelService.PrepareNavigation(selectedTabId));
            return View(model);
        }
    }
}
