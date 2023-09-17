// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SoulPowerLevelUp : Table {
  public static FB_SoulPowerLevelUp GetRootAsFB_SoulPowerLevelUp(ByteBuffer _bb) { return GetRootAsFB_SoulPowerLevelUp(_bb, new FB_SoulPowerLevelUp()); }
  public static FB_SoulPowerLevelUp GetRootAsFB_SoulPowerLevelUp(ByteBuffer _bb, FB_SoulPowerLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SoulPowerLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyCost { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int JieLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SoulPowerLevelUp> CreateFB_SoulPowerLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int MoneyType = -1,
      int MoneyCost = -1,
      int JieLevel = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_SoulPowerLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_SoulPowerLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_SoulPowerLevelUp.AddJieLevel(builder, JieLevel);
    FB_SoulPowerLevelUp.AddMoneyCost(builder, MoneyCost);
    FB_SoulPowerLevelUp.AddMoneyType(builder, MoneyType);
    FB_SoulPowerLevelUp.AddId(builder, Id);
    return FB_SoulPowerLevelUp.EndFB_SoulPowerLevelUp(builder);
  }

  public static void StartFB_SoulPowerLevelUp(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(1, MoneyType, -1); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(2, MoneyCost, -1); }
  public static void AddJieLevel(FlatBufferBuilder builder, int JieLevel) { builder.AddInt(3, JieLevel, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SoulPowerLevelUp> EndFB_SoulPowerLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SoulPowerLevelUp>(o);
  }
};

public sealed class FB_SoulPowerLevelUpContainer : Table {
  public static FB_SoulPowerLevelUpContainer GetRootAsFB_SoulPowerLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_SoulPowerLevelUpContainer(_bb, new FB_SoulPowerLevelUpContainer()); }
  public static FB_SoulPowerLevelUpContainer GetRootAsFB_SoulPowerLevelUpContainer(ByteBuffer _bb, FB_SoulPowerLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SoulPowerLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SoulPowerLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SoulPowerLevelUp GetItems(int j) { return GetItems(new FB_SoulPowerLevelUp(), j); }
  public FB_SoulPowerLevelUp GetItems(FB_SoulPowerLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SoulPowerLevelUpContainer> CreateFB_SoulPowerLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SoulPowerLevelUpContainer.AddItems(builder, items);
    return FB_SoulPowerLevelUpContainer.EndFB_SoulPowerLevelUpContainer(builder);
  }

  public static void StartFB_SoulPowerLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SoulPowerLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SoulPowerLevelUpContainer> EndFB_SoulPowerLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SoulPowerLevelUpContainer>(o);
  }
  public static void FinishFB_SoulPowerLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_SoulPowerLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
