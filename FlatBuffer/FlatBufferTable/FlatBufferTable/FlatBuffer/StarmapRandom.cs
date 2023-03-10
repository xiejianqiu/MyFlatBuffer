// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarmapRandom : Table {
  public static FB_StarmapRandom GetRootAsFB_StarmapRandom(ByteBuffer _bb) { return GetRootAsFB_StarmapRandom(_bb, new FB_StarmapRandom()); }
  public static FB_StarmapRandom GetRootAsFB_StarmapRandom(ByteBuffer _bb, FB_StarmapRandom obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarmapRandom __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GroupsNum { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetGroupList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GroupListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarmapRandom> CreateFB_StarmapRandom(FlatBufferBuilder builder,
      int ID = 0,
      int GroupsNum = -1,
      VectorOffset GroupList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_StarmapRandom.AddGroupList(builder, GroupList);
    FB_StarmapRandom.AddGroupsNum(builder, GroupsNum);
    FB_StarmapRandom.AddID(builder, ID);
    return FB_StarmapRandom.EndFB_StarmapRandom(builder);
  }

  public static void StartFB_StarmapRandom(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddGroupsNum(FlatBufferBuilder builder, int GroupsNum) { builder.AddInt(1, GroupsNum, -1); }
  public static void AddGroupList(FlatBufferBuilder builder, VectorOffset GroupListOffset) { builder.AddOffset(2, GroupListOffset.Value, 0); }
  public static VectorOffset CreateGroupListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGroupListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarmapRandom> EndFB_StarmapRandom(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarmapRandom>(o);
  }
};

public sealed class FB_StarmapRandomContainer : Table {
  public static FB_StarmapRandomContainer GetRootAsFB_StarmapRandomContainer(ByteBuffer _bb) { return GetRootAsFB_StarmapRandomContainer(_bb, new FB_StarmapRandomContainer()); }
  public static FB_StarmapRandomContainer GetRootAsFB_StarmapRandomContainer(ByteBuffer _bb, FB_StarmapRandomContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarmapRandomContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarmapRandomContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarmapRandom GetItems(int j) { return GetItems(new FB_StarmapRandom(), j); }
  public FB_StarmapRandom GetItems(FB_StarmapRandom obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarmapRandomContainer> CreateFB_StarmapRandomContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarmapRandomContainer.AddItems(builder, items);
    return FB_StarmapRandomContainer.EndFB_StarmapRandomContainer(builder);
  }

  public static void StartFB_StarmapRandomContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarmapRandom>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarmapRandomContainer> EndFB_StarmapRandomContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarmapRandomContainer>(o);
  }
  public static void FinishFB_StarmapRandomContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarmapRandomContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
