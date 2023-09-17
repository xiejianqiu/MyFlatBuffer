// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_IapGift : Table {
  public static FB_IapGift GetRootAsFB_IapGift(ByteBuffer _bb) { return GetRootAsFB_IapGift(_bb, new FB_IapGift()); }
  public static FB_IapGift GetRootAsFB_IapGift(ByteBuffer _bb, FB_IapGift obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_IapGift __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int IapId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetWorldLvList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WorldLvListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRmbIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RmbIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_IapGift> CreateFB_IapGift(FlatBufferBuilder builder,
      int Id = 0,
      int Type = -1,
      int IapId = -1,
      VectorOffset WorldLvList = default(VectorOffset),
      VectorOffset RmbIdList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_IapGift.AddRmbIdList(builder, RmbIdList);
    FB_IapGift.AddWorldLvList(builder, WorldLvList);
    FB_IapGift.AddIapId(builder, IapId);
    FB_IapGift.AddType(builder, Type);
    FB_IapGift.AddId(builder, Id);
    return FB_IapGift.EndFB_IapGift(builder);
  }

  public static void StartFB_IapGift(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddIapId(FlatBufferBuilder builder, int IapId) { builder.AddInt(2, IapId, -1); }
  public static void AddWorldLvList(FlatBufferBuilder builder, VectorOffset WorldLvListOffset) { builder.AddOffset(3, WorldLvListOffset.Value, 0); }
  public static VectorOffset CreateWorldLvListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWorldLvListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRmbIdList(FlatBufferBuilder builder, VectorOffset RmbIdListOffset) { builder.AddOffset(4, RmbIdListOffset.Value, 0); }
  public static VectorOffset CreateRmbIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRmbIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_IapGift> EndFB_IapGift(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_IapGift>(o);
  }
};

public sealed class FB_IapGiftContainer : Table {
  public static FB_IapGiftContainer GetRootAsFB_IapGiftContainer(ByteBuffer _bb) { return GetRootAsFB_IapGiftContainer(_bb, new FB_IapGiftContainer()); }
  public static FB_IapGiftContainer GetRootAsFB_IapGiftContainer(ByteBuffer _bb, FB_IapGiftContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_IapGiftContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_IapGiftContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_IapGift GetItems(int j) { return GetItems(new FB_IapGift(), j); }
  public FB_IapGift GetItems(FB_IapGift obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_IapGiftContainer> CreateFB_IapGiftContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_IapGiftContainer.AddItems(builder, items);
    return FB_IapGiftContainer.EndFB_IapGiftContainer(builder);
  }

  public static void StartFB_IapGiftContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_IapGift>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_IapGiftContainer> EndFB_IapGiftContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_IapGiftContainer>(o);
  }
  public static void FinishFB_IapGiftContainerBuffer(FlatBufferBuilder builder, Offset<FB_IapGiftContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
