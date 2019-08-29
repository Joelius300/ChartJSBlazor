using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJs.Blazor.ChartJS.Common
{
    /// <summary>
    /// Represents an object that can be either a single value or an array of values. This is used for typesafe js-interop.
    /// </summary>
    /// <typeparam name="T">The type of data this <see cref="IndexableOption{T}"/> is supposed to hold.</typeparam>
    [Newtonsoft.Json.JsonConverter(typeof(IndexableOptionConverter))]   // newtonsoft for now
    public struct IndexableOption<T> : IEquatable<IndexableOption<T>>
    {
        /// <summary>
        /// The compile-time name of the property which stores the wrapped value. This is used internally for serialization.
        /// </summary>
        internal const string PropertyName = nameof(Value);

        /// <summary>
        /// The actual value represented by this instance.
        /// </summary>
        public object Value { get; }

        /// <summary>
        /// Gets the value indicating whether the option wrapped in this <see cref="IndexableOption{T}"/> is indexed. 
        /// <para>True if the wrapped value represents an array of <typeparamref name="T"/>, false if it represents a single value of <typeparamref name="T"/>.</para>
        /// </summary>
        public bool IsIndexed { get; }

        /// <summary>
        /// Creates a new instance of <see cref="IndexableOption{T}"/> which represents a single value.
        /// </summary>
        /// <param name="singleValue">The single value this <see cref="IndexableOption{T}"/> should represent.</param>
        public IndexableOption(T singleValue)
        {
            Value = singleValue ?? throw new ArgumentNullException(nameof(singleValue));
            IsIndexed = false;
        }

        /// <summary>
        /// Creates a new instance of <see cref="IndexableOption{T}"/> which represents an array of values.
        /// </summary>
        /// <param name="indexedValues">The array of values this <see cref="IndexableOption{T}"/> should represent.</param>
        public IndexableOption(T[] indexedValues)
        {
            Value = indexedValues ?? throw new ArgumentNullException(nameof(indexedValues));
            IsIndexed = true;
        }

        /// <summary>
        /// Implicitly wraps a single value of <typeparamref name="T"/> to a new instance of <see cref="IndexableOption{T}"/>.
        /// </summary>
        /// <param name="singleValue">The single value to wrap</param>
        public static implicit operator IndexableOption<T>(T singleValue) => new IndexableOption<T>(singleValue);

        /// <summary>
        /// Implicitly wraps an array of values of <typeparamref name="T"/> to a new instance of <see cref="IndexableOption{T}"/>.
        /// </summary>
        /// <param name="indexedValues">The array of values to wrap</param>
        public static implicit operator IndexableOption<T>(T[] indexedValues) => new IndexableOption<T>(indexedValues);

        /// <summary>
        /// Explicitly unwraps an <see cref="IndexableOption{T}"/> to a single value.
        /// <para>If this instance represents an array of values instead of a single value, an <see cref="InvalidCastException"/> will be thrown.</para>
        /// </summary>
        /// <param name="wrappedValue">The wrapped single value</param>
        public static explicit operator T(IndexableOption<T> wrappedValue)
        {
            if (wrappedValue.IsIndexed)
                throw new InvalidCastException("This instance represents an array of values and can't be converted to a single value.");

            return (T)wrappedValue.Value;
        }

        /// <summary>
        /// Explicitly unwraps an <see cref="IndexableOption{T}"/> to an array of values.
        /// <para>If this instance represents a single value instead of an array of values, an <see cref="InvalidCastException"/> will be thrown.</para>
        /// </summary>
        /// <param name="wrappedValue">The wrapped array of values</param>
        public static explicit operator T[](IndexableOption<T> wrappedValue)
        {
            if (!wrappedValue.IsIndexed)
                throw new InvalidCastException("This instance represents a single value and can't be converted to an array of values.");

            return (T[])wrappedValue.Value;
        }

        /// <summary>
        /// Determines whether the specified <see cref="IndexableOption{T}"/> instance is considered equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="IndexableOption{T}"/> to compare with.</param>
        /// <returns>true if the objects are considered equal; otherwise, false.</returns>
        public bool Equals(IndexableOption<T> other)
        {
            if (IsIndexed != other.IsIndexed) return false;

            if (IsIndexed)
            {
                return EqualityComparer<T[]>.Default.Equals((T[])Value, (T[])other.Value);
            }
            else
            {
                return EqualityComparer<T>.Default.Equals((T)Value, (T)other.Value);
            }
        }

        /// <summary>
        /// Determines whether the specified object instance is considered equal to the current instance.
        /// </summary>
        /// <param name="obj">The object to compare with.</param>
        /// <returns>true if the objects are considered equal; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            // an indexable option cannot store null
            if (obj == null) return false;

            if (obj is IndexableOption<T> option)
            {
                return Equals(option);
            }
            else
            {
                return Value.Equals(obj);
            }
        }

        /// <summary>
        /// Returns the hash of the underlying object.
        /// </summary>
        /// <returns>The hash of the underlying object.</returns>
        public override int GetHashCode()
        {
            return -1937169414 + Value.GetHashCode();
        }

        /// <summary>
        /// Determines whether two specified <see cref="IndexableOption{T}"/> instances contain the same value.
        /// </summary>
        /// <param name="a">The first <see cref="IndexableOption{T}"/> to compare</param>
        /// <param name="b">The second <see cref="IndexableOption{T}"/> to compare</param>
        /// <returns>true if the value of a is the same as the value of b; otherwise, false.</returns>
        public static bool operator ==(IndexableOption<T> a, IndexableOption<T> b) => a.Equals(b);

        /// <summary>
        /// Determines whether two specified <see cref="IndexableOption{T}"/> instances contain different values.
        /// </summary>
        /// <param name="a">The first <see cref="IndexableOption{T}"/> to compare</param>
        /// <param name="b">The second <see cref="IndexableOption{T}"/> to compare</param>
        /// <returns>true if the value of a is different from the value of b; otherwise, false.</returns>
        public static bool operator !=(IndexableOption<T> a, IndexableOption<T> b) => !(a == b);
    }
}
