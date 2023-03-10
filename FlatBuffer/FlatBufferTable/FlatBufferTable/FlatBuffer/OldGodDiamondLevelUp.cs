// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OldGodDiamondLevelUp : Table {
  public static FB_OldGodDiamondLevelUp GetRootAsFB_OldGodDiamondLevelUp(ByteBuffer _bb) { return GetRootAsFB_OldGodDiamondLevelUp(_bb, new FB_OldGodDiamondLevelUp()); }
  public static FB_OldGodDiamondLevelUp GetRootAsFB_OldGodDiamondLevelUp(ByteBuffer _bb, FB_OldGodDiamondLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OldGodDiamondLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyCost { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetBaseAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BaseAttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBaseAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BaseAttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OldGodDiamondLevelUp> CreateFB_OldGodDiamondLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int MoneyType = 0,
      int MoneyCost = 0,
      VectorOffset BaseAttrIdList = default(VectorOffset),
      VectorOffset BaseAttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_OldGodDiamondLevelUp.AddBaseAttrValueList(builder, BaseAttrValueList);
    FB_OldGodDiamondLevelUp.AddBaseAttrIdList(builder, BaseAttrIdList);
    FB_OldGodDiamondLevelUp.AddMoneyCost(builder, MoneyCost);
    FB_OldGodDiamondLevelUp.AddMoneyType(builder, MoneyType);
    FB_OldGodDiamondLevelUp.AddId(builder, Id);
    return FB_OldGodDiamondLevelUp.EndFB_OldGodDiamondLevelUp(builder);
  }

  public static void StartFB_OldGodDiamondLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(1, MoneyType, 0); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(2, MoneyCost, 0); }
  public static void AddBaseAttrIdList(FlatBufferBuilder builder, VectorOffset BaseAttrIdListOffset) { builder.AddOffset(3, BaseAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateBaseAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBaseAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBaseAttrValueList(FlatBufferBuilder builder, VectorOffset BaseAttrValueListOffset) { builder.AddOffset(4, BaseAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateBaseAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBaseAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OldGodDiamondLevelUp> EndFB_OldGodDiamondLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodDiamondLevelUp>(o);
  }
};

public sealed class FB_OldGodDiamondLevelUpContainer : Table {
  public static FB_OldGodDiamondLevelUpContainer GetRootAsFB_OldGodDiamondLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_OldGodDiamondLevelUpContainer(_bb, new FB_OldGodDiamondLevelUpContainer()); }
  public static FB_OldGodDiamondLevelUpContainer GetRootAsFB_OldGodDiamondLevelUpContainer(ByteBuffer _bb, FB_OldGodDiamondLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OldGodDiamondLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OldGodDiamondLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OldGodDiamondLevelUp GetItems(int j) { return GetItems(new FB_OldGodDiamondLevelUp(), j); }
  public FB_OldGodDiamondLevelUp GetItems(FB_OldGodDiamondLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OldGodDiamondLevelUpContainer> CreateFB_OldGodDiamondLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OldGodDiamondLevelUpContainer.AddItems(builder, items);
    return FB_OldGodDiamondLevelUpContainer.EndFB_OldGodDiamondLevelUpContainer(builder);
  }

  public static void StartFB_OldGodDiamondLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OldGodDiamondLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OldGodDiamondLevelUpContainer> EndFB_OldGodDiamondLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodDiamondLevelUpContainer>(o);
  }
  public static void FinishFB_OldGodDiamondLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_OldGodDiamondLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
