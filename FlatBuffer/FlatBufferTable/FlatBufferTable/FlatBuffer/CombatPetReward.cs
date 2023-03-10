// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CombatPetReward : Table {
  public static FB_CombatPetReward GetRootAsFB_CombatPetReward(ByteBuffer _bb) { return GetRootAsFB_CombatPetReward(_bb, new FB_CombatPetReward()); }
  public static FB_CombatPetReward GetRootAsFB_CombatPetReward(ByteBuffer _bb, FB_CombatPetReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CombatPetReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DicId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetStarLimitList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int StarLimitListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBonusIndexList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BonusIndexListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int PassReward { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjectId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CombatPetReward> CreateFB_CombatPetReward(FlatBufferBuilder builder,
      int ID = 0,
      int DicId = -1,
      VectorOffset StarLimitList = default(VectorOffset),
      VectorOffset BonusIndexList = default(VectorOffset),
      int PassReward = -1,
      int FakeObjectId = -1) {
    builder.StartObject(6);
    FB_CombatPetReward.AddFakeObjectId(builder, FakeObjectId);
    FB_CombatPetReward.AddPassReward(builder, PassReward);
    FB_CombatPetReward.AddBonusIndexList(builder, BonusIndexList);
    FB_CombatPetReward.AddStarLimitList(builder, StarLimitList);
    FB_CombatPetReward.AddDicId(builder, DicId);
    FB_CombatPetReward.AddID(builder, ID);
    return FB_CombatPetReward.EndFB_CombatPetReward(builder);
  }

  public static void StartFB_CombatPetReward(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(1, DicId, -1); }
  public static void AddStarLimitList(FlatBufferBuilder builder, VectorOffset StarLimitListOffset) { builder.AddOffset(2, StarLimitListOffset.Value, 0); }
  public static VectorOffset CreateStarLimitListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartStarLimitListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusIndexList(FlatBufferBuilder builder, VectorOffset BonusIndexListOffset) { builder.AddOffset(3, BonusIndexListOffset.Value, 0); }
  public static VectorOffset CreateBonusIndexListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBonusIndexListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPassReward(FlatBufferBuilder builder, int PassReward) { builder.AddInt(4, PassReward, -1); }
  public static void AddFakeObjectId(FlatBufferBuilder builder, int FakeObjectId) { builder.AddInt(5, FakeObjectId, -1); }
  public static Offset<FB_CombatPetReward> EndFB_CombatPetReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CombatPetReward>(o);
  }
};

public sealed class FB_CombatPetRewardContainer : Table {
  public static FB_CombatPetRewardContainer GetRootAsFB_CombatPetRewardContainer(ByteBuffer _bb) { return GetRootAsFB_CombatPetRewardContainer(_bb, new FB_CombatPetRewardContainer()); }
  public static FB_CombatPetRewardContainer GetRootAsFB_CombatPetRewardContainer(ByteBuffer _bb, FB_CombatPetRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CombatPetRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CombatPetRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CombatPetReward GetItems(int j) { return GetItems(new FB_CombatPetReward(), j); }
  public FB_CombatPetReward GetItems(FB_CombatPetReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CombatPetRewardContainer> CreateFB_CombatPetRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CombatPetRewardContainer.AddItems(builder, items);
    return FB_CombatPetRewardContainer.EndFB_CombatPetRewardContainer(builder);
  }

  public static void StartFB_CombatPetRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CombatPetReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CombatPetRewardContainer> EndFB_CombatPetRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CombatPetRewardContainer>(o);
  }
  public static void FinishFB_CombatPetRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_CombatPetRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
