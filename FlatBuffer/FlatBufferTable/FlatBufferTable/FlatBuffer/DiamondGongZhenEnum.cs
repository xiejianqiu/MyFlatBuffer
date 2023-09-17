// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DiamondGongZhenEnum : Table {
  public static FB_DiamondGongZhenEnum GetRootAsFB_DiamondGongZhenEnum(ByteBuffer _bb) { return GetRootAsFB_DiamondGongZhenEnum(_bb, new FB_DiamondGongZhenEnum()); }
  public static FB_DiamondGongZhenEnum GetRootAsFB_DiamondGongZhenEnum(ByteBuffer _bb, FB_DiamondGongZhenEnum obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DiamondGongZhenEnum __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ConditionCuilianLv { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Rate { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_DiamondGongZhenEnum> CreateFB_DiamondGongZhenEnum(FlatBufferBuilder builder,
      int Id = 0,
      int ConditionCuilianLv = -1,
      int Rate = -1) {
    builder.StartObject(3);
    FB_DiamondGongZhenEnum.AddRate(builder, Rate);
    FB_DiamondGongZhenEnum.AddConditionCuilianLv(builder, ConditionCuilianLv);
    FB_DiamondGongZhenEnum.AddId(builder, Id);
    return FB_DiamondGongZhenEnum.EndFB_DiamondGongZhenEnum(builder);
  }

  public static void StartFB_DiamondGongZhenEnum(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddConditionCuilianLv(FlatBufferBuilder builder, int ConditionCuilianLv) { builder.AddInt(1, ConditionCuilianLv, -1); }
  public static void AddRate(FlatBufferBuilder builder, int Rate) { builder.AddInt(2, Rate, -1); }
  public static Offset<FB_DiamondGongZhenEnum> EndFB_DiamondGongZhenEnum(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondGongZhenEnum>(o);
  }
};

public sealed class FB_DiamondGongZhenEnumContainer : Table {
  public static FB_DiamondGongZhenEnumContainer GetRootAsFB_DiamondGongZhenEnumContainer(ByteBuffer _bb) { return GetRootAsFB_DiamondGongZhenEnumContainer(_bb, new FB_DiamondGongZhenEnumContainer()); }
  public static FB_DiamondGongZhenEnumContainer GetRootAsFB_DiamondGongZhenEnumContainer(ByteBuffer _bb, FB_DiamondGongZhenEnumContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DiamondGongZhenEnumContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DiamondGongZhenEnumContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DiamondGongZhenEnum GetItems(int j) { return GetItems(new FB_DiamondGongZhenEnum(), j); }
  public FB_DiamondGongZhenEnum GetItems(FB_DiamondGongZhenEnum obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DiamondGongZhenEnumContainer> CreateFB_DiamondGongZhenEnumContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DiamondGongZhenEnumContainer.AddItems(builder, items);
    return FB_DiamondGongZhenEnumContainer.EndFB_DiamondGongZhenEnumContainer(builder);
  }

  public static void StartFB_DiamondGongZhenEnumContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DiamondGongZhenEnum>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DiamondGongZhenEnumContainer> EndFB_DiamondGongZhenEnumContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondGongZhenEnumContainer>(o);
  }
  public static void FinishFB_DiamondGongZhenEnumContainerBuffer(FlatBufferBuilder builder, Offset<FB_DiamondGongZhenEnumContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
