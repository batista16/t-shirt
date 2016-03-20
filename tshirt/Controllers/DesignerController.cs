using System.Web.Mvc;
using tshirt.BusinessManagers.Tshirt;
using tshirt.Web.ViewModels;

namespace tshirt.Web.Controllers {
    public class DesignerController : BaseController {
        protected readonly ITshitBusinessManager TshitBm;

        public DesignerController(ITshitBusinessManager tshitBm) {
            TshitBm = tshitBm;
        }

        public ActionResult Index() {
            return View(CreateDesignerVm());
        }

        private DesignerVm CreateDesignerVm() {
            return new DesignerVm() {
                ProductTypes = TshitBm.GetProductTypes()
            };
        }
    }
}