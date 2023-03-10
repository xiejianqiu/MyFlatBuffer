// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChiJiRewardBase : Table {
  public static FB_ChiJiRewardBase GetRootAsFB_ChiJiRewardBase(ByteBuffer _bb) { return GetRootAsFB_ChiJiRewardBase(_bb, new FB_ChiJiRewardBase()); }
  public static FB_ChiJiRewardBase GetRootAsFB_ChiJiRewardBase(ByteBuffer _bb, FB_ChiJiRewardBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChiJiRewardBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinRank { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxRank { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Title { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Level { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Judge { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MailID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRewardIDList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardIDListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardCountList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardCountListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int RewardItemID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardItemCount { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ChiJiRewardBase> CreateFB_ChiJiRewardBase(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      int MinRank = -1,
      int MaxRank = -1,
      int Title = -1,
      int Level = -1,
      int Judge = -1,
      int MailID = -1,
      VectorOffset RewardIDList = default(VectorOffset),
      VectorOffset RewardCountList = default(VectorOffset),
      int RewardItemID = -1,
      int RewardItemCount = -1) {
    builder.StartObject(12);
    FB_ChiJiRewardBase.AddRewardItemCount(builder, RewardItemCount);
    FB_ChiJiRewardBase.AddRewardItemID(builder, RewardItemID);
    FB_ChiJiRewardBase.AddRewardCountList(builder, RewardCountList);
    FB_ChiJiRewardBase.AddRewardIDList(builder, RewardIDList);
    FB_ChiJiRewardBase.AddMailID(builder, MailID);
    FB_ChiJiRewardBase.AddJudge(builder, Judge);
    FB_ChiJiRewardBase.AddLevel(builder, Level);
    FB_ChiJiRewardBase.AddTitle(builder, Title);
    FB_ChiJiRewardBase.AddMaxRank(builder, MaxRank);
    FB_ChiJiRewardBase.AddMinRank(builder, MinRank);
    FB_ChiJiRewardBase.AddType(builder, Type);
    FB_ChiJiRewardBase.AddID(builder, ID);
    return FB_ChiJiRewardBase.EndFB_ChiJiRewardBase(builder);
  }

  public static void StartFB_ChiJiRewardBase(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddMinRank(FlatBufferBuilder builder, int MinRank) { builder.AddInt(2, MinRank, -1); }
  public static void AddMaxRank(FlatBufferBuilder builder, int MaxRank) { builder.AddInt(3, MaxRank, -1); }
  public static void AddTitle(FlatBufferBuilder builder, int Title) { builder.AddInt(4, Title, -1); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(5, Level, -1); }
  public static void AddJudge(FlatBufferBuilder builder, int Judge) { builder.AddInt(6, Judge, -1); }
  public static void AddMailID(FlatBufferBuilder builder, int MailID) { builder.AddInt(7, MailID, -1); }
  public static void AddRewardIDList(FlatBufferBuilder builder, VectorOffset RewardIDListOffset) { builder.AddOffset(8, RewardIDListOffset.Value, 0); }
  public static VectorOffset CreateRewardIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardCountList(FlatBufferBuilder builder, VectorOffset RewardCountListOffset) { builder.AddOffset(9, RewardCountListOffset.Value, 0); }
  public static VectorOffset CreateRewardCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardItemID(FlatBufferBuilder builder, int RewardItemID) { builder.AddInt(10, RewardItemID, -1); }
  public static void AddRewardItemCount(FlatBufferBuilder builder, int RewardItemCount) { builder.AddInt(11, RewardItemCount, -1); }
  public static Offset<FB_ChiJiRewardBase> EndFB_ChiJiRewardBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChiJiRewardBase>(o);
  }
};

public sealed class FB_ChiJiRewardBaseContainer : Table {
  public static FB_ChiJiRewardBaseContainer GetRootAsFB_ChiJiRewardBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ChiJiRewardBaseContainer(_bb, new FB_ChiJiRewardBaseContainer()); }
  public static FB_ChiJiRewardBaseContainer GetRootAsFB_ChiJiRewardBaseContainer(ByteBuffer _bb, FB_ChiJiRewardBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChiJiRewardBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChiJiRewardBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChiJiRewardBase GetItems(int j) { return GetItems(new FB_ChiJiRewardBase(), j); }
  public FB_ChiJiRewardBase GetItems(FB_ChiJiRewardBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChiJiRewardBaseContainer> CreateFB_ChiJiRewardBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChiJiRewardBaseContainer.AddItems(builder, items);
    return FB_ChiJiRewardBaseContainer.EndFB_ChiJiRewardBaseContainer(builder);
  }

  public static void StartFB_ChiJiRewardBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChiJiRewardBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChiJiRewardBaseContainer> EndFB_ChiJiRewardBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChiJiRewardBaseContainer>(o);
  }
  public static void FinishFB_ChiJiRewardBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChiJiRewardBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
