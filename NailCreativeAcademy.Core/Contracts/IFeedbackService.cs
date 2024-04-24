namespace NailCreativeAcademy.Core.Contracts
{
    using Models.Feedback;
    using NailCreativeAcademy.Core.Models.Trainer;

    public interface IFeedbackService
    {
        Task<IEnumerable<FeedbackViewModel>> AllAsync(int courseId);
        Task<int> AddAsync(FeedbackFormModel feedback,int courseId);
        Task EditAsync(FeedbackFormModel model, int feedbackId);
        Task <FeedbackFormModel> GetFeedbackById(int feedbackId);
        Task DeleteAsync(int feedbackId);
        Task<FeedbackViewModel> GetFeedbackToDeleteAsync(int feedbackId);
    }
}
