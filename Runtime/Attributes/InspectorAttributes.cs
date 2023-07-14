using System;
using UnityEngine;

namespace PunIntended.Utility
{
    /// <summary>
    /// makes this field read only
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class ReadOnlyAttribute : PropertyAttribute { }

    /// <summary>
    /// hides this field in scene instances
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class HideInSceneInstanceAttribute : PropertyAttribute { }

    /// <summary>
    /// makes this field read only in scene instances
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class ReadOnlyInSceneInstanceAttribute : PropertyAttribute { }

    /// <summary>
    /// shows button in unity inspector for this method
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class ButtonAttribute : Attribute { }
}
