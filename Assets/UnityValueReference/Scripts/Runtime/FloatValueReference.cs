using UnityEngine;

namespace KoganeUnityLib
{
	[CreateAssetMenu( fileName = "FloatValueReference", menuName = "Value Reference/float" )]
	public sealed class FloatValueReference : ScriptableObject
	{
		[SerializeField] private float m_value = 0;

		public float Value => m_value;
	}
}