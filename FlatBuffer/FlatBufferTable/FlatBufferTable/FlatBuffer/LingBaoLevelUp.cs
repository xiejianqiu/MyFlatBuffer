// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LingBaoLevelUp : Table {
  public static FB_LingBaoLevelUp GetRootAsFB_LingBaoLevelUp(ByteBuffer _bb) { return GetRootAsFB_LingBaoLevelUp(_bb, new FB_LingBaoLevelUp()); }
  public static FB_LingBaoLevelUp GetRootAsFB_LingBaoLevelUp(ByteBuffer _bb, FB_LingBaoLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LingBaoLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyCost { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingBaoLevelUp> CreateFB_LingBaoLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int MoneyType = -1,
      int MoneyCost = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_LingBaoLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_LingBaoLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_LingBaoLevelUp.AddMoneyCost(builder, MoneyCost);
    FB_LingBaoLevelUp.AddMoneyType(builder, MoneyType);
    FB_LingBaoLevelUp.AddId(builder, Id);
    return FB_LingBaoLevelUp.EndFB_LingBaoLevelUp(builder);
  }

  public static void StartFB_LingBaoLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(1, MoneyType, -1); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(2, MoneyCost, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingBaoLevelUp> EndFB_LingBaoLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingBaoLevelUp>(o);
  }
};

public sealed class FB_LingBaoLevelUpContainer : Table {
  public static FB_LingBaoLevelUpContainer GetRootAsFB_LingBaoLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_LingBaoLevelUpContainer(_bb, new FB_LingBaoLevelUpContainer()); }
  public static FB_LingBaoLevelUpContainer GetRootAsFB_LingBaoLevelUpContainer(ByteBuffer _bb, FB_LingBaoLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LingBaoLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LingBaoLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LingBaoLevelUp GetItems(int j) { return GetItems(new FB_LingBaoLevelUp(), j); }
  public FB_LingBaoLevelUp GetItems(FB_LingBaoLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingBaoLevelUpContainer> CreateFB_LingBaoLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LingBaoLevelUpContainer.AddItems(builder, items);
    return FB_LingBaoLevelUpContainer.EndFB_LingBaoLevelUpContainer(builder);
  }

  public static void StartFB_LingBaoLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LingBaoLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingBaoLevelUpContainer> EndFB_LingBaoLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingBaoLevelUpContainer>(o);
  }
  public static void FinishFB_LingBaoLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_LingBaoLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
