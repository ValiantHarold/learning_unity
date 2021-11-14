using Unity.Entities;
using Unity.Mathematics;

public struct BoidComponent : IComponentData
{
    public float speed;
    public float3 currentPosition;
    public float3 velocity;
    public float3 acceleration;
    public float3 target;
    public BlobAssetReference<BoidManagerBLOB> boidManagerReference;

    public float debug;
}