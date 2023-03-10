// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XianYuZhiYiUnlockLevelUp : Table {
  public static FB_XianYuZhiYiUnlockLevelUp GetRootAsFB_XianYuZhiYiUnlockLevelUp(ByteBuffer _bb) { return GetRootAsFB_XianYuZhiYiUnlockLevelUp(_bb, new FB_XianYuZhiYiUnlockLevelUp()); }
  public static FB_XianYuZhiYiUnlockLevelUp GetRootAsFB_XianYuZhiYiUnlockLevelUp(ByteBuffer _bb, FB_XianYuZhiYiUnlockLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XianYuZhiYiUnlockLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockItemNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrValue { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_XianYuZhiYiUnlockLevelUp> CreateFB_XianYuZhiYiUnlockLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int UnlockItemId = -1,
      int UnlockItemNum = -1,
      int AttrId = -1,
      int AttrValue = -1) {
    builder.StartObject(5);
    FB_XianYuZhiYiUnlockLevelUp.AddAttrValue(builder, AttrValue);
    FB_XianYuZhiYiUnlockLevelUp.AddAttrId(builder, AttrId);
    FB_XianYuZhiYiUnlockLevelUp.AddUnlockItemNum(builder, UnlockItemNum);
    FB_XianYuZhiYiUnlockLevelUp.AddUnlockItemId(builder, UnlockItemId);
    FB_XianYuZhiYiUnlockLevelUp.AddID(builder, ID);
    return FB_XianYuZhiYiUnlockLevelUp.EndFB_XianYuZhiYiUnlockLevelUp(builder);
  }

  public static void StartFB_XianYuZhiYiUnlockLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddUnlockItemId(FlatBufferBuilder builder, int UnlockItemId) { builder.AddInt(1, UnlockItemId, -1); }
  public static void AddUnlockItemNum(FlatBufferBuilder builder, int UnlockItemNum) { builder.AddInt(2, UnlockItemNum, -1); }
  public static void AddAttrId(FlatBufferBuilder builder, int AttrId) { builder.AddInt(3, AttrId, -1); }
  public static void AddAttrValue(FlatBufferBuilder builder, int AttrValue) { builder.AddInt(4, AttrValue, -1); }
  public static Offset<FB_XianYuZhiYiUnlockLevelUp> EndFB_XianYuZhiYiUnlockLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XianYuZhiYiUnlockLevelUp>(o);
  }
};

public sealed class FB_XianYuZhiYiUnlockLevelUpContainer : Table {
  public static FB_XianYuZhiYiUnlockLevelUpContainer GetRootAsFB_XianYuZhiYiUnlockLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_XianYuZhiYiUnlockLevelUpContainer(_bb, new FB_XianYuZhiYiUnlockLevelUpContainer()); }
  public static FB_XianYuZhiYiUnlockLevelUpContainer GetRootAsFB_XianYuZhiYiUnlockLevelUpContainer(ByteBuffer _bb, FB_XianYuZhiYiUnlockLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XianYuZhiYiUnlockLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XianYuZhiYiUnlockLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XianYuZhiYiUnlockLevelUp GetItems(int j) { return GetItems(new FB_XianYuZhiYiUnlockLevelUp(), j); }
  public FB_XianYuZhiYiUnlockLevelUp GetItems(FB_XianYuZhiYiUnlockLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XianYuZhiYiUnlockLevelUpContainer> CreateFB_XianYuZhiYiUnlockLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XianYuZhiYiUnlockLevelUpContainer.AddItems(builder, items);
    return FB_XianYuZhiYiUnlockLevelUpContainer.EndFB_XianYuZhiYiUnlockLevelUpContainer(builder);
  }

  public static void StartFB_XianYuZhiYiUnlockLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XianYuZhiYiUnlockLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XianYuZhiYiUnlockLevelUpContainer> EndFB_XianYuZhiYiUnlockLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XianYuZhiYiUnlockLevelUpContainer>(o);
  }
  public static void FinishFB_XianYuZhiYiUnlockLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_XianYuZhiYiUnlockLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
