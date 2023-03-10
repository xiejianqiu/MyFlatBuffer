// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipFavPoint : Table {
  public static FB_EquipFavPoint GetRootAsFB_EquipFavPoint(ByteBuffer _bb) { return GetRootAsFB_EquipFavPoint(_bb, new FB_EquipFavPoint()); }
  public static FB_EquipFavPoint GetRootAsFB_EquipFavPoint(ByteBuffer _bb, FB_EquipFavPoint obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipFavPoint __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool Lock { get { int o = __offset(6); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_EquipFavPoint> CreateFB_EquipFavPoint(FlatBufferBuilder builder,
      int Id = 0,
      bool Lock = false) {
    builder.StartObject(2);
    FB_EquipFavPoint.AddId(builder, Id);
    FB_EquipFavPoint.AddLock(builder, Lock);
    return FB_EquipFavPoint.EndFB_EquipFavPoint(builder);
  }

  public static void StartFB_EquipFavPoint(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLock(FlatBufferBuilder builder, bool Lock) { builder.AddBool(1, Lock, false); }
  public static Offset<FB_EquipFavPoint> EndFB_EquipFavPoint(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipFavPoint>(o);
  }
};

public sealed class FB_EquipFavPointContainer : Table {
  public static FB_EquipFavPointContainer GetRootAsFB_EquipFavPointContainer(ByteBuffer _bb) { return GetRootAsFB_EquipFavPointContainer(_bb, new FB_EquipFavPointContainer()); }
  public static FB_EquipFavPointContainer GetRootAsFB_EquipFavPointContainer(ByteBuffer _bb, FB_EquipFavPointContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipFavPointContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipFavPointContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipFavPoint GetItems(int j) { return GetItems(new FB_EquipFavPoint(), j); }
  public FB_EquipFavPoint GetItems(FB_EquipFavPoint obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipFavPointContainer> CreateFB_EquipFavPointContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipFavPointContainer.AddItems(builder, items);
    return FB_EquipFavPointContainer.EndFB_EquipFavPointContainer(builder);
  }

  public static void StartFB_EquipFavPointContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipFavPoint>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipFavPointContainer> EndFB_EquipFavPointContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipFavPointContainer>(o);
  }
  public static void FinishFB_EquipFavPointContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipFavPointContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
