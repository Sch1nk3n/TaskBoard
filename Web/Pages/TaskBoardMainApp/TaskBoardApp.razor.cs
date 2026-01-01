using Microsoft.AspNetCore.Components;

namespace TaskBoard.Web.Pages.TaskBoardMainApp
{
    public partial class TaskBoardApp : ComponentBase
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
