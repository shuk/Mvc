// <auto-generated />
namespace Microsoft.AspNet.Mvc.WebApiCompatShim
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.Mvc.WebApiCompatShim.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The key is invalid JQuery syntax because it is missing a closing bracket.
        /// </summary>
        internal static string JQuerySyntaxMissingClosingBracket
        {
            get { return GetString("JQuerySyntaxMissingClosingBracket"); }
        }

        /// <summary>
        /// The key is invalid JQuery syntax because it is missing a closing bracket.
        /// </summary>
        internal static string FormatJQuerySyntaxMissingClosingBracket()
        {
            return GetString("JQuerySyntaxMissingClosingBracket");
        }

        /// <summary>
        /// The number of keys in a NameValueCollection has exceeded the limit of '{0}'. You can adjust it by modifying the MaxHttpCollectionKeys property on the '{1}' class.
        /// </summary>
        internal static string MaxHttpCollectionKeyLimitReached
        {
            get { return GetString("MaxHttpCollectionKeyLimitReached"); }
        }

        /// <summary>
        /// The number of keys in a NameValueCollection has exceeded the limit of '{0}'. You can adjust it by modifying the MaxHttpCollectionKeys property on the '{1}' class.
        /// </summary>
        internal static string FormatMaxHttpCollectionKeyLimitReached(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MaxHttpCollectionKeyLimitReached"), p0, p1);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}