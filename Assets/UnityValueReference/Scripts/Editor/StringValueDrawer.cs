using UnityEditor;
using UnityEngine;

namespace KoganeUnityLib
{
	[CustomPropertyDrawer( typeof( StringValue ) )]
	public sealed class StringValueDrawer : PropertyDrawer
	{
		public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
		{
			var referenceProperty = property.FindPropertyRelative( "m_reference" );
			var valueProperty     = property.FindPropertyRelative( "m_value" );

			var referencePosition = position;
			var valuePosition     = position;

			referencePosition.width = position.width * 0.75f;
			valuePosition.x         = referencePosition.xMax;

			EditorGUI.PropertyField( referencePosition, referenceProperty, label );

			var reference = referenceProperty.objectReferenceValue as StringValueReference;

			if ( reference == null )
			{
				valueProperty.stringValue = EditorGUI.TextField( valuePosition, valueProperty.stringValue );
			}
			else
			{
				GUI.enabled = false;
				EditorGUI.TextField( valuePosition, reference.Value );
				GUI.enabled = true;
			}
		}
	}
}