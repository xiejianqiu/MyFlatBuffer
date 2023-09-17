// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BattlefieldRankRew : Table {
  public static FB_BattlefieldRankRew GetRootAsFB_BattlefieldRankRew(ByteBuffer _bb) { return GetRootAsFB_BattlefieldRankRew(_bb, new FB_BattlefieldRankRew()); }
  public static FB_BattlefieldRankRew GetRootAsFB_BattlefieldRankRew(ByteBuffer _bb, FB_BattlefieldRankRew obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BattlefieldRankRew __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int DropBoxId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_BattlefieldRankRew> CreateFB_BattlefieldRankRew(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset),
      int DropBoxId = -1) {
    builder.StartObject(4);
    FB_BattlefieldRankRew.AddDropBoxId(builder, DropBoxId);
    FB_BattlefieldRankRew.AddItemNumList(builder, ItemNumList);
    FB_BattlefieldRankRew.AddItemIdList(builder, ItemIdList);
    FB_BattlefieldRankRew.AddID(builder, ID);
    return FB_BattlefieldRankRew.EndFB_BattlefieldRankRew(builder);
  }

  public static void StartFB_BattlefieldRankRew(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(1, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(2, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDropBoxId(FlatBufferBuilder builder, int DropBoxId) { builder.AddInt(3, DropBoxId, -1); }
  public static Offset<FB_BattlefieldRankRew> EndFB_BattlefieldRankRew(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BattlefieldRankRew>(o);
  }
};

public sealed class FB_BattlefieldRankRewContainer : Table {
  public static FB_BattlefieldRankRewContainer GetRootAsFB_BattlefieldRankRewContainer(ByteBuffer _bb) { return GetRootAsFB_BattlefieldRankRewContainer(_bb, new FB_BattlefieldRankRewContainer()); }
  public static FB_BattlefieldRankRewContainer GetRootAsFB_BattlefieldRankRewContainer(ByteBuffer _bb, FB_BattlefieldRankRewContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BattlefieldRankRewContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BattlefieldRankRewContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BattlefieldRankRew GetItems(int j) { return GetItems(new FB_BattlefieldRankRew(), j); }
  public FB_BattlefieldRankRew GetItems(FB_BattlefieldRankRew obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BattlefieldRankRewContainer> CreateFB_BattlefieldRankRewContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BattlefieldRankRewContainer.AddItems(builder, items);
    return FB_BattlefieldRankRewContainer.EndFB_BattlefieldRankRewContainer(builder);
  }

  public static void StartFB_BattlefieldRankRewContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BattlefieldRankRew>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BattlefieldRankRewContainer> EndFB_BattlefieldRankRewContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BattlefieldRankRewContainer>(o);
  }
  public static void FinishFB_BattlefieldRankRewContainerBuffer(FlatBufferBuilder builder, Offset<FB_BattlefieldRankRewContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
