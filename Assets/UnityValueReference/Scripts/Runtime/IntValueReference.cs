using UnityEngine;

namespace KoganeUnityLib
{
	[CreateAssetMenu( fileName = "IntValueReference", menuName = "Value Reference/int" )]
	public sealed class IntValueReference : ScriptableObject
	{
		[SerializeField] private int m_value = 0;

		public int Value => m_value;
	}
}