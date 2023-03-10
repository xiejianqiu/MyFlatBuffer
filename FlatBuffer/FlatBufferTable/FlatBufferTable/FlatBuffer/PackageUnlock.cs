// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PackageUnlock : Table {
  public static FB_PackageUnlock GetRootAsFB_PackageUnlock(ByteBuffer _bb) { return GetRootAsFB_PackageUnlock(_bb, new FB_PackageUnlock()); }
  public static FB_PackageUnlock GetRootAsFB_PackageUnlock(ByteBuffer _bb, FB_PackageUnlock obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PackageUnlock __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RequireType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RequireValue { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_PackageUnlock> CreateFB_PackageUnlock(FlatBufferBuilder builder,
      int ID = 0,
      int RequireType = -1,
      int RequireValue = -1,
      int ItemID = -1,
      int ItemNum = -1) {
    builder.StartObject(5);
    FB_PackageUnlock.AddItemNum(builder, ItemNum);
    FB_PackageUnlock.AddItemID(builder, ItemID);
    FB_PackageUnlock.AddRequireValue(builder, RequireValue);
    FB_PackageUnlock.AddRequireType(builder, RequireType);
    FB_PackageUnlock.AddID(builder, ID);
    return FB_PackageUnlock.EndFB_PackageUnlock(builder);
  }

  public static void StartFB_PackageUnlock(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRequireType(FlatBufferBuilder builder, int RequireType) { builder.AddInt(1, RequireType, -1); }
  public static void AddRequireValue(FlatBufferBuilder builder, int RequireValue) { builder.AddInt(2, RequireValue, -1); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(3, ItemID, -1); }
  public static void AddItemNum(FlatBufferBuilder builder, int ItemNum) { builder.AddInt(4, ItemNum, -1); }
  public static Offset<FB_PackageUnlock> EndFB_PackageUnlock(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PackageUnlock>(o);
  }
};

public sealed class FB_PackageUnlockContainer : Table {
  public static FB_PackageUnlockContainer GetRootAsFB_PackageUnlockContainer(ByteBuffer _bb) { return GetRootAsFB_PackageUnlockContainer(_bb, new FB_PackageUnlockContainer()); }
  public static FB_PackageUnlockContainer GetRootAsFB_PackageUnlockContainer(ByteBuffer _bb, FB_PackageUnlockContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PackageUnlockContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PackageUnlockContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PackageUnlock GetItems(int j) { return GetItems(new FB_PackageUnlock(), j); }
  public FB_PackageUnlock GetItems(FB_PackageUnlock obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PackageUnlockContainer> CreateFB_PackageUnlockContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PackageUnlockContainer.AddItems(builder, items);
    return FB_PackageUnlockContainer.EndFB_PackageUnlockContainer(builder);
  }

  public static void StartFB_PackageUnlockContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PackageUnlock>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PackageUnlockContainer> EndFB_PackageUnlockContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PackageUnlockContainer>(o);
  }
  public static void FinishFB_PackageUnlockContainerBuffer(FlatBufferBuilder builder, Offset<FB_PackageUnlockContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
