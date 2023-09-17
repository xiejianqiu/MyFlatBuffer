// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_IapGift2 : Table {
  public static FB_IapGift2 GetRootAsFB_IapGift2(ByteBuffer _bb) { return GetRootAsFB_IapGift2(_bb, new FB_IapGift2()); }
  public static FB_IapGift2 GetRootAsFB_IapGift2(ByteBuffer _bb, FB_IapGift2 obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_IapGift2 __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Des2c { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Des3c { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int IapId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetWorldLvList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WorldLvListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int AllBuyRmbId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRmbIdList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RmbIdListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int Power { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_IapGift2> CreateFB_IapGift2(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Des2c = default(StringOffset),
      StringOffset Des3c = default(StringOffset),
      int Type = -1,
      int IapId = -1,
      VectorOffset WorldLvList = default(VectorOffset),
      int allBuyRmbId = -1,
      VectorOffset RmbIdList = default(VectorOffset),
      int Power = -1) {
    builder.StartObject(9);
    FB_IapGift2.AddPower(builder, Power);
    FB_IapGift2.AddRmbIdList(builder, RmbIdList);
    FB_IapGift2.AddAllBuyRmbId(builder, allBuyRmbId);
    FB_IapGift2.AddWorldLvList(builder, WorldLvList);
    FB_IapGift2.AddIapId(builder, IapId);
    FB_IapGift2.AddType(builder, Type);
    FB_IapGift2.AddDes3c(builder, Des3c);
    FB_IapGift2.AddDes2c(builder, Des2c);
    FB_IapGift2.AddId(builder, Id);
    return FB_IapGift2.EndFB_IapGift2(builder);
  }

  public static void StartFB_IapGift2(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddDes2c(FlatBufferBuilder builder, StringOffset Des2cOffset) { builder.AddOffset(1, Des2cOffset.Value, 0); }
  public static void AddDes3c(FlatBufferBuilder builder, StringOffset Des3cOffset) { builder.AddOffset(2, Des3cOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(3, Type, -1); }
  public static void AddIapId(FlatBufferBuilder builder, int IapId) { builder.AddInt(4, IapId, -1); }
  public static void AddWorldLvList(FlatBufferBuilder builder, VectorOffset WorldLvListOffset) { builder.AddOffset(5, WorldLvListOffset.Value, 0); }
  public static VectorOffset CreateWorldLvListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWorldLvListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAllBuyRmbId(FlatBufferBuilder builder, int allBuyRmbId) { builder.AddInt(6, allBuyRmbId, -1); }
  public static void AddRmbIdList(FlatBufferBuilder builder, VectorOffset RmbIdListOffset) { builder.AddOffset(7, RmbIdListOffset.Value, 0); }
  public static VectorOffset CreateRmbIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRmbIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPower(FlatBufferBuilder builder, int Power) { builder.AddInt(8, Power, -1); }
  public static Offset<FB_IapGift2> EndFB_IapGift2(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_IapGift2>(o);
  }
};

public sealed class FB_IapGift2Container : Table {
  public static FB_IapGift2Container GetRootAsFB_IapGift2Container(ByteBuffer _bb) { return GetRootAsFB_IapGift2Container(_bb, new FB_IapGift2Container()); }
  public static FB_IapGift2Container GetRootAsFB_IapGift2Container(ByteBuffer _bb, FB_IapGift2Container obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_IapGift2ContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_IapGift2Container __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_IapGift2 GetItems(int j) { return GetItems(new FB_IapGift2(), j); }
  public FB_IapGift2 GetItems(FB_IapGift2 obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_IapGift2Container> CreateFB_IapGift2Container(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_IapGift2Container.AddItems(builder, items);
    return FB_IapGift2Container.EndFB_IapGift2Container(builder);
  }

  public static void StartFB_IapGift2Container(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_IapGift2>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_IapGift2Container> EndFB_IapGift2Container(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_IapGift2Container>(o);
  }
  public static void FinishFB_IapGift2ContainerBuffer(FlatBufferBuilder builder, Offset<FB_IapGift2Container> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
