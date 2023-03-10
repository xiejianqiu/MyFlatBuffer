// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BattlefieldCampRew : Table {
  public static FB_BattlefieldCampRew GetRootAsFB_BattlefieldCampRew(ByteBuffer _bb) { return GetRootAsFB_BattlefieldCampRew(_bb, new FB_BattlefieldCampRew()); }
  public static FB_BattlefieldCampRew GetRootAsFB_BattlefieldCampRew(ByteBuffer _bb, FB_BattlefieldCampRew obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BattlefieldCampRew __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int DropBoxId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_BattlefieldCampRew> CreateFB_BattlefieldCampRew(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset),
      int DropBoxId = -1) {
    builder.StartObject(4);
    FB_BattlefieldCampRew.AddDropBoxId(builder, DropBoxId);
    FB_BattlefieldCampRew.AddItemNumList(builder, ItemNumList);
    FB_BattlefieldCampRew.AddItemIdList(builder, ItemIdList);
    FB_BattlefieldCampRew.AddID(builder, ID);
    return FB_BattlefieldCampRew.EndFB_BattlefieldCampRew(builder);
  }

  public static void StartFB_BattlefieldCampRew(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(1, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(2, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDropBoxId(FlatBufferBuilder builder, int DropBoxId) { builder.AddInt(3, DropBoxId, -1); }
  public static Offset<FB_BattlefieldCampRew> EndFB_BattlefieldCampRew(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BattlefieldCampRew>(o);
  }
};

public sealed class FB_BattlefieldCampRewContainer : Table {
  public static FB_BattlefieldCampRewContainer GetRootAsFB_BattlefieldCampRewContainer(ByteBuffer _bb) { return GetRootAsFB_BattlefieldCampRewContainer(_bb, new FB_BattlefieldCampRewContainer()); }
  public static FB_BattlefieldCampRewContainer GetRootAsFB_BattlefieldCampRewContainer(ByteBuffer _bb, FB_BattlefieldCampRewContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BattlefieldCampRewContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BattlefieldCampRewContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BattlefieldCampRew GetItems(int j) { return GetItems(new FB_BattlefieldCampRew(), j); }
  public FB_BattlefieldCampRew GetItems(FB_BattlefieldCampRew obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BattlefieldCampRewContainer> CreateFB_BattlefieldCampRewContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BattlefieldCampRewContainer.AddItems(builder, items);
    return FB_BattlefieldCampRewContainer.EndFB_BattlefieldCampRewContainer(builder);
  }

  public static void StartFB_BattlefieldCampRewContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BattlefieldCampRew>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BattlefieldCampRewContainer> EndFB_BattlefieldCampRewContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BattlefieldCampRewContainer>(o);
  }
  public static void FinishFB_BattlefieldCampRewContainerBuffer(FlatBufferBuilder builder, Offset<FB_BattlefieldCampRewContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
