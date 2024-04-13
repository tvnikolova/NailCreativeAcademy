namespace NailCreativeAcademy.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;
    using Core.Contracts;
    using Core.Models.Feedback;
    
    using static Core.Constants.MessageConstants;
    using Microsoft.AspNetCore.Authorization;

    public class FeedbackController : BaseController
    {
        private readonly IFeedbackService feedbackService;
		private readonly ICourseService courseService;
		public FeedbackController(IFeedbackService _feedbackService, ICourseService _courseService)
        {
            this.feedbackService = _feedbackService;
            this.courseService = _courseService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All(int id)
        {
            IEnumerable<FeedbackViewModel> allFeedbacks = await feedbackService.AllAsync(id);

            return View(allFeedbacks);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new FeedbackFormModel();
            
            return View(model);
        }
		[HttpPost]
		public async Task<IActionResult> Add(FeedbackFormModel feedback,int id)
		{
			var courseExist = await courseService.GetMyCourseByIdAsync(id);
            feedback.ClientId =  User.GetUserId();

  			if (!ModelState.IsValid)
            {
                return View(feedback);
            }

            if(courseExist==null)
            {
                ModelState.AddModelError(nameof(courseExist.Name), CourseNotExist);
            }

            int courseId = id;
            await feedbackService.AddAsync(feedback, id);

            return RedirectToAction(nameof(All), new { id = courseId });
            ;
        
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var foundeFeedback = await feedbackService.GetFeedbackById(id);

            if (foundeFeedback == null)
            {
                return BadRequest();
            }


            return View(foundeFeedback);

        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(FeedbackFormModel feedback, int id)
        {
            var foundeFeedback = await feedbackService.GetFeedbackById(id);

            if (foundeFeedback == null)
            {
                return BadRequest();
            }

            int courseId = foundeFeedback.CourseId;
            await feedbackService.EditAsync(feedback, id);

            return RedirectToAction(nameof(All),new { id = courseId });
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var foundeFeedback = await feedbackService.GetFeedbackToDeleteAsync(id);

            return View(foundeFeedback);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            var foundeFeedback = await feedbackService.GetFeedbackById(id);
            if (foundeFeedback == null)
            {
                return BadRequest();
            }
            int courseId = foundeFeedback.CourseId;

            await feedbackService.DeleteAsync(id);
            
            return RedirectToAction(nameof(All), new { id = courseId });
        }

    }
}
