using UnityEditor;
using UnityEngine;

namespace KoganeUnityLib
{
	[CustomPropertyDrawer( typeof( FloatValue ) )]
	public sealed class FloatValueDrawer : PropertyDrawer
	{
		public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
		{
			var referenceProperty = property.FindPropertyRelative( "m_reference" );
			var valueProperty     = property.FindPropertyRelative( "m_value" );

			var referencePosition = position;
			var valuePosition     = position;

			referencePosition.width = position.width * 0.75f;
			valuePosition.x         = referencePosition.xMax;

			EditorGUI.PropertyField( referencePosition, referenceProperty );

			var reference = referenceProperty.objectReferenceValue as FloatValueReference;

			if ( reference == null )
			{
				valueProperty.floatValue = EditorGUI.FloatField( valuePosition, valueProperty.floatValue );
			}
			else
			{
				GUI.enabled = false;
				EditorGUI.FloatField( valuePosition, reference.Value );
				GUI.enabled = true;
			}
		}
	}
}