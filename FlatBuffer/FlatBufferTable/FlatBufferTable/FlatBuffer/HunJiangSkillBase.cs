// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunJiangSkillBase : Table {
  public static FB_HunJiangSkillBase GetRootAsFB_HunJiangSkillBase(ByteBuffer _bb) { return GetRootAsFB_HunJiangSkillBase(_bb, new FB_HunJiangSkillBase()); }
  public static FB_HunJiangSkillBase GetRootAsFB_HunJiangSkillBase(ByteBuffer _bb, FB_HunJiangSkillBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunJiangSkillBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SkillBaseId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string BookDesc { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_HunJiangSkillBase> CreateFB_HunJiangSkillBase(FlatBufferBuilder builder,
      int ID = 0,
      int SkillBaseId = -1,
      StringOffset BookDesc = default(StringOffset)) {
    builder.StartObject(3);
    FB_HunJiangSkillBase.AddBookDesc(builder, BookDesc);
    FB_HunJiangSkillBase.AddSkillBaseId(builder, SkillBaseId);
    FB_HunJiangSkillBase.AddID(builder, ID);
    return FB_HunJiangSkillBase.EndFB_HunJiangSkillBase(builder);
  }

  public static void StartFB_HunJiangSkillBase(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddSkillBaseId(FlatBufferBuilder builder, int SkillBaseId) { builder.AddInt(1, SkillBaseId, -1); }
  public static void AddBookDesc(FlatBufferBuilder builder, StringOffset BookDescOffset) { builder.AddOffset(2, BookDescOffset.Value, 0); }
  public static Offset<FB_HunJiangSkillBase> EndFB_HunJiangSkillBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangSkillBase>(o);
  }
};

public sealed class FB_HunJiangSkillBaseContainer : Table {
  public static FB_HunJiangSkillBaseContainer GetRootAsFB_HunJiangSkillBaseContainer(ByteBuffer _bb) { return GetRootAsFB_HunJiangSkillBaseContainer(_bb, new FB_HunJiangSkillBaseContainer()); }
  public static FB_HunJiangSkillBaseContainer GetRootAsFB_HunJiangSkillBaseContainer(ByteBuffer _bb, FB_HunJiangSkillBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunJiangSkillBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunJiangSkillBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunJiangSkillBase GetItems(int j) { return GetItems(new FB_HunJiangSkillBase(), j); }
  public FB_HunJiangSkillBase GetItems(FB_HunJiangSkillBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangSkillBaseContainer> CreateFB_HunJiangSkillBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunJiangSkillBaseContainer.AddItems(builder, items);
    return FB_HunJiangSkillBaseContainer.EndFB_HunJiangSkillBaseContainer(builder);
  }

  public static void StartFB_HunJiangSkillBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunJiangSkillBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangSkillBaseContainer> EndFB_HunJiangSkillBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangSkillBaseContainer>(o);
  }
  public static void FinishFB_HunJiangSkillBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunJiangSkillBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
