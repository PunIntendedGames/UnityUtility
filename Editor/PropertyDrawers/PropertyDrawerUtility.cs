using UnityEditor.SceneManagement;

namespace PunIntended.Utility.Editor
{
    internal static class PropertyDrawerUtility
    {
        internal static bool InPrefabView => PrefabStageUtility.GetCurrentPrefabStage() != null;
    }
}
