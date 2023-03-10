// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PlayerSkinColor : Table {
  public static FB_PlayerSkinColor GetRootAsFB_PlayerSkinColor(ByteBuffer _bb) { return GetRootAsFB_PlayerSkinColor(_bb, new FB_PlayerSkinColor()); }
  public static FB_PlayerSkinColor GetRootAsFB_PlayerSkinColor(ByteBuffer _bb, FB_PlayerSkinColor obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PlayerSkinColor __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RGB { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitValue { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AvatarExp { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_PlayerSkinColor> CreateFB_PlayerSkinColor(FlatBufferBuilder builder,
      int ID = 0,
      int RGB = -1,
      int CostItemID = -1,
      int CostNum = -1,
      int LimitType = 0,
      int LimitValue = 0,
      int AvatarExp = -1) {
    builder.StartObject(7);
    FB_PlayerSkinColor.AddAvatarExp(builder, AvatarExp);
    FB_PlayerSkinColor.AddLimitValue(builder, LimitValue);
    FB_PlayerSkinColor.AddLimitType(builder, LimitType);
    FB_PlayerSkinColor.AddCostNum(builder, CostNum);
    FB_PlayerSkinColor.AddCostItemID(builder, CostItemID);
    FB_PlayerSkinColor.AddRGB(builder, RGB);
    FB_PlayerSkinColor.AddID(builder, ID);
    return FB_PlayerSkinColor.EndFB_PlayerSkinColor(builder);
  }

  public static void StartFB_PlayerSkinColor(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRGB(FlatBufferBuilder builder, int RGB) { builder.AddInt(1, RGB, -1); }
  public static void AddCostItemID(FlatBufferBuilder builder, int CostItemID) { builder.AddInt(2, CostItemID, -1); }
  public static void AddCostNum(FlatBufferBuilder builder, int CostNum) { builder.AddInt(3, CostNum, -1); }
  public static void AddLimitType(FlatBufferBuilder builder, int LimitType) { builder.AddInt(4, LimitType, 0); }
  public static void AddLimitValue(FlatBufferBuilder builder, int LimitValue) { builder.AddInt(5, LimitValue, 0); }
  public static void AddAvatarExp(FlatBufferBuilder builder, int AvatarExp) { builder.AddInt(6, AvatarExp, -1); }
  public static Offset<FB_PlayerSkinColor> EndFB_PlayerSkinColor(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayerSkinColor>(o);
  }
};

public sealed class FB_PlayerSkinColorContainer : Table {
  public static FB_PlayerSkinColorContainer GetRootAsFB_PlayerSkinColorContainer(ByteBuffer _bb) { return GetRootAsFB_PlayerSkinColorContainer(_bb, new FB_PlayerSkinColorContainer()); }
  public static FB_PlayerSkinColorContainer GetRootAsFB_PlayerSkinColorContainer(ByteBuffer _bb, FB_PlayerSkinColorContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PlayerSkinColorContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PlayerSkinColorContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PlayerSkinColor GetItems(int j) { return GetItems(new FB_PlayerSkinColor(), j); }
  public FB_PlayerSkinColor GetItems(FB_PlayerSkinColor obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PlayerSkinColorContainer> CreateFB_PlayerSkinColorContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PlayerSkinColorContainer.AddItems(builder, items);
    return FB_PlayerSkinColorContainer.EndFB_PlayerSkinColorContainer(builder);
  }

  public static void StartFB_PlayerSkinColorContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PlayerSkinColor>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PlayerSkinColorContainer> EndFB_PlayerSkinColorContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayerSkinColorContainer>(o);
  }
  public static void FinishFB_PlayerSkinColorContainerBuffer(FlatBufferBuilder builder, Offset<FB_PlayerSkinColorContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
