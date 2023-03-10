// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuideCollectBossTips : Table {
  public static FB_GuideCollectBossTips GetRootAsFB_GuideCollectBossTips(ByteBuffer _bb) { return GetRootAsFB_GuideCollectBossTips(_bb, new FB_GuideCollectBossTips()); }
  public static FB_GuideCollectBossTips GetRootAsFB_GuideCollectBossTips(ByteBuffer _bb, FB_GuideCollectBossTips obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuideCollectBossTips __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int BossFakeObjId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BossCharModelId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BossTalk { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GuideCollectBossTips> CreateFB_GuideCollectBossTips(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int BossFakeObjId = -1,
      int BossCharModelId = -1,
      int BossTalk = -1) {
    builder.StartObject(5);
    FB_GuideCollectBossTips.AddBossTalk(builder, BossTalk);
    FB_GuideCollectBossTips.AddBossCharModelId(builder, BossCharModelId);
    FB_GuideCollectBossTips.AddBossFakeObjId(builder, BossFakeObjId);
    FB_GuideCollectBossTips.AddName(builder, Name);
    FB_GuideCollectBossTips.AddId(builder, Id);
    return FB_GuideCollectBossTips.EndFB_GuideCollectBossTips(builder);
  }

  public static void StartFB_GuideCollectBossTips(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddBossFakeObjId(FlatBufferBuilder builder, int BossFakeObjId) { builder.AddInt(2, BossFakeObjId, -1); }
  public static void AddBossCharModelId(FlatBufferBuilder builder, int BossCharModelId) { builder.AddInt(3, BossCharModelId, -1); }
  public static void AddBossTalk(FlatBufferBuilder builder, int BossTalk) { builder.AddInt(4, BossTalk, -1); }
  public static Offset<FB_GuideCollectBossTips> EndFB_GuideCollectBossTips(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuideCollectBossTips>(o);
  }
};

public sealed class FB_GuideCollectBossTipsContainer : Table {
  public static FB_GuideCollectBossTipsContainer GetRootAsFB_GuideCollectBossTipsContainer(ByteBuffer _bb) { return GetRootAsFB_GuideCollectBossTipsContainer(_bb, new FB_GuideCollectBossTipsContainer()); }
  public static FB_GuideCollectBossTipsContainer GetRootAsFB_GuideCollectBossTipsContainer(ByteBuffer _bb, FB_GuideCollectBossTipsContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuideCollectBossTipsContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuideCollectBossTipsContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuideCollectBossTips GetItems(int j) { return GetItems(new FB_GuideCollectBossTips(), j); }
  public FB_GuideCollectBossTips GetItems(FB_GuideCollectBossTips obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuideCollectBossTipsContainer> CreateFB_GuideCollectBossTipsContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuideCollectBossTipsContainer.AddItems(builder, items);
    return FB_GuideCollectBossTipsContainer.EndFB_GuideCollectBossTipsContainer(builder);
  }

  public static void StartFB_GuideCollectBossTipsContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuideCollectBossTips>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuideCollectBossTipsContainer> EndFB_GuideCollectBossTipsContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuideCollectBossTipsContainer>(o);
  }
  public static void FinishFB_GuideCollectBossTipsContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuideCollectBossTipsContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
