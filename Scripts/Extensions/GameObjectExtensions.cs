using UnityEngine;  
  
namespace ISuckAtGameDev.Extensions
{
	public static class GameObjectExtensions  
	{
		public static void SetLayersRecursively(this GameObject gameObject, int layer)
		{
			gameObject.layer = layer;
			foreach (Transform transform in gameObject.transform)
			{
				transform.gameObject.SetLayersRecursively(layer);
			}
		}
	}
}