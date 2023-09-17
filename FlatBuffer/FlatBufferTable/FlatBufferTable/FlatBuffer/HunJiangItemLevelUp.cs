// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunJiangItemLevelUp : Table {
  public static FB_HunJiangItemLevelUp GetRootAsFB_HunJiangItemLevelUp(ByteBuffer _bb) { return GetRootAsFB_HunJiangItemLevelUp(_bb, new FB_HunJiangItemLevelUp()); }
  public static FB_HunJiangItemLevelUp GetRootAsFB_HunJiangItemLevelUp(ByteBuffer _bb, FB_HunJiangItemLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunJiangItemLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Quality { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Exp { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangItemLevelUp> CreateFB_HunJiangItemLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int Quality = 0,
      int Exp = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_HunJiangItemLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_HunJiangItemLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_HunJiangItemLevelUp.AddExp(builder, Exp);
    FB_HunJiangItemLevelUp.AddQuality(builder, Quality);
    FB_HunJiangItemLevelUp.AddId(builder, Id);
    return FB_HunJiangItemLevelUp.EndFB_HunJiangItemLevelUp(builder);
  }

  public static void StartFB_HunJiangItemLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(1, Quality, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(2, Exp, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangItemLevelUp> EndFB_HunJiangItemLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangItemLevelUp>(o);
  }
};

public sealed class FB_HunJiangItemLevelUpContainer : Table {
  public static FB_HunJiangItemLevelUpContainer GetRootAsFB_HunJiangItemLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_HunJiangItemLevelUpContainer(_bb, new FB_HunJiangItemLevelUpContainer()); }
  public static FB_HunJiangItemLevelUpContainer GetRootAsFB_HunJiangItemLevelUpContainer(ByteBuffer _bb, FB_HunJiangItemLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunJiangItemLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunJiangItemLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunJiangItemLevelUp GetItems(int j) { return GetItems(new FB_HunJiangItemLevelUp(), j); }
  public FB_HunJiangItemLevelUp GetItems(FB_HunJiangItemLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangItemLevelUpContainer> CreateFB_HunJiangItemLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunJiangItemLevelUpContainer.AddItems(builder, items);
    return FB_HunJiangItemLevelUpContainer.EndFB_HunJiangItemLevelUpContainer(builder);
  }

  public static void StartFB_HunJiangItemLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunJiangItemLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangItemLevelUpContainer> EndFB_HunJiangItemLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangItemLevelUpContainer>(o);
  }
  public static void FinishFB_HunJiangItemLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunJiangItemLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
