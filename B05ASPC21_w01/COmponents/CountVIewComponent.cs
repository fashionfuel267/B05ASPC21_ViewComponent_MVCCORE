using B05ASPC21_w01.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace B05ASPC21_w01.COmponents
{

    [ViewComponent(Name = "CountViewComponent")]
    public class CountViewComponent: ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
         var model=   new CartVM
            {
                Message = "This is from ViewCOmponent",
                Count = 10,
            };
            return View(model);
        }
    }
}
