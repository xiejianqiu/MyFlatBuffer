// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenZhuangLevelUp : Table {
  public static FB_ShenZhuangLevelUp GetRootAsFB_ShenZhuangLevelUp(ByteBuffer _bb) { return GetRootAsFB_ShenZhuangLevelUp(_bb, new FB_ShenZhuangLevelUp()); }
  public static FB_ShenZhuangLevelUp GetRootAsFB_ShenZhuangLevelUp(ByteBuffer _bb, FB_ShenZhuangLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenZhuangLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyCost { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenZhuangLevelUp> CreateFB_ShenZhuangLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int MoneyType = -1,
      int MoneyCost = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_ShenZhuangLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_ShenZhuangLevelUp.AddAttrIDList(builder, AttrIDList);
    FB_ShenZhuangLevelUp.AddMoneyCost(builder, MoneyCost);
    FB_ShenZhuangLevelUp.AddMoneyType(builder, MoneyType);
    FB_ShenZhuangLevelUp.AddID(builder, ID);
    return FB_ShenZhuangLevelUp.EndFB_ShenZhuangLevelUp(builder);
  }

  public static void StartFB_ShenZhuangLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(1, MoneyType, -1); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(2, MoneyCost, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(3, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenZhuangLevelUp> EndFB_ShenZhuangLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenZhuangLevelUp>(o);
  }
};

public sealed class FB_ShenZhuangLevelUpContainer : Table {
  public static FB_ShenZhuangLevelUpContainer GetRootAsFB_ShenZhuangLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_ShenZhuangLevelUpContainer(_bb, new FB_ShenZhuangLevelUpContainer()); }
  public static FB_ShenZhuangLevelUpContainer GetRootAsFB_ShenZhuangLevelUpContainer(ByteBuffer _bb, FB_ShenZhuangLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenZhuangLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenZhuangLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenZhuangLevelUp GetItems(int j) { return GetItems(new FB_ShenZhuangLevelUp(), j); }
  public FB_ShenZhuangLevelUp GetItems(FB_ShenZhuangLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenZhuangLevelUpContainer> CreateFB_ShenZhuangLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenZhuangLevelUpContainer.AddItems(builder, items);
    return FB_ShenZhuangLevelUpContainer.EndFB_ShenZhuangLevelUpContainer(builder);
  }

  public static void StartFB_ShenZhuangLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenZhuangLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenZhuangLevelUpContainer> EndFB_ShenZhuangLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenZhuangLevelUpContainer>(o);
  }
  public static void FinishFB_ShenZhuangLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenZhuangLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
