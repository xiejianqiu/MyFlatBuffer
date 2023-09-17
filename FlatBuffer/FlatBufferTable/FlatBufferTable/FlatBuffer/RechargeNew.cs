// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RechargeNew : Table {
  public static FB_RechargeNew GetRootAsFB_RechargeNew(ByteBuffer _bb) { return GetRootAsFB_RechargeNew(_bb, new FB_RechargeNew()); }
  public static FB_RechargeNew GetRootAsFB_RechargeNew(ByteBuffer _bb, FB_RechargeNew obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RechargeNew __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Index { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMin { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMax { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Glod { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemByJobList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemByJobListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardItemIdList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemIdListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardItemNumList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemNumListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public string BigFake { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_RechargeNew> CreateFB_RechargeNew(FlatBufferBuilder builder,
      int Id = 0,
      int Index = -1,
      int WorldLvMin = -1,
      int WorldLvMax = -1,
      int Glod = -1,
      VectorOffset ItemByJobList = default(VectorOffset),
      VectorOffset RewardItemIdList = default(VectorOffset),
      VectorOffset RewardItemNumList = default(VectorOffset),
      StringOffset BigFake = default(StringOffset)) {
    builder.StartObject(9);
    FB_RechargeNew.AddBigFake(builder, BigFake);
    FB_RechargeNew.AddRewardItemNumList(builder, RewardItemNumList);
    FB_RechargeNew.AddRewardItemIdList(builder, RewardItemIdList);
    FB_RechargeNew.AddItemByJobList(builder, ItemByJobList);
    FB_RechargeNew.AddGlod(builder, Glod);
    FB_RechargeNew.AddWorldLvMax(builder, WorldLvMax);
    FB_RechargeNew.AddWorldLvMin(builder, WorldLvMin);
    FB_RechargeNew.AddIndex(builder, Index);
    FB_RechargeNew.AddId(builder, Id);
    return FB_RechargeNew.EndFB_RechargeNew(builder);
  }

  public static void StartFB_RechargeNew(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddIndex(FlatBufferBuilder builder, int Index) { builder.AddInt(1, Index, -1); }
  public static void AddWorldLvMin(FlatBufferBuilder builder, int WorldLvMin) { builder.AddInt(2, WorldLvMin, -1); }
  public static void AddWorldLvMax(FlatBufferBuilder builder, int WorldLvMax) { builder.AddInt(3, WorldLvMax, -1); }
  public static void AddGlod(FlatBufferBuilder builder, int Glod) { builder.AddInt(4, Glod, -1); }
  public static void AddItemByJobList(FlatBufferBuilder builder, VectorOffset ItemByJobListOffset) { builder.AddOffset(5, ItemByJobListOffset.Value, 0); }
  public static VectorOffset CreateItemByJobListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemByJobListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardItemIdList(FlatBufferBuilder builder, VectorOffset RewardItemIdListOffset) { builder.AddOffset(6, RewardItemIdListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardItemNumList(FlatBufferBuilder builder, VectorOffset RewardItemNumListOffset) { builder.AddOffset(7, RewardItemNumListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBigFake(FlatBufferBuilder builder, StringOffset BigFakeOffset) { builder.AddOffset(8, BigFakeOffset.Value, 0); }
  public static Offset<FB_RechargeNew> EndFB_RechargeNew(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RechargeNew>(o);
  }
};

public sealed class FB_RechargeNewContainer : Table {
  public static FB_RechargeNewContainer GetRootAsFB_RechargeNewContainer(ByteBuffer _bb) { return GetRootAsFB_RechargeNewContainer(_bb, new FB_RechargeNewContainer()); }
  public static FB_RechargeNewContainer GetRootAsFB_RechargeNewContainer(ByteBuffer _bb, FB_RechargeNewContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RechargeNewContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RechargeNewContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RechargeNew GetItems(int j) { return GetItems(new FB_RechargeNew(), j); }
  public FB_RechargeNew GetItems(FB_RechargeNew obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RechargeNewContainer> CreateFB_RechargeNewContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RechargeNewContainer.AddItems(builder, items);
    return FB_RechargeNewContainer.EndFB_RechargeNewContainer(builder);
  }

  public static void StartFB_RechargeNewContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RechargeNew>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RechargeNewContainer> EndFB_RechargeNewContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RechargeNewContainer>(o);
  }
  public static void FinishFB_RechargeNewContainerBuffer(FlatBufferBuilder builder, Offset<FB_RechargeNewContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
