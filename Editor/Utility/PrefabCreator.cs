namespace Tilia.Interactions.Controllables.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Interactions/Controllables/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;
        private const string physicsRoot = "PhysicsJoint/";
        private const string transformRoot = "Transform/";

        private const string package = "io.extendreality.tilia.interactions.controllables.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabInteractionsAngularJointDrive = "Interactions.AngularJointDrive";
        private const string prefabInteractionsLinearJointDrive = "Interactions.LinearJointDrive";
        private const string prefabInteractionsAngularTransformDrive = "Interactions.AngularTransformDrive";
        private const string prefabInteractionsLinearTransformDrive = "Interactions.LinearTransformDrive";

        [MenuItem(menuItemRoot + physicsRoot + prefabInteractionsAngularJointDrive, false, priority)]
        private static void AddInteractionsAngularJointDrive()
        {
            string prefab = prefabInteractionsAngularJointDrive + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, physicsRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + physicsRoot + prefabInteractionsLinearJointDrive, false, priority)]
        private static void AddInteractionsLinearJointDrive()
        {
            string prefab = prefabInteractionsLinearJointDrive + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, physicsRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + transformRoot + prefabInteractionsAngularTransformDrive, false, priority)]
        private static void AddInteractionsAngularTransformDrive()
        {
            string prefab = prefabInteractionsAngularTransformDrive + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, transformRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + transformRoot + prefabInteractionsLinearTransformDrive, false, priority)]
        private static void AddInteractionsLinearTransformDrive()
        {
            string prefab = prefabInteractionsLinearTransformDrive + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, transformRoot, prefab);
            CreatePrefab(packageLocation);
        }
    }
}