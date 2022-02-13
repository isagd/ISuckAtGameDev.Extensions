using UnityEngine;  
  
namespace ISuckAtGameDev.Extensions
{
	public static class Vector3Extensions
	{
		public static Vector2 ToVector2(this Vector3 input) => new(input.x, input.y);

		public static Vector3 Flat(this Vector3 input) => new(input.x, 0, input.z);

		public static Vector3Int ToVector3Int(this Vector3 input) => new((int)input.x, (int)input.y, (int)input.z);
	}
}