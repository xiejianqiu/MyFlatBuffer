// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OldGodItemLevelUp : Table {
  public static FB_OldGodItemLevelUp GetRootAsFB_OldGodItemLevelUp(ByteBuffer _bb) { return GetRootAsFB_OldGodItemLevelUp(_bb, new FB_OldGodItemLevelUp()); }
  public static FB_OldGodItemLevelUp GetRootAsFB_OldGodItemLevelUp(ByteBuffer _bb, FB_OldGodItemLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OldGodItemLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyCost { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PerTimeMoneyCost { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetBaseAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BaseAttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBaseAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BaseAttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OldGodItemLevelUp> CreateFB_OldGodItemLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int MoneyType = -1,
      int MoneyCost = -1,
      int PerTimeMoneyCost = -1,
      VectorOffset BaseAttrIdList = default(VectorOffset),
      VectorOffset BaseAttrValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_OldGodItemLevelUp.AddBaseAttrValueList(builder, BaseAttrValueList);
    FB_OldGodItemLevelUp.AddBaseAttrIdList(builder, BaseAttrIdList);
    FB_OldGodItemLevelUp.AddPerTimeMoneyCost(builder, PerTimeMoneyCost);
    FB_OldGodItemLevelUp.AddMoneyCost(builder, MoneyCost);
    FB_OldGodItemLevelUp.AddMoneyType(builder, MoneyType);
    FB_OldGodItemLevelUp.AddID(builder, ID);
    return FB_OldGodItemLevelUp.EndFB_OldGodItemLevelUp(builder);
  }

  public static void StartFB_OldGodItemLevelUp(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(1, MoneyType, -1); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(2, MoneyCost, -1); }
  public static void AddPerTimeMoneyCost(FlatBufferBuilder builder, int PerTimeMoneyCost) { builder.AddInt(3, PerTimeMoneyCost, -1); }
  public static void AddBaseAttrIdList(FlatBufferBuilder builder, VectorOffset BaseAttrIdListOffset) { builder.AddOffset(4, BaseAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateBaseAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBaseAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBaseAttrValueList(FlatBufferBuilder builder, VectorOffset BaseAttrValueListOffset) { builder.AddOffset(5, BaseAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateBaseAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBaseAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OldGodItemLevelUp> EndFB_OldGodItemLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodItemLevelUp>(o);
  }
};

public sealed class FB_OldGodItemLevelUpContainer : Table {
  public static FB_OldGodItemLevelUpContainer GetRootAsFB_OldGodItemLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_OldGodItemLevelUpContainer(_bb, new FB_OldGodItemLevelUpContainer()); }
  public static FB_OldGodItemLevelUpContainer GetRootAsFB_OldGodItemLevelUpContainer(ByteBuffer _bb, FB_OldGodItemLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OldGodItemLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OldGodItemLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OldGodItemLevelUp GetItems(int j) { return GetItems(new FB_OldGodItemLevelUp(), j); }
  public FB_OldGodItemLevelUp GetItems(FB_OldGodItemLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OldGodItemLevelUpContainer> CreateFB_OldGodItemLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OldGodItemLevelUpContainer.AddItems(builder, items);
    return FB_OldGodItemLevelUpContainer.EndFB_OldGodItemLevelUpContainer(builder);
  }

  public static void StartFB_OldGodItemLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OldGodItemLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OldGodItemLevelUpContainer> EndFB_OldGodItemLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodItemLevelUpContainer>(o);
  }
  public static void FinishFB_OldGodItemLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_OldGodItemLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
