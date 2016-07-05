using BGLTechnicalTest.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace BGLTechnicalTest.Controllers
{
    public class HomeController : Controller
    {
        private PageRequest request { get; set; }
        private PageResponse userData { get; set; }

        public ActionResult Index(string searchString)
        {            
            if (!String.IsNullOrEmpty(searchString))
            {
                APIResult result = new APIResult();

                request = new PageRequest();
                userData = new PageResponse();

                //an abstract class can be instantiated by using a concrete class
                UserPageSearchBase userSearchBase = new UserPageProvider();
                               
                request.rawUrl = "https://api.github.com/users/" + searchString;
                userData = userSearchBase.GetUserAvailabilityLiveSearch(request);

                result.UserName = userData.userDetail.name;
                result.Location = userData.userDetail.location;
                result.Avatar = userData.userDetail.avatar_url;

                UserRepositorySearchBase repoSearchBase = new UserRepositoryProvider();
                
                request.rawUrl = userData.userDetail.repos_url;
                userData = repoSearchBase.GetUserRepositoryLiveSearch(request);

                result.Repositories = userData.userRepository.OrderByDescending(x => x.stargazers_count).Take(5).ToList();

                return View(result);
            }

            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}