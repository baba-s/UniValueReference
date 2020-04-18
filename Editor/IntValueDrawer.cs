﻿using UnityEditor;
using UnityEngine;
using UniValueReference.Internal;

namespace UniValueReference
{
	[CustomPropertyDrawer( typeof( IntValue ) )]
	internal sealed class IntValueDrawer : PropertyDrawer
	{
		public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
		{
			var referenceProperty = property.FindPropertyRelative( "m_reference" );
			var valueProperty     = property.FindPropertyRelative( "m_value" );

			var referencePosition = position;
			var valuePosition     = position;
			
			referencePosition.width = position.width * UnityValueReferenceUtils.DRAWER_WIDTH_RATE;
			valuePosition.x         = referencePosition.xMax;

			EditorGUI.PropertyField( referencePosition, referenceProperty, label );

			var reference = referenceProperty.objectReferenceValue as IntValueReference;

			if ( reference == null )
			{
				valueProperty.intValue = EditorGUI.IntField( valuePosition, valueProperty.intValue );
			}
			else
			{
				GUI.enabled = false;
				EditorGUI.IntField( valuePosition, reference.Value );
				GUI.enabled = true;
			}
		}
	}
}