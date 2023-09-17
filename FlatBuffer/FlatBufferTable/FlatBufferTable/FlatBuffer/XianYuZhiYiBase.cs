// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XianYuZhiYiBase : Table {
  public static FB_XianYuZhiYiBase GetRootAsFB_XianYuZhiYiBase(ByteBuffer _bb) { return GetRootAsFB_XianYuZhiYiBase(_bb, new FB_XianYuZhiYiBase()); }
  public static FB_XianYuZhiYiBase GetRootAsFB_XianYuZhiYiBase(ByteBuffer _bb, FB_XianYuZhiYiBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XianYuZhiYiBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quality { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ModelId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DescId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string IconName { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UnLockModelId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_XianYuZhiYiBase> CreateFB_XianYuZhiYiBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Quality = -1,
      int UnlockLevel = -1,
      int ModelId = -1,
      int DescId = -1,
      StringOffset IconName = default(StringOffset),
      int UnLockModelId = -1) {
    builder.StartObject(8);
    FB_XianYuZhiYiBase.AddUnLockModelId(builder, UnLockModelId);
    FB_XianYuZhiYiBase.AddIconName(builder, IconName);
    FB_XianYuZhiYiBase.AddDescId(builder, DescId);
    FB_XianYuZhiYiBase.AddModelId(builder, ModelId);
    FB_XianYuZhiYiBase.AddUnlockLevel(builder, UnlockLevel);
    FB_XianYuZhiYiBase.AddQuality(builder, Quality);
    FB_XianYuZhiYiBase.AddName(builder, Name);
    FB_XianYuZhiYiBase.AddID(builder, ID);
    return FB_XianYuZhiYiBase.EndFB_XianYuZhiYiBase(builder);
  }

  public static void StartFB_XianYuZhiYiBase(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(2, Quality, -1); }
  public static void AddUnlockLevel(FlatBufferBuilder builder, int UnlockLevel) { builder.AddInt(3, UnlockLevel, -1); }
  public static void AddModelId(FlatBufferBuilder builder, int ModelId) { builder.AddInt(4, ModelId, -1); }
  public static void AddDescId(FlatBufferBuilder builder, int DescId) { builder.AddInt(5, DescId, -1); }
  public static void AddIconName(FlatBufferBuilder builder, StringOffset IconNameOffset) { builder.AddOffset(6, IconNameOffset.Value, 0); }
  public static void AddUnLockModelId(FlatBufferBuilder builder, int UnLockModelId) { builder.AddInt(7, UnLockModelId, -1); }
  public static Offset<FB_XianYuZhiYiBase> EndFB_XianYuZhiYiBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XianYuZhiYiBase>(o);
  }
};

public sealed class FB_XianYuZhiYiBaseContainer : Table {
  public static FB_XianYuZhiYiBaseContainer GetRootAsFB_XianYuZhiYiBaseContainer(ByteBuffer _bb) { return GetRootAsFB_XianYuZhiYiBaseContainer(_bb, new FB_XianYuZhiYiBaseContainer()); }
  public static FB_XianYuZhiYiBaseContainer GetRootAsFB_XianYuZhiYiBaseContainer(ByteBuffer _bb, FB_XianYuZhiYiBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XianYuZhiYiBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XianYuZhiYiBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XianYuZhiYiBase GetItems(int j) { return GetItems(new FB_XianYuZhiYiBase(), j); }
  public FB_XianYuZhiYiBase GetItems(FB_XianYuZhiYiBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XianYuZhiYiBaseContainer> CreateFB_XianYuZhiYiBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XianYuZhiYiBaseContainer.AddItems(builder, items);
    return FB_XianYuZhiYiBaseContainer.EndFB_XianYuZhiYiBaseContainer(builder);
  }

  public static void StartFB_XianYuZhiYiBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XianYuZhiYiBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XianYuZhiYiBaseContainer> EndFB_XianYuZhiYiBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XianYuZhiYiBaseContainer>(o);
  }
  public static void FinishFB_XianYuZhiYiBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_XianYuZhiYiBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
