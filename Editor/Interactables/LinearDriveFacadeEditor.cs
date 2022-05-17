namespace Tilia.Interactions.Controllables.LinearDriver
{
    using System;
    using UnityEditor;
    using UnityEngine;
    using Zinnia.Utility;

    [CustomEditor(typeof(LinearDriveFacade), true)]
    public class LinearDriveFacadeEditor : ZinniaInspector
    {
        private const string buttonText = "Align To Initial Target Value";
        private LinearDriveFacade facade;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            try
            {
                EditorGUILayout.BeginHorizontal("GroupBox");
                GUILayout.FlexibleSpace();
                if (GUILayout.Button(buttonText))
                {
                    ChooseButtonLogic();
                }
                GUILayout.FlexibleSpace();
                EditorGUILayout.EndHorizontal();
            }
            catch (Exception exception)
            {
                if (exception.GetType() != typeof(ExitGUIException) && exception.GetType() != typeof(ArgumentException))
                {
                    Debug.LogError(exception);
                }
            }
        }

        protected virtual void OnEnable()
        {
            facade = (LinearDriveFacade)serializedObject.targetObject;
        }

        protected virtual void ChooseButtonLogic()
        {
            Vector3 newPosition = GetNewPosition();
            if (facade.Drive.GetType() == typeof(LinearTransformDrive))
            {
                AlignTransformToInitialTargetValue(newPosition);
            }
            else if (facade.Drive.GetType() == typeof(LinearJointDrive))
            {
                AlignJointToInitialTargetValue(newPosition);
            }
        }

        protected virtual void AlignJointToInitialTargetValue(Vector3 newPosition)
        {
            LinearJointDrive drive = (LinearJointDrive)facade.Drive;
            drive.Joint.transform.localPosition = newPosition;
        }

        protected virtual void AlignTransformToInitialTargetValue(Vector3 newPosition)
        {
            LinearTransformDrive drive = (LinearTransformDrive)facade.Drive;
            drive.Interactable.transform.localPosition = newPosition;
        }

        protected virtual float CalculatePosition()
        {
            float halfLimit = facade.DriveLimit * 0.5f;
            return Mathf.Lerp(-halfLimit, halfLimit, facade.InitialTargetValue);
        }

        protected virtual Vector3 GetNewPosition()
        {
            float position = CalculatePosition();
            switch (facade.DriveAxis)
            {
                case Driver.DriveAxis.Axis.XAxis:
                    return Vector3.right * position;
                case Driver.DriveAxis.Axis.YAxis:
                    return Vector3.up * position;
                case Driver.DriveAxis.Axis.ZAxis:
                    return Vector3.forward * position;
            }

            return Vector3.zero;
        }
    }
}