namespace Tilia.Interactions.Controllables.Interactables
{
    using Tilia.Interactions.Controllables.AngularDriver;
    using Tilia.Interactions.Controllables.LinearDriver;
    using Tilia.Interactions.Interactables.Interactables;
    using UnityEditor;
    using UnityEngine;

    [InitializeOnLoad]
    public class ControllableCreatorEditorWindow : EditorWindow
    {
        private const string windowPath = "Window/Tilia/Interactions/";
        private const string windowTitle = "Controllable Creator";
        private const string angularJointAsset = "Interactions.AngularJointDrive";
        private const string linearJointAsset = "Interactions.LinearJointDrive";
        private const string angularTransformAsset = "Interactions.AngularTransformDrive";
        private const string linearTransformAsset = "Interactions.LinearTransformDrive";
        private const string assetSuffix = ".prefab";
        private const string buttonText = "Convert";
        private static EditorWindow promptWindow;
        private Vector2 scrollPosition;
        private GameObject angularJointPrefab;
        private GameObject linearJointPrefab;
        private GameObject angularTransformPrefab;
        private GameObject linearTransformPrefab;
        private string[] prefabTypes = new string[]
        {
            "Linear Joint Drive",
            "Linear Transform Drive",
            "Angular Joint Drive",
            "Angular Transform Drive"
        };
        private int prefabTypeIndex = 0;

        public void OnGUI()
        {
            using (GUILayout.ScrollViewScope scrollViewScope = new GUILayout.ScrollViewScope(scrollPosition))
            {
                scrollPosition = scrollViewScope.scrollPosition;
                GUILayout.Label(windowTitle, EditorStyles.boldLabel);

                prefabTypeIndex = EditorGUILayout.Popup(prefabTypeIndex, prefabTypes);

                if (GUILayout.Button(buttonText))
                {
                    switch (prefabTypeIndex)
                    {
                        case 0:
                            ProcessSelectedGameObjects<LinearJointDrive>(linearJointPrefab);
                            break;
                        case 1:
                            ProcessSelectedGameObjects<LinearTransformDrive>(linearTransformPrefab);
                            break;
                        case 2:
                            ProcessSelectedGameObjects<AngularJointDrive>(angularJointPrefab);
                            break;
                        case 3:
                            ProcessSelectedGameObjects<AngularTransformDrive>(angularTransformPrefab);
                            break;
                    }

                }
            }
        }

        protected virtual void OnEnable()
        {
            SetAsset(angularJointAsset, ref angularJointPrefab);
            SetAsset(linearJointAsset, ref linearJointPrefab);
            SetAsset(angularTransformAsset, ref angularTransformPrefab);
            SetAsset(linearTransformAsset, ref linearTransformPrefab);
        }

        protected virtual void SetAsset(string assetName, ref GameObject prefab)
        {
            foreach (string assetGUID in AssetDatabase.FindAssets(assetName))
            {
                string assetPath = AssetDatabase.GUIDToAssetPath(assetGUID);
                if (assetPath.Contains(assetName + assetSuffix))
                {
                    prefab = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
                }
            }
        }

        protected virtual void ProcessSelectedGameObjects<DriveType>(GameObject prefabToUse)
        {
            foreach (Transform selectedTransform in Selection.transforms)
            {
                ConvertSelectedGameObject<DriveType>(selectedTransform.gameObject, prefabToUse);
            }
        }

        protected virtual void ConvertSelectedGameObject<DriveType>(GameObject objectToConvert, GameObject prefabToUse)
        {
            DriveType interactable = objectToConvert.GetComponentInParent<DriveType>();
            if (interactable == null)
            {
                CreateInteractable(objectToConvert, prefabToUse);
            }
        }

        protected virtual void CreateInteractable(GameObject objectToWrap, GameObject prefabToUse)
        {
            int siblingIndex = objectToWrap.transform.GetSiblingIndex();
            GameObject newInteractable = (GameObject)PrefabUtility.InstantiatePrefab(prefabToUse);
            newInteractable.name += "_" + objectToWrap.name;
            InteractableFacade facade = newInteractable.GetComponentInChildren<InteractableFacade>();

            newInteractable.transform.SetParent(objectToWrap.transform.parent);
            newInteractable.transform.localPosition = objectToWrap.transform.localPosition;

            foreach (MeshRenderer defaultMeshes in facade.Configuration.MeshContainer.GetComponentsInChildren<MeshRenderer>())
            {
                defaultMeshes.gameObject.SetActive(false);
            }

            objectToWrap.transform.SetParent(facade.Configuration.MeshContainer.transform);
            objectToWrap.transform.localPosition = Vector3.zero;

            newInteractable.transform.SetSiblingIndex(siblingIndex);
        }

        [MenuItem(windowPath + windowTitle)]
        private static void ShowWindow()
        {
            promptWindow = EditorWindow.GetWindow(typeof(ControllableCreatorEditorWindow));
            promptWindow.titleContent = new GUIContent(windowTitle);
        }
    }
}