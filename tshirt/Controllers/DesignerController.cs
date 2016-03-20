using System.Linq;
using System.Web.Mvc;
using tshirt.BusinessManagers.Tshirt;
using tshirt.Data;

namespace tshirt.Web.Controllers {
    public class DesignerController : BaseController
    {
        protected readonly ITshitBusinessManager TshitBm;

        public DesignerController(ITshitBusinessManager tshitBm)
        {
            TshitBm = tshitBm;
        }

        public ActionResult Index()
        {
            var styles = TshitBm.GetProductTypes();
            return View(styles);
        }
    }
}