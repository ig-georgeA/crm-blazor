using CRMApp16.Models.CRMApp;

namespace CRMApp16.CRMApp
{
    public class MockCRMAppService : ICRMAppService
    {
        public Task<List<MeetingsTasksType>> GetMeetingsTasksList()
        {
            return Task.FromResult<List<MeetingsTasksType>>(new());
        }
    }
}
