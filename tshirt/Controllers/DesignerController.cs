using System.Linq;
using System.Web.Mvc;
using tshirt.Data;

namespace tshirt.Web.Controllers {
    public class DesignerController : BaseController {
        public ActionResult Index() {
            var db = TshirtContext.Create();
            return View(db.ProductTypes.ToList());
        }
    }
}