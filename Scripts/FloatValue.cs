using System;
using UnityEngine;

namespace UniValueReference
{
	[Serializable]
	public sealed class FloatValue
	{
		[SerializeField] private FloatValueReference m_reference = null;
		[SerializeField] private float               m_value     = 0;

		public float Value => m_reference != null ? m_reference.Value : m_value;

		public FloatValue()
		{
		}

		public FloatValue( float value ) => m_value = value;

		public FloatValue( FloatValueReference reference ) => m_reference = reference;

		public override string ToString() => Value.ToString();

		public string ToString( IFormatProvider provider ) => Value.ToString( provider );

		public string ToString( string format ) => Value.ToString( format );

		public string ToString( string format, IFormatProvider provider )
		{
			return Value.ToString( format, provider );
		}

		public static implicit operator float( FloatValue value ) => value.Value;
	}
}