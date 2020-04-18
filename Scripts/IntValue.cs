using System;
using UnityEngine;

namespace UniValueReference
{
	[Serializable]
	public sealed class IntValue
	{
		[SerializeField] private IntValueReference m_reference = null;
		[SerializeField] private int               m_value     = 0;

		public int Value => m_reference != null ? m_reference.Value : m_value;

		public IntValue()
		{
		}

		public IntValue( int value ) => m_value = value;

		public IntValue( IntValueReference reference ) => m_reference = reference;

		public override string ToString() => Value.ToString();

		public string ToString( IFormatProvider provider ) => Value.ToString( provider );

		public string ToString( string format ) => Value.ToString( format );

		public string ToString( string format, IFormatProvider provider )
		{
			return Value.ToString( format, provider );
		}

		public static implicit operator int( IntValue value ) => value.Value;
	}
}