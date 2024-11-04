using Microsoft.AspNetCore.Authorization.Infrastructure;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private IEnumerable<TaskItem> tasks =
		[
			new() { Id = 1, Title="Task 1", Description="Description", CreatedDate=DateTime.Now},
            new() { Id = 1, Title="Task 2", Description="Description 2", CreatedDate=DateTime.Now},
            new() { Id = 1, Title="Task 3", Description="Description 3", CreatedDate=DateTime.Now},
        ];

        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(tasks);
        }
    }
}
