using UnityEngine;  
  
namespace ISuckAtGameDev.Extensions
{
	public static class SpriteRendererExtensions  
	{
		public static void Fade(this SpriteRenderer renderer, float alpha)
		{
			var color = renderer.color;
			color.a = alpha;
			renderer.color = color;
		}
	}
}
