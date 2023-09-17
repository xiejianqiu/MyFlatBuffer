// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildPresent : Table {
  public static FB_GuildPresent GetRootAsFB_GuildPresent(ByteBuffer _bb) { return GetRootAsFB_GuildPresent(_bb, new FB_GuildPresent()); }
  public static FB_GuildPresent GetRootAsFB_GuildPresent(ByteBuffer _bb, FB_GuildPresent obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildPresent __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string IconPath { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int JobLimit { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardMoneyTypeList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardMoneyTypeListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardMoneyList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardMoneyListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildPresent> CreateFB_GuildPresent(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset IconPath = default(StringOffset),
      int JobLimit = -1,
      int AttrID = -1,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset RewardMoneyTypeList = default(VectorOffset),
      VectorOffset RewardMoneyList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_GuildPresent.AddRewardMoneyList(builder, RewardMoneyList);
    FB_GuildPresent.AddRewardMoneyTypeList(builder, RewardMoneyTypeList);
    FB_GuildPresent.AddItemIDList(builder, ItemIDList);
    FB_GuildPresent.AddAttrID(builder, AttrID);
    FB_GuildPresent.AddJobLimit(builder, JobLimit);
    FB_GuildPresent.AddIconPath(builder, IconPath);
    FB_GuildPresent.AddName(builder, Name);
    FB_GuildPresent.AddID(builder, ID);
    return FB_GuildPresent.EndFB_GuildPresent(builder);
  }

  public static void StartFB_GuildPresent(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset IconPathOffset) { builder.AddOffset(2, IconPathOffset.Value, 0); }
  public static void AddJobLimit(FlatBufferBuilder builder, int JobLimit) { builder.AddInt(3, JobLimit, -1); }
  public static void AddAttrID(FlatBufferBuilder builder, int AttrID) { builder.AddInt(4, AttrID, -1); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(5, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardMoneyTypeList(FlatBufferBuilder builder, VectorOffset RewardMoneyTypeListOffset) { builder.AddOffset(6, RewardMoneyTypeListOffset.Value, 0); }
  public static VectorOffset CreateRewardMoneyTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardMoneyTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardMoneyList(FlatBufferBuilder builder, VectorOffset RewardMoneyListOffset) { builder.AddOffset(7, RewardMoneyListOffset.Value, 0); }
  public static VectorOffset CreateRewardMoneyListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardMoneyListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildPresent> EndFB_GuildPresent(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildPresent>(o);
  }
};

public sealed class FB_GuildPresentContainer : Table {
  public static FB_GuildPresentContainer GetRootAsFB_GuildPresentContainer(ByteBuffer _bb) { return GetRootAsFB_GuildPresentContainer(_bb, new FB_GuildPresentContainer()); }
  public static FB_GuildPresentContainer GetRootAsFB_GuildPresentContainer(ByteBuffer _bb, FB_GuildPresentContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildPresentContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildPresentContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildPresent GetItems(int j) { return GetItems(new FB_GuildPresent(), j); }
  public FB_GuildPresent GetItems(FB_GuildPresent obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildPresentContainer> CreateFB_GuildPresentContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildPresentContainer.AddItems(builder, items);
    return FB_GuildPresentContainer.EndFB_GuildPresentContainer(builder);
  }

  public static void StartFB_GuildPresentContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildPresent>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildPresentContainer> EndFB_GuildPresentContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildPresentContainer>(o);
  }
  public static void FinishFB_GuildPresentContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildPresentContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
