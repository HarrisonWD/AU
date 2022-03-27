namespace AU.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        private readonly HttpClient _http;
        public CategoryService(HttpClient http)
        {
            this._http = http;
        }
        public async Task GetCategories()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("category");
            if(response != null && response.Data != null)
            Categories = response.Data;
        }
    }
}

