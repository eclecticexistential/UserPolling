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
        public ActionResult Index(string UserId, string Question, string Vote)
        {
            VoteForm vote = new VoteForm
            {
                UserId = UserId,
                Question = Question,
                Vote = Vote
            };
            var castVote = new VoteLogic();
            castVote.CastVote(vote);
            return RedirectToAction("Index");
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
            ViewBag.Message = "Question Added.";
            return View();
        }

        public ActionResult Vote()
        {
            ViewBag.Message = "Voice Your Opinion";

            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Vote(string UserId, string Question, string Vote)
        {
            VoteForm vote = new VoteForm
            {
                UserId = UserId,
                Question = Question,
                Vote = Vote
            };
            var castVote = new VoteLogic();
            castVote.CastVote(vote);
            return RedirectToAction("Vote");
        }
    }
}