using System.Collections;
using UnityEditor;
using UnityEngine;

namespace PunIntended.Utility.Editor
{
    [CustomPropertyDrawer(typeof(HideInSceneInstanceAttribute))]
    public class HideInSceneInstanceDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return PropertyDrawerUtility.InPrefabView ? EditorGUI.GetPropertyHeight(property, label, true) : 0f;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (PropertyDrawerUtility.InPrefabView)
            {
                EditorGUI.PropertyField(position, property, label, true);
            }
        }
    }
}