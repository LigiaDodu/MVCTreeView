using System.Collections.Generic;
using System.Web.Mvc;

namespace TreeView.Controllers
{
    public class TreeViewController : Controller
    {
        // GET: TreeView
        public ActionResult Index()
        {

            var list = new List<Models.ProfileTreeViewItem>();

            var profileList = new List<Models.Profile>
            {
                new Models.Profile(1, "Vip"),
                new Models.Profile(2, "Unverified"),
                new Models.Profile(3, "Verified"),
                new Models.Profile(4, "Restricted"),
                new Models.Profile(5, "LowRoller"),
                new Models.Profile(6, "Test")
            };

            var listcat = new List<Models.ProfileTreeViewItem>();

            var categoryList = new List<Models.Profile>
            {
                new Models.Profile(1, "DefaultCurrency"),
                new Models.Profile(2, "WeakCurrencyx10"),
                new Models.Profile(3, "WeakCurrencyx100")
              
            };

            var listOverrides = new List<Models.ProfileTreeViewItem>();

            var profileOverrides = new List<Models.Profile>
            {
                new Models.Profile(1, "Cashier"),
                new Models.Profile(2, "Stones And Bones"),
                new Models.Profile(3, "Video Slots")

            };

            foreach (var profile in profileOverrides)
            {
                listOverrides.Add(new Models.ProfileTreeViewItem(profile));
            }


            foreach (var profile in categoryList)
            {
                listcat.Add(new Models.ProfileTreeViewItem(profile, listOverrides));
            }

            foreach (var profile in profileList)
            {
                list.Add(new Models.ProfileTreeViewItem(profile, listcat));
            }

            return View(list);
        }
    }
}