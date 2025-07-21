using BlazorAIStorybook.Core.Models;

namespace BlazorAIStorybook.Core.Services;

public class StoryRequestService
{
    private readonly List<StoryRequestModel> _requests = new();
    private StoryRequestModel? _currentRequest;

    public StoryRequestModel? CurrentRequest
    {
        get => _currentRequest;
        set
        {
            _currentRequest = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;
    private void NotifyStateChanged() => OnChange?.Invoke();

    public IEnumerable<StoryRequestModel> GetAllRequests() => _requests;

    public void AddRequest(StoryRequestModel request)
    {
        _requests.Add(request);
        CurrentRequest = request;
    }

    public StoryRequestModel? GetRequest(int index)
    {
        if (index < 0 || index >= _requests.Count)
            return null;
        return _requests[index];
    }

    public bool UpdateRequest(int index, StoryRequestModel updatedRequest)
    {
        if (index < 0 || index >= _requests.Count)
            return false;
        _requests[index] = updatedRequest;
        CurrentRequest = updatedRequest;
        return true;
    }
}
