using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cherevko.UltimaRatio.WebApp.Models
{
	public class VkHttpClient : IVkHttpClient
	{
		private readonly ILogger<VkHttpClient> _logger;

		private readonly HttpClient client;

		public VkHttpClient(ILogger<VkHttpClient> logger)
		{
			_logger = logger;
			client = new HttpClient();
		}

		public async Task<VkJson> GetPhotos()
		{
			HttpResponseMessage response = await client.GetAsync("https://api.vk.com/method/photos.get?access_token=1867af7e1867af7e1867af7e3318161c29118671867af7e46d528fe6ebfd81c41d67cf1&v=5.103&owner_id=-24735760&album_id=179528153&rev=0&extended=0&feed_type=photo&count=100");
			response.EnsureSuccessStatusCode();
			var content = await response.Content.ReadAsStringAsync();
			var result = DeserializeVkResponse(content);
			return result;
		}

		private VkJson DeserializeVkResponse(string content)
		{
			var options = new JsonSerializerOptions()
			{
				PropertyNameCaseInsensitive = true
			};
			return JsonSerializer.Deserialize<VkJson>(content, options);
		}
	}
}
