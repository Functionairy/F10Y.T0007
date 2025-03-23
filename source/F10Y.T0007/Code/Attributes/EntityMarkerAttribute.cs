using System;

using F10Y.T0000;


namespace F10Y.T0007
{
    /// <summary>
    /// Attribute indicating a class is an entity (a class specialized to participate in data storage with Entity Framework Core).
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying entity classes and building a catalogue of entities.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class, // Scripts are the same as functions (just no input or output arguments).
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
    )]
    [MarkerAttributeMarker]
    public class EntityMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a class is *not* an entity class.
        /// This is useful for marking classes that end up canonical entity code file locations, but are not entity classes.
        /// </summary>
        public bool Is_Entity { get; }


        public EntityMarkerAttribute(
            bool is_Entity = true)
        {
            this.Is_Entity = is_Entity;
        }
    }
}
