using System.Collections.Generic;
using UnityEngine;  
  
namespace ISuckAtGameDev.Extensions
{
	public static class ListExtensions  
	{
		public static T Rand<T>(this IList<T> list)
		{
			return list[Random.Range(0, list.Count)];
		}
	}
}
