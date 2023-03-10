// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_Bullet : Table {
  public static FB_Bullet GetRootAsFB_Bullet(ByteBuffer _bb) { return GetRootAsFB_Bullet(_bb, new FB_Bullet()); }
  public static FB_Bullet GetRootAsFB_Bullet(ByteBuffer _bb, FB_Bullet obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_Bullet __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EffectId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float Duration { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Delay { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float HeightRefix { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_Bullet> CreateFB_Bullet(FlatBufferBuilder builder,
      int Id = 0,
      int EffectId = -1,
      float Duration = 0,
      float Delay = 0,
      float HeightRefix = 0) {
    builder.StartObject(5);
    FB_Bullet.AddHeightRefix(builder, HeightRefix);
    FB_Bullet.AddDelay(builder, Delay);
    FB_Bullet.AddDuration(builder, Duration);
    FB_Bullet.AddEffectId(builder, EffectId);
    FB_Bullet.AddId(builder, Id);
    return FB_Bullet.EndFB_Bullet(builder);
  }

  public static void StartFB_Bullet(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddEffectId(FlatBufferBuilder builder, int EffectId) { builder.AddInt(1, EffectId, -1); }
  public static void AddDuration(FlatBufferBuilder builder, float Duration) { builder.AddFloat(2, Duration, 0); }
  public static void AddDelay(FlatBufferBuilder builder, float Delay) { builder.AddFloat(3, Delay, 0); }
  public static void AddHeightRefix(FlatBufferBuilder builder, float HeightRefix) { builder.AddFloat(4, HeightRefix, 0); }
  public static Offset<FB_Bullet> EndFB_Bullet(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_Bullet>(o);
  }
};

public sealed class FB_BulletContainer : Table {
  public static FB_BulletContainer GetRootAsFB_BulletContainer(ByteBuffer _bb) { return GetRootAsFB_BulletContainer(_bb, new FB_BulletContainer()); }
  public static FB_BulletContainer GetRootAsFB_BulletContainer(ByteBuffer _bb, FB_BulletContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BulletContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BulletContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_Bullet GetItems(int j) { return GetItems(new FB_Bullet(), j); }
  public FB_Bullet GetItems(FB_Bullet obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BulletContainer> CreateFB_BulletContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BulletContainer.AddItems(builder, items);
    return FB_BulletContainer.EndFB_BulletContainer(builder);
  }

  public static void StartFB_BulletContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_Bullet>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BulletContainer> EndFB_BulletContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BulletContainer>(o);
  }
  public static void FinishFB_BulletContainerBuffer(FlatBufferBuilder builder, Offset<FB_BulletContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
