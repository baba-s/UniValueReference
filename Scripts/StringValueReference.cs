using UnityEngine;

namespace UniValueReference
{
	[CreateAssetMenu( fileName = "StringValueReference", menuName = "UniValueReference/string", order = 9012 )]
	public sealed class StringValueReference : ScriptableObject
	{
		[SerializeField] private string m_value = null;

		public string Value => m_value;
	}
}