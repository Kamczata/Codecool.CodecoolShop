using Codecool.CodecoolShop.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Components
{
    public class SuppliersMenu : ViewComponent
    {
        private readonly ISupplierRepository _supplierRepository;
        public SuppliersMenu(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public IViewComponentResult Invoke()
        {
            var suppliers = _supplierRepository.GetAll().OrderBy(s => s.Name);
            return View(suppliers);
        }
    }
}
