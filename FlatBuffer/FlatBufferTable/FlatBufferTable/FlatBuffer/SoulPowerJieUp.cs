// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SoulPowerJieUp : Table {
  public static FB_SoulPowerJieUp GetRootAsFB_SoulPowerJieUp(ByteBuffer _bb) { return GetRootAsFB_SoulPowerJieUp(_bb, new FB_SoulPowerJieUp()); }
  public static FB_SoulPowerJieUp GetRootAsFB_SoulPowerJieUp(ByteBuffer _bb, FB_SoulPowerJieUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SoulPowerJieUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCost { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SoulPowerJieUp> CreateFB_SoulPowerJieUp(FlatBufferBuilder builder,
      int Id = 0,
      int ItemId = -1,
      int ItemCost = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_SoulPowerJieUp.AddAttrValueList(builder, AttrValueList);
    FB_SoulPowerJieUp.AddAttrIdList(builder, AttrIdList);
    FB_SoulPowerJieUp.AddItemCost(builder, ItemCost);
    FB_SoulPowerJieUp.AddItemId(builder, ItemId);
    FB_SoulPowerJieUp.AddId(builder, Id);
    return FB_SoulPowerJieUp.EndFB_SoulPowerJieUp(builder);
  }

  public static void StartFB_SoulPowerJieUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(1, ItemId, -1); }
  public static void AddItemCost(FlatBufferBuilder builder, int ItemCost) { builder.AddInt(2, ItemCost, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SoulPowerJieUp> EndFB_SoulPowerJieUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SoulPowerJieUp>(o);
  }
};

public sealed class FB_SoulPowerJieUpContainer : Table {
  public static FB_SoulPowerJieUpContainer GetRootAsFB_SoulPowerJieUpContainer(ByteBuffer _bb) { return GetRootAsFB_SoulPowerJieUpContainer(_bb, new FB_SoulPowerJieUpContainer()); }
  public static FB_SoulPowerJieUpContainer GetRootAsFB_SoulPowerJieUpContainer(ByteBuffer _bb, FB_SoulPowerJieUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SoulPowerJieUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SoulPowerJieUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SoulPowerJieUp GetItems(int j) { return GetItems(new FB_SoulPowerJieUp(), j); }
  public FB_SoulPowerJieUp GetItems(FB_SoulPowerJieUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SoulPowerJieUpContainer> CreateFB_SoulPowerJieUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SoulPowerJieUpContainer.AddItems(builder, items);
    return FB_SoulPowerJieUpContainer.EndFB_SoulPowerJieUpContainer(builder);
  }

  public static void StartFB_SoulPowerJieUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SoulPowerJieUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SoulPowerJieUpContainer> EndFB_SoulPowerJieUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SoulPowerJieUpContainer>(o);
  }
  public static void FinishFB_SoulPowerJieUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_SoulPowerJieUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
