using UnityEngine;

namespace KoganeUnityLib
{
	[CreateAssetMenu( fileName = "StringValueReference", menuName = "Value Reference/string" )]
	public sealed class StringValueReference : ScriptableObject
	{
		[SerializeField] private string m_value = null;

		public string Value => m_value;
	}
}