// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BattlefieldCollectionRew : Table {
  public static FB_BattlefieldCollectionRew GetRootAsFB_BattlefieldCollectionRew(ByteBuffer _bb) { return GetRootAsFB_BattlefieldCollectionRew(_bb, new FB_BattlefieldCollectionRew()); }
  public static FB_BattlefieldCollectionRew GetRootAsFB_BattlefieldCollectionRew(ByteBuffer _bb, FB_BattlefieldCollectionRew obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BattlefieldCollectionRew __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int AddBuildNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DropBoxId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_BattlefieldCollectionRew> CreateFB_BattlefieldCollectionRew(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset),
      int AddBuildNum = -1,
      int DropBoxId = -1) {
    builder.StartObject(5);
    FB_BattlefieldCollectionRew.AddDropBoxId(builder, DropBoxId);
    FB_BattlefieldCollectionRew.AddAddBuildNum(builder, AddBuildNum);
    FB_BattlefieldCollectionRew.AddItemNumList(builder, ItemNumList);
    FB_BattlefieldCollectionRew.AddItemIdList(builder, ItemIdList);
    FB_BattlefieldCollectionRew.AddID(builder, ID);
    return FB_BattlefieldCollectionRew.EndFB_BattlefieldCollectionRew(builder);
  }

  public static void StartFB_BattlefieldCollectionRew(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(1, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(2, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAddBuildNum(FlatBufferBuilder builder, int AddBuildNum) { builder.AddInt(3, AddBuildNum, -1); }
  public static void AddDropBoxId(FlatBufferBuilder builder, int DropBoxId) { builder.AddInt(4, DropBoxId, -1); }
  public static Offset<FB_BattlefieldCollectionRew> EndFB_BattlefieldCollectionRew(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BattlefieldCollectionRew>(o);
  }
};

public sealed class FB_BattlefieldCollectionRewContainer : Table {
  public static FB_BattlefieldCollectionRewContainer GetRootAsFB_BattlefieldCollectionRewContainer(ByteBuffer _bb) { return GetRootAsFB_BattlefieldCollectionRewContainer(_bb, new FB_BattlefieldCollectionRewContainer()); }
  public static FB_BattlefieldCollectionRewContainer GetRootAsFB_BattlefieldCollectionRewContainer(ByteBuffer _bb, FB_BattlefieldCollectionRewContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BattlefieldCollectionRewContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BattlefieldCollectionRewContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BattlefieldCollectionRew GetItems(int j) { return GetItems(new FB_BattlefieldCollectionRew(), j); }
  public FB_BattlefieldCollectionRew GetItems(FB_BattlefieldCollectionRew obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BattlefieldCollectionRewContainer> CreateFB_BattlefieldCollectionRewContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BattlefieldCollectionRewContainer.AddItems(builder, items);
    return FB_BattlefieldCollectionRewContainer.EndFB_BattlefieldCollectionRewContainer(builder);
  }

  public static void StartFB_BattlefieldCollectionRewContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BattlefieldCollectionRew>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BattlefieldCollectionRewContainer> EndFB_BattlefieldCollectionRewContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BattlefieldCollectionRewContainer>(o);
  }
  public static void FinishFB_BattlefieldCollectionRewContainerBuffer(FlatBufferBuilder builder, Offset<FB_BattlefieldCollectionRewContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
