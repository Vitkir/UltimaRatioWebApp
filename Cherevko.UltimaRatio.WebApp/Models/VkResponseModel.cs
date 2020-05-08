using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Cherevko.UltimaRatio.WebApp.Models
{
	public class VkJson
	{
		public VkResponseModel Response { get; set; }
	}

	public class VkResponseModel
	{
		public int Count { get; set; }

		public List<VkPhotoModel> Items { get; set; }
	}

	public class VkPhotoModel
	{
		[JsonPropertyName("album_id")]
		public int AlbumId { get; set; }

		[JsonPropertyName("owner_id")]
		public int OwnerId { get; set; }

		public int Id { get; set; }

		[JsonPropertyName("user_id")]
		public int UserId { get; set; }

		public int Date { get; set; }

		public string Text { get; set; }

		public List<PhotoSizeModel> Sizes { get; set; }
	}

	public class PhotoSizeModel
	{
		public int Height { get; set; }

		public int Width { get; set; }

		public string Type { get; set; }

		public string Url { get; set; }
	}
}