using System.Linq;
using System.Web.Mvc;
using Voting.Models;

namespace Voting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Index(string questNum, int answer)
        {
            var castVote = new VoteLogic();
            var user = User.Identity.Name;
            castVote.CastVote(questNum, answer, user);
            return View();
        }

        public ActionResult AskQuestions()
        {
            ViewBag.Message = "Ask a New Question.";

            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult AskQuestions(string question)
        {
            var stub = new Questions();
            using(var questions = new VoteContext())
            {
                var test = questions.AskedQuestions.SingleOrDefault(x => x.Question == question);
                if(test == null)
                {
                    stub.Question = question;
                    questions.AskedQuestions.Add(stub);
                    questions.SaveChanges();
                }
            }

            return View();
        }

        public ActionResult Vote()
        {
            ViewBag.Message = "Voice Your Opinion";

            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Vote(string questNum, int answer)
        {
            var castVote = new VoteLogic();
            var user = User.Identity.Name;
            castVote.CastVote(questNum, answer, user);
            return View();
        }
    }
}