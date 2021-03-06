using UnityEngine;  
  
namespace ISuckAtGameDev.Extensions
{
	public static class TransformExtensions  
	{
		public static void DestroyChildren(this Transform t)
		{
			foreach (Transform child in t)
			{
				Object.Destroy(child.gameObject);
			}
		}
	}
}