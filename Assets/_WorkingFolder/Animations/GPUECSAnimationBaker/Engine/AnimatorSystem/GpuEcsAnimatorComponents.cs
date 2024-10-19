using Unity.Entities;
using Unity.Mathematics;

namespace GPUECSAnimationBaker.Engine.AnimatorSystem
{
    public struct GpuEcsAnimationDataComponent : IComponentData
    {
        public int totalNbrOfFrames;
        public int nbrOfAttachmentAnchors;
    }

    [InternalBufferCapacity(0)]
    public struct GpuEcsAnimationDataBufferElement : IBufferElementData
    {
        public int startFrameIndex;
        public int nbrOfFramesPerSample;
        public int nbrOfInBetweenSamples;
        public float blendTimeCorrection;
        public int startEventOccurenceId;
        public int nbrOfEventOccurenceIds;
        public bool loop;
    }

    [InternalBufferCapacity(0)]
    public struct GpuEcsAnimationEventOccurenceBufferElement : IBufferElementData
    {
        public float eventNormalizedTime;
        public int eventId;
    }
    
    public struct GpuEcsAnimatorShaderDataComponent : IComponentData
    {
        public float4x4 shaderData;
    }

    public struct GpuEcsAnimatorInitializedComponent : IComponentData
    {
        public bool initialized;
    }
    
    public struct GpuEcsAnimatorTransitionInfoComponent : IComponentData
    {
        public AnimatorInfo current;
        public float blendPreviousToCurrent; // 0 when only previous is running, 1 when only current is running
        public AnimatorInfo previous;
    }

    public struct GpuEcsAnimatorStateComponent : IComponentData
    {
        public float currentNormalizedTime;
        public float previousNormalizedTime;
        public bool stoppedCurrent;
        public bool stoppedPrevious;
    }

    [InternalBufferCapacity(0)]
    public struct GpuEcsAttachmentAnchorDataBufferElement : IBufferElementData
    {
        public float4x4 anchorTransform;
    }
    
    [InternalBufferCapacity(0)]
    public struct GpuEcsCurrentAttachmentAnchorBufferElement : IBufferElementData
    {
        public float4x4 currentTransform;
    }
    
    [InternalBufferCapacity(1)]
    public struct GpuEcsAnimatorEventBufferElement : IBufferElementData
    {
        public int animationId;
        public int eventId;
    }
    
}