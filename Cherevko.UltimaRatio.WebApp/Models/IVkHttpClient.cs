using System.Threading.Tasks;

namespace Cherevko.UltimaRatio.WebApp.Models
{
	public interface IVkHttpClient
	{
		Task<VkJson> GetPhotos();
	}
}