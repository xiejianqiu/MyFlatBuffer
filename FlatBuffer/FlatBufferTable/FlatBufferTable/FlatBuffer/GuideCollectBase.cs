// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuideCollectBase : Table {
  public static FB_GuideCollectBase GetRootAsFB_GuideCollectBase(ByteBuffer _bb) { return GetRootAsFB_GuideCollectBase(_bb, new FB_GuideCollectBase()); }
  public static FB_GuideCollectBase GetRootAsFB_GuideCollectBase(ByteBuffer _bb, FB_GuideCollectBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuideCollectBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int AddPointNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CombatProbability { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GuideCollectBase> CreateFB_GuideCollectBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int AddPointNum = -1,
      int CombatProbability = -1) {
    builder.StartObject(4);
    FB_GuideCollectBase.AddCombatProbability(builder, CombatProbability);
    FB_GuideCollectBase.AddAddPointNum(builder, AddPointNum);
    FB_GuideCollectBase.AddName(builder, Name);
    FB_GuideCollectBase.AddId(builder, Id);
    return FB_GuideCollectBase.EndFB_GuideCollectBase(builder);
  }

  public static void StartFB_GuideCollectBase(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddAddPointNum(FlatBufferBuilder builder, int AddPointNum) { builder.AddInt(2, AddPointNum, -1); }
  public static void AddCombatProbability(FlatBufferBuilder builder, int CombatProbability) { builder.AddInt(3, CombatProbability, -1); }
  public static Offset<FB_GuideCollectBase> EndFB_GuideCollectBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuideCollectBase>(o);
  }
};

public sealed class FB_GuideCollectBaseContainer : Table {
  public static FB_GuideCollectBaseContainer GetRootAsFB_GuideCollectBaseContainer(ByteBuffer _bb) { return GetRootAsFB_GuideCollectBaseContainer(_bb, new FB_GuideCollectBaseContainer()); }
  public static FB_GuideCollectBaseContainer GetRootAsFB_GuideCollectBaseContainer(ByteBuffer _bb, FB_GuideCollectBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuideCollectBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuideCollectBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuideCollectBase GetItems(int j) { return GetItems(new FB_GuideCollectBase(), j); }
  public FB_GuideCollectBase GetItems(FB_GuideCollectBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuideCollectBaseContainer> CreateFB_GuideCollectBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuideCollectBaseContainer.AddItems(builder, items);
    return FB_GuideCollectBaseContainer.EndFB_GuideCollectBaseContainer(builder);
  }

  public static void StartFB_GuideCollectBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuideCollectBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuideCollectBaseContainer> EndFB_GuideCollectBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuideCollectBaseContainer>(o);
  }
  public static void FinishFB_GuideCollectBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuideCollectBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
