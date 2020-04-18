using System;
using UnityEngine;

namespace UniValueReference
{
	[Serializable]
	public sealed class StringValue
	{
		[SerializeField] private StringValueReference m_reference = null;
		[SerializeField] private string               m_value     = null;

		public string Value => m_reference != null ? m_reference.Value : m_value;

		public StringValue()
		{
		}

		public StringValue( string value ) => m_value = value;

		public StringValue( StringValueReference reference ) => m_reference = reference;

		public override string ToString() => Value;

		public string ToString( IFormatProvider provider ) => Value.ToString( provider );

		public static implicit operator string( StringValue value ) => value.Value;
	}
}