using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;


namespace GPUECSAnimationBaker.Engine.AnimatorSystem
{
    [Serializable]
    public class MyGpuEcsAnimatorObject : ScriptableObject {
        public int totalNbrOfFrames;
        public int nbrOfAttachmentAnchors;
        public GpuEcsAnimationData[] animations;
        public GpuEcsAnimationEventOccurence[] animationEventOccurences;
        public TransformUsageFlags transformUsageFlags = TransformUsageFlags.Dynamic;
        public GpuEcsAttachmentAnchorData attachmentAnchorData;
    }
}