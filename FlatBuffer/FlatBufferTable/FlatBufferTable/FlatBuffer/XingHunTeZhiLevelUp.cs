// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingHunTeZhiLevelUp : Table {
  public static FB_XingHunTeZhiLevelUp GetRootAsFB_XingHunTeZhiLevelUp(ByteBuffer _bb) { return GetRootAsFB_XingHunTeZhiLevelUp(_bb, new FB_XingHunTeZhiLevelUp()); }
  public static FB_XingHunTeZhiLevelUp GetRootAsFB_XingHunTeZhiLevelUp(ByteBuffer _bb, FB_XingHunTeZhiLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingHunTeZhiLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyCost { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunTeZhiLevelUp> CreateFB_XingHunTeZhiLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int MoneyType = 0,
      int MoneyCost = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_XingHunTeZhiLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_XingHunTeZhiLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_XingHunTeZhiLevelUp.AddMoneyCost(builder, MoneyCost);
    FB_XingHunTeZhiLevelUp.AddMoneyType(builder, MoneyType);
    FB_XingHunTeZhiLevelUp.AddId(builder, Id);
    return FB_XingHunTeZhiLevelUp.EndFB_XingHunTeZhiLevelUp(builder);
  }

  public static void StartFB_XingHunTeZhiLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(1, MoneyType, 0); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(2, MoneyCost, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunTeZhiLevelUp> EndFB_XingHunTeZhiLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunTeZhiLevelUp>(o);
  }
};

public sealed class FB_XingHunTeZhiLevelUpContainer : Table {
  public static FB_XingHunTeZhiLevelUpContainer GetRootAsFB_XingHunTeZhiLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_XingHunTeZhiLevelUpContainer(_bb, new FB_XingHunTeZhiLevelUpContainer()); }
  public static FB_XingHunTeZhiLevelUpContainer GetRootAsFB_XingHunTeZhiLevelUpContainer(ByteBuffer _bb, FB_XingHunTeZhiLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingHunTeZhiLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingHunTeZhiLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingHunTeZhiLevelUp GetItems(int j) { return GetItems(new FB_XingHunTeZhiLevelUp(), j); }
  public FB_XingHunTeZhiLevelUp GetItems(FB_XingHunTeZhiLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunTeZhiLevelUpContainer> CreateFB_XingHunTeZhiLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingHunTeZhiLevelUpContainer.AddItems(builder, items);
    return FB_XingHunTeZhiLevelUpContainer.EndFB_XingHunTeZhiLevelUpContainer(builder);
  }

  public static void StartFB_XingHunTeZhiLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingHunTeZhiLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunTeZhiLevelUpContainer> EndFB_XingHunTeZhiLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunTeZhiLevelUpContainer>(o);
  }
  public static void FinishFB_XingHunTeZhiLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingHunTeZhiLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
