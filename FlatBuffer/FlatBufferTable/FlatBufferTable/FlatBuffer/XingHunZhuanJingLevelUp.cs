// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingHunZhuanJingLevelUp : Table {
  public static FB_XingHunZhuanJingLevelUp GetRootAsFB_XingHunZhuanJingLevelUp(ByteBuffer _bb) { return GetRootAsFB_XingHunZhuanJingLevelUp(_bb, new FB_XingHunZhuanJingLevelUp()); }
  public static FB_XingHunZhuanJingLevelUp GetRootAsFB_XingHunZhuanJingLevelUp(ByteBuffer _bb, FB_XingHunZhuanJingLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingHunZhuanJingLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyCost { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_XingHunZhuanJingLevelUp> CreateFB_XingHunZhuanJingLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int MoneyType = -1,
      int MoneyCost = -1) {
    builder.StartObject(3);
    FB_XingHunZhuanJingLevelUp.AddMoneyCost(builder, MoneyCost);
    FB_XingHunZhuanJingLevelUp.AddMoneyType(builder, MoneyType);
    FB_XingHunZhuanJingLevelUp.AddID(builder, ID);
    return FB_XingHunZhuanJingLevelUp.EndFB_XingHunZhuanJingLevelUp(builder);
  }

  public static void StartFB_XingHunZhuanJingLevelUp(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(1, MoneyType, -1); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(2, MoneyCost, -1); }
  public static Offset<FB_XingHunZhuanJingLevelUp> EndFB_XingHunZhuanJingLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunZhuanJingLevelUp>(o);
  }
};

public sealed class FB_XingHunZhuanJingLevelUpContainer : Table {
  public static FB_XingHunZhuanJingLevelUpContainer GetRootAsFB_XingHunZhuanJingLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_XingHunZhuanJingLevelUpContainer(_bb, new FB_XingHunZhuanJingLevelUpContainer()); }
  public static FB_XingHunZhuanJingLevelUpContainer GetRootAsFB_XingHunZhuanJingLevelUpContainer(ByteBuffer _bb, FB_XingHunZhuanJingLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingHunZhuanJingLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingHunZhuanJingLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingHunZhuanJingLevelUp GetItems(int j) { return GetItems(new FB_XingHunZhuanJingLevelUp(), j); }
  public FB_XingHunZhuanJingLevelUp GetItems(FB_XingHunZhuanJingLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunZhuanJingLevelUpContainer> CreateFB_XingHunZhuanJingLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingHunZhuanJingLevelUpContainer.AddItems(builder, items);
    return FB_XingHunZhuanJingLevelUpContainer.EndFB_XingHunZhuanJingLevelUpContainer(builder);
  }

  public static void StartFB_XingHunZhuanJingLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingHunZhuanJingLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunZhuanJingLevelUpContainer> EndFB_XingHunZhuanJingLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunZhuanJingLevelUpContainer>(o);
  }
  public static void FinishFB_XingHunZhuanJingLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingHunZhuanJingLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
