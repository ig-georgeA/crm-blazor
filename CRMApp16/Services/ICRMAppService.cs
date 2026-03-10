using CRMApp16.Models.CRMApp;

namespace CRMApp16.CRMApp
{
    public interface ICRMAppService
    {
        Task<List<MeetingsTasksType>> GetMeetingsTasksList();
    }
}
