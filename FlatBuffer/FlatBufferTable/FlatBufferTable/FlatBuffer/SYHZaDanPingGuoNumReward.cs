// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHZaDanPingGuoNumReward : Table {
  public static FB_SYHZaDanPingGuoNumReward GetRootAsFB_SYHZaDanPingGuoNumReward(ByteBuffer _bb) { return GetRootAsFB_SYHZaDanPingGuoNumReward(_bb, new FB_SYHZaDanPingGuoNumReward()); }
  public static FB_SYHZaDanPingGuoNumReward GetRootAsFB_SYHZaDanPingGuoNumReward(ByteBuffer _bb, FB_SYHZaDanPingGuoNumReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHZaDanPingGuoNumReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Group { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMin { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMax { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Num { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemCountList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemCountListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHZaDanPingGuoNumReward> CreateFB_SYHZaDanPingGuoNumReward(FlatBufferBuilder builder,
      int id = 0,
      int type = -1,
      int group = -1,
      int WorldLvMin = -1,
      int WorldLvMax = -1,
      int num = -1,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemCountList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_SYHZaDanPingGuoNumReward.AddItemCountList(builder, ItemCountList);
    FB_SYHZaDanPingGuoNumReward.AddItemIdList(builder, ItemIdList);
    FB_SYHZaDanPingGuoNumReward.AddNum(builder, num);
    FB_SYHZaDanPingGuoNumReward.AddWorldLvMax(builder, WorldLvMax);
    FB_SYHZaDanPingGuoNumReward.AddWorldLvMin(builder, WorldLvMin);
    FB_SYHZaDanPingGuoNumReward.AddGroup(builder, group);
    FB_SYHZaDanPingGuoNumReward.AddType(builder, type);
    FB_SYHZaDanPingGuoNumReward.AddId(builder, id);
    return FB_SYHZaDanPingGuoNumReward.EndFB_SYHZaDanPingGuoNumReward(builder);
  }

  public static void StartFB_SYHZaDanPingGuoNumReward(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddType(FlatBufferBuilder builder, int type) { builder.AddInt(1, type, -1); }
  public static void AddGroup(FlatBufferBuilder builder, int group) { builder.AddInt(2, group, -1); }
  public static void AddWorldLvMin(FlatBufferBuilder builder, int WorldLvMin) { builder.AddInt(3, WorldLvMin, -1); }
  public static void AddWorldLvMax(FlatBufferBuilder builder, int WorldLvMax) { builder.AddInt(4, WorldLvMax, -1); }
  public static void AddNum(FlatBufferBuilder builder, int num) { builder.AddInt(5, num, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(6, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemCountList(FlatBufferBuilder builder, VectorOffset ItemCountListOffset) { builder.AddOffset(7, ItemCountListOffset.Value, 0); }
  public static VectorOffset CreateItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHZaDanPingGuoNumReward> EndFB_SYHZaDanPingGuoNumReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHZaDanPingGuoNumReward>(o);
  }
};

public sealed class FB_SYHZaDanPingGuoNumRewardContainer : Table {
  public static FB_SYHZaDanPingGuoNumRewardContainer GetRootAsFB_SYHZaDanPingGuoNumRewardContainer(ByteBuffer _bb) { return GetRootAsFB_SYHZaDanPingGuoNumRewardContainer(_bb, new FB_SYHZaDanPingGuoNumRewardContainer()); }
  public static FB_SYHZaDanPingGuoNumRewardContainer GetRootAsFB_SYHZaDanPingGuoNumRewardContainer(ByteBuffer _bb, FB_SYHZaDanPingGuoNumRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHZaDanPingGuoNumRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHZaDanPingGuoNumRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHZaDanPingGuoNumReward GetItems(int j) { return GetItems(new FB_SYHZaDanPingGuoNumReward(), j); }
  public FB_SYHZaDanPingGuoNumReward GetItems(FB_SYHZaDanPingGuoNumReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHZaDanPingGuoNumRewardContainer> CreateFB_SYHZaDanPingGuoNumRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHZaDanPingGuoNumRewardContainer.AddItems(builder, items);
    return FB_SYHZaDanPingGuoNumRewardContainer.EndFB_SYHZaDanPingGuoNumRewardContainer(builder);
  }

  public static void StartFB_SYHZaDanPingGuoNumRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHZaDanPingGuoNumReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHZaDanPingGuoNumRewardContainer> EndFB_SYHZaDanPingGuoNumRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHZaDanPingGuoNumRewardContainer>(o);
  }
  public static void FinishFB_SYHZaDanPingGuoNumRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHZaDanPingGuoNumRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
