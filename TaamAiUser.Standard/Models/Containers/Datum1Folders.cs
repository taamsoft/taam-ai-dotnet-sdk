using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace TaamAiUser.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<Datum1Folders>),
        new Type[] {
            typeof(FolderCase),
            typeof(MStringCase)
        },
        true
    )]
    public abstract class Datum1Folders
    {
        /// <summary>
        /// This is Folder case.
        /// </summary>
        /// <returns>
        /// The Datum1Folders instance, wrapping the provided Folder value.
        /// </returns>
        public static Datum1Folders FromFolder(Folder folder)
        {
            return new FolderCase().Set(folder);
        }

        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The Datum1Folders instance, wrapping the provided string value.
        /// </returns>
        public static Datum1Folders FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<Folder, T> folder, Func<string, T> mString);

        [JsonConverter(typeof(UnionTypeCaseConverter<FolderCase, Folder>))]
        private sealed class FolderCase : Datum1Folders, ICaseValue<FolderCase, Folder>
        {
            public Folder _value;

            public override T Match<T>(Func<Folder, T> folder, Func<string, T> mString)
            {
                return folder(_value);
            }

            public FolderCase Set(Folder value)
            {
                _value = value;
                return this;
            }

            public Folder Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : Datum1Folders, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(Func<Folder, T> folder, Func<string, T> mString)
            {
                return mString(_value);
            }

            public MStringCase Set(string value)
            {
                _value = value;
                return this;
            }

            public string Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}