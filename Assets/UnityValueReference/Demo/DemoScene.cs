using UnityEngine;

namespace KoganeUnityLib
{
	[ExecuteInEditMode]
	public sealed class DemoScene : MonoBehaviour
	{
		[SerializeField] private IntValue    m_intValue    = null;
		[SerializeField] private FloatValue  m_floatValue  = null;
		[SerializeField] private StringValue m_stringValue = null;

		private void Update()
		{
			int    i = m_intValue;
			float  f = m_floatValue;
			string s = m_stringValue;

			Debug.Log( m_intValue );
			Debug.Log( m_floatValue );
			Debug.Log( m_stringValue );
		}
	}
}