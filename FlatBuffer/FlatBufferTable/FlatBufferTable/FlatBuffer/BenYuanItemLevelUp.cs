// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BenYuanItemLevelUp : Table {
  public static FB_BenYuanItemLevelUp GetRootAsFB_BenYuanItemLevelUp(ByteBuffer _bb) { return GetRootAsFB_BenYuanItemLevelUp(_bb, new FB_BenYuanItemLevelUp()); }
  public static FB_BenYuanItemLevelUp GetRootAsFB_BenYuanItemLevelUp(ByteBuffer _bb, FB_BenYuanItemLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BenYuanItemLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Exp { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BenYuanItemLevelUp> CreateFB_BenYuanItemLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int Exp = 0,
      int ItemId = 0,
      int ItemCount = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_BenYuanItemLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_BenYuanItemLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_BenYuanItemLevelUp.AddItemCount(builder, ItemCount);
    FB_BenYuanItemLevelUp.AddItemId(builder, ItemId);
    FB_BenYuanItemLevelUp.AddExp(builder, Exp);
    FB_BenYuanItemLevelUp.AddId(builder, Id);
    return FB_BenYuanItemLevelUp.EndFB_BenYuanItemLevelUp(builder);
  }

  public static void StartFB_BenYuanItemLevelUp(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(1, Exp, 0); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(2, ItemId, 0); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(3, ItemCount, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BenYuanItemLevelUp> EndFB_BenYuanItemLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BenYuanItemLevelUp>(o);
  }
};

public sealed class FB_BenYuanItemLevelUpContainer : Table {
  public static FB_BenYuanItemLevelUpContainer GetRootAsFB_BenYuanItemLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_BenYuanItemLevelUpContainer(_bb, new FB_BenYuanItemLevelUpContainer()); }
  public static FB_BenYuanItemLevelUpContainer GetRootAsFB_BenYuanItemLevelUpContainer(ByteBuffer _bb, FB_BenYuanItemLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BenYuanItemLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BenYuanItemLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BenYuanItemLevelUp GetItems(int j) { return GetItems(new FB_BenYuanItemLevelUp(), j); }
  public FB_BenYuanItemLevelUp GetItems(FB_BenYuanItemLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BenYuanItemLevelUpContainer> CreateFB_BenYuanItemLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BenYuanItemLevelUpContainer.AddItems(builder, items);
    return FB_BenYuanItemLevelUpContainer.EndFB_BenYuanItemLevelUpContainer(builder);
  }

  public static void StartFB_BenYuanItemLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BenYuanItemLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BenYuanItemLevelUpContainer> EndFB_BenYuanItemLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BenYuanItemLevelUpContainer>(o);
  }
  public static void FinishFB_BenYuanItemLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_BenYuanItemLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
