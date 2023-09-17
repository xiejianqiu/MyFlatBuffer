// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildBlessBase : Table {
  public static FB_GuildBlessBase GetRootAsFB_GuildBlessBase(ByteBuffer _bb) { return GetRootAsFB_GuildBlessBase(_bb, new FB_GuildBlessBase()); }
  public static FB_GuildBlessBase GetRootAsFB_GuildBlessBase(ByteBuffer _bb, FB_GuildBlessBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildBlessBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DictID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRewardIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardNumList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardNumListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildBlessBase> CreateFB_GuildBlessBase(FlatBufferBuilder builder,
      int ID = 0,
      int DictID = -1,
      VectorOffset RewardIDList = default(VectorOffset),
      VectorOffset RewardNumList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_GuildBlessBase.AddRewardNumList(builder, RewardNumList);
    FB_GuildBlessBase.AddRewardIDList(builder, RewardIDList);
    FB_GuildBlessBase.AddDictID(builder, DictID);
    FB_GuildBlessBase.AddID(builder, ID);
    return FB_GuildBlessBase.EndFB_GuildBlessBase(builder);
  }

  public static void StartFB_GuildBlessBase(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddDictID(FlatBufferBuilder builder, int DictID) { builder.AddInt(1, DictID, -1); }
  public static void AddRewardIDList(FlatBufferBuilder builder, VectorOffset RewardIDListOffset) { builder.AddOffset(2, RewardIDListOffset.Value, 0); }
  public static VectorOffset CreateRewardIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardNumList(FlatBufferBuilder builder, VectorOffset RewardNumListOffset) { builder.AddOffset(3, RewardNumListOffset.Value, 0); }
  public static VectorOffset CreateRewardNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildBlessBase> EndFB_GuildBlessBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildBlessBase>(o);
  }
};

public sealed class FB_GuildBlessBaseContainer : Table {
  public static FB_GuildBlessBaseContainer GetRootAsFB_GuildBlessBaseContainer(ByteBuffer _bb) { return GetRootAsFB_GuildBlessBaseContainer(_bb, new FB_GuildBlessBaseContainer()); }
  public static FB_GuildBlessBaseContainer GetRootAsFB_GuildBlessBaseContainer(ByteBuffer _bb, FB_GuildBlessBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildBlessBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildBlessBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildBlessBase GetItems(int j) { return GetItems(new FB_GuildBlessBase(), j); }
  public FB_GuildBlessBase GetItems(FB_GuildBlessBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildBlessBaseContainer> CreateFB_GuildBlessBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildBlessBaseContainer.AddItems(builder, items);
    return FB_GuildBlessBaseContainer.EndFB_GuildBlessBaseContainer(builder);
  }

  public static void StartFB_GuildBlessBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildBlessBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildBlessBaseContainer> EndFB_GuildBlessBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildBlessBaseContainer>(o);
  }
  public static void FinishFB_GuildBlessBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildBlessBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
