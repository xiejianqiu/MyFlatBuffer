// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingYuTicketBonus : Table {
  public static FB_XingYuTicketBonus GetRootAsFB_XingYuTicketBonus(ByteBuffer _bb) { return GetRootAsFB_XingYuTicketBonus(_bb, new FB_XingYuTicketBonus()); }
  public static FB_XingYuTicketBonus GetRootAsFB_XingYuTicketBonus(ByteBuffer _bb, FB_XingYuTicketBonus obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingYuTicketBonus __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Limit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string MissionDesc { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetRewardList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int NumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingYuTicketBonus> CreateFB_XingYuTicketBonus(FlatBufferBuilder builder,
      int ID = 0,
      int Limit = -1,
      StringOffset MissionDesc = default(StringOffset),
      VectorOffset RewardList = default(VectorOffset),
      VectorOffset NumList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_XingYuTicketBonus.AddNumList(builder, NumList);
    FB_XingYuTicketBonus.AddRewardList(builder, RewardList);
    FB_XingYuTicketBonus.AddMissionDesc(builder, MissionDesc);
    FB_XingYuTicketBonus.AddLimit(builder, Limit);
    FB_XingYuTicketBonus.AddID(builder, ID);
    return FB_XingYuTicketBonus.EndFB_XingYuTicketBonus(builder);
  }

  public static void StartFB_XingYuTicketBonus(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLimit(FlatBufferBuilder builder, int Limit) { builder.AddInt(1, Limit, -1); }
  public static void AddMissionDesc(FlatBufferBuilder builder, StringOffset MissionDescOffset) { builder.AddOffset(2, MissionDescOffset.Value, 0); }
  public static void AddRewardList(FlatBufferBuilder builder, VectorOffset RewardListOffset) { builder.AddOffset(3, RewardListOffset.Value, 0); }
  public static VectorOffset CreateRewardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNumList(FlatBufferBuilder builder, VectorOffset NumListOffset) { builder.AddOffset(4, NumListOffset.Value, 0); }
  public static VectorOffset CreateNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingYuTicketBonus> EndFB_XingYuTicketBonus(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYuTicketBonus>(o);
  }
};

public sealed class FB_XingYuTicketBonusContainer : Table {
  public static FB_XingYuTicketBonusContainer GetRootAsFB_XingYuTicketBonusContainer(ByteBuffer _bb) { return GetRootAsFB_XingYuTicketBonusContainer(_bb, new FB_XingYuTicketBonusContainer()); }
  public static FB_XingYuTicketBonusContainer GetRootAsFB_XingYuTicketBonusContainer(ByteBuffer _bb, FB_XingYuTicketBonusContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingYuTicketBonusContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingYuTicketBonusContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingYuTicketBonus GetItems(int j) { return GetItems(new FB_XingYuTicketBonus(), j); }
  public FB_XingYuTicketBonus GetItems(FB_XingYuTicketBonus obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingYuTicketBonusContainer> CreateFB_XingYuTicketBonusContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingYuTicketBonusContainer.AddItems(builder, items);
    return FB_XingYuTicketBonusContainer.EndFB_XingYuTicketBonusContainer(builder);
  }

  public static void StartFB_XingYuTicketBonusContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingYuTicketBonus>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingYuTicketBonusContainer> EndFB_XingYuTicketBonusContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYuTicketBonusContainer>(o);
  }
  public static void FinishFB_XingYuTicketBonusContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingYuTicketBonusContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
