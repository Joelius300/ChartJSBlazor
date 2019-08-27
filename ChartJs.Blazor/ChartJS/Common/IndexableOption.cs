using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJs.Blazor.ChartJS.Common
{
    /// <summary>
    /// Represents a field that can be either a single value or multiple values (array). This is used for typesafe js-interop.
    /// </summary>
    /// <typeparam name="T">The type of data this <see cref="IndexableOption{T}"/> is supposed to hold.</typeparam>
    [Newtonsoft.Json.JsonConverter(typeof(IndexableOptionConverter))]   // newtonsoft for now
    public sealed class IndexableOption<T>
    {
        /// <summary>
        /// The compile-time name of the property which stores the wrapped value.
        /// </summary>
        public const string PropertyName = nameof(Value);

        /// <summary>
        /// The actual value represented by this instance.
        /// </summary>
        public object Value { get; }

        /// <summary>
        /// Gets the value indicating whether the option wrapped in this <see cref="IndexableOption{T}"/> is indexed. 
        /// If true, the wrapped value represents an array of <typeparamref name="T"/>, if not, a single value of <typeparamref name="T"/>.
        /// </summary>
        public bool IsIndexed { get; }

        /// <summary>
        /// Creates a new instance of <see cref="IndexableOption{T}"/> which represents a single value.
        /// </summary>
        /// <param name="singleValue">The single value this <see cref="IndexableOption{T}"/> represents.</param>
        public IndexableOption(T singleValue)
        {
            if (singleValue == null)
                throw new ArgumentNullException(nameof(singleValue));

            IsIndexed = false;
            Value = singleValue;
        }

        /// <summary>
        /// Creates a new instance of <see cref="IndexableOption{T}"/> which represents an array of values.
        /// </summary>
        /// <param name="indexedValues">The array of values this <see cref="IndexableOption{T}"/> represents.</param>
        public IndexableOption(T[] indexedValues)
        {
            if (indexedValues == null)
                throw new ArgumentNullException(nameof(indexedValues));

            IsIndexed = true;
            Value = indexedValues;
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

        public static implicit operator IndexableOption<T>(List<string> v)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines whether the specified object instance is considered equal to the current instance.
        /// </summary>
        /// <param name="obj">The object to compare with.</param>
        /// <returns>true if the objects are considered equal; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is IndexableOption<T> option)
            {
                return EqualityComparer<object>.Default.Equals(Value, option.Value);
            }
            else
            {
                return EqualityComparer<object>.Default.Equals(Value, obj);
            }
        }

        /// <summary>
        /// Returns the hash of the underlying object.
        /// </summary>
        /// <returns>The hash of the underlying object.</returns>
        public override int GetHashCode()
        {
            return -1937169414 + EqualityComparer<object>.Default.GetHashCode(Value);
        }
    }
}
