using UnityEngine;

namespace UniValueReference
{
	[CreateAssetMenu( fileName = "FloatValueReference", menuName = "UniValueReference/float", order = 9011)]
	public sealed class FloatValueReference : ScriptableObject
	{
		[SerializeField] private float m_value = 0;

		public float Value => m_value;
	}
}