using UnityEngine;

namespace UniValueReference
{
	[CreateAssetMenu( fileName = "IntValueReference", menuName = "UniValueReference/int", order = 9010 )]
	public sealed class IntValueReference : ScriptableObject
	{
		[SerializeField] private int m_value = 0;

		public int Value => m_value;
	}
}